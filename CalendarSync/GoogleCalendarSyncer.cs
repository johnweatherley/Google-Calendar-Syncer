using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace Gui
{
    public partial class GoogleCalendarSyncer : Form
    {
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar Sync";
        CalendarService CalendarService = new CalendarService();

        public GoogleCalendarSyncer()
        {
            InitializeComponent();

            UserCredential credential;

            if (!File.Exists("client_secret.json"))
            {
                if (MessageBox.Show("Credential JSON file not found.  Please create the proper credentials at https://console.developers.google.com/projectselector/apis/credentials and save the JSON file to the program directory.  Go there now?", "JSON Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) { System.Diagnostics.Process.Start("https://console.developers.google.com/projectselector/apis/credentials"); }

                Application.Exit();
                Environment.Exit(0);
            }

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/google-calendar-syncer.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            CalendarService = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            
        }

        private void btnGetCalendars_Click(object sender, EventArgs e)
        {
            CalendarListResource.ListRequest callist = CalendarService.CalendarList.List();
            CalendarList list = callist.Execute();

            dgvFromCalendars.AutoGenerateColumns = true;            
            dgvFromCalendars.DataSource = list.Items.Select(o => new { o.Id, o.Summary, o.Description}).ToList();
            dgvToCalendars.DataSource = list.Items.Select(o => new { o.Id, o.Summary, o.Description }).ToList();

            btnCopyEvents.Enabled = tbSearchFilter.Enabled = tbReplace.Enabled = startDate.Enabled = endDate.Enabled = true;

            lblInfo.Text = "Double click calendar to preview events with filters.  Select Source (left) and Destination (right) calendar and click 'Copy Events'";
        }

        private void dgvFromCalendars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = dgvFromCalendars.SelectedRows[0].DataBoundItem;

            var calId = (string)selectedItem.GetType().GetProperty("Id").GetValue(selectedItem, null);

            var eventsRequest = CalendarService.Events.List(calId);
            eventsRequest.TimeMin = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day, 0,0,0);
            eventsRequest.TimeMax = new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day, 23, 59, 59);
            eventsRequest.ShowDeleted = false;
            eventsRequest.SingleEvents = true;
            eventsRequest.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;
                 

            eventsRequest.Q = tbSearchFilter.Text;

            // List events.
            Events events = eventsRequest.Execute();
            
            EventsPreview eventsPreview = new EventsPreview(events, tbSearchFilter.Text, tbReplace.Text);
            eventsPreview.Show();
        }

        private void btnCopyEvents_Click(object sender, EventArgs e)
        {
            var selectedItemSrc = dgvFromCalendars.SelectedRows[0].DataBoundItem;
            var selectedItemDest = dgvToCalendars.SelectedRows[0].DataBoundItem;

            var srcCalId = (string)selectedItemSrc.GetType().GetProperty("Id").GetValue(selectedItemSrc, null);
            var srcCalSum = (string)selectedItemSrc.GetType().GetProperty("Summary").GetValue(selectedItemSrc, null);
            var destCalId = (string)selectedItemDest.GetType().GetProperty("Id").GetValue(selectedItemDest, null);
            var destCalSum = (string)selectedItemDest.GetType().GetProperty("Summary").GetValue(selectedItemDest, null);

            var eventsRequest = CalendarService.Events.List(srcCalId);
            eventsRequest.TimeMin = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day, 0, 0, 0);
            eventsRequest.TimeMax = new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day, 23, 59, 59);
            eventsRequest.ShowDeleted = false;
            eventsRequest.SingleEvents = true;            
            eventsRequest.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            eventsRequest.Q = tbSearchFilter.Text;

            // List events.
            Events events = eventsRequest.Execute();

            foreach (var srcEvent in events.Items)
            {
                var destEvent = new Event();
                var newId = Guid.NewGuid().ToString("N");
                var title = string.Empty;
                
                if (tbReplace.Text != string.Empty)
                {
                    title = srcEvent.Summary.Trim().Replace(tbSearchFilter.Text, tbReplace.Text);
                }
                else
                {
                    title = srcEvent.Summary.Trim();
                }

                destEvent.Id = newId.Substring(0,26);
                destEvent.ICalUID = destEvent.Id + "@google.com";
                destEvent.Summary = title;
                destEvent.Description = srcEvent.Description;
                destEvent.Start = srcEvent.Start;
                destEvent.End = srcEvent.End;
                
                var org = new Event.OrganizerData { DisplayName = destCalSum, Email = destCalId };
                destEvent.Organizer = org;
                var newEvt = CalendarService.Events.Import(destEvent, destCalId).Execute();

                lblInfo.Text = string.Format("{0} Events copied from {1} to {2}", events.Items.Count, srcCalSum, destCalSum);
            }
        }
    }
}

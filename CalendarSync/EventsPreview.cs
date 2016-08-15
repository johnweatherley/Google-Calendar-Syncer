using Google.Apis.Calendar.v3.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gui
{
    public partial class EventsPreview : Form
    {
        public EventsPreview(Events events, string filter, string replace)
        {
            InitializeComponent();

            dgvEventsPreview.AutoGenerateColumns = true;

            if (replace != string.Empty)
            {
                dgvEventsPreview.DataSource = events.Items.Select(o => new { OldSummary = o.Summary, NewSummary = o.Summary.Replace(filter, replace), o.Description, Start = (o.Start.DateTime == null ? DateTime.Parse(o.Start.Date) : o.Start.DateTime), End = (o.End.DateTime == null ? "All Day" : o.End.DateTime.ToString()) }).ToList();
            }
            else
            {
                dgvEventsPreview.DataSource = events.Items.Select(o => new { o.Summary, o.Description, Start = (o.Start.DateTime == null ? DateTime.Parse(o.Start.Date) : o.Start.DateTime), End = (o.End.DateTime == null ? "All Day" : o.End.DateTime.ToString()) }).ToList();
            }

            
        }
    }
}

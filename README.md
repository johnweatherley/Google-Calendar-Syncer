# Google-Calendar-Syncer
Tool to copy events from one Google Calendar to another.

To use the API, you'll need to create and download a credential JSON file from here: https://console.developers.google.com/projectselector/apis/credentials
Move the credential file to the program directory and rename it to "client_secret.json"
After you do this, you'll be able to run the tool and Goolge will ask you to authorize the API credentials.

Before running the solution, restore the nuget packages.

To get started, click "Get Calendars" and you'll be asked to authenticate against your Google account.  You'll only need to do this once.

Both the Source (left) and Destination (right) grids will be populated with your calendars.

Enter the text filter (if needed) and date range you wish to copy.  The text filter will filter on the event summary, or title.

Double click on the source calendar to get a preview of the events that will be copied.  If a text replacement has been entered, it will show the original summary text along with the modified text.

Once you're satified with the events, select the destination calendar and click "Copy".
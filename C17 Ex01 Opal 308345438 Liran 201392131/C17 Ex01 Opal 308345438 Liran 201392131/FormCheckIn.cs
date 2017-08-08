using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public partial class FormCheckIn : Form
    {
        private const int m_BrowserVersion = 11001; 
        private const string m_WebUrl = "https://www.google.co.il/maps?q=";
        private const string m_Comma = ",";
        private const string m_Plus = "+";

        private List<string> usertDetails { get; set; }

        private FacebookOperation facebookOp { get; set; }

        public FormCheckIn(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();

            RegisterKey.SetWebBrowserVersion(m_BrowserVersion);

            facebookOp = i_FacebookOp;

            try
            {
                usertDetails = facebookOp.FetchUserBasicDetails();
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void buttonFetchCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (facebookOp.FetchCheckInCount() > 0)
                {
                    listBoxCheckIn.DisplayMember = "Name";
                    listBoxCheckIn.DataSource = facebookOp.FetchCheckIn();
                }
                else
                {
                    MessageNotification.showWarningMessage(usertDetails[0] + " has no Checkins");
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void listBoxCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Checkin checkIn = listBoxCheckIn.SelectedItem as Checkin;
            StringBuilder urlLocation = new StringBuilder();
            urlLocation.Append(m_WebUrl);
            Page selectedEvent = listBoxCheckIn.SelectedItem as Page;
            urlLocation.Append(selectedEvent.Location.Street + m_Comma + m_Plus);
            urlLocation.Append(selectedEvent.Location.City + m_Comma + m_Plus);
            urlLocation.Append(selectedEvent.Location.State + m_Comma + m_Plus);
            urlLocation.Append(selectedEvent.Location.Country + m_Comma + m_Plus);
            urlLocation.Append(selectedEvent.Location.Zip + m_Comma + m_Plus);

            webBrowser1.Navigate(urlLocation.ToString());
        }
    }
}

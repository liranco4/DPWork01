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
        private FacebookOperation FacebookOp { get; set; }
        private const int m_BrowserVersion = 11001; 
        List<string> UsertDetails { get; set; }
        private const string m_WebUrl = "https://www.google.co.il/maps?q=";
        private const string m_Comma = ",";
        private const string m_Plus = "+";

        public FormCheckIn(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();

            RegisterKey.SetWebBrowserVersion(m_BrowserVersion);

            FacebookOp = i_FacebookOp;

            try
            {
                UsertDetails = FacebookOp.FetchUserBasicDetails();
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
                if (FacebookOp.FetchCheckInCount() > 0)
                {
                    listBoxCheckIn.DisplayMember = "Name";
                    listBoxCheckIn.DataSource = FacebookOp.FetchCheckIn();
                }
                else
                {
                    MessageNotification.showWarningMessage(UsertDetails[0] + " has no Checkins");
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
            StringBuilder urlLocation = new StringBuilder();;
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

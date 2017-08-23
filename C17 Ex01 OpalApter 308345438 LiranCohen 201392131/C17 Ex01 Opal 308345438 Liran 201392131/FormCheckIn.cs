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
using System.Threading;


namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public partial class FormCheckIn : Form
    {
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private const string k_WebUrl = "https://www.google.co.il/maps?q=";
        private const string k_Comma = ",";
        private const string k_Plus = "+";
        private List<string> m_UserDetails;
        private FacebookOperation m_FacebookOp;

        public FormCheckIn()
        {
            InitializeComponent();

            m_FacebookOp = FacebookOperation.InstanceFacebookOperation;

            try
            {
                m_UserDetails = m_FacebookOp.FetchUserBasicDetails();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
                //MessageNotification.ShowErrorMessage(exception.Message);
            }
        }

        private void buttonFetchCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                /*listBoxCheckIn.DisplayMember = "Name";
                listBoxCheckIn.DataSource = m_FacebookOp.FetchCheckIn();*/

                new Thread(ShowCheckIns).Start();

                /*if (m_FacebookOp.FetchCheckInCount() == 0)
                {
                    FactoryMessageNotification.CreateMessage(m_UserDetails[0] + " has no Checkins", k_Warning);
                }*/
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
        }

        private void ShowCheckIns()
        {
            listBoxCheckIn.Invoke(new Action(() => checkinBindingSource.DataSource = m_FacebookOp.FetchCheckIn()));

            if (m_FacebookOp.FetchCheckInCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UserDetails[0] + " has no Checkins", k_Warning);
            }
        }

        private void listBoxCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Checkin checkIn = listBoxCheckIn.SelectedItem as Checkin;
            StringBuilder urlLocation = new StringBuilder();
            urlLocation.Append(k_WebUrl);
            Page selectedEvent = listBoxCheckIn.SelectedItem as Page;
            urlLocation.Append(selectedEvent.Location.Street + k_Comma + k_Plus);
            urlLocation.Append(selectedEvent.Location.City + k_Comma + k_Plus);
            urlLocation.Append(selectedEvent.Location.State + k_Comma + k_Plus);
            urlLocation.Append(selectedEvent.Location.Country + k_Comma + k_Plus);
            urlLocation.Append(selectedEvent.Location.Zip + k_Comma + k_Plus);
            webCheckINBrowserProxy.Navigate(urlLocation.ToString());
        }
    }
}

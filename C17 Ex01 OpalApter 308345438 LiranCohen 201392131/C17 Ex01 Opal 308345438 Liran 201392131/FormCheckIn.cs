using System;
using System.Threading;
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
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private const string k_WebUrl = "https://www.google.co.il/maps?q=";
        private const string k_Comma = ",";
        private const string k_Plus = "+";
        private CheckInServices m_CheckInServices;

        public FormCheckIn()
        {
            InitializeComponent();
            m_CheckInServices = new CheckInServices();
        }

        private void buttonFetchCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() => m_CheckInServices.ShowCheckIns(listBoxCheckIn, checkinBindingSource)).Start();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm();
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

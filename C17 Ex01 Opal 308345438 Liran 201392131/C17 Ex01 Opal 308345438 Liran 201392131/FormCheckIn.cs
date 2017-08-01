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
        List<string> UsertDetails { get; set; }

        public FormCheckIn(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();
            FacebookOp = i_FacebookOp;

            UsertDetails = FacebookOp.FetchUserBasicDetails();
        }

        private void buttonFetchCheckIn_Click(object sender, EventArgs e)
        {
            if (FacebookOp.FetchCheckInCount() > 0)
            {
                listBoxCheckIn.DisplayMember = "Name";
                listBoxCheckIn.DataSource = FacebookOp.FetchCheckIn();
            }
            else
            {
                MessageBox.Show(UsertDetails[0] + " has no Checkins");
            }
        }

        private void listBoxCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Checkin checkIn = listBoxCheckIn.SelectedItem as Checkin;
            StringBuilder urlLocation = new StringBuilder();;
            urlLocation.Append("https://maps.google.com/maps?q=");
            Checkin selectedEvent = listBoxCheckIn.SelectedItem as Checkin;
            urlLocation.Append(selectedEvent.Place.Location.Street + "," + "+");
            urlLocation.Append(selectedEvent.Place.Location.City + "," + "+");
            urlLocation.Append(selectedEvent.Place.Location.State + "," + "+");
            urlLocation.Append(selectedEvent.Place.Location.Country + "," + "+");
            urlLocation.Append(selectedEvent.Place.Location.Zip + "," + "+");

            webBrowser1.Navigate(urlLocation.ToString());
        }



    }
}

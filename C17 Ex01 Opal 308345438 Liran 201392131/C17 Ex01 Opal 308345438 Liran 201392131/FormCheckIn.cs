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

            SetWebBrowserVersion(11001);

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
            urlLocation.Append("https://www.google.co.il/maps?q=");
            Page selectedEvent = listBoxCheckIn.SelectedItem as Page;
            urlLocation.Append(selectedEvent.Location.Street + "," + "+");
            urlLocation.Append(selectedEvent.Location.City + "," + "+");
            urlLocation.Append(selectedEvent.Location.State + "," + "+");
            urlLocation.Append(selectedEvent.Location.Country + "," + "+");
            urlLocation.Append(selectedEvent.Location.Zip + "," + "+");

            webBrowser1.Navigate(urlLocation.ToString());
        }

        private void SetWebBrowserVersion(int ie_version)
        {
            const string key64bit =
                @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\" +
                @"MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
            const string key32bit =
                @"SOFTWARE\Microsoft\Internet Explorer\MAIN\" +
                @"FeatureControl\FEATURE_BROWSER_EMULATION";
            string app_name = System.AppDomain.CurrentDomain.FriendlyName;

            // You can do both if you like.
            SetRegistryDword(key64bit, app_name, ie_version);
            //SetRegistryDword(key32bit, app_name, ie_version);
        }

        private void SetRegistryDword(string key_name, string value_name, int value)
        {
            // Open the key.
            Microsoft.Win32.RegistryKey key =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key_name, true);
            if (key == null)
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(key_name,
                    Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);

            // Set the desired value.
            key.SetValue(value_name, value, Microsoft.Win32.RegistryValueKind.DWord);

            key.Close();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public partial class FormAlbums : Form
    {
        private FacebookOperation FacebookOp { get; set; }
        List<string> UsertDetails { get; set; }
        List<Page> MusicPages { get; set; }

        public FormAlbums(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();
            FacebookOp = i_FacebookOp;
            UsertDetails = FacebookOp.FetchUserBasicDetails();
            SetWebBrowserVersion(11001);
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            MusicPages = FacebookOp.FetchMusic();

            listBoxFetchAlbums.DisplayMember = "Name";
            listBoxFetchAlbums.DataSource = MusicPages;

            if (MusicPages.Count() == 0)
            {
                MessageBox.Show(UsertDetails[0] + " has no Albums");
            }
        }

        private void listBoxFetchAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page musicPage = listBoxFetchAlbums.SelectedItem as Page;
            StringBuilder url = new StringBuilder();
            string[] singerName=musicPage.Name.Split();
            url.Append("https://www.youtube.com/results?search_query=");
            foreach (string name in singerName)
            {
                url.Append(name + "+");
            }

            webBrowserVideos.Navigate(url.ToString());
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

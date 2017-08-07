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
    public partial class FormMusics : Form
    {
        private FacebookOperation FacebookOp { get; set; }
        List<string> UsertDetails { get; set; }
        List<Page> MusicPages { get; set; }
        private const int m_BrowserVersion = 11001;
        private const string m_WebUrl = "https://www.youtube.com/results?search_query=";

        public FormMusics(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();
            FacebookOp = i_FacebookOp;
            RegisterKey.SetWebBrowserVersion(m_BrowserVersion);

            try
            {
                UsertDetails = FacebookOp.FetchUserBasicDetails();
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void buttonFetchMusics_Click(object sender, EventArgs e)
        {
            try
            {
                MusicPages = FacebookOp.FetchMusic();
                listBoxFetchMusics.DisplayMember = "Name";
                listBoxFetchMusics.DataSource = MusicPages;

                if (MusicPages.Count() == 0)
                {
                    MessageNotification.showWarningMessage(UsertDetails[0] + " has no Albums");
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void listBoxFetchAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page musicPage = listBoxFetchMusics.SelectedItem as Page;
            StringBuilder url = new StringBuilder();
            string[] singerName = musicPage.URL.Split('/');
            url.Append(m_WebUrl);
            url.Append(singerName[3]);
            webBrowserVideos.Navigate(url.ToString());
        }   
       
    }
}

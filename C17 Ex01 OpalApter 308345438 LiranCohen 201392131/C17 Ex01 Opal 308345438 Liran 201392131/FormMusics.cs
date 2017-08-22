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
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private const int k_BrowserVersion = 11001;
        private const string k_WebUrl = "https://www.youtube.com/results?search_query=";
        private FacebookOperation m_FacebookOp;
        private List<string> m_UsertDetails;
        private List<Page> m_MusicPages;

        public FormMusics()
        {
            InitializeComponent();
            m_FacebookOp = FacebookOperation.InstanceFacebookOperation;
            RegisterKey.SetWebBrowserVersion(k_BrowserVersion);
            try
            {
                m_UsertDetails = m_FacebookOp.FetchUserBasicDetails();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
                //MessageNotification.ShowErrorMessage(exception.Message);
            }
        }

        private void buttonFetchMusics_Click(object sender, EventArgs e)
        {
            try
            {
                m_MusicPages = m_FacebookOp.FetchMusic();
                listBoxFetchMusics.DisplayMember = "Name";
                listBoxFetchMusics.DataSource = m_MusicPages;

                if (m_MusicPages.Count() == 0)
                {
                    FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no Music Pages", k_Warning);
                    //MessageNotification.ShowWarningMessage(m_UsertDetails[0] + " has no Music Pages");
                }
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
                //MessageNotification.ShowErrorMessage(exception.Message);
            }
        }

        private void listBoxFetchMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page musicPage = listBoxFetchMusics.SelectedItem as Page;
            StringBuilder url = new StringBuilder();
            string[] singerName = musicPage.URL.Split('/');
            url.Append(k_WebUrl);
            url.Append(singerName[3]);
            webBrowserVideos.Navigate(url.ToString());
        }   
    }
}

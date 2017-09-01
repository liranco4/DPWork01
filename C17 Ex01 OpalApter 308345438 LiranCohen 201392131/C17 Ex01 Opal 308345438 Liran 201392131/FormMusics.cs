using System;
using System.Threading;
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
        private MusicServices m_MusicServices;

        public FormMusics()
        {
            InitializeComponent();
            try
            {
                m_MusicServices = new MusicServices();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
        }

        private void buttonFetchMusics_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() => m_MusicServices.ShowMusicPages(listBoxFetchMusics, pageBindingSource)).Start();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
        }

        private void listBoxFetchMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page musicPage = listBoxFetchMusics.SelectedItem as Page;
            StringBuilder url = new StringBuilder();
            string[] singerName = musicPage.URL.Split('/');
            url.Append(k_WebUrl);
            url.Append(singerName[3]);
            webBrowserVideosProxy.Navigate(url.ToString());
        }
    }
}

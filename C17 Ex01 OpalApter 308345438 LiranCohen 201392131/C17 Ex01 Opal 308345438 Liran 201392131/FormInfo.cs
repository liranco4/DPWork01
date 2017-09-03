using System;
using System.Threading;
using System.IO;
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
    public partial class FormInfo : Form
    {
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private const string k_PagePicUrl = "page.png";
        private InfoServices m_InfoServices;

        public FormInfo()
        {
            InitializeComponent();
            m_InfoServices = new InfoServices();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                string result = m_InfoServices.PostStatus(textBoxPost.Text);                
                MessageBox.Show(string.Format("Status Post ID: {0}",result));
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm(); ;
            }
            catch (ArgumentException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm(); ;
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() => m_InfoServices.ShowFriends(listBoxFetchFriends, userBindingSource)).Start();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm(); ;
            }
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() => m_InfoServices.ShowLikedPages(listBoxFetchLikedPages, pageBindingSource)).Start();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm(); ;
            }
        }

        private void buttonFetchPost_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() => m_InfoServices.ShowPosts(listBoxFetchPost, postBindingSource)).Start();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm(); ;
            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() => m_InfoServices.ShowEvents(listBoxFetchEvents, eventBindingSource)).Start();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm(); ;
            }
        }
    }
}
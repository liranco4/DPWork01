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
            new Thread(() => 
            {           
            try
            {
                string result = m_InfoServices.PostStatus(textBoxPost.Text);
                MessageBox.Show(string.Format("Status Post ID: {0}", result));   
            }
            catch(Facebook.FacebookOAuthException exception)
            {
                FactoryMessageNotification.CreateMessage(string.Format("Post failed: {0}",exception.Message), k_Error).ShowMessageNotificationOnForm();
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm();
            }
            catch (ArgumentException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm();
            }
            }).Start();
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            new Thread(() => 
            {
            try
            {
                 m_InfoServices.ShowFriends(listBoxFetchFriends, userBindingSource);
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm();
            }
            }).Start();
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    m_InfoServices.ShowLikedPages(listBoxFetchLikedPages, pageBindingSource);
                }
                catch (InvalidOperationException exception)
                {
                    FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm();
                }
            }).Start();
        }

        private void buttonFetchPost_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    m_InfoServices.ShowPosts(listBoxFetchPost, postBindingSource);
                }
                catch (InvalidOperationException exception)
                {
                    FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm();
                }
            }).Start();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            new Thread(() => 
            {
            try
            {
                m_InfoServices.ShowEvents(listBoxFetchEvents, eventBindingSource);
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm();
            }
            }).Start();
        }
    }
}
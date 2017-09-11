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
using System.Globalization;

namespace C17_Ex02_Opal_308345438_Liran_201392131
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
            m_InfoServices.UpdatingResponsePostID += this.showResponsePostIDOnFormInfo_UpdatingResponsePostID;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            new Thread(() => 
            {           
            try
            {
                m_InfoServices.PostStatus(textBoxPost.Text); 
            }
            catch(Facebook.FacebookOAuthException exception)
            {
                FactoryMessageNotification.CreateMessage(string.Format("Post failed: {0}", exception.Message), k_Error).ShowMessageNotificationOnForm();
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

        private void showResponsePostIDOnFormInfo_UpdatingResponsePostID(string i_ResponsePostID)
        {
            MessageBox.Show(string.Format("Status Post ID: {0}", i_ResponsePostID));   
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            new Thread(() => 
            {
            try
            {
                 m_InfoServices.ShowFriends(listBoxFetchFriends, userBindingSource,cbSortByFriends);
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
                    m_InfoServices.ShowLikedPages(listBoxFetchLikedPages, pageBindingSource,cbSortByLikedPages);
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
                m_InfoServices.ShowEvents(listBoxFetchEvents, eventBindingSource,cbSortByEvents);
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error).ShowMessageNotificationOnForm();
            }
            }).Start();
        }

        private void cbSortByLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_InfoServices.SortLikedPages(listBoxFetchLikedPages, pageBindingSource, cbSortByLikedPages.SelectedItem.ToString());
        }

        private void cbSortByFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_InfoServices.SortFriends(listBoxFetchFriends, userBindingSource, cbSortByFriends.SelectedItem.ToString());
        }

        private void cbSortByEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_InfoServices.SortEvents(listBoxFetchEvents, eventBindingSource, cbSortByEvents.SelectedItem.ToString());
        }


    }
}
using System;
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
using System.Threading;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public partial class FormInfo : Form
    {
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private const string k_PagePicUrl = "page.png";
        private FacebookOperation m_FacebookOp;
        private List<string> m_UsertDetails;

        public FormInfo()
        {
            InitializeComponent();
            m_FacebookOp = FacebookOperation.InstanceFacebookOperation;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Status Posted! ID: " + m_FacebookOp.PostStatus(textBoxPost.Text));
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }            
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            //listBoxFetchFriends.DataSource = null;
            //listBoxFetchFriends.DisplayMember = "Name";
            try
            {

                new Thread(ShowFriends).Start();
                //listBoxFetchFriends.DataSource = m_FacebookOp.FetchFriend();

                //if (m_FacebookOp.FetchFriendCount() == 0)
                //{
                //    m_UsertDetails = m_FacebookOp.FetchUserBasicDetails();
                //    FactoryMessageNotification.CreateMessage(m_UsertDetails[0]+"has no friends", k_Warning);
                //}
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
        }

        /*private void listBoxFetchFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFetchFriends.DataSource != null)
                {
                    string picUrl = m_FacebookOp.FetchFriendProfilePicture((User)listBoxFetchFriends.SelectedItem);
                    pictureBoxFriendPic.Load(picUrl);
                }
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
        }*/

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            //listBoxFetchLikedPages.DataSource = null;
            //listBoxFetchLikedPages.DisplayMember = "Name";

            try
            {
                new Thread(ShowLikedPages).Start();
                //listBoxFetchLikedPages.DataSource = m_FacebookOp.FetchLikedPages();

                //if (m_FacebookOp.FetchLikedPagesCount() == 0)
                //{
                //    FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no liked pages", k_Warning);
                //}
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
        }

        /*private void listBoxFetchLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                if (listBoxFetchLikedPages.DataSource != null)
                {
                    string picUrl = m_FacebookOp.FetchLikedPagePicture((Page)listBoxFetchLikedPages.SelectedItem);
                    pictureBoxLikedPage.Load(picUrl);
                }
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
            catch (ArgumentException)
            {
                pictureBoxLikedPage.ImageLocation = k_PagePicUrl;
            }
        }*/

        private void buttonFetchPost_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(ShowPosts).Start();
                /*listBoxFetchPost.DisplayMember = "Message";
                listBoxFetchPost.DataSource = m_FacebookOp.FetchPosts();*/

                //if (m_FacebookOp.FetchPostsCount() == 0)
                //{
                //    FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no post", k_Warning);
                //}
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            try
            {
                /*listBoxFetchEvents.DisplayMember = "Name";
                listBoxFetchEvents.DataSource = m_FacebookOp.FetchEvents();*/
                new Thread(ShowEvents).Start();

                //if (m_FacebookOp.FetchEevntsCount() == 0)
                //{
                //    FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no events", k_Warning);
                //}
            }
            catch (InvalidOperationException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
        }

        private void ShowLikedPages()
        {
            //listBoxFetchLikedPages.Invoke(new Action(() => listBoxFetchLikedPages.DataSource = m_FacebookOp.FetchLikedPages()));
            listBoxFetchLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = m_FacebookOp.FetchLikedPages()));

            if (m_FacebookOp.FetchLikedPagesCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no liked pages", k_Warning);
            }
        }

        private void ShowEvents()
        {
            listBoxFetchEvents.Invoke(new Action(() => eventBindingSource.DataSource = m_FacebookOp.FetchEvents()));

            if (m_FacebookOp.FetchEevntsCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no events", k_Warning);
            }
        }

        private void ShowPosts()
        {
            listBoxFetchPost.Invoke(new Action(() => postBindingSource.DataSource = m_FacebookOp.FetchPosts()));

            if (m_FacebookOp.FetchPostsCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no post", k_Warning);
            }
        }

        private void ShowFriends()
        {
            listBoxFetchFriends.Invoke(new Action(() => userBindingSource.DataSource = m_FacebookOp.FetchFriend()));

            if (m_FacebookOp.FetchFriendCount() == 0)
            {
                m_UsertDetails = m_FacebookOp.FetchUserBasicDetails();
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + "has no friends", k_Warning);
            }
        }

  
    }
}
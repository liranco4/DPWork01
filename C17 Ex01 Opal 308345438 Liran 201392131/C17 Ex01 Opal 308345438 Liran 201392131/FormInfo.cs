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

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public partial class FormInfo : Form
    {
        private const string m_PagePicUrl = "page.png";

        private FacebookOperation facebookOp { get; set; }

        private List<string> usertDetails { get; set; }

        public FormInfo(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();

            facebookOp = i_FacebookOp;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Status Posted! ID: " + facebookOp.PostStatus(textBoxPost.Text));
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }            
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            listBoxFetchFriends.DataSource = null;
            listBoxFetchFriends.DisplayMember = "Name";
            try
            {
                if (facebookOp.FetchFriendCount() > 0)
                {
                    listBoxFetchFriends.DataSource = facebookOp.FetchFriend();
                }
                else
                {
                    usertDetails = facebookOp.FetchUserBasicDetails();
                    MessageNotification.showWarningMessage(usertDetails[0] + " has no friends");
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void listBoxFetchFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFetchFriends.DataSource != null)
                {
                    string picUrl = facebookOp.FetchFriendProfilePicture((User)listBoxFetchFriends.SelectedItem);
                    pictureBoxFriendPic.Load(picUrl);
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            listBoxFetchLikedPages.DataSource = null;
            listBoxFetchLikedPages.DisplayMember = "Name";

            try
            {
                if (facebookOp.FetchLikedPagesCount() > 0)
                {
                    listBoxFetchLikedPages.DataSource = facebookOp.FetchLikedPages();
                }
                else
                {
                    MessageNotification.showWarningMessage(usertDetails[0] + " has no liked pages");
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void listBoxFetchLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (listBoxFetchLikedPages.DataSource != null)
                {
                    string picUrl = facebookOp.FetchLikedPagePicture((Page)listBoxFetchLikedPages.SelectedItem);
                    pictureBoxLikedPage.Load(picUrl);
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
            catch (ArgumentException)
            {
                pictureBoxLikedPage.ImageLocation = m_PagePicUrl;
            }
        }

        private void buttonFetchPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (facebookOp.FetchPostsCount() > 0)
                {
                    listBoxFetchPost.DisplayMember = "Message";
                    listBoxFetchPost.DataSource = facebookOp.FetchPosts();
                }
                else
                {
                    MessageNotification.showWarningMessage(usertDetails[0] + " has no post");
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            try
            {
                if (facebookOp.FetchEevntsCount() > 0)
                {
                    listBoxFetchEvents.DisplayMember = "Name";
                    listBoxFetchEvents.DataSource = facebookOp.FetchEvents();
                }
                else
                {
                    MessageNotification.showWarningMessage(usertDetails[0] + " has no events");
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }       
    }
}
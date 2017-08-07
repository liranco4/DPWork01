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
    public partial class FormInfo : Form
    {
        private FacebookOperation FacebookOp { get; set; }

        List<string> UsertDetails { get; set; }

        public FormInfo(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();

            FacebookOp = i_FacebookOp;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Status Posted! ID: " + (FacebookOp.PostStatus(textBoxPost.Text)));
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
            
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            listBoxFetchFriends.Items.Clear();
            listBoxFetchFriends.DisplayMember = "Name";
            try
            {
                if (FacebookOp.FetchFriendCount() > 0)
                {
                    listBoxFetchFriends.DataSource = FacebookOp.FetchFriend();
                }
                else
                {
                    UsertDetails = FacebookOp.FetchUserBasicDetails();
                    MessageNotification.showWarningMessage(UsertDetails[0] + " has no friends");
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
                string picUrl = FacebookOp.FetchFriendProfilePicture((User)listBoxFetchFriends.SelectedItem);
                pictureBoxFriendPic.Load(picUrl);
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {

            listBoxFetchLikedPages.Items.Clear();
            listBoxFetchLikedPages.DisplayMember = "Name";

            try
            {
                if (FacebookOp.FetchLikedPagesCount() > 0)
                {
                    listBoxFetchLikedPages.DataSource = FacebookOp.FetchLikedPages();
                }
                else
                {
                    MessageNotification.showWarningMessage(UsertDetails[0] + " has no liked pages");
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
                string picUrl = FacebookOp.FetchLikedPagePicture((Page)listBoxFetchLikedPages.SelectedItem);
                pictureBoxLikedPage.Load(picUrl);
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void buttonFetchPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (FacebookOp.FetchPostsCount() > 0)
                {
                    listBoxFetchPost.DisplayMember = "Message";
                    listBoxFetchPost.DataSource = FacebookOp.FetchPosts();
                }
                else
                {
                    MessageNotification.showWarningMessage(UsertDetails[0] + " has no post");
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
                if (FacebookOp.FetchEevntsCount() > 0)
                {
                    listBoxFetchEvents.DisplayMember = "Name";
                    listBoxFetchEvents.DataSource = FacebookOp.FetchEvents();
                }
                else
                {
                    MessageNotification.showWarningMessage(UsertDetails[0] + " has no events");
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

       
    }
}

﻿using System;
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
        private FacebookOperation m_FacebookOp;
        private List<string> m_UsertDetails;

        public FormInfo(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();

            m_FacebookOp = i_FacebookOp;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Status Posted! ID: " + m_FacebookOp.PostStatus(textBoxPost.Text));
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
                if (m_FacebookOp.FetchFriendCount() > 0)
                {
                    listBoxFetchFriends.DataSource = m_FacebookOp.FetchFriend();
                }
                else
                {
                    m_UsertDetails = m_FacebookOp.FetchUserBasicDetails();
                    MessageNotification.showWarningMessage(m_UsertDetails[0] + " has no friends");
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
                    string picUrl = m_FacebookOp.FetchFriendProfilePicture((User)listBoxFetchFriends.SelectedItem);
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
                if (m_FacebookOp.FetchLikedPagesCount() > 0)
                {
                    listBoxFetchLikedPages.DataSource = m_FacebookOp.FetchLikedPages();
                }
                else
                {
                    MessageNotification.showWarningMessage(m_UsertDetails[0] + " has no liked pages");
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
                    string picUrl = m_FacebookOp.FetchLikedPagePicture((Page)listBoxFetchLikedPages.SelectedItem);
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
                if (m_FacebookOp.FetchPostsCount() > 0)
                {
                    listBoxFetchPost.DisplayMember = "Message";
                    listBoxFetchPost.DataSource = m_FacebookOp.FetchPosts();
                }
                else
                {
                    MessageNotification.showWarningMessage(m_UsertDetails[0] + " has no post");
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
                if (m_FacebookOp.FetchEevntsCount() > 0)
                {
                    listBoxFetchEvents.DisplayMember = "Name";
                    listBoxFetchEvents.DataSource = m_FacebookOp.FetchEvents();
                }
                else
                {
                    MessageNotification.showWarningMessage(m_UsertDetails[0] + " has no events");
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }       
    }
}
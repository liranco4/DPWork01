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
            MessageBox.Show("Status Posted! ID: "+(FacebookOp.PostStatus(textBoxPost.Text)));
            
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            listBoxFetchFriends.Items.Clear();
            listBoxFetchFriends.DisplayMember = "Name";

            if (FacebookOp.FetchFriendCount() > 0)
            {
                listBoxFetchFriends.DataSource = FacebookOp.FetchFriend();
            }
            else
            {
                UsertDetails=FacebookOp.FetchUserBasicDetails();
                MessageBox.Show(UsertDetails[0] + " has no friends");
            }
        }

        private void listBoxFetchFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            string picUrl = FacebookOp.FetchFriendProfilePicture((User)listBoxFetchFriends.SelectedItem);
            pictureBoxFriendPic.Load(picUrl);
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {

            listBoxFetchLikedPages.Items.Clear();
            listBoxFetchLikedPages.DisplayMember = "Name";//jjjj

            if(FacebookOp.FetchLikedPagesCount()>0)
            {
                listBoxFetchLikedPages.DataSource = FacebookOp.FetchLikedPages();
            }
            else
            {
                MessageBox.Show(UsertDetails[0] + " has no liked pages");
            }
        }

        private void listBoxFetchLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string picUrl = FacebookOp.FetchLikedPagePicture((Page)listBoxFetchLikedPages.SelectedItem);
            pictureBoxLikedPage.Load(picUrl);
        }

        private void buttonFetchPost_Click(object sender, EventArgs e)
        {
            if (FacebookOp.FetchPostsCount() > 0)
            {
                listBoxFetchPost.DisplayMember = "Message";
                listBoxFetchPost.DataSource = FacebookOp.FetchPosts();
            }
            else
            {
                MessageBox.Show(UsertDetails[0] + " has no post");
            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            if (FacebookOp.FetchEevntsCount() > 0)
            {
                listBoxFetchEvents.DisplayMember = "Name";
                listBoxFetchEvents.DataSource = FacebookOp.FetchEvents();
            }
            else
            {
                MessageBox.Show(UsertDetails[0] + " has no events");
            }
        }


    }
}

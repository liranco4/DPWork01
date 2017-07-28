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
    public partial class FormAlbums : Form
    {
        private FacebookOperation faceBookOperation = new FacebookOperation("1752749615018089", 200, 20.5f);
        public FormAlbums()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loadVideoButton_Click(object sender, EventArgs e)
        {
            /*if(!faceBookOperation.LoginToFaceBook( "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",

                //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",

                // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
                "read_page_mailboxes",
                // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
                // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
                "manage_pages",
                "publish_pages",
                "publish_actions",

                "rsvp_event"
                ))
            {
                MessageBox.Show("Can not login"); 
            }
            else
            {
                
                foreach(Video video in faceBookOperation.FetchUserVideos())
               {
                   int x = 1;
                    listBox1.Items.Add(video.URL);
               }
            }*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 1;
            axWindowsMediaPlayer1.URL = "https://www.youtube.com/watch?v=5tpQEsJ0iVg&spfreload=1";
        }
       
    }
}

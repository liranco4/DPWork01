using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public partial class FormHome : Form
    {
        FacebookOperation FacebookOp { get; set; }
        List<Panel> PanelsList { get; set; }
        bool ToMove { get; set; }
        int MValX { get; set; }
        int MValY { get; set; }
        Form CurrentForm { get; set; }

        public FormHome()
        {
            InitializeComponent();

           FacebookOp = new FacebookOperation("1752749615018089", 200, 20.5f);
            var imageSize = PictureBox1.Image.Size;
            var fitSize = PictureBox1.ClientSize;
            PictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            pictureBoxProfile.BringToFront();
            PanelsList=new List<Panel>();
            PanelsList.Add(panel1);
            PanelsList.Add(panel2);
            PanelsList.Add(panel3);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            List<string> userDetails;

            if (FacebookOp.LoginToFaceBook("public_profile",
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
                userDetails = FacebookOp.FetchUserBasicDetails();
                pictureBoxProfile.Load(FacebookOp.FetchUserProfilePicture());
                labelUserInfo.Text = "Hello " + userDetails[0] + " " + userDetails[1];
            }
            else
            {
                MessageBox.Show("Cannot Loged In");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ToMove = true;
            MValX = e.X+panel1.Width;
            MValY = e.Y+panel2.Height;
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            ToMove = false;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (ToMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (!FacebookOp.isLoggedIn())
            {
                MessageBox.Show("You have to log in first");
            }
            else
            {
                if (panel3.Controls.Count > 0)
                {
                    ((Form)panel3.Controls[0]).Hide();
                    panel3.Controls.RemoveAt(0);
                }
                FormInfo objForm = new FormInfo();
                objForm.TopLevel = false;
                panel3.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            if (!FacebookOp.isLoggedIn())
            {
                MessageBox.Show("You have to log in first");
            }
            else
            {
                if (panel3.Controls.Count > 0)
                {
                    ((Form)panel3.Controls[0]).Hide();
                    panel3.Controls.RemoveAt(0);
                }
                FormAlbums objForm = new FormAlbums();
                objForm.TopLevel = false;
                panel3.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (!FacebookOp.isLoggedIn())
            {
                MessageBox.Show("You have to log in first");
            }
            else
            {
                if (panel3.Controls.Count > 0)
                {
                    ((Form)panel3.Controls[0]).Hide();
                    panel3.Controls.RemoveAt(0);
                }
                FormCheckIn objForm = new FormCheckIn();
                objForm.TopLevel = false;
                panel3.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
            }
        }

    }
    
}

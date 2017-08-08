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
    public partial class FormHome : Form
    {
        private const string m_AutenticationMessage = "You must login first";
        private const string m_LoggedOutError = "You are not logged in";
        private const string m_CannotLoggedInError = "Cannot log in";

        private FacebookOperation facebookOp { get; set; }

        private List<Panel> panelsList { get; set; }

        private bool toMove { get; set; }

        private int mValX { get; set; }

        private int mValY { get; set; }

        private Form currentForm { get; set; }

        public FormHome()
        {
            InitializeComponent();

           facebookOp = new FacebookOperation("1752749615018089", 200, 20.5f);
            var imageSize = PictureBox1.Image.Size;
            var fitSize = PictureBox1.ClientSize;
            PictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            pictureBoxProfile.BringToFront();
            panelsList = new List<Panel>();
            panelsList.Add(panel1);
            panelsList.Add(panel2);
            panelsList.Add(panel3);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            List<string> userDetails;
            try
            {
                if (facebookOp.LoginToFaceBook(
                "public_profile",
                "user_actions.music",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_status",
                "user_tagged_places",
                "user_website",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event"))
                {
                    userDetails = facebookOp.FetchUserBasicDetails();
                    pictureBoxProfile.Load(facebookOp.FetchUserProfilePicture());
                    labelUserInfo.Text = "Hello " + userDetails[0] + " " + userDetails[1];
                    pictureBoxProfile.Show();
                }
                else
                {
                    MessageNotification.showErrorMessage(m_CannotLoggedInError);
                }
            }
            catch (Facebook.FacebookOAuthException exception)
            {
                MessageNotification.showErrorMessage(exception.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (!facebookOp.isLoggedIn())
            {
                MessageNotification.showWarningMessage(m_AutenticationMessage);
            }
            else
            {
                FormInfo objForm = new FormInfo(facebookOp);
                objForm.TopLevel = false;
                panel3.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
                if (panel3.Controls.Count > 1)
                {
                    panel3.Controls[1].Show();
                    ((Form)panel3.Controls[0]).Hide();
                    panel3.Controls.RemoveAt(0);
                }
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            if (!facebookOp.isLoggedIn())
            {
                MessageNotification.showWarningMessage(m_AutenticationMessage);
            }
            else
            {
                FormMusics objForm = new FormMusics(facebookOp);
                objForm.TopLevel = false;
                panel3.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
                if (panel3.Controls.Count > 1)
                {
                    panel3.Controls[1].Show();
                    ((Form)panel3.Controls[0]).Hide();
                    panel3.Controls.RemoveAt(0);
                }
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (!facebookOp.isLoggedIn())
            {
                MessageNotification.showWarningMessage(m_AutenticationMessage);
            }
            else
            {
                FormCheckIn objForm = new FormCheckIn(facebookOp);
                objForm.TopLevel = false;
                panel3.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
                if (panel3.Controls.Count > 1)
                {
                    panel3.Controls[1].Show();
                    ((Form)panel3.Controls[0]).Hide();
                    panel3.Controls.RemoveAt(0);
                }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if(facebookOp.isLoggedIn())
            {
                facebookOp.LogOut();
                pictureBoxProfile.Hide();
                labelUserInfo.Text = string.Empty;
                if (panel3.Controls.Count > 0)
                {
                    ((Form)panel3.Controls[0]).Hide();
                    panel3.Controls.RemoveAt(0);
                }
            }
            else
            {
                MessageNotification.showErrorMessage(m_LoggedOutError);
            }
        }

        private void pictureBoxHomePage_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            toMove = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            toMove = true;
            mValX = e.X + panel1.Width;
            mValY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (toMove)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            toMove = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (toMove)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            toMove = true;
            mValX = e.X;
            mValY = e.Y;
        }
    }    
}

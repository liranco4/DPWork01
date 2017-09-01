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
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private const string k_AutenticationMessage = "You must login first";
        private const string k_LoggedOutError = "You are not logged in";
        private const string k_CannotLoggedInError = "Cannot log in";
        private SingletonFacebookAppService m_FacebookAppService;
        private List<Panel> m_PanelsList;
        private bool m_ToMove;
        private int m_MValX;
        private int m_MValY;

        public FormHome()
        {
            InitializeComponent();
            SingletonFacebookAppService.AppID = "1752749615018089";
            m_FacebookAppService = SingletonFacebookAppService.GetInstanceFacebookServices;
            var imageSize = PictureBox1.Image.Size;
            var fitSize = PictureBox1.ClientSize;
            PictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
            PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            pictureBoxProfile.BringToFront();
            m_PanelsList = new List<Panel>();
            m_PanelsList.Add(panel1);
            m_PanelsList.Add(panel2);
            m_PanelsList.Add(panel3);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            List<string> userDetails;
            try
            {
                if (m_FacebookAppService.LoginToFaceBook(
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
                    userDetails = m_FacebookAppService.FetchUserBasicDetails();
                    pictureBoxProfile.Load(m_FacebookAppService.FetchUserProfilePicture());
                    labelUserInfo.Text = "Hello " + userDetails[0] + " " + userDetails[1];
                    pictureBoxProfile.Show();
                }
                else
                {
                  FactoryMessageNotification.CreateMessage(k_CannotLoggedInError, k_Error);
                }
            }
            catch (Facebook.FacebookOAuthException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
            }
            catch (ArgumentNullException exception)
            {
                FactoryMessageNotification.CreateMessage(exception.Message, k_Error);
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
            if (!m_FacebookAppService.isLoggedIn())
            {
                FactoryMessageNotification.CreateMessage(k_AutenticationMessage, k_Warning);
            }
            else
            {
                FormInfo objForm = new FormInfo();
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

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            if (!m_FacebookAppService.isLoggedIn())
            {
                FactoryMessageNotification.CreateMessage(k_AutenticationMessage, k_Warning);
            }
            else
            {
                FormMusics objForm = new FormMusics();
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
            if (!m_FacebookAppService.isLoggedIn())
            {
                FactoryMessageNotification.CreateMessage(k_AutenticationMessage, k_Warning);
            }
            else
            {
                FormCheckIn objForm = new FormCheckIn();
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
            if(m_FacebookAppService.isLoggedIn())
            {
                m_FacebookAppService.LogOut();
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
                FactoryMessageNotification.CreateMessage(k_LoggedOutError, k_Error);
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
            m_ToMove = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            m_ToMove = true;
            m_MValX = e.X + panel1.Width;
            m_MValY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_ToMove)
            {
                this.SetDesktopLocation(MousePosition.X - m_MValX, MousePosition.Y - m_MValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m_ToMove = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_ToMove)
            {
                this.SetDesktopLocation(MousePosition.X - m_MValX, MousePosition.Y - m_MValY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m_ToMove = true;
            m_MValX = e.X;
            m_MValY = e.Y;
        }
    }    
}

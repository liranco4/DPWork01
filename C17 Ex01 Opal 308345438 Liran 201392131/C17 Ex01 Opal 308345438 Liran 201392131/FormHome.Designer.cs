namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxHomePage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            resources.ApplyResources(this.buttonLogin, "buttonLogin");
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.buttonCheckIn);
            this.panel1.Controls.Add(this.buttonAlbums);
            this.panel1.Controls.Add(this.buttonInfo);
            this.panel1.Controls.Add(this.PictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonCheckIn
            // 
            resources.ApplyResources(this.buttonCheckIn, "buttonCheckIn");
            this.buttonCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonAlbums
            // 
            resources.ApplyResources(this.buttonAlbums, "buttonAlbums");
            this.buttonAlbums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonInfo
            // 
            resources.ApplyResources(this.buttonInfo, "buttonInfo");
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources.facebook;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.panel2.Controls.Add(this.pictureBoxProfile);
            this.panel2.Controls.Add(this.pictureBoxHomePage);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelUserInfo);
            this.panel2.Controls.Add(this.buttonMin);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBoxHomePage
            // 
            this.pictureBoxHomePage.BackgroundImage = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources.home;
            resources.ApplyResources(this.pictureBoxHomePage, "pictureBoxHomePage");
            this.pictureBoxHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHomePage.Image = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources.home;
            this.pictureBoxHomePage.Name = "pictureBoxHomePage";
            this.pictureBoxHomePage.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxHomePage, resources.GetString("pictureBoxHomePage.ToolTip"));
            this.pictureBoxHomePage.Click += new System.EventHandler(this.pictureBoxHomePage_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUserInfo
            // 
            resources.ApplyResources(this.labelUserInfo, "labelUserInfo");
            this.labelUserInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUserInfo.Name = "labelUserInfo";
            // 
            // buttonMin
            // 
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonMin, "buttonMin");
            this.buttonMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.pictureBoxProfile, "pictureBoxProfile");
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources.background1;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources._36427424_Mobile_apps_pattern_with_music_chat_gallery_speaking_bubble_email_magnifying_glass_shopping_search_n_Stock_Vector;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxHomePage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}


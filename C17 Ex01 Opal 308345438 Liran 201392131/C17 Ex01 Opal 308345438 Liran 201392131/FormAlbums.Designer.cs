namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    partial class FormAlbums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbums));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxFetchAlbums = new System.Windows.Forms.ListBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.webBrowserVideos = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(90, 177);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(287, 234);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // listBoxFetchAlbums
            // 
            this.listBoxFetchAlbums.FormattingEnabled = true;
            this.listBoxFetchAlbums.ItemHeight = 16;
            this.listBoxFetchAlbums.Location = new System.Drawing.Point(13, 78);
            this.listBoxFetchAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFetchAlbums.Name = "listBoxFetchAlbums";
            this.listBoxFetchAlbums.Size = new System.Drawing.Size(296, 580);
            this.listBoxFetchAlbums.TabIndex = 3;
            this.listBoxFetchAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxFetchAlbums_SelectedIndexChanged);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFetchAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchAlbums.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchAlbums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchAlbums.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(13, 12);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(187, 43);
            this.buttonFetchAlbums.TabIndex = 6;
            this.buttonFetchAlbums.Text = "Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = false;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // webBrowserVideos
            // 
            this.webBrowserVideos.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowserVideos.Location = new System.Drawing.Point(364, 0);
            this.webBrowserVideos.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserVideos.Name = "webBrowserVideos";
            this.webBrowserVideos.Size = new System.Drawing.Size(853, 679);
            this.webBrowserVideos.TabIndex = 7;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources._36427424_Mobile_apps_pattern_with_music_chat_gallery_speaking_bubble_email_magnifying_glass_shopping_search_n_Stock_Vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1217, 679);
            this.Controls.Add(this.webBrowserVideos);
            this.Controls.Add(this.buttonFetchAlbums);
            this.Controls.Add(this.listBoxFetchAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBoxFetchAlbums;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.WebBrowser webBrowserVideos;
    }
}
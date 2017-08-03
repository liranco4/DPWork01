namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    partial class FormMusics
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxFetchMusics = new System.Windows.Forms.ListBox();
            this.buttonFetchMusics = new System.Windows.Forms.Button();
            this.webBrowserVideos = new System.Windows.Forms.WebBrowser();
            this.descriptionOflistBoxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listBoxFetchMusics
            // 
            this.listBoxFetchMusics.FormattingEnabled = true;
            this.listBoxFetchMusics.Location = new System.Drawing.Point(10, 125);
            this.listBoxFetchMusics.Name = "listBoxFetchMusics";
            this.listBoxFetchMusics.Size = new System.Drawing.Size(337, 420);
            this.listBoxFetchMusics.TabIndex = 3;
            this.listBoxFetchMusics.SelectedIndexChanged += new System.EventHandler(this.listBoxFetchAlbums_SelectedIndexChanged);
            // 
            // buttonFetchMusics
            // 
            this.buttonFetchMusics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFetchMusics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchMusics.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchMusics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchMusics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchMusics.Location = new System.Drawing.Point(10, 10);
            this.buttonFetchMusics.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchMusics.Name = "buttonFetchMusics";
            this.buttonFetchMusics.Size = new System.Drawing.Size(337, 60);
            this.buttonFetchMusics.TabIndex = 6;
            this.buttonFetchMusics.Text = "Load Your Favorite Singers Musics";
            this.buttonFetchMusics.UseVisualStyleBackColor = false;
            this.buttonFetchMusics.Click += new System.EventHandler(this.buttonFetchMusics_Click);
            // 
            // webBrowserVideos
            // 
            this.webBrowserVideos.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowserVideos.Location = new System.Drawing.Point(469, 0);
            this.webBrowserVideos.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowserVideos.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowserVideos.Name = "webBrowserVideos";
            this.webBrowserVideos.Size = new System.Drawing.Size(640, 552);
            this.webBrowserVideos.TabIndex = 7;
            // 
            // descriptionOflistBoxLabel
            // 
            this.descriptionOflistBoxLabel.AutoSize = true;
            this.descriptionOflistBoxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.descriptionOflistBoxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionOflistBoxLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionOflistBoxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionOflistBoxLabel.Location = new System.Drawing.Point(12, 88);
            this.descriptionOflistBoxLabel.Name = "descriptionOflistBoxLabel";
            this.descriptionOflistBoxLabel.Size = new System.Drawing.Size(335, 20);
            this.descriptionOflistBoxLabel.TabIndex = 8;
            this.descriptionOflistBoxLabel.Text = "Select your favorite singer from the following list:";
            // 
            // FormMusics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources._36427424_Mobile_apps_pattern_with_music_chat_gallery_speaking_bubble_email_magnifying_glass_shopping_search_n_Stock_Vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1109, 552);
            this.Controls.Add(this.descriptionOflistBoxLabel);
            this.Controls.Add(this.webBrowserVideos);
            this.Controls.Add(this.buttonFetchMusics);
            this.Controls.Add(this.listBoxFetchMusics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMusics";
            this.Text = "FormAlbums";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBoxFetchMusics;
        private System.Windows.Forms.Button buttonFetchMusics;
        private System.Windows.Forms.WebBrowser webBrowserVideos;
        private System.Windows.Forms.Label descriptionOflistBoxLabel;
    }
}
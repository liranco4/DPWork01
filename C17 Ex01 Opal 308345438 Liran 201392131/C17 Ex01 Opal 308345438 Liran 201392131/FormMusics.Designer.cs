﻿namespace C17_Ex01_Opal_308345438_Liran_201392131
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.listBoxFetchMusics.ItemHeight = 16;
            this.listBoxFetchMusics.Location = new System.Drawing.Point(13, 159);
            this.listBoxFetchMusics.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFetchMusics.Name = "listBoxFetchMusics";
            this.listBoxFetchMusics.Size = new System.Drawing.Size(259, 532);
            this.listBoxFetchMusics.TabIndex = 3;
            this.listBoxFetchMusics.SelectedIndexChanged += new System.EventHandler(this.listBoxFetchAlbums_SelectedIndexChanged);
            // 
            // buttonFetchMusics
            // 
            this.buttonFetchMusics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFetchMusics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchMusics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchMusics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchMusics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchMusics.Location = new System.Drawing.Point(12, 11);
            this.buttonFetchMusics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchMusics.Name = "buttonFetchMusics";
            this.buttonFetchMusics.Size = new System.Drawing.Size(328, 55);
            this.buttonFetchMusics.TabIndex = 6;
            this.buttonFetchMusics.Text = "Load Your Favorite Singers Musics";
            this.buttonFetchMusics.UseVisualStyleBackColor = false;
            this.buttonFetchMusics.Click += new System.EventHandler(this.buttonFetchMusics_Click);
            // 
            // webBrowserVideos
            // 
            this.webBrowserVideos.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowserVideos.Location = new System.Drawing.Point(592, 0);
            this.webBrowserVideos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowserVideos.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserVideos.Name = "webBrowserVideos";
            this.webBrowserVideos.Size = new System.Drawing.Size(887, 679);
            this.webBrowserVideos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "from the following list :   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select your favorite singer";
            // 
            // FormMusics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources._36427424_Mobile_apps_pattern_with_music_chat_gallery_speaking_bubble_email_magnifying_glass_shopping_search_n_Stock_Vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1479, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowserVideos);
            this.Controls.Add(this.buttonFetchMusics);
            this.Controls.Add(this.listBoxFetchMusics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
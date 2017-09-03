namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    partial class FormCheckIn
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
            this.buttonFetchCheckIn = new System.Windows.Forms.Button();
            this.webCheckINBrowserProxy = new C17_Ex01_Opal_308345438_Liran_201392131.WebBrowserProxy();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchCheckIn
            // 
            this.buttonFetchCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFetchCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchCheckIn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchCheckIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchCheckIn.Location = new System.Drawing.Point(33, 12);
            this.buttonFetchCheckIn.Name = "buttonFetchCheckIn";
            this.buttonFetchCheckIn.Size = new System.Drawing.Size(187, 43);
            this.buttonFetchCheckIn.TabIndex = 5;
            this.buttonFetchCheckIn.Text = "Check In";
            this.buttonFetchCheckIn.UseVisualStyleBackColor = false;
            this.buttonFetchCheckIn.Click += new System.EventHandler(this.buttonFetchCheckIn_Click);
            // 
            // webCheckINBrowserProxy
            // 
            this.webCheckINBrowserProxy.Dock = System.Windows.Forms.DockStyle.Right;
            this.webCheckINBrowserProxy.Location = new System.Drawing.Point(364, 0);
            this.webCheckINBrowserProxy.MinimumSize = new System.Drawing.Size(20, 20);
            this.webCheckINBrowserProxy.Name = "webCheckINBrowserProxy";
            this.webCheckINBrowserProxy.Size = new System.Drawing.Size(835, 633);
            this.webCheckINBrowserProxy.TabIndex = 6;
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.DataSource = this.checkinBindingSource;
            this.listBoxCheckIn.DisplayMember = "Name";
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.ItemHeight = 16;
            this.listBoxCheckIn.Location = new System.Drawing.Point(33, 61);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(325, 516);
            this.listBoxCheckIn.TabIndex = 7;
            this.listBoxCheckIn.SelectedIndexChanged += new System.EventHandler(this.listBoxCheckIn_SelectedIndexChanged);
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C17_Ex01_Opal_308345438_Liran_201392131.Properties.Resources._36427424_Mobile_apps_pattern_with_music_chat_gallery_speaking_bubble_email_magnifying_glass_shopping_search_n_Stock_Vector;
            this.ClientSize = new System.Drawing.Size(1199, 633);
            this.Controls.Add(this.listBoxCheckIn);
            this.Controls.Add(this.webCheckINBrowserProxy);
            this.Controls.Add(this.buttonFetchCheckIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckIn";
            this.Text = "FormCheckIn";
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchCheckIn;
        private System.Windows.Forms.WebBrowser webCheckINBrowserProxy;
        private System.Windows.Forms.ListBox listBoxCheckIn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource checkinBindingSource;
    }
}
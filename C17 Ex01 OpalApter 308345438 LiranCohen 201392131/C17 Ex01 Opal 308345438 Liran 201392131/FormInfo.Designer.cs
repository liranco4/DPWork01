namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    partial class FormInfo
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
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label categoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.listBoxFetchFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.listBoxFetchLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchLikedPages = new System.Windows.Forms.Button();
            this.listBoxFetchPost = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchPost = new System.Windows.Forms.Button();
            this.listBoxFetchEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            endTimeLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = System.Drawing.Color.Transparent;
            endTimeLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endTimeLabel.Location = new System.Drawing.Point(971, 259);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(82, 24);
            endTimeLabel.TabIndex = 15;
            endTimeLabel.Text = "End Time:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = System.Drawing.Color.Transparent;
            startTimeLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F);
            startTimeLabel.Location = new System.Drawing.Point(971, 293);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(92, 24);
            startTimeLabel.TabIndex = 19;
            startTimeLabel.Text = "Start Time:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            birthdayLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F);
            birthdayLabel.Location = new System.Drawing.Point(53, 206);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(76, 24);
            birthdayLabel.TabIndex = 21;
            birthdayLabel.Text = "Birthday:";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(57, 49);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(823, 107);
            this.textBoxPost.TabIndex = 0;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPost.Location = new System.Drawing.Point(907, 113);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(142, 43);
            this.buttonPost.TabIndex = 2;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // listBoxFetchFriends
            // 
            this.listBoxFetchFriends.DataSource = this.userBindingSource;
            this.listBoxFetchFriends.DisplayMember = "Name";
            this.listBoxFetchFriends.FormattingEnabled = true;
            this.listBoxFetchFriends.ItemHeight = 16;
            this.listBoxFetchFriends.Location = new System.Drawing.Point(57, 323);
            this.listBoxFetchFriends.Name = "listBoxFetchFriends";
            this.listBoxFetchFriends.Size = new System.Drawing.Size(305, 404);
            this.listBoxFetchFriends.TabIndex = 3;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFetchFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchFriends.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchFriends.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchFriends.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchFriends.Location = new System.Drawing.Point(57, 274);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(142, 43);
            this.buttonFetchFriends.TabIndex = 4;
            this.buttonFetchFriends.Text = "Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = false;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // listBoxFetchLikedPages
            // 
            this.listBoxFetchLikedPages.DataSource = this.pageBindingSource;
            this.listBoxFetchLikedPages.DisplayMember = "Name";
            this.listBoxFetchLikedPages.FormattingEnabled = true;
            this.listBoxFetchLikedPages.ItemHeight = 16;
            this.listBoxFetchLikedPages.Location = new System.Drawing.Point(422, 323);
            this.listBoxFetchLikedPages.Name = "listBoxFetchLikedPages";
            this.listBoxFetchLikedPages.Size = new System.Drawing.Size(305, 404);
            this.listBoxFetchLikedPages.TabIndex = 7;
            this.listBoxFetchLikedPages.ValueMember = "AccessToken";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // buttonFetchLikedPages
            // 
            this.buttonFetchLikedPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFetchLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchLikedPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchLikedPages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchLikedPages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchLikedPages.Location = new System.Drawing.Point(422, 274);
            this.buttonFetchLikedPages.Name = "buttonFetchLikedPages";
            this.buttonFetchLikedPages.Size = new System.Drawing.Size(142, 43);
            this.buttonFetchLikedPages.TabIndex = 8;
            this.buttonFetchLikedPages.Text = "liked pages";
            this.buttonFetchLikedPages.UseVisualStyleBackColor = false;
            this.buttonFetchLikedPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // listBoxFetchPost
            // 
            this.listBoxFetchPost.DataSource = this.postBindingSource;
            this.listBoxFetchPost.DisplayMember = "Message";
            this.listBoxFetchPost.FormattingEnabled = true;
            this.listBoxFetchPost.ItemHeight = 16;
            this.listBoxFetchPost.Location = new System.Drawing.Point(797, 563);
            this.listBoxFetchPost.Name = "listBoxFetchPost";
            this.listBoxFetchPost.Size = new System.Drawing.Size(389, 164);
            this.listBoxFetchPost.TabIndex = 10;
            this.listBoxFetchPost.ValueMember = "Caption";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // buttonFetchPost
            // 
            this.buttonFetchPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFetchPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchPost.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchPost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchPost.Location = new System.Drawing.Point(797, 514);
            this.buttonFetchPost.Name = "buttonFetchPost";
            this.buttonFetchPost.Size = new System.Drawing.Size(142, 43);
            this.buttonFetchPost.TabIndex = 11;
            this.buttonFetchPost.Text = "Fetch post";
            this.buttonFetchPost.UseVisualStyleBackColor = false;
            this.buttonFetchPost.Click += new System.EventHandler(this.buttonFetchPost_Click);
            // 
            // listBoxFetchEvents
            // 
            this.listBoxFetchEvents.DataSource = this.eventBindingSource;
            this.listBoxFetchEvents.DisplayMember = "Name";
            this.listBoxFetchEvents.FormattingEnabled = true;
            this.listBoxFetchEvents.ItemHeight = 16;
            this.listBoxFetchEvents.Location = new System.Drawing.Point(797, 323);
            this.listBoxFetchEvents.Name = "listBoxFetchEvents";
            this.listBoxFetchEvents.Size = new System.Drawing.Size(389, 164);
            this.listBoxFetchEvents.TabIndex = 12;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFetchEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchEvents.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchEvents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchEvents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchEvents.Location = new System.Drawing.Point(797, 274);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(142, 43);
            this.buttonFetchEvents.TabIndex = 13;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = false;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Font = new System.Drawing.Font("Segoe Print", 7.8F);
            this.endTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(1069, 253);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(117, 30);
            this.endTimeDateTimePicker.TabIndex = 16;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Font = new System.Drawing.Font("Segoe Print", 7.8F);
            this.startTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(1069, 287);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(117, 30);
            this.startTimeDateTimePicker.TabIndex = 20;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(598, 206);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(129, 111);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageNormalPictureBox.TabIndex = 21;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Font = new System.Drawing.Font("Segoe Print", 7.8F);
            this.birthdayTextBox.Location = new System.Drawing.Point(135, 206);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(91, 30);
            this.birthdayTextBox.TabIndex = 22;
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(233, 206);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(129, 111);
            this.imageNormalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageNormalPictureBox1.TabIndex = 24;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = System.Drawing.Color.Transparent;
            categoryLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F);
            categoryLabel.Location = new System.Drawing.Point(418, 206);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(77, 24);
            categoryLabel.TabIndex = 24;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Category", true));
            this.categoryTextBox.Font = new System.Drawing.Font("Segoe Print", 7.8F);
            this.categoryTextBox.Location = new System.Drawing.Point(501, 206);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(91, 30);
            this.categoryTextBox.TabIndex = 25;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1286, 747);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.imageNormalPictureBox1);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(this.endTimeDateTimePicker);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimeDateTimePicker);
            this.Controls.Add(this.buttonFetchEvents);
            this.Controls.Add(this.listBoxFetchEvents);
            this.Controls.Add(this.buttonFetchPost);
            this.Controls.Add(this.listBoxFetchPost);
            this.Controls.Add(this.buttonFetchLikedPages);
            this.Controls.Add(this.listBoxFetchLikedPages);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.listBoxFetchFriends);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfo";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ListBox listBoxFetchFriends;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox listBoxFetchLikedPages;
        private System.Windows.Forms.Button buttonFetchLikedPages;
        private System.Windows.Forms.ListBox listBoxFetchPost;
        private System.Windows.Forms.Button buttonFetchPost;
        private System.Windows.Forms.ListBox listBoxFetchEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
        private System.Windows.Forms.TextBox categoryTextBox;        
    }
}
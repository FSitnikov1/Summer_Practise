namespace Client
{
    partial class Messanger
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Групповой", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Личный", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Общий чат"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messanger));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MChatPanel = new System.Windows.Forms.Panel();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.CurrentRecipientLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.ChatListBox = new System.Windows.Forms.ListBox();
            this.MChats = new System.Windows.Forms.Panel();
            this.ChatListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status_imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CurUserToolStripTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserDelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.MChatPanel.SuspendLayout();
            this.MChats.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.MChatPanel);
            this.MainPanel.Controls.Add(this.MChats);
            this.MainPanel.Controls.Add(this.menuStrip1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1084, 611);
            this.MainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите чат:";
            // 
            // MChatPanel
            // 
            this.MChatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MChatPanel.Controls.Add(this.MessageTextBox);
            this.MChatPanel.Controls.Add(this.CurrentRecipientLabel);
            this.MChatPanel.Controls.Add(this.SendButton);
            this.MChatPanel.Controls.Add(this.ChatListBox);
            this.MChatPanel.Location = new System.Drawing.Point(186, 29);
            this.MChatPanel.Name = "MChatPanel";
            this.MChatPanel.Size = new System.Drawing.Size(886, 570);
            this.MChatPanel.TabIndex = 2;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextBox.Location = new System.Drawing.Point(129, 541);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(661, 20);
            this.MessageTextBox.TabIndex = 4;
            // 
            // CurrentRecipientLabel
            // 
            this.CurrentRecipientLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CurrentRecipientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentRecipientLabel.Location = new System.Drawing.Point(3, 541);
            this.CurrentRecipientLabel.Name = "CurrentRecipientLabel";
            this.CurrentRecipientLabel.Size = new System.Drawing.Size(120, 20);
            this.CurrentRecipientLabel.TabIndex = 3;
            this.CurrentRecipientLabel.Text = "Общий чат";
            this.CurrentRecipientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(796, 531);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(87, 36);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ChatListBox
            // 
            this.ChatListBox.FormattingEnabled = true;
            this.ChatListBox.Items.AddRange(new object[] {
            " "});
            this.ChatListBox.Location = new System.Drawing.Point(3, 3);
            this.ChatListBox.Name = "ChatListBox";
            this.ChatListBox.Size = new System.Drawing.Size(880, 524);
            this.ChatListBox.TabIndex = 1;
            this.ChatListBox.DoubleClick += new System.EventHandler(this.ChatListBox_DoubleClick);
            // 
            // MChats
            // 
            this.MChats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MChats.Controls.Add(this.ChatListView);
            this.MChats.Location = new System.Drawing.Point(3, 55);
            this.MChats.Name = "MChats";
            this.MChats.Size = new System.Drawing.Size(162, 544);
            this.MChats.TabIndex = 1;
            // 
            // ChatListView
            // 
            this.ChatListView.AutoArrange = false;
            this.ChatListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ChatListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ChatListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatListView.FullRowSelect = true;
            listViewGroup1.Header = "Групповой";
            listViewGroup1.Name = "MultipleListViewGroup";
            listViewGroup2.Header = "Личный";
            listViewGroup2.Name = "SingleListViewGroup";
            this.ChatListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ChatListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ChatListView.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            this.ChatListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ChatListView.LargeImageList = this.status_imageList;
            this.ChatListView.Location = new System.Drawing.Point(0, 0);
            this.ChatListView.MultiSelect = false;
            this.ChatListView.Name = "ChatListView";
            this.ChatListView.Size = new System.Drawing.Size(162, 544);
            this.ChatListView.SmallImageList = this.status_imageList;
            this.ChatListView.TabIndex = 1;
            this.ChatListView.UseCompatibleStateImageBehavior = false;
            this.ChatListView.View = System.Windows.Forms.View.List;
            this.ChatListView.Click += new System.EventHandler(this.ChatListView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 150;
            // 
            // status_imageList
            // 
            this.status_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("status_imageList.ImageStream")));
            this.status_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.status_imageList.Images.SetKeyName(0, "CircleRed.png");
            this.status_imageList.Images.SetKeyName(1, "CircleGreen.png");
            this.status_imageList.Images.SetKeyName(2, "CircleRed.jpg");
            this.status_imageList.Images.SetKeyName(3, "CircleGreen.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurUserToolStripTextBox,
            this.UserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CurUserToolStripTextBox
            // 
            this.CurUserToolStripTextBox.Name = "CurUserToolStripTextBox";
            this.CurUserToolStripTextBox.Size = new System.Drawing.Size(12, 20);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserDelToolStripMenuItem});
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.UserToolStripMenuItem.Text = "Аккаунт";
            // 
            // UserDelToolStripMenuItem
            // 
            this.UserDelToolStripMenuItem.Name = "UserDelToolStripMenuItem";
            this.UserDelToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.UserDelToolStripMenuItem.Text = "Удалить пользователя";
            this.UserDelToolStripMenuItem.Click += new System.EventHandler(this.UserDelToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Messanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.MainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Messanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messanger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Messanger_FormClosed);
            this.Load += new System.EventHandler(this.Messanger_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MChatPanel.ResumeLayout(false);
            this.MChatPanel.PerformLayout();
            this.MChats.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MChatPanel;
        private System.Windows.Forms.Panel MChats;
        private System.Windows.Forms.Label CurrentRecipientLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox ChatListBox;
        internal System.Windows.Forms.TextBox MessageTextBox;
        public System.Windows.Forms.ImageList status_imageList;
        private System.Windows.Forms.ListView ChatListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserDelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CurUserToolStripTextBox;
    }
}
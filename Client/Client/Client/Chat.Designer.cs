namespace Client
{
    partial class Chat
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.btn_loginin = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.in_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.in_login = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.er_label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 1;
            label1.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // btn_loginin
            // 
            this.btn_loginin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_loginin.Location = new System.Drawing.Point(41, 17);
            this.btn_loginin.Name = "btn_loginin";
            this.btn_loginin.Size = new System.Drawing.Size(101, 23);
            this.btn_loginin.TabIndex = 2;
            this.btn_loginin.Text = "Войти";
            this.btn_loginin.UseVisualStyleBackColor = true;
            this.btn_loginin.Click += new System.EventHandler(this.btn_loginin_Click);
            // 
            // btn_registration
            // 
            this.btn_registration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_registration.Location = new System.Drawing.Point(0, 54);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(184, 23);
            this.btn_registration.TabIndex = 3;
            this.btn_registration.Text = "Зарегистрироваться";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // in_password
            // 
            this.in_password.Location = new System.Drawing.Point(26, 77);
            this.in_password.Name = "in_password";
            this.in_password.Size = new System.Drawing.Size(134, 20);
            this.in_password.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.in_login);
            this.panel1.Controls.Add(this.in_password);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Location = new System.Drawing.Point(53, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 120);
            this.panel1.TabIndex = 3;
            // 
            // in_login
            // 
            this.in_login.Location = new System.Drawing.Point(26, 31);
            this.in_login.Name = "in_login";
            this.in_login.Size = new System.Drawing.Size(134, 20);
            this.in_login.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_loginin);
            this.panel2.Controls.Add(this.btn_registration);
            this.panel2.Location = new System.Drawing.Point(53, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 77);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.error_label);
            this.panel3.Controls.Add(this.er_label);
            this.panel3.Location = new System.Drawing.Point(53, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 54);
            this.panel3.TabIndex = 3;
            // 
            // error_label
            // 
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(3, 0);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(178, 46);
            this.error_label.TabIndex = 5;
            // 
            // er_label
            // 
            this.er_label.Location = new System.Drawing.Point(0, 0);
            this.er_label.Name = "er_label";
            this.er_label.Size = new System.Drawing.Size(100, 23);
            this.er_label.TabIndex = 0;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 277);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_FormClosed);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.Enter += new System.EventHandler(this.btn_loginin_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loginin;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.TextBox in_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox in_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label er_label;
        private System.Windows.Forms.Label error_label;
    }
}
namespace POS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.log = new XanderUI.XUIFormDesign();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.username_lable = new MetroFramework.Controls.MetroLabel();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.password_lable = new MetroFramework.Controls.MetroLabel();
            this.userType_lable = new MetroFramework.Controls.MetroLabel();
            this.log_btn = new XanderUI.XUIButton();
            this.log.WorkingArea.SuspendLayout();
            this.log.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.ExitApplication = true;
            this.log.FormStyle = XanderUI.XUIFormDesign.Style.Ubuntu;
            this.log.Location = new System.Drawing.Point(0, 0);
            this.log.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.log.MaterialForeColor = System.Drawing.Color.White;
            this.log.Name = "log";
            this.log.ShowMaximize = true;
            this.log.ShowMinimize = true;
            this.log.Size = new System.Drawing.Size(1151, 688);
            this.log.TabIndex = 0;
            this.log.TitleText = "        Login";
            // 
            // log.WorkingArea
            // 
            this.log.WorkingArea.BackColor = System.Drawing.Color.White;
            this.log.WorkingArea.Controls.Add(this.metroPanel1);
            this.log.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.log.WorkingArea.Name = "WorkingArea";
            this.log.WorkingArea.Size = new System.Drawing.Size(1151, 658);
            this.log.WorkingArea.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.log_btn);
            this.metroPanel1.Controls.Add(this.userType_lable);
            this.metroPanel1.Controls.Add(this.password);
            this.metroPanel1.Controls.Add(this.password_lable);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.username);
            this.metroPanel1.Controls.Add(this.username_lable);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(89, 106);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(522, 398);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // username_lable
            // 
            this.username_lable.AutoSize = true;
            this.username_lable.Location = new System.Drawing.Point(60, 79);
            this.username_lable.Name = "username_lable";
            this.username_lable.Size = new System.Drawing.Size(73, 20);
            this.username_lable.TabIndex = 2;
            this.username_lable.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(183, 79);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(236, 23);
            this.username.TabIndex = 3;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(183, 235);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(218, 30);
            this.metroComboBox1.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(183, 164);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(236, 23);
            this.password.TabIndex = 6;
            // 
            // password_lable
            // 
            this.password_lable.AutoSize = true;
            this.password_lable.Location = new System.Drawing.Point(60, 164);
            this.password_lable.Name = "password_lable";
            this.password_lable.Size = new System.Drawing.Size(66, 20);
            this.password_lable.TabIndex = 5;
            this.password_lable.Text = "Password";
            // 
            // userType_lable
            // 
            this.userType_lable.AutoSize = true;
            this.userType_lable.Location = new System.Drawing.Point(60, 245);
            this.userType_lable.Name = "userType_lable";
            this.userType_lable.Size = new System.Drawing.Size(72, 20);
            this.userType_lable.TabIndex = 7;
            this.userType_lable.Text = "User Type";
            // 
            // log_btn
            // 
            this.log_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.log_btn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("log_btn.ButtonImage")));
            this.log_btn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.log_btn.ButtonText = "Login";
            this.log_btn.ClickBackColor = System.Drawing.Color.Black;
            this.log_btn.ClickTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.log_btn.CornerRadius = 5;
            this.log_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.log_btn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.log_btn.HoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.log_btn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.log_btn.Location = new System.Drawing.Point(273, 319);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(200, 50);
            this.log_btn.TabIndex = 8;
            this.log_btn.TextColor = System.Drawing.Color.DodgerBlue;
            this.log_btn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 688);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.log.WorkingArea.ResumeLayout(false);
            this.log.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign log;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private XanderUI.XUIButton log_btn;
        private MetroFramework.Controls.MetroLabel userType_lable;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroLabel password_lable;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroLabel username_lable;
    }
}


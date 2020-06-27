namespace GRADING_SYSTEMM
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.login = new MetroFramework.Controls.MetroTile();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.id_no = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(82, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 130);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.metroPanel1.Controls.Add(this.login);
            this.metroPanel1.Controls.Add(this.password);
            this.metroPanel1.Controls.Add(this.id_no);
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(294, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(280, 176);
            this.metroPanel1.TabIndex = 15;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // login
            // 
            this.login.ActiveControl = null;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Location = new System.Drawing.Point(99, 121);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(83, 37);
            this.login.TabIndex = 63;
            this.login.Text = "Log in";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.login.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.login.UseSelectable = true;
            this.login.UseTileImage = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.DisplayIcon = true;
            this.password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Icon = ((System.Drawing.Image)(resources.GetObject("password.Icon")));
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(42, 72);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.PromptText = "Password";
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(201, 30);
            this.password.Style = MetroFramework.MetroColorStyle.White;
            this.password.TabIndex = 5;
            this.password.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.UseCustomBackColor = true;
            this.password.UseCustomForeColor = true;
            this.password.UseSelectable = true;
            this.password.UseStyleColors = true;
            this.password.UseSystemPasswordChar = true;
            this.password.WaterMark = "Password";
            this.password.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // id_no
            // 
            this.id_no.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.id_no.CustomButton.Image = null;
            this.id_no.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.id_no.CustomButton.Name = "";
            this.id_no.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.id_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_no.CustomButton.TabIndex = 1;
            this.id_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_no.CustomButton.UseSelectable = true;
            this.id_no.CustomButton.Visible = false;
            this.id_no.DisplayIcon = true;
            this.id_no.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.id_no.ForeColor = System.Drawing.Color.Black;
            this.id_no.Icon = ((System.Drawing.Image)(resources.GetObject("id_no.Icon")));
            this.id_no.Lines = new string[0];
            this.id_no.Location = new System.Drawing.Point(42, 33);
            this.id_no.MaxLength = 32767;
            this.id_no.Name = "id_no";
            this.id_no.PasswordChar = '\0';
            this.id_no.PromptText = "ID number";
            this.id_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_no.SelectedText = "";
            this.id_no.SelectionLength = 0;
            this.id_no.SelectionStart = 0;
            this.id_no.ShortcutsEnabled = true;
            this.id_no.Size = new System.Drawing.Size(201, 30);
            this.id_no.Style = MetroFramework.MetroColorStyle.White;
            this.id_no.TabIndex = 4;
            this.id_no.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_no.UseCustomBackColor = true;
            this.id_no.UseCustomForeColor = true;
            this.id_no.UseSelectable = true;
            this.id_no.UseStyleColors = true;
            this.id_no.WaterMark = "ID number";
            this.id_no.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.id_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_no.TextChanged += new System.EventHandler(this.id_no_TextChanged);
            this.id_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_no_KeyPress);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(17, 288);
            this.metroPanel2.TabIndex = 17;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.AliceBlue;
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(615, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(17, 288);
            this.metroPanel3.TabIndex = 18;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(45, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sumulong College of Arts ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(93, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "and Sciences";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(99, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "SCAS";
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(582, 8);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(7);
            this.logout.Size = new System.Drawing.Size(24, 24);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 63;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(632, 288);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox password;
        public MetroFramework.Controls.MetroTextBox id_no;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logout;

    }
}


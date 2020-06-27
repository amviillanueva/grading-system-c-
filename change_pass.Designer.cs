namespace GRADING_SYSTEMM
{
    partial class change_pass
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
            this.cancel = new MetroFramework.Controls.MetroButton();
            this.neww = new MetroFramework.Controls.MetroTextBox();
            this.confirm = new MetroFramework.Controls.MetroTextBox();
            this.old = new MetroFramework.Controls.MetroTextBox();
            this.save = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(141, 157);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(54, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseCustomBackColor = true;
            this.cancel.UseCustomForeColor = true;
            this.cancel.UseSelectable = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // neww
            // 
            this.neww.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.neww.CustomButton.Image = null;
            this.neww.CustomButton.Location = new System.Drawing.Point(139, 2);
            this.neww.CustomButton.Name = "";
            this.neww.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.neww.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.neww.CustomButton.TabIndex = 1;
            this.neww.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.neww.CustomButton.UseSelectable = true;
            this.neww.CustomButton.Visible = false;
            this.neww.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.neww.Lines = new string[0];
            this.neww.Location = new System.Drawing.Point(38, 74);
            this.neww.MaxLength = 32767;
            this.neww.Name = "neww";
            this.neww.PasswordChar = '●';
            this.neww.PromptText = "New password";
            this.neww.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.neww.SelectedText = "";
            this.neww.SelectionLength = 0;
            this.neww.SelectionStart = 0;
            this.neww.ShortcutsEnabled = true;
            this.neww.Size = new System.Drawing.Size(157, 20);
            this.neww.Style = MetroFramework.MetroColorStyle.White;
            this.neww.TabIndex = 6;
            this.neww.UseCustomBackColor = true;
            this.neww.UseCustomForeColor = true;
            this.neww.UseSelectable = true;
            this.neww.UseStyleColors = true;
            this.neww.UseSystemPasswordChar = true;
            this.neww.WaterMark = "New password";
            this.neww.WaterMarkColor = System.Drawing.Color.DimGray;
            this.neww.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.confirm.CustomButton.Image = null;
            this.confirm.CustomButton.Location = new System.Drawing.Point(139, 2);
            this.confirm.CustomButton.Name = "";
            this.confirm.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.confirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirm.CustomButton.TabIndex = 1;
            this.confirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirm.CustomButton.UseSelectable = true;
            this.confirm.CustomButton.Visible = false;
            this.confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirm.Lines = new string[0];
            this.confirm.Location = new System.Drawing.Point(38, 114);
            this.confirm.MaxLength = 32767;
            this.confirm.Name = "confirm";
            this.confirm.PasswordChar = '●';
            this.confirm.PromptText = "Confirm password";
            this.confirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirm.SelectedText = "";
            this.confirm.SelectionLength = 0;
            this.confirm.SelectionStart = 0;
            this.confirm.ShortcutsEnabled = true;
            this.confirm.Size = new System.Drawing.Size(157, 20);
            this.confirm.Style = MetroFramework.MetroColorStyle.White;
            this.confirm.TabIndex = 7;
            this.confirm.UseCustomBackColor = true;
            this.confirm.UseCustomForeColor = true;
            this.confirm.UseSelectable = true;
            this.confirm.UseStyleColors = true;
            this.confirm.UseSystemPasswordChar = true;
            this.confirm.WaterMark = "Confirm password";
            this.confirm.WaterMarkColor = System.Drawing.Color.DimGray;
            this.confirm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // old
            // 
            this.old.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.old.CustomButton.Image = null;
            this.old.CustomButton.Location = new System.Drawing.Point(139, 2);
            this.old.CustomButton.Name = "";
            this.old.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.old.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.old.CustomButton.TabIndex = 1;
            this.old.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.old.CustomButton.UseSelectable = true;
            this.old.CustomButton.Visible = false;
            this.old.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.old.Lines = new string[0];
            this.old.Location = new System.Drawing.Point(38, 37);
            this.old.MaxLength = 32767;
            this.old.Name = "old";
            this.old.PasswordChar = '●';
            this.old.PromptText = "Old password";
            this.old.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.old.SelectedText = "";
            this.old.SelectionLength = 0;
            this.old.SelectionStart = 0;
            this.old.ShortcutsEnabled = true;
            this.old.Size = new System.Drawing.Size(157, 20);
            this.old.Style = MetroFramework.MetroColorStyle.White;
            this.old.TabIndex = 5;
            this.old.UseCustomBackColor = true;
            this.old.UseCustomForeColor = true;
            this.old.UseSelectable = true;
            this.old.UseStyleColors = true;
            this.old.UseSystemPasswordChar = true;
            this.old.WaterMark = "Old password";
            this.old.WaterMarkColor = System.Drawing.Color.DimGray;
            this.old.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(71, 157);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(54, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseCustomBackColor = true;
            this.save.UseCustomForeColor = true;
            this.save.UseSelectable = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // change_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(231, 215);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.neww);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.old);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "change_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "change_pass";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton cancel;
        public MetroFramework.Controls.MetroTextBox neww;
        public MetroFramework.Controls.MetroTextBox confirm;
        public MetroFramework.Controls.MetroTextBox old;
        private MetroFramework.Controls.MetroButton save;
    }
}
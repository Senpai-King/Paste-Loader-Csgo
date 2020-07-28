namespace Beta_Loader
{
	// Token: 0x0200003B RID: 59
	public partial class Register : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x00007940 File Offset: 0x00005B40
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007978 File Offset: 0x00005B78
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Beta_Loader.Register));
			this.Redeem = new global::System.Windows.Forms.CheckBox();
			this.Username = new global::MetroFramework.Controls.MetroTextBox();
			this.Password = new global::MetroFramework.Controls.MetroTextBox();
			this.Email = new global::MetroFramework.Controls.MetroTextBox();
			this.Token = new global::MetroFramework.Controls.MetroTextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Redeem.AutoSize = true;
			this.Redeem.ForeColor = global::System.Drawing.Color.BlueViolet;
			this.Redeem.Location = new global::System.Drawing.Point(23, 176);
			this.Redeem.Name = "Redeem";
			this.Redeem.Size = new global::System.Drawing.Size(100, 17);
			this.Redeem.TabIndex = 9;
			this.Redeem.Text = "Redeem Token";
			this.Redeem.UseVisualStyleBackColor = true;
			this.Redeem.CheckedChanged += new global::System.EventHandler(this.Redeem_CheckedChanged);
			this.Username.CustomButton.Image = null;
			this.Username.CustomButton.Location = new global::System.Drawing.Point(105, 1);
			this.Username.CustomButton.Name = "";
			this.Username.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.Username.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Username.CustomButton.TabIndex = 1;
			this.Username.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.Username.CustomButton.UseSelectable = true;
			this.Username.CustomButton.Visible = false;
			this.Username.Lines = new string[0];
			this.Username.Location = new global::System.Drawing.Point(23, 41);
			this.Username.MaxLength = 32767;
			this.Username.Name = "Username";
			this.Username.PasswordChar = '\0';
			this.Username.PromptText = "Username";
			this.Username.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.Username.SelectedText = "";
			this.Username.SelectionLength = 0;
			this.Username.SelectionStart = 0;
			this.Username.ShortcutsEnabled = true;
			this.Username.Size = new global::System.Drawing.Size(127, 23);
			this.Username.TabIndex = 14;
			this.Username.UseSelectable = true;
			this.Username.WaterMark = "Username";
			this.Username.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.Username.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.Password.CustomButton.Image = null;
			this.Password.CustomButton.Location = new global::System.Drawing.Point(105, 1);
			this.Password.CustomButton.Name = "";
			this.Password.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.Password.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Password.CustomButton.TabIndex = 1;
			this.Password.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.Password.CustomButton.UseSelectable = true;
			this.Password.CustomButton.Visible = false;
			this.Password.Lines = new string[0];
			this.Password.Location = new global::System.Drawing.Point(156, 41);
			this.Password.MaxLength = 32767;
			this.Password.Name = "Password";
			this.Password.PasswordChar = '*';
			this.Password.PromptText = "Password";
			this.Password.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.Password.SelectedText = "";
			this.Password.SelectionLength = 0;
			this.Password.SelectionStart = 0;
			this.Password.ShortcutsEnabled = true;
			this.Password.Size = new global::System.Drawing.Size(127, 23);
			this.Password.TabIndex = 15;
			this.Password.UseSelectable = true;
			this.Password.WaterMark = "Password";
			this.Password.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.Password.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.Email.CustomButton.Image = null;
			this.Email.CustomButton.Location = new global::System.Drawing.Point(237, 1);
			this.Email.CustomButton.Name = "";
			this.Email.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.Email.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Email.CustomButton.TabIndex = 1;
			this.Email.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.Email.CustomButton.UseSelectable = true;
			this.Email.CustomButton.Visible = false;
			this.Email.Lines = new string[0];
			this.Email.Location = new global::System.Drawing.Point(22, 88);
			this.Email.MaxLength = 32767;
			this.Email.Name = "Email";
			this.Email.PasswordChar = '\0';
			this.Email.PromptText = "Email";
			this.Email.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.Email.SelectedText = "";
			this.Email.SelectionLength = 0;
			this.Email.SelectionStart = 0;
			this.Email.ShortcutsEnabled = true;
			this.Email.Size = new global::System.Drawing.Size(259, 23);
			this.Email.TabIndex = 16;
			this.Email.UseSelectable = true;
			this.Email.WaterMark = "Email";
			this.Email.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.Email.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.Token.CustomButton.Image = null;
			this.Token.CustomButton.Location = new global::System.Drawing.Point(238, 1);
			this.Token.CustomButton.Name = "";
			this.Token.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.Token.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Token.CustomButton.TabIndex = 1;
			this.Token.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.Token.CustomButton.UseSelectable = true;
			this.Token.CustomButton.Visible = false;
			this.Token.Lines = new string[0];
			this.Token.Location = new global::System.Drawing.Point(22, 129);
			this.Token.MaxLength = 32767;
			this.Token.Name = "Token";
			this.Token.PasswordChar = '\0';
			this.Token.PromptText = "Token";
			this.Token.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.Token.SelectedText = "";
			this.Token.SelectionLength = 0;
			this.Token.SelectionStart = 0;
			this.Token.ShortcutsEnabled = true;
			this.Token.Size = new global::System.Drawing.Size(260, 23);
			this.Token.TabIndex = 17;
			this.Token.UseSelectable = true;
			this.Token.WaterMark = "Token";
			this.Token.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.Token.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.button1.BackColor = global::System.Drawing.Color.BlueViolet;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new global::System.Drawing.Point(139, 170);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(142, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Register";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(305, 205);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.Token);
			base.Controls.Add(this.Email);
			base.Controls.Add(this.Password);
			base.Controls.Add(this.Username);
			base.Controls.Add(this.Redeem);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Register";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.Style = global::MetroFramework.MetroColorStyle.Purple;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.Register_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000172 RID: 370
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.CheckBox Redeem;

		// Token: 0x04000174 RID: 372
		private global::MetroFramework.Controls.MetroTextBox Username;

		// Token: 0x04000175 RID: 373
		private global::MetroFramework.Controls.MetroTextBox Password;

		// Token: 0x04000176 RID: 374
		private global::MetroFramework.Controls.MetroTextBox Email;

		// Token: 0x04000177 RID: 375
		private global::MetroFramework.Controls.MetroTextBox Token;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.Button button1;
	}
}

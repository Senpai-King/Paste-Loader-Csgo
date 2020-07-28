namespace Beta_Loader
{
	// Token: 0x02000038 RID: 56
	public partial class Login : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060000DA RID: 218 RVA: 0x000064C4 File Offset: 0x000046C4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000064FC File Offset: 0x000046FC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Beta_Loader.Login));
			this.metroStyleManager1 = new global::MetroFramework.Components.MetroStyleManager(this.components);
			this.metroLabel1 = new global::MetroFramework.Controls.MetroLabel();
			this.Username = new global::MetroFramework.Controls.MetroTextBox();
			this.Password = new global::MetroFramework.Controls.MetroTextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.metroStyleManager1).BeginInit();
			base.SuspendLayout();
			this.metroStyleManager1.Owner = null;
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new global::System.Drawing.Point(32, 19);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new global::System.Drawing.Size(0, 0);
			this.metroLabel1.TabIndex = 8;
			this.metroLabel1.Click += new global::System.EventHandler(this.metroLabel1_Click);
			this.Username.CustomButton.Image = null;
			this.Username.CustomButton.Location = new global::System.Drawing.Point(188, 1);
			this.Username.CustomButton.Name = "";
			this.Username.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.Username.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Username.CustomButton.TabIndex = 1;
			this.Username.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.Username.CustomButton.UseSelectable = true;
			this.Username.CustomButton.Visible = false;
			this.Username.Lines = new string[0];
			this.Username.Location = new global::System.Drawing.Point(41, 79);
			this.Username.MaxLength = 32767;
			this.Username.Name = "Username";
			this.Username.PasswordChar = '\0';
			this.Username.PromptText = "Username";
			this.Username.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.Username.SelectedText = "";
			this.Username.SelectionLength = 0;
			this.Username.SelectionStart = 0;
			this.Username.ShortcutsEnabled = true;
			this.Username.Size = new global::System.Drawing.Size(210, 23);
			this.Username.TabIndex = 9;
			this.Username.UseSelectable = true;
			this.Username.WaterMark = "Username";
			this.Username.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.Username.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.Password.CustomButton.Image = null;
			this.Password.CustomButton.Location = new global::System.Drawing.Point(188, 1);
			this.Password.CustomButton.Name = "";
			this.Password.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.Password.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Password.CustomButton.TabIndex = 1;
			this.Password.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.Password.CustomButton.UseSelectable = true;
			this.Password.CustomButton.Visible = false;
			this.Password.Lines = new string[0];
			this.Password.Location = new global::System.Drawing.Point(41, 119);
			this.Password.MaxLength = 32767;
			this.Password.Name = "Password";
			this.Password.PasswordChar = '*';
			this.Password.PromptText = "Password";
			this.Password.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.Password.SelectedText = "";
			this.Password.SelectionLength = 0;
			this.Password.SelectionStart = 0;
			this.Password.ShortcutsEnabled = true;
			this.Password.Size = new global::System.Drawing.Size(210, 23);
			this.Password.TabIndex = 11;
			this.Password.UseSelectable = true;
			this.Password.WaterMark = "Password";
			this.Password.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.Password.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.button1.BackColor = global::System.Drawing.Color.BlueViolet;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new global::System.Drawing.Point(41, 165);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(104, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.BlueViolet;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new global::System.Drawing.Point(151, 165);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(100, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Register";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label1.AutoSize = true;
			this.label1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 32.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.BlueViolet;
			this.label1.Location = new global::System.Drawing.Point(32, 5);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(137, 51);
			this.label1.TabIndex = 14;
			this.label1.Text = "Zyper";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.AutoEllipsis = true;
			this.label2.AutoSize = true;
			this.label2.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.25f, global::System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(156, 51);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(86, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Cheats";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Click += new global::System.EventHandler(this.label1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(299, 204);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.Password);
			base.Controls.Add(this.Username);
			base.Controls.Add(this.metroLabel1);
			this.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Login";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.Style = global::MetroFramework.MetroColorStyle.Purple;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.metroStyleManager1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400015E RID: 350
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400015F RID: 351
		private global::MetroFramework.Components.MetroStyleManager metroStyleManager1;

		// Token: 0x04000160 RID: 352
		private global::MetroFramework.Controls.MetroLabel metroLabel1;

		// Token: 0x04000161 RID: 353
		private global::MetroFramework.Controls.MetroTextBox Username;

		// Token: 0x04000162 RID: 354
		private global::MetroFramework.Controls.MetroTextBox Password;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.Label label2;
	}
}

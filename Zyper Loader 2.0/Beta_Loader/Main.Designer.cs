namespace Beta_Loader
{
	// Token: 0x02000039 RID: 57
	public partial class Main : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00006FB8 File Offset: 0x000051B8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00006FF0 File Offset: 0x000051F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Beta_Loader.Main));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new global::System.Drawing.Point(14, 169);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(29, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "User";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new global::System.Drawing.Point(168, 169);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "expire";
			this.label2.Click += new global::System.EventHandler(this.label2_Click_1);
			this.button1.BackColor = global::System.Drawing.Color.BlueViolet;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new global::System.Drawing.Point(163, 107);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(124, 39);
			this.button1.TabIndex = 13;
			this.button1.Text = "Inject";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Myanmar Text", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(159, 55);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(44, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "Server:";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Myanmar Text", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.label4.Location = new global::System.Drawing.Point(198, 55);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(42, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "online";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Myanmar Text", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(159, 75);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(44, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Status:";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Myanmar Text", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.label6.Location = new global::System.Drawing.Point(198, 75);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(68, 20);
			this.label6.TabIndex = 14;
			this.label6.Text = "undetected";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Myanmar Text", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(154, 7);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(113, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "ZYPER CSGO CHEAT";
			this.pictureBox3.Image = global::Beta_Loader.Properties.Resources.zyper_logo_para_o_loader1;
			this.pictureBox3.Location = new global::System.Drawing.Point(17, 20);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(131, 126);
			this.pictureBox3.TabIndex = 17;
			this.pictureBox3.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(300, 189);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Main";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.Style = global::MetroFramework.MetroColorStyle.Purple;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			base.Load += new global::System.EventHandler(this.Main_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000167 RID: 359
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000168 RID: 360
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400016A RID: 362
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400016B RID: 363
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.PictureBox pictureBox3;
	}
}

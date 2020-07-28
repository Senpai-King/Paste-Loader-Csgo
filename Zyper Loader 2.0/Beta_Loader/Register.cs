using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using c_auth;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Beta_Loader
{
	// Token: 0x0200003B RID: 59
	public partial class Register : MetroForm
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00007769 File Offset: 0x00005969
		public Register()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00007780 File Offset: 0x00005980
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00007788 File Offset: 0x00005988
		public bool response { get; set; }

		// Token: 0x060000ED RID: 237 RVA: 0x00007794 File Offset: 0x00005994
		private void rregister_Click(object sender, EventArgs e)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			bool @checked = this.Redeem.Checked;
			if (@checked)
			{
				this.response = c_api.c_activate(this.Username.Text, this.Password.Text, this.Token.Text);
			}
			else
			{
				this.response = c_api.c_register(this.Username.Text, this.Email.Text, this.Password.Text, this.Token.Text, "default");
			}
			bool response = this.response;
			if (response)
			{
				MessageBox.Show("Registered/Activated successfuly");
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007848 File Offset: 0x00005A48
		private void Redeem_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Redeem.Checked;
			if (@checked)
			{
				this.button1.Text = "Activate";
			}
			else
			{
				this.button1.Text = "Register";
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006442 File Offset: 0x00004642
		private void Register_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000788C File Offset: 0x00005A8C
		private void button1_Click(object sender, EventArgs e)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			bool @checked = this.Redeem.Checked;
			if (@checked)
			{
				this.response = c_api.c_activate(this.Username.Text, this.Password.Text, this.Token.Text);
			}
			else
			{
				this.response = c_api.c_register(this.Username.Text, this.Email.Text, this.Password.Text, this.Token.Text, "default");
			}
			bool response = this.response;
			if (response)
			{
				MessageBox.Show("Registered/Activated successfuly");
			}
		}
	}
}

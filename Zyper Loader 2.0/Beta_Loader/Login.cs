using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using c_auth;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Beta_Loader
{
	// Token: 0x02000038 RID: 56
	public partial class Login : MetroForm
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00006390 File Offset: 0x00004590
		public Login()
		{
			this.InitializeComponent();
			c_api.c_init("1.0", "Vr9o89z6Qp1GwZAMcoXAYZgxclhLR5eco1zYKE7FXJG", "dnasbdasjdovuisdnoslk;sad");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000063C0 File Offset: 0x000045C0
		private void OpenRegister_Click(object sender, EventArgs e)
		{
			Register register = new Register();
			register.Show();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000063DC File Offset: 0x000045DC
		private void llogin_Click(object sender, EventArgs e)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			bool flag = c_api.c_login(this.Username.Text, this.Password.Text, "default");
			bool flag2 = flag;
			if (flag2)
			{
				c_api.c_log("Successfully logged in");
				new Main().Show();
				base.Hide();
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000643A File Offset: 0x0000463A
		private void Login_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006442 File Offset: 0x00004642
		private void Login_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006442 File Offset: 0x00004642
		private void metroLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00006448 File Offset: 0x00004648
		private void button1_Click(object sender, EventArgs e)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			bool flag = c_api.c_login(this.Username.Text, this.Password.Text, "default");
			bool flag2 = flag;
			if (flag2)
			{
				c_api.c_log("Successfully logged in");
				new Main().Show();
				base.Hide();
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000064A8 File Offset: 0x000046A8
		private void button2_Click(object sender, EventArgs e)
		{
			Register register = new Register();
			register.Show();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006442 File Offset: 0x00004642
		private void label1_Click(object sender, EventArgs e)
		{
		}
	}
}

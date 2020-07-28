using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Beta_Loader.Properties;
using c_auth;
using ManualMapInjection.Injection;
using MetroFramework;
using MetroFramework.Forms;

namespace Beta_Loader
{
	// Token: 0x02000039 RID: 57
	public partial class Main : MetroForm
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00006E0B File Offset: 0x0000500B
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000643A File Offset: 0x0000463A
		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00006E24 File Offset: 0x00005024
		private void Main_Load(object sender, EventArgs e)
		{
			this.label1.Text = c_userdata.username;
			this.label2.Text = c_userdata.expires.ToString();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006442 File Offset: 0x00004642
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006442 File Offset: 0x00004642
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006442 File Offset: 0x00004642
		private void metroLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006442 File Offset: 0x00004642
		private void label2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006442 File Offset: 0x00004642
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006442 File Offset: 0x00004642
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00006E5C File Offset: 0x0000505C
		private void button1_Click(object sender, EventArgs e)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Process process = Process.GetProcessesByName("csgo").FirstOrDefault<Process>();
			bool flag = process != null;
			if (flag)
			{
				try
				{
					using (WebClient webClient = new WebClient())
					{
						webClient.Proxy = null;
						webClient.Headers.Add("2asda1d23", c_api.c_var("1231asd92133a", "default"));
						byte[] bytesToBeDecrypted = webClient.DownloadData(c_api.c_var("koexgay", "default"));
						byte[] buffer = AES.DecryptAES(bytesToBeDecrypted, Encoding.UTF8.GetBytes(c_api.c_var("koezgay", "default")));
						ManualMapInjector manualMapInjector = new ManualMapInjector(process)
						{
							AsyncInjection = true
						};
						this.button1.Text = string.Format("hmodule = 0x{0:x8}", manualMapInjector.Inject(buffer).ToInt64());
						MessageBox.Show("Success!!!");
						c_api.c_log("injected successfully");
						Application.Exit();
					}
				}
				catch (Exception ex)
				{
					string str = "Exception happened : ";
					Exception ex2 = ex;
					MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null));
					Application.Exit();
				}
			}
			else
			{
				MessageBox.Show("Please open CSGO");
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00006442 File Offset: 0x00004642
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}
	}
}

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace c_auth
{
	// Token: 0x02000033 RID: 51
	public class c_api
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000049C0 File Offset: 0x00002BC0
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000049C7 File Offset: 0x00002BC7
		private static string program_key { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000049CF File Offset: 0x00002BCF
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000049D6 File Offset: 0x00002BD6
		private static string enc_key { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000049DE File Offset: 0x00002BDE
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000049E5 File Offset: 0x00002BE5
		private static string iv_key { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000049ED File Offset: 0x00002BED
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000049F4 File Offset: 0x00002BF4
		private static string session_id { get; set; }

		// Token: 0x060000A6 RID: 166 RVA: 0x000049FC File Offset: 0x00002BFC
		public static void c_init(string c_version, string c_program_key, string c_encryption_key)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					webClient.Headers["User-Agent"] = c_api.user_agent;
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(c_encryption.pin_public_key);
					c_api.program_key = c_program_key;
					c_api.iv_key = c_encryption.iv_key();
					c_api.enc_key = c_encryption_key;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["version"] = c_encryption.encrypt(c_version, c_api.enc_key, "default_iv");
					nameValueCollection["session_iv"] = c_encryption.encrypt(c_api.iv_key, c_api.enc_key, "default_iv");
					nameValueCollection["api_version"] = c_encryption.encrypt("3.4b", c_api.enc_key, "default_iv");
					nameValueCollection["program_key"] = c_encryption.byte_arr_to_str(Encoding.UTF8.GetBytes(c_api.program_key));
					NameValueCollection data = nameValueCollection;
					string text = Encoding.UTF8.GetString(webClient.UploadValues(c_api.api_link + "handler.php?type=init", data));
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object send, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
					bool flag = text != "program_doesnt_exist";
					if (flag)
					{
						text = c_encryption.decrypt(text, c_api.enc_key, "default_iv");
						string text2 = text;
						string text3 = text2;
						if (!(text3 == "killswitch_is_enabled"))
						{
							if (text3 != null)
							{
								if (text3.Contains("wrong_version"))
								{
									MessageBox.Show("Wrong program version", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									Process.Start(text.Split(new char[]
									{
										'|'
									})[1]);
									Environment.Exit(0);
									goto IL_231;
								}
								if (text3 == "old_api_version")
								{
									MessageBox.Show("Please download the newest API files on the auth's website", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									Environment.Exit(0);
									goto IL_231;
								}
							}
							string[] array = text.Split(new char[]
							{
								'|'
							});
							c_api.iv_key += array[1];
							c_api.session_id = array[2];
						}
						else
						{
							MessageBox.Show("The killswitch of the program is enabled, contact the developer", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							Environment.Exit(0);
						}
						IL_231:;
					}
					else
					{
						MessageBox.Show("The program doesnt exist!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Environment.Exit(0);
					}
				}
			}
			catch (CryptographicException)
			{
				MessageBox.Show("Invalid API/Encryption key or the session expired", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(0);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public static bool c_login(string c_username, string c_password, string c_hwid = "default")
		{
			bool flag = c_hwid == "default";
			if (flag)
			{
				c_hwid = WindowsIdentity.GetCurrent().User.Value;
			}
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					webClient.Headers["User-Agent"] = c_api.user_agent;
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(c_encryption.pin_public_key);
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["username"] = c_encryption.encrypt(c_username, c_api.enc_key, c_api.iv_key);
					nameValueCollection["password"] = c_encryption.encrypt(c_password, c_api.enc_key, c_api.iv_key);
					nameValueCollection["hwid"] = c_encryption.encrypt(c_hwid, c_api.enc_key, c_api.iv_key);
					nameValueCollection["sessid"] = c_encryption.byte_arr_to_str(Encoding.UTF8.GetBytes(c_api.session_id));
					NameValueCollection data = nameValueCollection;
					string text = c_encryption.decrypt(Encoding.UTF8.GetString(webClient.UploadValues(c_api.api_link + "handler.php?type=login", data)), c_api.enc_key, c_api.iv_key);
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object send, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
					string text2 = text;
					string text3 = text2;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num <= 1655430144U)
					{
						if (num != 315331473U)
						{
							if (num != 1090128640U)
							{
								if (num == 1655430144U)
								{
									if (text3 == "invalid_password")
									{
										MessageBox.Show("Invalid password", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										return false;
									}
								}
							}
							else if (text3 == "user_is_banned")
							{
								MessageBox.Show("The user is banned", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return false;
							}
						}
						else if (text3 == "invalid_username")
						{
							MessageBox.Show("Invalid username", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
					}
					else if (num <= 3041788540U)
					{
						if (num != 1762808469U)
						{
							if (num == 3041788540U)
							{
								if (text3 == "killswitch_is_enabled")
								{
									MessageBox.Show("The killswitch of the program is enabled, contact the developer", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									goto IL_3BC;
								}
							}
						}
						else if (text3 == "invalid_hwid")
						{
							MessageBox.Show("Invalid HWID", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
					}
					else if (num != 3919198259U)
					{
						if (num == 4290619222U)
						{
							if (text3 == "user_is_paused")
							{
								MessageBox.Show("The user's sub is paused", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return false;
							}
						}
					}
					else if (text3 == "no_sub")
					{
						MessageBox.Show("Your subscription is over", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return false;
					}
					if (text3 != null)
					{
						if (text3.Contains("logged_in"))
						{
							string[] array = text.Split(new char[]
							{
								'|'
							});
							c_userdata.username = array[1];
							c_userdata.email = array[2];
							c_userdata.expires = c_encryption.unix_to_date(Convert.ToDouble(array[3]));
							c_userdata.var = array[4];
							c_userdata.rank = Convert.ToInt32(array[5]);
							c_api.stored_pass = c_encryption.encrypt(c_password, c_api.enc_key, c_api.iv_key);
							MessageBox.Show("Logged in!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return true;
						}
					}
					MessageBox.Show("Invalid API/Encryption key or the session expired", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				IL_3BC:;
			}
			catch (FormatException)
			{
				MessageBox.Show("The session expired!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				Environment.Exit(0);
				return false;
			}
			return false;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000514C File Offset: 0x0000334C
		public static bool c_register(string c_username, string c_email, string c_password, string c_token, string c_hwid = "default")
		{
			bool flag = c_hwid == "default";
			if (flag)
			{
				c_hwid = WindowsIdentity.GetCurrent().User.Value;
			}
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					webClient.Headers["User-Agent"] = c_api.user_agent;
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(c_encryption.pin_public_key);
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["username"] = c_encryption.encrypt(c_username, c_api.enc_key, c_api.iv_key);
					nameValueCollection["email"] = c_encryption.encrypt(c_email, c_api.enc_key, c_api.iv_key);
					nameValueCollection["password"] = c_encryption.encrypt(c_password, c_api.enc_key, c_api.iv_key);
					nameValueCollection["token"] = c_encryption.encrypt(c_token, c_api.enc_key, c_api.iv_key);
					nameValueCollection["hwid"] = c_encryption.encrypt(c_hwid, c_api.enc_key, c_api.iv_key);
					nameValueCollection["sessid"] = c_encryption.byte_arr_to_str(Encoding.UTF8.GetBytes(c_api.session_id));
					NameValueCollection data = nameValueCollection;
					string text = c_encryption.decrypt(Encoding.UTF8.GetString(webClient.UploadValues(c_api.api_link + "handler.php?type=register", data)), c_api.enc_key, c_api.iv_key);
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object send, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
					string text2 = text;
					string text3 = text2;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num <= 1094710442U)
					{
						if (num <= 680835602U)
						{
							if (num != 101939353U)
							{
								if (num == 680835602U)
								{
									if (text3 == "user_already_exists")
									{
										MessageBox.Show("User already exists", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										return false;
									}
								}
							}
							else if (text3 == "email_already_exists")
							{
								MessageBox.Show("Email already exists", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return false;
							}
						}
						else if (num != 979353360U)
						{
							if (num == 1094710442U)
							{
								if (text3 == "used_token")
								{
									MessageBox.Show("Already used token", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return false;
								}
							}
						}
						else if (text3 == "success")
						{
							MessageBox.Show("Success!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return true;
						}
					}
					else if (num <= 3041788540U)
					{
						if (num != 1913904611U)
						{
							if (num == 3041788540U)
							{
								if (text3 == "killswitch_is_enabled")
								{
									MessageBox.Show("The killswitch of the program is enabled, contact the developer", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									goto IL_3B2;
								}
							}
						}
						else if (text3 == "invalid_email_format")
						{
							MessageBox.Show("Invalid email format", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
					}
					else if (num != 4105418607U)
					{
						if (num == 4204349226U)
						{
							if (text3 == "invalid_token")
							{
								MessageBox.Show("Invalid token", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return false;
							}
						}
					}
					else if (text3 == "maximum_users_reached")
					{
						MessageBox.Show("Maximum users of the program was reached, please contact the program owner", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return false;
					}
					MessageBox.Show("Invalid API/Encryption key or the session expired", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				IL_3B2:;
			}
			catch (FormatException)
			{
				MessageBox.Show("The session expired!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(0);
				return false;
			}
			return false;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000055A0 File Offset: 0x000037A0
		public static bool c_activate(string c_username, string c_password, string c_token)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					webClient.Headers["User-Agent"] = c_api.user_agent;
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(c_encryption.pin_public_key);
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["username"] = c_encryption.encrypt(c_username, c_api.enc_key, c_api.iv_key);
					nameValueCollection["password"] = c_encryption.encrypt(c_password, c_api.enc_key, c_api.iv_key);
					nameValueCollection["token"] = c_encryption.encrypt(c_token, c_api.enc_key, c_api.iv_key);
					nameValueCollection["sessid"] = c_encryption.byte_arr_to_str(Encoding.UTF8.GetBytes(c_api.session_id));
					NameValueCollection data = nameValueCollection;
					string text = c_encryption.decrypt(Encoding.UTF8.GetString(webClient.UploadValues(c_api.api_link + "handler.php?type=activate", data)), c_api.enc_key, c_api.iv_key);
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object send, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
					string text2 = text;
					string text3 = text2;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num <= 1094710442U)
					{
						if (num <= 979353360U)
						{
							if (num != 315331473U)
							{
								if (num == 979353360U)
								{
									if (text3 == "success")
									{
										MessageBox.Show("Success!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
										return true;
									}
								}
							}
							else if (text3 == "invalid_username")
							{
								MessageBox.Show("Invalid username", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return false;
							}
						}
						else if (num != 1090128640U)
						{
							if (num == 1094710442U)
							{
								if (text3 == "used_token")
								{
									MessageBox.Show("Already used token", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return false;
								}
							}
						}
						else if (text3 == "user_is_banned")
						{
							MessageBox.Show("The user is banned", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
					}
					else if (num <= 3041788540U)
					{
						if (num != 1655430144U)
						{
							if (num == 3041788540U)
							{
								if (text3 == "killswitch_is_enabled")
								{
									MessageBox.Show("The killswitch of the program is enabled, contact the developer", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									goto IL_350;
								}
							}
						}
						else if (text3 == "invalid_password")
						{
							MessageBox.Show("Invalid password", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
					}
					else if (num != 4204349226U)
					{
						if (num == 4290619222U)
						{
							if (text3 == "user_is_paused")
							{
								MessageBox.Show("The user's sub is paused", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return false;
							}
						}
					}
					else if (text3 == "invalid_token")
					{
						MessageBox.Show("Invalid token", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return false;
					}
					MessageBox.Show("Invalid API/Encryption key or the session expired", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				IL_350:;
			}
			catch (FormatException)
			{
				MessageBox.Show("The session expired!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(0);
				return false;
			}
			return false;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005990 File Offset: 0x00003B90
		public static bool c_all_in_one(string c_token, string c_hwid = "default")
		{
			bool flag = c_hwid == "default";
			if (flag)
			{
				c_hwid = WindowsIdentity.GetCurrent().User.Value;
			}
			bool flag2 = c_api.c_login(c_token, c_token, c_hwid);
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				bool flag3 = c_api.c_register(c_token, c_token + "@email.com", c_token, c_token, c_hwid);
				if (flag3)
				{
					Environment.Exit(0);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000059F7 File Offset: 0x00003BF7
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000059FE File Offset: 0x00003BFE
		private static string stored_pass { get; set; }

		// Token: 0x060000AD RID: 173 RVA: 0x00005A08 File Offset: 0x00003C08
		public static string c_var(string c_var_name, string c_hwid = "default")
		{
			bool flag = c_hwid == "default";
			if (flag)
			{
				c_hwid = WindowsIdentity.GetCurrent().User.Value;
			}
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					webClient.Headers["User-Agent"] = c_api.user_agent;
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(c_encryption.pin_public_key);
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["var_name"] = c_encryption.encrypt(c_var_name, c_api.enc_key, c_api.iv_key);
					nameValueCollection["username"] = c_encryption.encrypt(c_userdata.username, c_api.enc_key, c_api.iv_key);
					nameValueCollection["password"] = c_api.stored_pass;
					nameValueCollection["hwid"] = c_encryption.encrypt(c_hwid, c_api.enc_key, c_api.iv_key);
					nameValueCollection["sessid"] = c_encryption.byte_arr_to_str(Encoding.UTF8.GetBytes(c_api.session_id));
					NameValueCollection data = nameValueCollection;
					string text = c_encryption.decrypt(Encoding.UTF8.GetString(webClient.UploadValues(c_api.api_link + "handler.php?type=var", data)), c_api.enc_key, c_api.iv_key);
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object send, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
					result = text;
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("The session expired!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				result = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(0);
				result = "";
			}
			return result;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005C08 File Offset: 0x00003E08
		public static void c_log(string c_message)
		{
			bool flag = c_userdata.username == null;
			if (flag)
			{
				c_userdata.username = "NONE";
			}
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					webClient.Headers["User-Agent"] = c_api.user_agent;
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(c_encryption.pin_public_key);
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["username"] = c_encryption.encrypt(c_userdata.username, c_api.enc_key, c_api.iv_key);
					nameValueCollection["message"] = c_encryption.encrypt(c_message, c_api.enc_key, c_api.iv_key);
					nameValueCollection["sessid"] = c_encryption.byte_arr_to_str(Encoding.UTF8.GetBytes(c_api.session_id));
					NameValueCollection data = nameValueCollection;
					string @string = Encoding.UTF8.GetString(webClient.UploadValues(c_api.api_link + "handler.php?type=log", data));
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object send, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("The session expired!!", "cAuth", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(0);
			}
		}

		// Token: 0x04000150 RID: 336
		private static string api_link = "https://cauth.me/api/";

		// Token: 0x04000151 RID: 337
		private static string user_agent = "Mozilla cAuth";
	}
}

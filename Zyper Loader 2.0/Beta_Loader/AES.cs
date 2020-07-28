using System;
using System.IO;
using System.Security.Cryptography;

namespace Beta_Loader
{
	// Token: 0x02000037 RID: 55
	internal class AES
	{
		// Token: 0x060000CF RID: 207 RVA: 0x0000627C File Offset: 0x0000447C
		public static byte[] DecryptAES(byte[] bytesToBeDecrypted, byte[] passwordBytes)
		{
			byte[] result = null;
			byte[] salt = new byte[]
			{
				1,
				2,
				38,
				6,
				4,
				5,
				6,
				3,
				4,
				9,
				6,
				34,
				4,
				9,
				4,
				3,
				3,
				46,
				54,
				64,
				5,
				31,
				24,
				65,
				1,
				63,
				4,
				56,
				46,
				3,
				7,
				3
			};
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						cryptoStream.Close();
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}
	}
}

using System;

namespace c_auth
{
	// Token: 0x02000035 RID: 53
	public class c_userdata
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005E4F File Offset: 0x0000404F
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00005E56 File Offset: 0x00004056
		public static string username { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00005E5E File Offset: 0x0000405E
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00005E65 File Offset: 0x00004065
		public static string email { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00005E6D File Offset: 0x0000406D
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00005E74 File Offset: 0x00004074
		public static DateTime expires { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00005E7C File Offset: 0x0000407C
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00005E83 File Offset: 0x00004083
		public static string var { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005E8B File Offset: 0x0000408B
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00005E92 File Offset: 0x00004092
		public static int rank { get; set; }
	}
}

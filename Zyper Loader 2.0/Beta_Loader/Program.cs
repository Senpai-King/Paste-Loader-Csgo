using System;
using System.Windows.Forms;

namespace Beta_Loader
{
	// Token: 0x0200003A RID: 58
	internal static class Program
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x0000774E File Offset: 0x0000594E
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}

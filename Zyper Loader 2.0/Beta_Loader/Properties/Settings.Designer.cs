using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Beta_Loader.Properties
{
	// Token: 0x0200003D RID: 61
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000853C File Offset: 0x0000673C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400017B RID: 379
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

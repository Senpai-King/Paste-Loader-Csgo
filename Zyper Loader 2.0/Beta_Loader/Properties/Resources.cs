using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Beta_Loader.Properties
{
	// Token: 0x0200003C RID: 60
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x000083A7 File Offset: 0x000065A7
		internal Resources()
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000083B4 File Offset: 0x000065B4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Beta_Loader.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000083FC File Offset: 0x000065FC
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00008413 File Offset: 0x00006613
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000841C File Offset: 0x0000661C
		internal static Bitmap iconfinder_counterstrike_squircle_4737388
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("iconfinder_counterstrike_squircle_4737388", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000844C File Offset: 0x0000664C
		internal static Bitmap iconfinder_csgo_squircle_4737387__1_
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("iconfinder_csgo_squircle_4737387 (1)", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000847C File Offset: 0x0000667C
		internal static Bitmap IMG_20191114_WA0157
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("IMG-20191114-WA0157", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000084AC File Offset: 0x000066AC
		internal static Bitmap Zyper_Cheats_Logo_sem_fundo
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Zyper Cheats Logo sem fundo", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000084DC File Offset: 0x000066DC
		internal static Bitmap zyper_logo_para_o_loader
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("zyper logo para o loader", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000850C File Offset: 0x0000670C
		internal static Bitmap zyper_logo_para_o_loader1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("zyper logo para o loader1", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000179 RID: 377
		private static ResourceManager resourceMan;

		// Token: 0x0400017A RID: 378
		private static CultureInfo resourceCulture;
	}
}

using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000027 RID: 39
	public class PIMAGE_SECTION_HEADER : ManagedPtr<IMAGE_SECTION_HEADER>
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00004184 File Offset: 0x00002384
		public PIMAGE_SECTION_HEADER(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000418F File Offset: 0x0000238F
		public PIMAGE_SECTION_HEADER(object value) : base(value, true)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000419C File Offset: 0x0000239C
		public new static explicit operator PIMAGE_SECTION_HEADER(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_SECTION_HEADER result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_SECTION_HEADER(ptr);
			}
			return result;
		}
	}
}

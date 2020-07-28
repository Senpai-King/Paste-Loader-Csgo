using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000022 RID: 34
	public class PIMAGE_DOS_HEADER : ManagedPtr<IMAGE_DOS_HEADER>
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003F5F File Offset: 0x0000215F
		public PIMAGE_DOS_HEADER(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003F6A File Offset: 0x0000216A
		public PIMAGE_DOS_HEADER(object value) : base(value, true)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003F78 File Offset: 0x00002178
		public new static explicit operator PIMAGE_DOS_HEADER(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_DOS_HEADER result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_DOS_HEADER(ptr);
			}
			return result;
		}
	}
}

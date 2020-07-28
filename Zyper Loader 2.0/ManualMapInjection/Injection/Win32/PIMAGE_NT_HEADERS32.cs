using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000023 RID: 35
	public class PIMAGE_NT_HEADERS32 : ManagedPtr<IMAGE_NT_HEADERS32>
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00003FA4 File Offset: 0x000021A4
		public PIMAGE_NT_HEADERS32(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003FAF File Offset: 0x000021AF
		public PIMAGE_NT_HEADERS32(object value) : base(value, true)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003FBC File Offset: 0x000021BC
		public new static explicit operator PIMAGE_NT_HEADERS32(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_NT_HEADERS32 result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_NT_HEADERS32(ptr);
			}
			return result;
		}
	}
}

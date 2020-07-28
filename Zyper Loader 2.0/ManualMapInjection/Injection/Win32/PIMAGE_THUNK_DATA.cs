using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000028 RID: 40
	public class PIMAGE_THUNK_DATA : ManagedPtr<IMAGE_THUNK_DATA>
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000041C8 File Offset: 0x000023C8
		public PIMAGE_THUNK_DATA(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000041D3 File Offset: 0x000023D3
		public PIMAGE_THUNK_DATA(object value) : base(value, true)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000041E0 File Offset: 0x000023E0
		public static PIMAGE_THUNK_DATA operator +(PIMAGE_THUNK_DATA c1, int c2)
		{
			return new PIMAGE_THUNK_DATA(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000420C File Offset: 0x0000240C
		public static PIMAGE_THUNK_DATA operator ++(PIMAGE_THUNK_DATA a)
		{
			return a + 1;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004228 File Offset: 0x00002428
		public new static explicit operator PIMAGE_THUNK_DATA(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_THUNK_DATA result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_THUNK_DATA(ptr);
			}
			return result;
		}
	}
}

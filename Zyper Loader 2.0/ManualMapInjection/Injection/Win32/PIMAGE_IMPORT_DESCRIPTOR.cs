using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000026 RID: 38
	public class PIMAGE_IMPORT_DESCRIPTOR : ManagedPtr<IMAGE_IMPORT_DESCRIPTOR>
	{
		// Token: 0x06000056 RID: 86 RVA: 0x000040F8 File Offset: 0x000022F8
		public PIMAGE_IMPORT_DESCRIPTOR(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004103 File Offset: 0x00002303
		public PIMAGE_IMPORT_DESCRIPTOR(object value) : base(value, true)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004110 File Offset: 0x00002310
		public static PIMAGE_IMPORT_DESCRIPTOR operator +(PIMAGE_IMPORT_DESCRIPTOR c1, int c2)
		{
			return new PIMAGE_IMPORT_DESCRIPTOR(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000413C File Offset: 0x0000233C
		public static PIMAGE_IMPORT_DESCRIPTOR operator ++(PIMAGE_IMPORT_DESCRIPTOR a)
		{
			return a + 1;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004158 File Offset: 0x00002358
		public new static explicit operator PIMAGE_IMPORT_DESCRIPTOR(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_IMPORT_DESCRIPTOR result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_IMPORT_DESCRIPTOR(ptr);
			}
			return result;
		}
	}
}

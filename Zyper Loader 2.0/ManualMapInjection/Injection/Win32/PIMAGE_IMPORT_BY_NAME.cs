using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002C RID: 44
	public class PIMAGE_IMPORT_BY_NAME : ManagedPtr<IMAGE_IMPORT_BY_NAME>
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000043F8 File Offset: 0x000025F8
		public PIMAGE_IMPORT_BY_NAME(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004403 File Offset: 0x00002603
		public PIMAGE_IMPORT_BY_NAME(object value) : base(value, true)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004410 File Offset: 0x00002610
		public static PIMAGE_IMPORT_BY_NAME operator +(PIMAGE_IMPORT_BY_NAME c1, int c2)
		{
			return new PIMAGE_IMPORT_BY_NAME(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000443C File Offset: 0x0000263C
		public static PIMAGE_IMPORT_BY_NAME operator ++(PIMAGE_IMPORT_BY_NAME a)
		{
			return a + 1;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004458 File Offset: 0x00002658
		public new static explicit operator PIMAGE_IMPORT_BY_NAME(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_IMPORT_BY_NAME result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_IMPORT_BY_NAME(ptr);
			}
			return result;
		}
	}
}

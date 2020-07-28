using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000029 RID: 41
	public class PIMAGE_EXPORT_DIRECTORY : ManagedPtr<IMAGE_EXPORT_DIRECTORY>
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00004254 File Offset: 0x00002454
		public PIMAGE_EXPORT_DIRECTORY(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000425F File Offset: 0x0000245F
		public PIMAGE_EXPORT_DIRECTORY(object value) : base(value, true)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000426C File Offset: 0x0000246C
		public static PIMAGE_EXPORT_DIRECTORY operator +(PIMAGE_EXPORT_DIRECTORY c1, int c2)
		{
			return new PIMAGE_EXPORT_DIRECTORY(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004298 File Offset: 0x00002498
		public static PIMAGE_EXPORT_DIRECTORY operator ++(PIMAGE_EXPORT_DIRECTORY a)
		{
			return a + 1;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000042B4 File Offset: 0x000024B4
		public new static explicit operator PIMAGE_EXPORT_DIRECTORY(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_EXPORT_DIRECTORY result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_EXPORT_DIRECTORY(ptr);
			}
			return result;
		}
	}
}

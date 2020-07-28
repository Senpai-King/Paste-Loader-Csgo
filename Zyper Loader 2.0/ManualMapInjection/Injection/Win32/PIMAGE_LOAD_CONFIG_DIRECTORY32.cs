using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000031 RID: 49
	public class PIMAGE_LOAD_CONFIG_DIRECTORY32 : ManagedPtr<IMAGE_LOAD_CONFIG_DIRECTORY32>
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000046B4 File Offset: 0x000028B4
		public PIMAGE_LOAD_CONFIG_DIRECTORY32(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000046BF File Offset: 0x000028BF
		public PIMAGE_LOAD_CONFIG_DIRECTORY32(object value) : base(value, true)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000046CC File Offset: 0x000028CC
		public static PIMAGE_LOAD_CONFIG_DIRECTORY32 operator +(PIMAGE_LOAD_CONFIG_DIRECTORY32 c1, int c2)
		{
			return new PIMAGE_LOAD_CONFIG_DIRECTORY32(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000046F8 File Offset: 0x000028F8
		public static PIMAGE_LOAD_CONFIG_DIRECTORY32 operator ++(PIMAGE_LOAD_CONFIG_DIRECTORY32 a)
		{
			return a + 1;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004714 File Offset: 0x00002914
		public new static explicit operator PIMAGE_LOAD_CONFIG_DIRECTORY32(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_LOAD_CONFIG_DIRECTORY32 result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_LOAD_CONFIG_DIRECTORY32(ptr);
			}
			return result;
		}
	}
}

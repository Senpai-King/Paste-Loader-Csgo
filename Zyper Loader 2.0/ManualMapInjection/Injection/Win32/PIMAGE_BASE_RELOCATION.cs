using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002E RID: 46
	public class PIMAGE_BASE_RELOCATION : ManagedPtr<IMAGE_BASE_RELOCATION>
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00004510 File Offset: 0x00002710
		public PIMAGE_BASE_RELOCATION(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000451B File Offset: 0x0000271B
		public PIMAGE_BASE_RELOCATION(object value) : base(value, true)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004528 File Offset: 0x00002728
		public static PIMAGE_BASE_RELOCATION operator +(PIMAGE_BASE_RELOCATION c1, int c2)
		{
			return new PIMAGE_BASE_RELOCATION(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004554 File Offset: 0x00002754
		public static PIMAGE_BASE_RELOCATION operator ++(PIMAGE_BASE_RELOCATION a)
		{
			return a + 1;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004570 File Offset: 0x00002770
		public new static explicit operator PIMAGE_BASE_RELOCATION(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_BASE_RELOCATION result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_BASE_RELOCATION(ptr);
			}
			return result;
		}
	}
}

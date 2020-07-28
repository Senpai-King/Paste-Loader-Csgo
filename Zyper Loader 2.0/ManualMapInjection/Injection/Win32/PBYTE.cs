using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002D RID: 45
	public class PBYTE : ManagedPtr<byte>
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00004484 File Offset: 0x00002684
		public PBYTE(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000448F File Offset: 0x0000268F
		public PBYTE(object value) : base(value, true)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000449C File Offset: 0x0000269C
		public static PBYTE operator +(PBYTE c1, int c2)
		{
			return new PBYTE(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000044C8 File Offset: 0x000026C8
		public static PBYTE operator ++(PBYTE a)
		{
			return a + 1;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000044E4 File Offset: 0x000026E4
		public new static explicit operator PBYTE(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PBYTE result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PBYTE(ptr);
			}
			return result;
		}
	}
}

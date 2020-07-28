using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002B RID: 43
	public class PDWORD : ManagedPtr<uint>
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000436C File Offset: 0x0000256C
		public PDWORD(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004377 File Offset: 0x00002577
		public PDWORD(object value) : base(value, true)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004384 File Offset: 0x00002584
		public static PDWORD operator +(PDWORD c1, int c2)
		{
			return new PDWORD(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000043B0 File Offset: 0x000025B0
		public static PDWORD operator ++(PDWORD a)
		{
			return a + 1;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000043CC File Offset: 0x000025CC
		public new static explicit operator PDWORD(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PDWORD result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PDWORD(ptr);
			}
			return result;
		}
	}
}

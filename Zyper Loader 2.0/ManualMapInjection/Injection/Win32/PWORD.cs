using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002A RID: 42
	public class PWORD : ManagedPtr<ushort>
	{
		// Token: 0x06000068 RID: 104 RVA: 0x000042E0 File Offset: 0x000024E0
		public PWORD(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000042EB File Offset: 0x000024EB
		public PWORD(object value) : base(value, true)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000042F8 File Offset: 0x000024F8
		public static PWORD operator +(PWORD c1, int c2)
		{
			return new PWORD(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004324 File Offset: 0x00002524
		public static PWORD operator ++(PWORD a)
		{
			return a + 1;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004340 File Offset: 0x00002540
		public new static explicit operator PWORD(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PWORD result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PWORD(ptr);
			}
			return result;
		}
	}
}

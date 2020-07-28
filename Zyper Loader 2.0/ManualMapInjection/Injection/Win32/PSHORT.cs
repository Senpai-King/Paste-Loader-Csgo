using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002F RID: 47
	public class PSHORT : ManagedPtr<short>
	{
		// Token: 0x06000081 RID: 129 RVA: 0x0000459C File Offset: 0x0000279C
		public PSHORT(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000045A7 File Offset: 0x000027A7
		public PSHORT(object value) : base(value, true)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000045B4 File Offset: 0x000027B4
		public static PSHORT operator +(PSHORT c1, int c2)
		{
			return new PSHORT(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000045E0 File Offset: 0x000027E0
		public static PSHORT operator ++(PSHORT a)
		{
			return a + 1;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000045FC File Offset: 0x000027FC
		public new static explicit operator PSHORT(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PSHORT result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PSHORT(ptr);
			}
			return result;
		}
	}
}

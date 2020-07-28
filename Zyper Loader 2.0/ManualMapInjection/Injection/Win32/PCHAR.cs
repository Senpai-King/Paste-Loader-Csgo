using System;
using System.Runtime.InteropServices;
using System.Text;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000024 RID: 36
	public class PCHAR : ManagedPtr<char>
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003FE8 File Offset: 0x000021E8
		public PCHAR(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003FF3 File Offset: 0x000021F3
		public PCHAR(object value) : base(value, true)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003FFF File Offset: 0x000021FF
		public PCHAR(string value) : base(Encoding.UTF8.GetBytes(value), true)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004018 File Offset: 0x00002218
		public static PCHAR operator +(PCHAR c1, int c2)
		{
			return new PCHAR(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004044 File Offset: 0x00002244
		public static PCHAR operator ++(PCHAR a)
		{
			return a + 1;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004060 File Offset: 0x00002260
		public new static explicit operator PCHAR(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PCHAR result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PCHAR(ptr);
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000408C File Offset: 0x0000228C
		public override string ToString()
		{
			return Marshal.PtrToStringAnsi(base.Address) ?? string.Empty;
		}
	}
}

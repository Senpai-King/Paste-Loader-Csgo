using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000025 RID: 37
	public class PPROCESS_BASIC_INFORMATION : ManagedPtr<PROCESS_BASIC_INFORMATION>
	{
		// Token: 0x06000053 RID: 83 RVA: 0x000040B2 File Offset: 0x000022B2
		public PPROCESS_BASIC_INFORMATION(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000040BD File Offset: 0x000022BD
		public PPROCESS_BASIC_INFORMATION(object value) : base(value, true)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000040CC File Offset: 0x000022CC
		public new static explicit operator PPROCESS_BASIC_INFORMATION(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PPROCESS_BASIC_INFORMATION result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PPROCESS_BASIC_INFORMATION(ptr);
			}
			return result;
		}
	}
}

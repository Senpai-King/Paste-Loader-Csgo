using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Types
{
	// Token: 0x02000032 RID: 50
	public class ManagedPtr<T> where T : struct
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004740 File Offset: 0x00002940
		public IntPtr Address { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004748 File Offset: 0x00002948
		public T Value
		{
			get
			{
				return this[0U];
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004764 File Offset: 0x00002964
		public int StructSize
		{
			get
			{
				bool flag = this._structSize == null;
				if (flag)
				{
					this._structSize = new int?(Marshal.SizeOf(typeof(T)));
				}
				return this._structSize.Value;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000047B0 File Offset: 0x000029B0
		private static T GetStructure(IntPtr address)
		{
			return (T)((object)Marshal.PtrToStructure(address, typeof(T)));
		}

		// Token: 0x1700000E RID: 14
		public T this[uint index]
		{
			get
			{
				return ManagedPtr<T>.GetStructure(this.Address + (int)(index * (uint)this.StructSize));
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004804 File Offset: 0x00002A04
		public static ManagedPtr<T>operator +(ManagedPtr<T> c1, int c2)
		{
			return new ManagedPtr<T>(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004830 File Offset: 0x00002A30
		public static ManagedPtr<T>operator ++(ManagedPtr<T> a)
		{
			return a + 1;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000484C File Offset: 0x00002A4C
		public static ManagedPtr<T>operator -(ManagedPtr<T> c1, int c2)
		{
			return new ManagedPtr<T>(c1.Address - c2 * c1.StructSize);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004878 File Offset: 0x00002A78
		public static ManagedPtr<T>operator --(ManagedPtr<T> a)
		{
			return a - 1;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004894 File Offset: 0x00002A94
		public static explicit operator ManagedPtr<T>(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			ManagedPtr<T> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new ManagedPtr<T>(ptr);
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000048C0 File Offset: 0x00002AC0
		public static explicit operator IntPtr(ManagedPtr<T> ptr)
		{
			return ptr.Address;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000048D8 File Offset: 0x00002AD8
		public ManagedPtr(IntPtr address)
		{
			this.Address = address;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000048EC File Offset: 0x00002AEC
		public ManagedPtr(object value, bool freeHandle = true)
		{
			bool flag = value == null;
			if (flag)
			{
				throw new InvalidOperationException("Cannot create a pointer of type null");
			}
			try
			{
				this._handle = GCHandle.Alloc(value, GCHandleType.Pinned);
			}
			catch (Exception)
			{
				throw new InvalidOperationException("Cannot create a pointer of type " + value.GetType().Name);
			}
			this._freeHandle = freeHandle;
			this.Address = this._handle.AddrOfPinnedObject();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000496C File Offset: 0x00002B6C
		protected override void Finalize()
		{
			try
			{
				bool flag = this._handle.IsAllocated && this._freeHandle;
				if (flag)
				{
					this._handle.Free();
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x04000148 RID: 328
		private int? _structSize;

		// Token: 0x04000149 RID: 329
		private GCHandle _handle;

		// Token: 0x0400014A RID: 330
		private bool _freeHandle;
	}
}

using System;

namespace Utf8Json.Internal
{
	// Token: 0x02000095 RID: 149
	public struct MGIMFHAGEKMNFOIMFL<T>
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00003D06 File Offset: 0x00001F06
		public MGIMFHAGEKMNFOIMFL(int initialSize)
		{
			this.Buffer = new T[initialSize];
			this.Size = 0;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		public void Add(T value)
		{
			if (this.Size >= this.Buffer.Length)
			{
				Array.Resize<T>(ref this.Buffer, this.Size * 2);
			}
			T[] buffer = this.Buffer;
			int size = this.Size;
			this.Size = size + 1;
			buffer[size] = value;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		public T[] ToArray()
		{
			if (this.Buffer.Length == this.Size)
			{
				return this.Buffer;
			}
			T[] array = new T[this.Size];
			Array.Copy(this.Buffer, array, this.Size);
			return array;
		}

		// Token: 0x04000144 RID: 324
		public T[] Buffer;

		// Token: 0x04000145 RID: 325
		public int Size;
	}
}

using System;

namespace Utf8Json.Internal
{
	// Token: 0x02000097 RID: 151
	internal class FLKLOHJCFNJIBPBADP<T>
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00003D35 File Offset: 0x00001F35
		public FLKLOHJCFNJIBPBADP(int bufferLength)
		{
			this.bufferLength = bufferLength;
			this.buffers = new T[4][];
			this.gate = new object();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000D440 File Offset: 0x0000B640
		public T[] Rent()
		{
			object obj = this.gate;
			T[] result;
			lock (obj)
			{
				if (this.index >= this.buffers.Length)
				{
					Array.Resize<T[]>(ref this.buffers, this.buffers.Length * 2);
				}
				if (this.buffers[this.index] == null)
				{
					this.buffers[this.index] = new T[this.bufferLength];
				}
				T[] array = this.buffers[this.index];
				this.buffers[this.index] = null;
				this.index++;
				result = array;
			}
			return result;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000D4F4 File Offset: 0x0000B6F4
		public void Return(T[] array)
		{
			if (array.Length != this.bufferLength)
			{
				throw new InvalidOperationException("return buffer is not from pool");
			}
			object obj = this.gate;
			lock (obj)
			{
				if (this.index != 0)
				{
					T[][] array2 = this.buffers;
					int num = this.index - 1;
					this.index = num;
					array2[num] = array;
				}
			}
		}

		// Token: 0x04000147 RID: 327
		private readonly int bufferLength;

		// Token: 0x04000148 RID: 328
		private readonly object gate;

		// Token: 0x04000149 RID: 329
		private int index;

		// Token: 0x0400014A RID: 330
		private T[][] buffers;
	}
}

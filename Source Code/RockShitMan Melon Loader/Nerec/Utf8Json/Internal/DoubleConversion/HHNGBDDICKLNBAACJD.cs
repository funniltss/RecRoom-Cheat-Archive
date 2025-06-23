using System;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000BC RID: 188
	internal struct HHNGBDDICKLNBAACJD
	{
		// Token: 0x06000307 RID: 775 RVA: 0x0000481D File Offset: 0x00002A1D
		public HHNGBDDICKLNBAACJD(byte[] buffer, int position)
		{
			this.buffer = buffer;
			this.offset = position;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00011500 File Offset: 0x0000F700
		public void AddCharacter(byte str)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = str;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00011538 File Offset: 0x0000F738
		public void AddString(byte[] str)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, str.Length);
			for (int i = 0; i < str.Length; i++)
			{
				this.buffer[this.offset + i] = str[i];
			}
			this.offset += str.Length;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0001158C File Offset: 0x0000F78C
		public void AddSubstring(byte[] str, int length)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, length);
			for (int i = 0; i < length; i++)
			{
				this.buffer[this.offset + i] = str[i];
			}
			this.offset += length;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000115D8 File Offset: 0x0000F7D8
		public void AddSubstring(byte[] str, int start, int length)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, length);
			for (int i = 0; i < length; i++)
			{
				this.buffer[this.offset + i] = str[start + i];
			}
			this.offset += length;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00011628 File Offset: 0x0000F828
		public void AddPadding(byte c, int count)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, count);
			for (int i = 0; i < count; i++)
			{
				this.buffer[this.offset + i] = c;
			}
			this.offset += count;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00011674 File Offset: 0x0000F874
		public void AddStringSlow(string str)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, CHFCLNEOCDIHMILKOP.UTF8.GetMaxByteCount(str.Length));
			this.offset += CHFCLNEOCDIHMILKOP.UTF8.GetBytes(str, 0, str.Length, this.buffer, this.offset);
		}

		// Token: 0x040001CD RID: 461
		public byte[] buffer;

		// Token: 0x040001CE RID: 462
		public int offset;
	}
}

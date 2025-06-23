using System;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000C9 RID: 201
	internal struct FAJALLMDLONJIEJMNJ
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00004B10 File Offset: 0x00002D10
		public FAJALLMDLONJIEJMNJ(byte[] buffer, int offset)
		{
			this.buffer = buffer;
			this.offset = offset;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00004B20 File Offset: 0x00002D20
		public byte PBHEHCDKBGPMJMLDCK
		{
			get
			{
				return this.buffer[this.offset];
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00004B2F File Offset: 0x00002D2F
		public static FAJALLMDLONJIEJMNJ operator ++(FAJALLMDLONJIEJMNJ self)
		{
			self.offset++;
			return self;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000135B8 File Offset: 0x000117B8
		public static FAJALLMDLONJIEJMNJ operator +(FAJALLMDLONJIEJMNJ self, int length)
		{
			return new FAJALLMDLONJIEJMNJ
			{
				buffer = self.buffer,
				offset = self.offset + length
			};
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00004B3E File Offset: 0x00002D3E
		public static int operator -(FAJALLMDLONJIEJMNJ lhs, FAJALLMDLONJIEJMNJ rhs)
		{
			return lhs.offset - rhs.offset;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00004B4D File Offset: 0x00002D4D
		public static bool operator ==(FAJALLMDLONJIEJMNJ lhs, FAJALLMDLONJIEJMNJ rhs)
		{
			return lhs.offset == rhs.offset;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00004B5D File Offset: 0x00002D5D
		public static bool operator !=(FAJALLMDLONJIEJMNJ lhs, FAJALLMDLONJIEJMNJ rhs)
		{
			return lhs.offset != rhs.offset;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00004B70 File Offset: 0x00002D70
		public static bool operator ==(FAJALLMDLONJIEJMNJ lhs, char rhs)
		{
			return lhs.buffer[lhs.offset] == (byte)rhs;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00004B83 File Offset: 0x00002D83
		public static bool operator !=(FAJALLMDLONJIEJMNJ lhs, char rhs)
		{
			return lhs.buffer[lhs.offset] != (byte)rhs;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00004B99 File Offset: 0x00002D99
		public static bool operator ==(FAJALLMDLONJIEJMNJ lhs, byte rhs)
		{
			return lhs.buffer[lhs.offset] == rhs;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00004BAB File Offset: 0x00002DAB
		public static bool operator !=(FAJALLMDLONJIEJMNJ lhs, byte rhs)
		{
			return lhs.buffer[lhs.offset] != rhs;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public static bool operator >=(FAJALLMDLONJIEJMNJ lhs, char rhs)
		{
			return lhs.buffer[lhs.offset] >= (byte)rhs;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00004BD6 File Offset: 0x00002DD6
		public static bool operator <=(FAJALLMDLONJIEJMNJ lhs, char rhs)
		{
			return lhs.buffer[lhs.offset] <= (byte)rhs;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00004BEC File Offset: 0x00002DEC
		public static bool operator >(FAJALLMDLONJIEJMNJ lhs, char rhs)
		{
			return lhs.buffer[lhs.offset] > (byte)rhs;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00004BFF File Offset: 0x00002DFF
		public static bool operator <(FAJALLMDLONJIEJMNJ lhs, char rhs)
		{
			return lhs.buffer[lhs.offset] < (byte)rhs;
		}

		// Token: 0x0400021B RID: 539
		private byte[] buffer;

		// Token: 0x0400021C RID: 540
		private int offset;
	}
}

using System;
using System.Runtime.InteropServices;

namespace Utf8Json.Internal
{
	// Token: 0x020000A5 RID: 165
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct LNMOFFKENDGOEDLKBN
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00004049 File Offset: 0x00002249
		public LNMOFFKENDGOEDLKBN(ref Guid value)
		{
			this = default(LNMOFFKENDGOEDLKBN);
			this.Value = value;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000EA30 File Offset: 0x0000CC30
		public LNMOFFKENDGOEDLKBN(ref ArraySegment<byte> utf8string)
		{
			this = default(LNMOFFKENDGOEDLKBN);
			byte[] array = utf8string.Array;
			int offset = utf8string.Offset;
			if (utf8string.Count == 32)
			{
				if (BitConverter.IsLittleEndian)
				{
					this.Byte0 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 6);
					this.Byte1 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 4);
					this.Byte2 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 2);
					this.Byte3 = LNMOFFKENDGOEDLKBN.Parse(array, offset);
					this.Byte4 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 10);
					this.Byte5 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 8);
					this.Byte6 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 14);
					this.Byte7 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 12);
				}
				else
				{
					this.Byte0 = LNMOFFKENDGOEDLKBN.Parse(array, offset);
					this.Byte1 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 2);
					this.Byte2 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 4);
					this.Byte3 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 6);
					this.Byte4 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 8);
					this.Byte5 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 10);
					this.Byte6 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 12);
					this.Byte7 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 14);
				}
				this.Byte8 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 16);
				this.Byte9 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 18);
				this.Byte10 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 20);
				this.Byte11 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 22);
				this.Byte12 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 24);
				this.Byte13 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 26);
				this.Byte14 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 28);
				this.Byte15 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 30);
				return;
			}
			if (utf8string.Count == 36)
			{
				if (BitConverter.IsLittleEndian)
				{
					this.Byte0 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 6);
					this.Byte1 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 4);
					this.Byte2 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 2);
					this.Byte3 = LNMOFFKENDGOEDLKBN.Parse(array, offset);
					if (array[offset + 8] != 45)
					{
						goto IL_378;
					}
					this.Byte4 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 11);
					this.Byte5 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 9);
					if (array[offset + 13] != 45)
					{
						goto IL_378;
					}
					this.Byte6 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 16);
					this.Byte7 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 14);
				}
				else
				{
					this.Byte0 = LNMOFFKENDGOEDLKBN.Parse(array, offset);
					this.Byte1 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 2);
					this.Byte2 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 4);
					this.Byte3 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 6);
					if (array[offset + 8] != 45)
					{
						goto IL_378;
					}
					this.Byte4 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 9);
					this.Byte5 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 11);
					if (array[offset + 13] != 45)
					{
						goto IL_378;
					}
					this.Byte6 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 14);
					this.Byte7 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 16);
				}
				if (array[offset + 18] == 45)
				{
					this.Byte8 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 19);
					this.Byte9 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 21);
					if (array[offset + 23] == 45)
					{
						this.Byte10 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 24);
						this.Byte11 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 26);
						this.Byte12 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 28);
						this.Byte13 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 30);
						this.Byte14 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 32);
						this.Byte15 = LNMOFFKENDGOEDLKBN.Parse(array, offset + 34);
						return;
					}
				}
			}
			IL_378:
			throw new ArgumentException("Invalid Guid Pattern.");
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000405E File Offset: 0x0000225E
		private static byte Parse(byte[] bytes, int highOffset)
		{
			return LNMOFFKENDGOEDLKBN.SwitchParse(bytes[highOffset]) * 16 + LNMOFFKENDGOEDLKBN.SwitchParse(bytes[highOffset + 1]);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		private static byte SwitchParse(byte b)
		{
			switch (b)
			{
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
			case 55:
			case 56:
			case 57:
				return b - 48;
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
				return b - 55;
			case 97:
			case 98:
			case 99:
			case 100:
			case 101:
			case 102:
				return b - 87;
			}
			throw new ArgumentException("Invalid Guid Pattern.");
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000EF90 File Offset: 0x0000D190
		public void Write(byte[] buffer, int offset)
		{
			if (BitConverter.IsLittleEndian)
			{
				buffer[offset + 6] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte0];
				buffer[offset + 7] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte0];
				buffer[offset + 4] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte1];
				buffer[offset + 5] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte1];
				buffer[offset + 2] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte2];
				buffer[offset + 3] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte2];
				buffer[offset] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte3];
				buffer[offset + 1] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte3];
				buffer[offset + 8] = 45;
				buffer[offset + 11] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte4];
				buffer[offset + 12] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte4];
				buffer[offset + 9] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte5];
				buffer[offset + 10] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte5];
				buffer[offset + 13] = 45;
				buffer[offset + 16] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte6];
				buffer[offset + 17] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte6];
				buffer[offset + 14] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte7];
				buffer[offset + 15] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte7];
			}
			else
			{
				buffer[offset] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte0];
				buffer[offset + 1] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte0];
				buffer[offset + 2] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte1];
				buffer[offset + 3] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte1];
				buffer[offset + 4] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte2];
				buffer[offset + 5] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte2];
				buffer[offset + 6] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte3];
				buffer[offset + 7] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte3];
				buffer[offset + 8] = 45;
				buffer[offset + 9] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte4];
				buffer[offset + 10] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte4];
				buffer[offset + 11] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte5];
				buffer[offset + 12] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte5];
				buffer[offset + 13] = 45;
				buffer[offset + 14] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte6];
				buffer[offset + 15] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte6];
				buffer[offset + 16] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte7];
				buffer[offset + 17] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte7];
			}
			buffer[offset + 18] = 45;
			buffer[offset + 19] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte8];
			buffer[offset + 20] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte8];
			buffer[offset + 21] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte9];
			buffer[offset + 22] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte9];
			buffer[offset + 23] = 45;
			buffer[offset + 24] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte10];
			buffer[offset + 25] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte10];
			buffer[offset + 26] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte11];
			buffer[offset + 27] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte11];
			buffer[offset + 28] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte12];
			buffer[offset + 29] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte12];
			buffer[offset + 30] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte13];
			buffer[offset + 31] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte13];
			buffer[offset + 32] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte14];
			buffer[offset + 33] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte14];
			buffer[offset + 34] = LNMOFFKENDGOEDLKBN.byteToHexStringHigh[(int)this.Byte15];
			buffer[offset + 35] = LNMOFFKENDGOEDLKBN.byteToHexStringLow[(int)this.Byte15];
		}

		// Token: 0x04000175 RID: 373
		[FieldOffset(0)]
		public readonly Guid Value;

		// Token: 0x04000176 RID: 374
		[FieldOffset(0)]
		public readonly byte Byte0;

		// Token: 0x04000177 RID: 375
		[FieldOffset(1)]
		public readonly byte Byte1;

		// Token: 0x04000178 RID: 376
		[FieldOffset(2)]
		public readonly byte Byte2;

		// Token: 0x04000179 RID: 377
		[FieldOffset(3)]
		public readonly byte Byte3;

		// Token: 0x0400017A RID: 378
		[FieldOffset(4)]
		public readonly byte Byte4;

		// Token: 0x0400017B RID: 379
		[FieldOffset(5)]
		public readonly byte Byte5;

		// Token: 0x0400017C RID: 380
		[FieldOffset(6)]
		public readonly byte Byte6;

		// Token: 0x0400017D RID: 381
		[FieldOffset(7)]
		public readonly byte Byte7;

		// Token: 0x0400017E RID: 382
		[FieldOffset(8)]
		public readonly byte Byte8;

		// Token: 0x0400017F RID: 383
		[FieldOffset(9)]
		public readonly byte Byte9;

		// Token: 0x04000180 RID: 384
		[FieldOffset(10)]
		public readonly byte Byte10;

		// Token: 0x04000181 RID: 385
		[FieldOffset(11)]
		public readonly byte Byte11;

		// Token: 0x04000182 RID: 386
		[FieldOffset(12)]
		public readonly byte Byte12;

		// Token: 0x04000183 RID: 387
		[FieldOffset(13)]
		public readonly byte Byte13;

		// Token: 0x04000184 RID: 388
		[FieldOffset(14)]
		public readonly byte Byte14;

		// Token: 0x04000185 RID: 389
		[FieldOffset(15)]
		public readonly byte Byte15;

		// Token: 0x04000186 RID: 390
		private static byte[] byteToHexStringHigh = new byte[]
		{
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			48,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			49,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			50,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			51,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			52,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			53,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			54,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			55,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			56,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			57,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			97,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			98,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			99,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			100,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			101,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102,
			102
		};

		// Token: 0x04000187 RID: 391
		private static byte[] byteToHexStringLow = new byte[]
		{
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102
		};
	}
}

using System;
using Utf8Json.Internal.DoubleConversion;

namespace Utf8Json.Internal
{
	// Token: 0x020000A6 RID: 166
	public static class OCPOKGPLBCLIEHKKHN
	{
		// Token: 0x0600024E RID: 590 RVA: 0x000040AD File Offset: 0x000022AD
		public static bool IsNumber(byte c)
		{
			return 48 <= c && c <= 57;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000F328 File Offset: 0x0000D528
		public static bool IsNumberRepresentation(byte c)
		{
			switch (c)
			{
			case 43:
			case 45:
			case 46:
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
				return true;
			}
			return false;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000040BE File Offset: 0x000022BE
		public static sbyte ReadSByte(byte[] bytes, int offset, out int readCount)
		{
			return checked((sbyte)OCPOKGPLBCLIEHKKHN.ReadInt64(bytes, offset, out readCount));
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000040C9 File Offset: 0x000022C9
		public static short ReadInt16(byte[] bytes, int offset, out int readCount)
		{
			return checked((short)OCPOKGPLBCLIEHKKHN.ReadInt64(bytes, offset, out readCount));
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000040D4 File Offset: 0x000022D4
		public static int ReadInt32(byte[] bytes, int offset, out int readCount)
		{
			return checked((int)OCPOKGPLBCLIEHKKHN.ReadInt64(bytes, offset, out readCount));
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000F380 File Offset: 0x0000D580
		public static long ReadInt64(byte[] bytes, int offset, out int readCount)
		{
			long num = 0L;
			int num2 = 1;
			if (bytes[offset] == 45)
			{
				num2 = -1;
			}
			for (int i = (num2 == -1) ? (offset + 1) : offset; i < bytes.Length; i++)
			{
				if (!OCPOKGPLBCLIEHKKHN.IsNumber(bytes[i]))
				{
					readCount = i - offset;
					IL_4B:
					return num * (long)num2;
				}
				num = num * 10L + (long)(bytes[i] - 48);
			}
			readCount = bytes.Length - offset;
			goto IL_4B;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000040DF File Offset: 0x000022DF
		public static byte ReadByte(byte[] bytes, int offset, out int readCount)
		{
			return checked((byte)OCPOKGPLBCLIEHKKHN.ReadUInt64(bytes, offset, out readCount));
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000040EA File Offset: 0x000022EA
		public static ushort ReadUInt16(byte[] bytes, int offset, out int readCount)
		{
			return checked((ushort)OCPOKGPLBCLIEHKKHN.ReadUInt64(bytes, offset, out readCount));
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000040F5 File Offset: 0x000022F5
		public static uint ReadUInt32(byte[] bytes, int offset, out int readCount)
		{
			return checked((uint)OCPOKGPLBCLIEHKKHN.ReadUInt64(bytes, offset, out readCount));
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000F3DC File Offset: 0x0000D5DC
		public static ulong ReadUInt64(byte[] bytes, int offset, out int readCount)
		{
			ulong num = 0UL;
			for (int i = offset; i < bytes.Length; i++)
			{
				if (!OCPOKGPLBCLIEHKKHN.IsNumber(bytes[i]))
				{
					readCount = i - offset;
					return num;
				}
				num = checked(num * 10UL + (ulong)(bytes[i] - 48));
			}
			readCount = bytes.Length - offset;
			return num;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00004100 File Offset: 0x00002300
		public static float ReadSingle(byte[] bytes, int offset, out int readCount)
		{
			return JHMMNENMMBEGNACKKH.ToSingle(bytes, offset, out readCount);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000410A File Offset: 0x0000230A
		public static double ReadDouble(byte[] bytes, int offset, out int readCount)
		{
			return JHMMNENMMBEGNACKKH.ToDouble(bytes, offset, out readCount);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00004114 File Offset: 0x00002314
		public static int WriteByte(ref byte[] buffer, int offset, byte value)
		{
			return OCPOKGPLBCLIEHKKHN.WriteUInt64(ref buffer, offset, (ulong)value);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00004114 File Offset: 0x00002314
		public static int WriteUInt16(ref byte[] buffer, int offset, ushort value)
		{
			return OCPOKGPLBCLIEHKKHN.WriteUInt64(ref buffer, offset, (ulong)value);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00004114 File Offset: 0x00002314
		public static int WriteUInt32(ref byte[] buffer, int offset, uint value)
		{
			return OCPOKGPLBCLIEHKKHN.WriteUInt64(ref buffer, offset, (ulong)value);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000F424 File Offset: 0x0000D624
		public static int WriteUInt64(ref byte[] buffer, int offset, ulong value)
		{
			int num = offset;
			ulong num2 = value;
			ulong num7;
			if (num2 < 10000UL)
			{
				if (num2 < 10UL)
				{
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 1);
					goto IL_488;
				}
				if (num2 < 100UL)
				{
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 2);
					goto IL_463;
				}
				if (num2 < 1000UL)
				{
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 3);
					goto IL_43E;
				}
				GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 4);
			}
			else
			{
				ulong num3 = num2 / 10000UL;
				num2 -= num3 * 10000UL;
				if (num3 < 10000UL)
				{
					if (num3 < 10UL)
					{
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 5);
						goto IL_407;
					}
					if (num3 < 100UL)
					{
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 6);
						goto IL_3E2;
					}
					if (num3 < 1000UL)
					{
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 7);
						goto IL_3BD;
					}
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 8);
				}
				else
				{
					ulong num4 = num3 / 10000UL;
					num3 -= num4 * 10000UL;
					if (num4 < 10000UL)
					{
						if (num4 < 10UL)
						{
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 9);
							goto IL_386;
						}
						if (num4 < 100UL)
						{
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 10);
							goto IL_361;
						}
						if (num4 < 1000UL)
						{
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 11);
							goto IL_33C;
						}
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 12);
					}
					else
					{
						ulong num5 = num4 / 10000UL;
						num4 -= num5 * 10000UL;
						if (num5 < 10000UL)
						{
							if (num5 < 10UL)
							{
								GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 13);
								goto IL_304;
							}
							if (num5 < 100UL)
							{
								GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 14);
								goto IL_2DC;
							}
							if (num5 < 1000UL)
							{
								GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 15);
								goto IL_2B4;
							}
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 16);
						}
						else
						{
							ulong num6 = num5 / 10000UL;
							num5 -= num6 * 10000UL;
							if (num6 < 10000UL)
							{
								if (num6 < 10UL)
								{
									GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 17);
									goto IL_279;
								}
								if (num6 < 100UL)
								{
									GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 18);
									goto IL_251;
								}
								if (num6 < 1000UL)
								{
									GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 19);
									goto IL_229;
								}
								GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 20);
							}
							buffer[offset++] = (byte)(48UL + (num7 = num6 * 8389UL >> 23));
							num6 -= num7 * 1000UL;
							IL_229:
							buffer[offset++] = (byte)(48UL + (num7 = num6 * 5243UL >> 19));
							num6 -= num7 * 100UL;
							IL_251:
							buffer[offset++] = (byte)(48UL + (num7 = num6 * 6554UL >> 16));
							num6 -= num7 * 10UL;
							IL_279:
							buffer[offset++] = (byte)(48UL + num6);
						}
						buffer[offset++] = (byte)(48UL + (num7 = num5 * 8389UL >> 23));
						num5 -= num7 * 1000UL;
						IL_2B4:
						buffer[offset++] = (byte)(48UL + (num7 = num5 * 5243UL >> 19));
						num5 -= num7 * 100UL;
						IL_2DC:
						buffer[offset++] = (byte)(48UL + (num7 = num5 * 6554UL >> 16));
						num5 -= num7 * 10UL;
						IL_304:
						buffer[offset++] = (byte)(48UL + num5);
					}
					buffer[offset++] = (byte)(48UL + (num7 = num4 * 8389UL >> 23));
					num4 -= num7 * 1000UL;
					IL_33C:
					buffer[offset++] = (byte)(48UL + (num7 = num4 * 5243UL >> 19));
					num4 -= num7 * 100UL;
					IL_361:
					buffer[offset++] = (byte)(48UL + (num7 = num4 * 6554UL >> 16));
					num4 -= num7 * 10UL;
					IL_386:
					buffer[offset++] = (byte)(48UL + num4);
				}
				buffer[offset++] = (byte)(48UL + (num7 = num3 * 8389UL >> 23));
				num3 -= num7 * 1000UL;
				IL_3BD:
				buffer[offset++] = (byte)(48UL + (num7 = num3 * 5243UL >> 19));
				num3 -= num7 * 100UL;
				IL_3E2:
				buffer[offset++] = (byte)(48UL + (num7 = num3 * 6554UL >> 16));
				num3 -= num7 * 10UL;
				IL_407:
				buffer[offset++] = (byte)(48UL + num3);
			}
			buffer[offset++] = (byte)(48UL + (num7 = num2 * 8389UL >> 23));
			num2 -= num7 * 1000UL;
			IL_43E:
			buffer[offset++] = (byte)(48UL + (num7 = num2 * 5243UL >> 19));
			num2 -= num7 * 100UL;
			IL_463:
			buffer[offset++] = (byte)(48UL + (num7 = num2 * 6554UL >> 16));
			num2 -= num7 * 10UL;
			IL_488:
			buffer[offset++] = (byte)(48UL + num2);
			return offset - num;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000411F File Offset: 0x0000231F
		public static int WriteSByte(ref byte[] buffer, int offset, sbyte value)
		{
			return OCPOKGPLBCLIEHKKHN.WriteInt64(ref buffer, offset, (long)value);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000411F File Offset: 0x0000231F
		public static int WriteInt16(ref byte[] buffer, int offset, short value)
		{
			return OCPOKGPLBCLIEHKKHN.WriteInt64(ref buffer, offset, (long)value);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000411F File Offset: 0x0000231F
		public static int WriteInt32(ref byte[] buffer, int offset, int value)
		{
			return OCPOKGPLBCLIEHKKHN.WriteInt64(ref buffer, offset, (long)value);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000F8CC File Offset: 0x0000DACC
		public static int WriteInt64(ref byte[] buffer, int offset, long value)
		{
			int num = offset;
			long num2 = value;
			if (value < 0L)
			{
				if (value == -9223372036854775808L)
				{
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 20);
					buffer[offset++] = 45;
					buffer[offset++] = 57;
					buffer[offset++] = 50;
					buffer[offset++] = 50;
					buffer[offset++] = 51;
					buffer[offset++] = 51;
					buffer[offset++] = 55;
					buffer[offset++] = 50;
					buffer[offset++] = 48;
					buffer[offset++] = 51;
					buffer[offset++] = 54;
					buffer[offset++] = 56;
					buffer[offset++] = 53;
					buffer[offset++] = 52;
					buffer[offset++] = 55;
					buffer[offset++] = 55;
					buffer[offset++] = 53;
					buffer[offset++] = 56;
					buffer[offset++] = 48;
					buffer[offset++] = 56;
					return offset - num;
				}
				GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 1);
				buffer[offset++] = 45;
				num2 = -value;
			}
			long num7;
			if (num2 < 10000L)
			{
				if (num2 < 10L)
				{
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 1);
					goto IL_59E;
				}
				if (num2 < 100L)
				{
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 2);
					goto IL_579;
				}
				if (num2 < 1000L)
				{
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 3);
					goto IL_554;
				}
				GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 4);
			}
			else
			{
				long num3 = num2 / 10000L;
				num2 -= num3 * 10000L;
				if (num3 < 10000L)
				{
					if (num3 < 10L)
					{
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 5);
						goto IL_51D;
					}
					if (num3 < 100L)
					{
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 6);
						goto IL_4F8;
					}
					if (num3 < 1000L)
					{
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 7);
						goto IL_4D3;
					}
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 8);
				}
				else
				{
					long num4 = num3 / 10000L;
					num3 -= num4 * 10000L;
					if (num4 < 10000L)
					{
						if (num4 < 10L)
						{
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 9);
							goto IL_49C;
						}
						if (num4 < 100L)
						{
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 10);
							goto IL_477;
						}
						if (num4 < 1000L)
						{
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 11);
							goto IL_452;
						}
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 12);
					}
					else
					{
						long num5 = num4 / 10000L;
						num4 -= num5 * 10000L;
						if (num5 < 10000L)
						{
							if (num5 < 10L)
							{
								GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 13);
								goto IL_41A;
							}
							if (num5 < 100L)
							{
								GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 14);
								goto IL_3F2;
							}
							if (num5 < 1000L)
							{
								GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 15);
								goto IL_3CA;
							}
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 16);
						}
						else
						{
							long num6 = num5 / 10000L;
							num5 -= num6 * 10000L;
							if (num6 < 10000L)
							{
								if (num6 < 10L)
								{
									GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 17);
									goto IL_38F;
								}
								if (num6 < 100L)
								{
									GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 18);
									goto IL_367;
								}
								if (num6 < 1000L)
								{
									GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 19);
									goto IL_33F;
								}
								GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref buffer, offset, 20);
							}
							buffer[offset++] = (byte)(48L + (num7 = num6 * 8389L >> 23));
							num6 -= num7 * 1000L;
							IL_33F:
							buffer[offset++] = (byte)(48L + (num7 = num6 * 5243L >> 19));
							num6 -= num7 * 100L;
							IL_367:
							buffer[offset++] = (byte)(48L + (num7 = num6 * 6554L >> 16));
							num6 -= num7 * 10L;
							IL_38F:
							buffer[offset++] = (byte)(48L + num6);
						}
						buffer[offset++] = (byte)(48L + (num7 = num5 * 8389L >> 23));
						num5 -= num7 * 1000L;
						IL_3CA:
						buffer[offset++] = (byte)(48L + (num7 = num5 * 5243L >> 19));
						num5 -= num7 * 100L;
						IL_3F2:
						buffer[offset++] = (byte)(48L + (num7 = num5 * 6554L >> 16));
						num5 -= num7 * 10L;
						IL_41A:
						buffer[offset++] = (byte)(48L + num5);
					}
					buffer[offset++] = (byte)(48L + (num7 = num4 * 8389L >> 23));
					num4 -= num7 * 1000L;
					IL_452:
					buffer[offset++] = (byte)(48L + (num7 = num4 * 5243L >> 19));
					num4 -= num7 * 100L;
					IL_477:
					buffer[offset++] = (byte)(48L + (num7 = num4 * 6554L >> 16));
					num4 -= num7 * 10L;
					IL_49C:
					buffer[offset++] = (byte)(48L + num4);
				}
				buffer[offset++] = (byte)(48L + (num7 = num3 * 8389L >> 23));
				num3 -= num7 * 1000L;
				IL_4D3:
				buffer[offset++] = (byte)(48L + (num7 = num3 * 5243L >> 19));
				num3 -= num7 * 100L;
				IL_4F8:
				buffer[offset++] = (byte)(48L + (num7 = num3 * 6554L >> 16));
				num3 -= num7 * 10L;
				IL_51D:
				buffer[offset++] = (byte)(48L + num3);
			}
			buffer[offset++] = (byte)(48L + (num7 = num2 * 8389L >> 23));
			num2 -= num7 * 1000L;
			IL_554:
			buffer[offset++] = (byte)(48L + (num7 = num2 * 5243L >> 19));
			num2 -= num7 * 100L;
			IL_579:
			buffer[offset++] = (byte)(48L + (num7 = num2 * 6554L >> 16));
			num2 -= num7 * 10L;
			IL_59E:
			buffer[offset++] = (byte)(48L + num2);
			return offset - num;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000412A File Offset: 0x0000232A
		public static int WriteSingle(ref byte[] bytes, int offset, float value)
		{
			return PEFHEAKKGLPFCPKEGF.GetBytes(ref bytes, offset, value);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00004134 File Offset: 0x00002334
		public static int WriteDouble(ref byte[] bytes, int offset, double value)
		{
			return PEFHEAKKGLPFCPKEGF.GetBytes(ref bytes, offset, value);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000FE8C File Offset: 0x0000E08C
		public static bool ReadBoolean(byte[] bytes, int offset, out int readCount)
		{
			if (bytes[offset] == 116)
			{
				if (bytes[offset + 1] == 114 && bytes[offset + 2] == 117 && bytes[offset + 3] == 101)
				{
					readCount = 4;
					return true;
				}
				throw new InvalidOperationException("value is not boolean(true).");
			}
			else
			{
				if (bytes[offset] != 102)
				{
					throw new InvalidOperationException("value is not boolean.");
				}
				if (bytes[offset + 1] == 97 && bytes[offset + 2] == 108 && bytes[offset + 3] == 115 && bytes[offset + 4] == 101)
				{
					readCount = 5;
					return false;
				}
				throw new InvalidOperationException("value is not boolean(false).");
			}
		}
	}
}

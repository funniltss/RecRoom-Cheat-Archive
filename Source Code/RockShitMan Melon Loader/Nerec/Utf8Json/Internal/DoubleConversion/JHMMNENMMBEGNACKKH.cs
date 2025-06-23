using System;
using System.Text;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000CA RID: 202
	internal static class JHMMNENMMBEGNACKKH
	{
		// Token: 0x0600036D RID: 877 RVA: 0x00004C12 File Offset: 0x00002E12
		private static byte[] GetBuffer()
		{
			if (JHMMNENMMBEGNACKKH.kBuffer == null)
			{
				JHMMNENMMBEGNACKKH.kBuffer = new byte[782];
			}
			return JHMMNENMMBEGNACKKH.kBuffer;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00004C2F File Offset: 0x00002E2F
		private static byte[] GetFallbackBuffer()
		{
			if (JHMMNENMMBEGNACKKH.fallbackBuffer == null)
			{
				JHMMNENMMBEGNACKKH.fallbackBuffer = new byte[99];
			}
			return JHMMNENMMBEGNACKKH.fallbackBuffer;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00004C49 File Offset: 0x00002E49
		public static double ToDouble(byte[] buffer, int offset, out int readCount)
		{
			return JHMMNENMMBEGNACKKH.StringToIeee(new FAJALLMDLONJIEJMNJ(buffer, offset), buffer.Length - offset, true, out readCount);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00004C5E File Offset: 0x00002E5E
		public static float ToSingle(byte[] buffer, int offset, out int readCount)
		{
			return (float)JHMMNENMMBEGNACKKH.StringToIeee(new FAJALLMDLONJIEJMNJ(buffer, offset), buffer.Length - offset, false, out readCount);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000135EC File Offset: 0x000117EC
		private static bool isWhitespace(int x)
		{
			if (x < 128)
			{
				for (int i = 0; i < JHMMNENMMBEGNACKKH.kWhitespaceTable7Length; i++)
				{
					if ((int)JHMMNENMMBEGNACKKH.kWhitespaceTable7[i] == x)
					{
						return true;
					}
				}
			}
			else
			{
				for (int j = 0; j < JHMMNENMMBEGNACKKH.kWhitespaceTable16Length; j++)
				{
					if ((int)JHMMNENMMBEGNACKKH.kWhitespaceTable16[j] == x)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00004C74 File Offset: 0x00002E74
		private static bool AdvanceToNonspace(ref FAJALLMDLONJIEJMNJ current, FAJALLMDLONJIEJMNJ end)
		{
			while (current != end)
			{
				if (!JHMMNENMMBEGNACKKH.isWhitespace((int)current.PBHEHCDKBGPMJMLDCK))
				{
					return true;
				}
				current = ++current;
			}
			return false;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001363C File Offset: 0x0001183C
		private static bool ConsumeSubString(ref FAJALLMDLONJIEJMNJ current, FAJALLMDLONJIEJMNJ end, byte[] substring)
		{
			for (int i = 1; i < substring.Length; i++)
			{
				current = ++current;
				if (current == end || current != substring[i])
				{
					return false;
				}
			}
			current = ++current;
			return true;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00004CA7 File Offset: 0x00002EA7
		private static bool ConsumeFirstCharacter(ref FAJALLMDLONJIEJMNJ iter, byte[] str, int offset)
		{
			return iter.PBHEHCDKBGPMJMLDCK == str[offset];
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00004CB4 File Offset: 0x00002EB4
		private static double SignedZero(bool sign)
		{
			if (!sign)
			{
				return 0.0;
			}
			return --0.0;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001369C File Offset: 0x0001189C
		private static double StringToIeee(FAJALLMDLONJIEJMNJ input, int length, bool read_as_double, out int processed_characters_count)
		{
			FAJALLMDLONJIEJMNJ fajallmdlonjiejmnj = input;
			FAJALLMDLONJIEJMNJ fajallmdlonjiejmnj2 = input + length;
			processed_characters_count = 0;
			bool flag = true;
			bool flag2 = false;
			bool flag3 = true;
			bool flag4 = true;
			if (length == 0)
			{
				return 0.0;
			}
			if (flag2 || flag3)
			{
				if (!JHMMNENMMBEGNACKKH.AdvanceToNonspace(ref fajallmdlonjiejmnj, fajallmdlonjiejmnj2))
				{
					processed_characters_count = fajallmdlonjiejmnj - input;
					return 0.0;
				}
				if (!flag2 && input != fajallmdlonjiejmnj)
				{
					return double.NaN;
				}
			}
			byte[] buffer = JHMMNENMMBEGNACKKH.GetBuffer();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			bool flag5 = false;
			bool flag6 = false;
			if (fajallmdlonjiejmnj == '+' || fajallmdlonjiejmnj == '-')
			{
				flag6 = (fajallmdlonjiejmnj == '-');
				fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
				FAJALLMDLONJIEJMNJ fajallmdlonjiejmnj3 = fajallmdlonjiejmnj;
				if (!JHMMNENMMBEGNACKKH.AdvanceToNonspace(ref fajallmdlonjiejmnj3, fajallmdlonjiejmnj2))
				{
					return double.NaN;
				}
				if (!flag4 && fajallmdlonjiejmnj != fajallmdlonjiejmnj3)
				{
					return double.NaN;
				}
				fajallmdlonjiejmnj = fajallmdlonjiejmnj3;
			}
			if (JHMMNENMMBEGNACKKH.infinity_symbol_ != null && JHMMNENMMBEGNACKKH.ConsumeFirstCharacter(ref fajallmdlonjiejmnj, JHMMNENMMBEGNACKKH.infinity_symbol_, 0))
			{
				if (!JHMMNENMMBEGNACKKH.ConsumeSubString(ref fajallmdlonjiejmnj, fajallmdlonjiejmnj2, JHMMNENMMBEGNACKKH.infinity_symbol_))
				{
					return double.NaN;
				}
				if (!flag3 && !flag && fajallmdlonjiejmnj != fajallmdlonjiejmnj2)
				{
					return double.NaN;
				}
				if (!flag && JHMMNENMMBEGNACKKH.AdvanceToNonspace(ref fajallmdlonjiejmnj, fajallmdlonjiejmnj2))
				{
					return double.NaN;
				}
				processed_characters_count = fajallmdlonjiejmnj - input;
				if (!flag6)
				{
					return double.PositiveInfinity;
				}
				return double.NegativeInfinity;
			}
			else if (JHMMNENMMBEGNACKKH.nan_symbol_ != null && JHMMNENMMBEGNACKKH.ConsumeFirstCharacter(ref fajallmdlonjiejmnj, JHMMNENMMBEGNACKKH.nan_symbol_, 0))
			{
				if (!JHMMNENMMBEGNACKKH.ConsumeSubString(ref fajallmdlonjiejmnj, fajallmdlonjiejmnj2, JHMMNENMMBEGNACKKH.nan_symbol_))
				{
					return double.NaN;
				}
				if (!flag3 && !flag && fajallmdlonjiejmnj != fajallmdlonjiejmnj2)
				{
					return double.NaN;
				}
				if (!flag && JHMMNENMMBEGNACKKH.AdvanceToNonspace(ref fajallmdlonjiejmnj, fajallmdlonjiejmnj2))
				{
					return double.NaN;
				}
				processed_characters_count = fajallmdlonjiejmnj - input;
				if (!flag6)
				{
					return double.NaN;
				}
				return double.NaN;
			}
			else
			{
				bool flag7 = false;
				if (fajallmdlonjiejmnj == '0')
				{
					fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
					if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2)
					{
						processed_characters_count = fajallmdlonjiejmnj - input;
						return JHMMNENMMBEGNACKKH.SignedZero(flag6);
					}
					flag7 = true;
					while (fajallmdlonjiejmnj == '0')
					{
						fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
						if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2)
						{
							processed_characters_count = fajallmdlonjiejmnj - input;
							return JHMMNENMMBEGNACKKH.SignedZero(flag6);
						}
					}
				}
				bool flag8 = flag7 && false;
				while (fajallmdlonjiejmnj >= '0' && fajallmdlonjiejmnj <= '9')
				{
					if (num3 < 772)
					{
						buffer[num++] = fajallmdlonjiejmnj.PBHEHCDKBGPMJMLDCK;
						num3++;
					}
					else
					{
						num4++;
						flag5 = (flag5 || fajallmdlonjiejmnj != '0');
					}
					fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
					if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2)
					{
						IL_506:
						num2 += num4;
						if (flag5)
						{
							buffer[num++] = 49;
							num2--;
						}
						buffer[num] = 0;
						double? num5;
						if (read_as_double)
						{
							num5 = EMHOPOIONJBBHJKOEC.Strtod(new DFELICPFJECDGJNKPN(buffer, 0, num), num2);
						}
						else
						{
							float? num6 = EMHOPOIONJBBHJKOEC.Strtof(new DFELICPFJECDGJNKPN(buffer, 0, num), num2);
							num5 = ((num6 != null) ? new double?((double)num6.GetValueOrDefault()) : null);
						}
						if (num5 == null)
						{
							processed_characters_count = fajallmdlonjiejmnj - input;
							byte[] array = JHMMNENMMBEGNACKKH.GetFallbackBuffer();
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref JHMMNENMMBEGNACKKH.fallbackBuffer, 0, processed_characters_count);
							int count = 0;
							while (input != fajallmdlonjiejmnj)
							{
								array[count++] = input.PBHEHCDKBGPMJMLDCK;
								input = ++input;
							}
							return double.Parse(Encoding.UTF8.GetString(array, 0, count));
						}
						processed_characters_count = fajallmdlonjiejmnj - input;
						if (!flag6)
						{
							return num5.Value;
						}
						return -num5.Value;
					}
				}
				if (num3 == 0)
				{
					flag8 = false;
				}
				if (fajallmdlonjiejmnj == '.')
				{
					if (flag8 && !flag)
					{
						return double.NaN;
					}
					if (flag8)
					{
						goto IL_506;
					}
					fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
					if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2)
					{
						if (num3 == 0 && !flag7)
						{
							return double.NaN;
						}
						goto IL_506;
					}
					else
					{
						if (num3 == 0)
						{
							while (fajallmdlonjiejmnj == '0')
							{
								fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
								if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2)
								{
									processed_characters_count = fajallmdlonjiejmnj - input;
									return JHMMNENMMBEGNACKKH.SignedZero(flag6);
								}
								num2--;
							}
						}
						while (fajallmdlonjiejmnj >= '0' && fajallmdlonjiejmnj <= '9')
						{
							if (num3 < 772)
							{
								buffer[num++] = fajallmdlonjiejmnj.PBHEHCDKBGPMJMLDCK;
								num3++;
								num2--;
							}
							else
							{
								flag5 = (flag5 || fajallmdlonjiejmnj != '0');
							}
							fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
							if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2)
							{
								goto IL_506;
							}
						}
					}
				}
				if (!flag7 && num2 == 0 && num3 == 0)
				{
					return double.NaN;
				}
				if (fajallmdlonjiejmnj == 'e' || fajallmdlonjiejmnj == 'E')
				{
					if (flag8 && !flag)
					{
						return double.NaN;
					}
					if (flag8)
					{
						goto IL_506;
					}
					fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
					if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2)
					{
						if (!flag)
						{
							return double.NaN;
						}
						goto IL_506;
					}
					else
					{
						byte b = 43;
						if (fajallmdlonjiejmnj == '+' || fajallmdlonjiejmnj == '-')
						{
							b = fajallmdlonjiejmnj.PBHEHCDKBGPMJMLDCK;
							fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
							if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2)
							{
								if (!flag)
								{
									return double.NaN;
								}
								goto IL_506;
							}
						}
						if (fajallmdlonjiejmnj == fajallmdlonjiejmnj2 || fajallmdlonjiejmnj < '0' || fajallmdlonjiejmnj > '9')
						{
							if (!flag)
							{
								return double.NaN;
							}
							goto IL_506;
						}
						else
						{
							int num7 = 0;
							do
							{
								int num8 = (int)(fajallmdlonjiejmnj.PBHEHCDKBGPMJMLDCK - 48);
								if (num7 >= 107374182 && (num7 != 107374182 || num8 > 3))
								{
									num7 = 1073741823;
								}
								else
								{
									num7 = num7 * 10 + num8;
								}
								fajallmdlonjiejmnj = ++fajallmdlonjiejmnj;
							}
							while (fajallmdlonjiejmnj != fajallmdlonjiejmnj2 && fajallmdlonjiejmnj >= '0' && fajallmdlonjiejmnj <= '9');
							num2 += ((b == 45) ? (-num7) : num7);
						}
					}
				}
				if (!flag3 && !flag && fajallmdlonjiejmnj != fajallmdlonjiejmnj2)
				{
					return double.NaN;
				}
				if (!flag && JHMMNENMMBEGNACKKH.AdvanceToNonspace(ref fajallmdlonjiejmnj, fajallmdlonjiejmnj2))
				{
					return double.NaN;
				}
				if (flag3)
				{
					JHMMNENMMBEGNACKKH.AdvanceToNonspace(ref fajallmdlonjiejmnj, fajallmdlonjiejmnj2);
					goto IL_506;
				}
				goto IL_506;
			}
		}

		// Token: 0x0400021D RID: 541
		[ThreadStatic]
		private static byte[] kBuffer;

		// Token: 0x0400021E RID: 542
		[ThreadStatic]
		private static byte[] fallbackBuffer;

		// Token: 0x0400021F RID: 543
		private const JHMMNENMMBEGNACKKH.FODHOKCGGPMAIINCEE flags_ = (JHMMNENMMBEGNACKKH.FODHOKCGGPMAIINCEE)52;

		// Token: 0x04000220 RID: 544
		private const double empty_string_value_ = 0.0;

		// Token: 0x04000221 RID: 545
		private const double junk_string_value_ = double.NaN;

		// Token: 0x04000222 RID: 546
		private const int kMaxSignificantDigits = 772;

		// Token: 0x04000223 RID: 547
		private const int kBufferSize = 782;

		// Token: 0x04000224 RID: 548
		private static readonly byte[] infinity_symbol_ = CHFCLNEOCDIHMILKOP.UTF8.GetBytes(double.PositiveInfinity.ToString());

		// Token: 0x04000225 RID: 549
		private static readonly byte[] nan_symbol_ = CHFCLNEOCDIHMILKOP.UTF8.GetBytes(double.NaN.ToString());

		// Token: 0x04000226 RID: 550
		private static readonly byte[] kWhitespaceTable7 = new byte[]
		{
			32,
			13,
			10,
			9,
			11,
			12
		};

		// Token: 0x04000227 RID: 551
		private static readonly int kWhitespaceTable7Length = JHMMNENMMBEGNACKKH.kWhitespaceTable7.Length;

		// Token: 0x04000228 RID: 552
		private static readonly ushort[] kWhitespaceTable16 = new ushort[]
		{
			160,
			8232,
			8233,
			5760,
			6158,
			8192,
			8193,
			8194,
			8195,
			8196,
			8197,
			8198,
			8199,
			8200,
			8201,
			8202,
			8239,
			8287,
			12288,
			65279
		};

		// Token: 0x04000229 RID: 553
		private static readonly int kWhitespaceTable16Length = JHMMNENMMBEGNACKKH.kWhitespaceTable16.Length;

		// Token: 0x020000CB RID: 203
		private enum FODHOKCGGPMAIINCEE
		{
			// Token: 0x0400022B RID: 555
			NO_FLAGS,
			// Token: 0x0400022C RID: 556
			ALLOW_HEX,
			// Token: 0x0400022D RID: 557
			ALLOW_OCTALS,
			// Token: 0x0400022E RID: 558
			ALLOW_TRAILING_JUNK = 4,
			// Token: 0x0400022F RID: 559
			ALLOW_LEADING_SPACES = 8,
			// Token: 0x04000230 RID: 560
			ALLOW_TRAILING_SPACES = 16,
			// Token: 0x04000231 RID: 561
			ALLOW_SPACES_AFTER_SIGN = 32,
			// Token: 0x04000232 RID: 562
			ALLOW_CASE_INSENSIBILITY = 64
		}
	}
}

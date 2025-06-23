using System;
using System.Globalization;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000BD RID: 189
	internal static class PEFHEAKKGLPFCPKEGF
	{
		// Token: 0x0600030E RID: 782 RVA: 0x0000482D File Offset: 0x00002A2D
		private static byte[] GetDecimalRepBuffer(int size)
		{
			if (PEFHEAKKGLPFCPKEGF.decimalRepBuffer == null)
			{
				PEFHEAKKGLPFCPKEGF.decimalRepBuffer = new byte[size];
			}
			return PEFHEAKKGLPFCPKEGF.decimalRepBuffer;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00004846 File Offset: 0x00002A46
		private static byte[] GetExponentialRepBuffer(int size)
		{
			if (PEFHEAKKGLPFCPKEGF.exponentialRepBuffer == null)
			{
				PEFHEAKKGLPFCPKEGF.exponentialRepBuffer = new byte[size];
			}
			return PEFHEAKKGLPFCPKEGF.exponentialRepBuffer;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000485F File Offset: 0x00002A5F
		private static byte[] GetToStringBuffer()
		{
			if (PEFHEAKKGLPFCPKEGF.toStringBuffer == null)
			{
				PEFHEAKKGLPFCPKEGF.toStringBuffer = new byte[24];
			}
			return PEFHEAKKGLPFCPKEGF.toStringBuffer;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000116D0 File Offset: 0x0000F8D0
		public static int GetBytes(ref byte[] buffer, int offset, float value)
		{
			HHNGBDDICKLNBAACJD hhngbddicklnbaacjd = new HHNGBDDICKLNBAACJD(buffer, offset);
			if (!PEFHEAKKGLPFCPKEGF.ToShortestIeeeNumber((double)value, ref hhngbddicklnbaacjd, PEFHEAKKGLPFCPKEGF.MKNIFHLKBPBNJGEIAG.SHORTEST_SINGLE))
			{
				throw new InvalidOperationException("not support float value:" + value.ToString());
			}
			buffer = hhngbddicklnbaacjd.buffer;
			return hhngbddicklnbaacjd.offset - offset;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0001171C File Offset: 0x0000F91C
		public static int GetBytes(ref byte[] buffer, int offset, double value)
		{
			HHNGBDDICKLNBAACJD hhngbddicklnbaacjd = new HHNGBDDICKLNBAACJD(buffer, offset);
			if (!PEFHEAKKGLPFCPKEGF.ToShortestIeeeNumber(value, ref hhngbddicklnbaacjd, PEFHEAKKGLPFCPKEGF.MKNIFHLKBPBNJGEIAG.SHORTEST))
			{
				throw new InvalidOperationException("not support double value:" + value.ToString());
			}
			buffer = hhngbddicklnbaacjd.buffer;
			return hhngbddicklnbaacjd.offset - offset;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00011768 File Offset: 0x0000F968
		private static bool RoundWeed(byte[] buffer, int length, ulong distance_too_high_w, ulong unsafe_interval, ulong rest, ulong ten_kappa, ulong unit)
		{
			ulong num = distance_too_high_w - unit;
			ulong num2 = distance_too_high_w + unit;
			while (rest < num && unsafe_interval - rest >= ten_kappa && (rest + ten_kappa < num || num - rest >= rest + ten_kappa - num))
			{
				int num3 = length - 1;
				buffer[num3] -= 1;
				rest += ten_kappa;
			}
			return (rest >= num2 || unsafe_interval - rest < ten_kappa || (rest + ten_kappa >= num2 && num2 - rest <= rest + ten_kappa - num2)) && 2UL * unit <= rest && rest <= unsafe_interval - 4UL * unit;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000117F8 File Offset: 0x0000F9F8
		private static void BiggestPowerTen(uint number, int number_bits, out uint power, out int exponent_plus_one)
		{
			int num = (number_bits + 1) * 1233 >> 12;
			num++;
			if (number < PEFHEAKKGLPFCPKEGF.kSmallPowersOfTen[num])
			{
				num--;
			}
			power = PEFHEAKKGLPFCPKEGF.kSmallPowersOfTen[num];
			exponent_plus_one = num;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00011830 File Offset: 0x0000FA30
		private static bool DigitGen(HDHDIOINPIINFEHAMH low, HDHDIOINPIINFEHAMH w, HDHDIOINPIINFEHAMH high, byte[] buffer, out int length, out int kappa)
		{
			ulong num = 1UL;
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh = new HDHDIOINPIINFEHAMH(low.f - num, low.e);
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh2 = new HDHDIOINPIINFEHAMH(high.f + num, high.e);
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh3 = HDHDIOINPIINFEHAMH.Minus(ref hdhdioinpiinfehamh2, ref hdhdioinpiinfehamh);
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh4 = new HDHDIOINPIINFEHAMH(1UL << -w.e, w.e);
			uint num2 = (uint)(hdhdioinpiinfehamh2.f >> -hdhdioinpiinfehamh4.e);
			ulong num3 = hdhdioinpiinfehamh2.f & hdhdioinpiinfehamh4.f - 1UL;
			uint num4;
			int num5;
			PEFHEAKKGLPFCPKEGF.BiggestPowerTen(num2, 64 - -hdhdioinpiinfehamh4.e, out num4, out num5);
			kappa = num5;
			length = 0;
			while (kappa > 0)
			{
				int num6 = (int)(num2 / num4);
				buffer[length] = (byte)(48 + num6);
				length++;
				num2 %= num4;
				kappa--;
				ulong num7 = ((ulong)num2 << -hdhdioinpiinfehamh4.e) + num3;
				if (num7 < hdhdioinpiinfehamh3.f)
				{
					return PEFHEAKKGLPFCPKEGF.RoundWeed(buffer, length, HDHDIOINPIINFEHAMH.Minus(ref hdhdioinpiinfehamh2, ref w).f, hdhdioinpiinfehamh3.f, num7, (ulong)num4 << -hdhdioinpiinfehamh4.e, num);
				}
				num4 /= 10U;
			}
			do
			{
				num3 *= 10UL;
				num *= 10UL;
				hdhdioinpiinfehamh3.f *= 10UL;
				int num8 = (int)(num3 >> -hdhdioinpiinfehamh4.e);
				buffer[length] = (byte)(48 + num8);
				length++;
				num3 &= hdhdioinpiinfehamh4.f - 1UL;
				kappa--;
			}
			while (num3 >= hdhdioinpiinfehamh3.f);
			return PEFHEAKKGLPFCPKEGF.RoundWeed(buffer, length, HDHDIOINPIINFEHAMH.Minus(ref hdhdioinpiinfehamh2, ref w).f * num, hdhdioinpiinfehamh3.f, num3, hdhdioinpiinfehamh4.f, num);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000119EC File Offset: 0x0000FBEC
		private static bool Grisu3(double v, PEFHEAKKGLPFCPKEGF.DKKLMMAFDDNJOHAGCO mode, byte[] buffer, out int length, out int decimal_exponent)
		{
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh = new MNKABGNLNPAALJMGKF(v).AsNormalizedDiyFp();
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh2;
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh3;
			if (mode == PEFHEAKKGLPFCPKEGF.DKKLMMAFDDNJOHAGCO.FAST_DTOA_SHORTEST)
			{
				new MNKABGNLNPAALJMGKF(v).NormalizedBoundaries(out hdhdioinpiinfehamh2, out hdhdioinpiinfehamh3);
			}
			else
			{
				if (mode != PEFHEAKKGLPFCPKEGF.DKKLMMAFDDNJOHAGCO.FAST_DTOA_SHORTEST_SINGLE)
				{
					throw new Exception("Invalid Mode.");
				}
				new FMGHMOBIJHKCNEJIFN((float)v).NormalizedBoundaries(out hdhdioinpiinfehamh2, out hdhdioinpiinfehamh3);
			}
			int min_exponent = -60 - (hdhdioinpiinfehamh.e + 64);
			int max_exponent = -32 - (hdhdioinpiinfehamh.e + 64);
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh4;
			int num;
			NBGFGLNABDPFPOJAOB.GetCachedPowerForBinaryExponentRange(min_exponent, max_exponent, out hdhdioinpiinfehamh4, out num);
			HDHDIOINPIINFEHAMH w = HDHDIOINPIINFEHAMH.Times(ref hdhdioinpiinfehamh, ref hdhdioinpiinfehamh4);
			HDHDIOINPIINFEHAMH low = HDHDIOINPIINFEHAMH.Times(ref hdhdioinpiinfehamh2, ref hdhdioinpiinfehamh4);
			HDHDIOINPIINFEHAMH high = HDHDIOINPIINFEHAMH.Times(ref hdhdioinpiinfehamh3, ref hdhdioinpiinfehamh4);
			int num2;
			bool result = PEFHEAKKGLPFCPKEGF.DigitGen(low, w, high, buffer, out length, out num2);
			decimal_exponent = -num + num2;
			return result;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00011AA0 File Offset: 0x0000FCA0
		private static bool FastDtoa(double v, PEFHEAKKGLPFCPKEGF.DKKLMMAFDDNJOHAGCO mode, byte[] buffer, out int length, out int decimal_point)
		{
			int num = 0;
			if (mode <= PEFHEAKKGLPFCPKEGF.DKKLMMAFDDNJOHAGCO.FAST_DTOA_SHORTEST_SINGLE)
			{
				bool flag = PEFHEAKKGLPFCPKEGF.Grisu3(v, mode, buffer, out length, out num);
				if (flag)
				{
					decimal_point = length + num;
				}
				else
				{
					decimal_point = -1;
				}
				return flag;
			}
			throw new Exception("unreachable code.");
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00011AE0 File Offset: 0x0000FCE0
		private static bool HandleSpecialValues(double value, ref HHNGBDDICKLNBAACJD result_builder)
		{
			MNKABGNLNPAALJMGKF mnkabgnlnpaaljmgkf = new MNKABGNLNPAALJMGKF(value);
			if (mnkabgnlnpaaljmgkf.IsInfinite())
			{
				if (PEFHEAKKGLPFCPKEGF.infinity_symbol_ == null)
				{
					return false;
				}
				if (value < 0.0)
				{
					result_builder.AddCharacter(45);
				}
				result_builder.AddString(PEFHEAKKGLPFCPKEGF.infinity_symbol_);
				return true;
			}
			else
			{
				if (!mnkabgnlnpaaljmgkf.IsNan())
				{
					return false;
				}
				if (PEFHEAKKGLPFCPKEGF.nan_symbol_ == null)
				{
					return false;
				}
				result_builder.AddString(PEFHEAKKGLPFCPKEGF.nan_symbol_);
				return true;
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00011B48 File Offset: 0x0000FD48
		private static bool ToShortestIeeeNumber(double value, ref HHNGBDDICKLNBAACJD result_builder, PEFHEAKKGLPFCPKEGF.MKNIFHLKBPBNJGEIAG mode)
		{
			if (new MNKABGNLNPAALJMGKF(value).IsSpecial())
			{
				return PEFHEAKKGLPFCPKEGF.HandleSpecialValues(value, ref result_builder);
			}
			byte[] array = PEFHEAKKGLPFCPKEGF.GetDecimalRepBuffer(18);
			bool flag;
			int num;
			int num2;
			if (!PEFHEAKKGLPFCPKEGF.DoubleToAscii(value, mode, 0, array, out flag, out num, out num2))
			{
				string str = value.ToString("G17", CultureInfo.InvariantCulture);
				result_builder.AddStringSlow(str);
				return true;
			}
			bool flag2 = (PEFHEAKKGLPFCPKEGF.flags_ & PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI.UNIQUE_ZERO) > PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI.NO_FLAGS;
			if (flag && (value != 0.0 || !flag2))
			{
				result_builder.AddCharacter(45);
			}
			int num3 = num2 - 1;
			if (PEFHEAKKGLPFCPKEGF.decimal_in_shortest_low_ <= num3 && num3 < PEFHEAKKGLPFCPKEGF.decimal_in_shortest_high_)
			{
				PEFHEAKKGLPFCPKEGF.CreateDecimalRepresentation(array, num, num2, Math.Max(0, num - num2), ref result_builder);
			}
			else
			{
				PEFHEAKKGLPFCPKEGF.CreateExponentialRepresentation(array, num, num3, ref result_builder);
			}
			return true;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00011C04 File Offset: 0x0000FE04
		private static void CreateDecimalRepresentation(byte[] decimal_digits, int length, int decimal_point, int digits_after_point, ref HHNGBDDICKLNBAACJD result_builder)
		{
			if (decimal_point <= 0)
			{
				result_builder.AddCharacter(48);
				if (digits_after_point > 0)
				{
					result_builder.AddCharacter(46);
					result_builder.AddPadding(48, -decimal_point);
					result_builder.AddSubstring(decimal_digits, length);
					int count = digits_after_point - -decimal_point - length;
					result_builder.AddPadding(48, count);
				}
			}
			else if (decimal_point >= length)
			{
				result_builder.AddSubstring(decimal_digits, length);
				result_builder.AddPadding(48, decimal_point - length);
				if (digits_after_point > 0)
				{
					result_builder.AddCharacter(46);
					result_builder.AddPadding(48, digits_after_point);
				}
			}
			else
			{
				result_builder.AddSubstring(decimal_digits, decimal_point);
				result_builder.AddCharacter(46);
				result_builder.AddSubstring(decimal_digits, decimal_point, length - decimal_point);
				int count2 = digits_after_point - (length - decimal_point);
				result_builder.AddPadding(48, count2);
			}
			if (digits_after_point == 0)
			{
				if ((PEFHEAKKGLPFCPKEGF.flags_ & PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI.EMIT_TRAILING_DECIMAL_POINT) != PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI.NO_FLAGS)
				{
					result_builder.AddCharacter(46);
				}
				if ((PEFHEAKKGLPFCPKEGF.flags_ & PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI.EMIT_TRAILING_ZERO_AFTER_POINT) != PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI.NO_FLAGS)
				{
					result_builder.AddCharacter(48);
				}
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00011CDC File Offset: 0x0000FEDC
		private static void CreateExponentialRepresentation(byte[] decimal_digits, int length, int exponent, ref HHNGBDDICKLNBAACJD result_builder)
		{
			result_builder.AddCharacter(decimal_digits[0]);
			if (length != 1)
			{
				result_builder.AddCharacter(46);
				result_builder.AddSubstring(decimal_digits, 1, length - 1);
			}
			result_builder.AddCharacter((byte)PEFHEAKKGLPFCPKEGF.exponent_character_);
			if (exponent < 0)
			{
				result_builder.AddCharacter(45);
				exponent = -exponent;
			}
			else if ((PEFHEAKKGLPFCPKEGF.flags_ & PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI.EMIT_POSITIVE_EXPONENT_SIGN) != PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI.NO_FLAGS)
			{
				result_builder.AddCharacter(43);
			}
			if (exponent == 0)
			{
				result_builder.AddCharacter(48);
				return;
			}
			byte[] array = PEFHEAKKGLPFCPKEGF.GetExponentialRepBuffer(6);
			array[5] = 0;
			int num = 5;
			while (exponent > 0)
			{
				array[--num] = (byte)(48 + exponent % 10);
				exponent /= 10;
			}
			result_builder.AddSubstring(array, num, 5 - num);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00011D78 File Offset: 0x0000FF78
		private static bool DoubleToAscii(double v, PEFHEAKKGLPFCPKEGF.MKNIFHLKBPBNJGEIAG mode, int requested_digits, byte[] vector, out bool sign, out int length, out int point)
		{
			if (new MNKABGNLNPAALJMGKF(v).Sign() < 0)
			{
				sign = true;
				v = -v;
			}
			else
			{
				sign = false;
			}
			if (v == 0.0)
			{
				vector[0] = 48;
				length = 1;
				point = 1;
				return true;
			}
			bool result;
			if (mode != PEFHEAKKGLPFCPKEGF.MKNIFHLKBPBNJGEIAG.SHORTEST)
			{
				if (mode != PEFHEAKKGLPFCPKEGF.MKNIFHLKBPBNJGEIAG.SHORTEST_SINGLE)
				{
					throw new Exception("Unreachable code.");
				}
				result = PEFHEAKKGLPFCPKEGF.FastDtoa(v, PEFHEAKKGLPFCPKEGF.DKKLMMAFDDNJOHAGCO.FAST_DTOA_SHORTEST_SINGLE, vector, out length, out point);
			}
			else
			{
				result = PEFHEAKKGLPFCPKEGF.FastDtoa(v, PEFHEAKKGLPFCPKEGF.DKKLMMAFDDNJOHAGCO.FAST_DTOA_SHORTEST, vector, out length, out point);
			}
			return result;
		}

		// Token: 0x040001CF RID: 463
		[ThreadStatic]
		private static byte[] decimalRepBuffer;

		// Token: 0x040001D0 RID: 464
		[ThreadStatic]
		private static byte[] exponentialRepBuffer;

		// Token: 0x040001D1 RID: 465
		[ThreadStatic]
		private static byte[] toStringBuffer;

		// Token: 0x040001D2 RID: 466
		private static readonly byte[] infinity_symbol_ = CHFCLNEOCDIHMILKOP.UTF8.GetBytes(double.PositiveInfinity.ToString());

		// Token: 0x040001D3 RID: 467
		private static readonly byte[] nan_symbol_ = CHFCLNEOCDIHMILKOP.UTF8.GetBytes(double.NaN.ToString());

		// Token: 0x040001D4 RID: 468
		private static readonly PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI flags_ = (PEFHEAKKGLPFCPKEGF.BGLCEDPHJJEKFKLBMI)9;

		// Token: 0x040001D5 RID: 469
		private static readonly char exponent_character_ = 'E';

		// Token: 0x040001D6 RID: 470
		private static readonly int decimal_in_shortest_low_ = -4;

		// Token: 0x040001D7 RID: 471
		private static readonly int decimal_in_shortest_high_ = 15;

		// Token: 0x040001D8 RID: 472
		private const int kBase10MaximalLength = 17;

		// Token: 0x040001D9 RID: 473
		private const int kFastDtoaMaximalLength = 17;

		// Token: 0x040001DA RID: 474
		private const int kFastDtoaMaximalSingleLength = 9;

		// Token: 0x040001DB RID: 475
		private const int kMinimalTargetExponent = -60;

		// Token: 0x040001DC RID: 476
		private const int kMaximalTargetExponent = -32;

		// Token: 0x040001DD RID: 477
		private static readonly uint[] kSmallPowersOfTen = new uint[]
		{
			0U,
			1U,
			10U,
			100U,
			1000U,
			10000U,
			100000U,
			1000000U,
			10000000U,
			100000000U,
			1000000000U
		};

		// Token: 0x020000BE RID: 190
		private enum DKKLMMAFDDNJOHAGCO
		{
			// Token: 0x040001DF RID: 479
			FAST_DTOA_SHORTEST,
			// Token: 0x040001E0 RID: 480
			FAST_DTOA_SHORTEST_SINGLE
		}

		// Token: 0x020000BF RID: 191
		private enum MKNIFHLKBPBNJGEIAG
		{
			// Token: 0x040001E2 RID: 482
			SHORTEST,
			// Token: 0x040001E3 RID: 483
			SHORTEST_SINGLE
		}

		// Token: 0x020000C0 RID: 192
		private enum BGLCEDPHJJEKFKLBMI
		{
			// Token: 0x040001E5 RID: 485
			NO_FLAGS,
			// Token: 0x040001E6 RID: 486
			EMIT_POSITIVE_EXPONENT_SIGN,
			// Token: 0x040001E7 RID: 487
			EMIT_TRAILING_DECIMAL_POINT,
			// Token: 0x040001E8 RID: 488
			EMIT_TRAILING_ZERO_AFTER_POINT = 4,
			// Token: 0x040001E9 RID: 489
			UNIQUE_ZERO = 8
		}
	}
}

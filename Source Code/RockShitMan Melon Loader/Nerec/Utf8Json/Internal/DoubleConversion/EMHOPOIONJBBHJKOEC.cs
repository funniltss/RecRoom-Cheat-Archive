using System;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000C8 RID: 200
	internal static class EMHOPOIONJBBHJKOEC
	{
		// Token: 0x06000350 RID: 848 RVA: 0x00004ACE File Offset: 0x00002CCE
		private static byte[] GetCopyBuffer()
		{
			if (EMHOPOIONJBBHJKOEC.copyBuffer == null)
			{
				EMHOPOIONJBBHJKOEC.copyBuffer = new byte[780];
			}
			return EMHOPOIONJBBHJKOEC.copyBuffer;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00012F38 File Offset: 0x00011138
		private static DFELICPFJECDGJNKPN TrimLeadingZeros(DFELICPFJECDGJNKPN buffer)
		{
			for (int i = 0; i < buffer.length(); i++)
			{
				if (buffer.get_Item(i) != 48)
				{
					return buffer.SubVector(i, buffer.length());
				}
			}
			return new DFELICPFJECDGJNKPN(buffer.bytes, buffer.start, 0);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00012F88 File Offset: 0x00011188
		private static DFELICPFJECDGJNKPN TrimTrailingZeros(DFELICPFJECDGJNKPN buffer)
		{
			for (int i = buffer.length() - 1; i >= 0; i--)
			{
				if (buffer.get_Item(i) != 48)
				{
					return buffer.SubVector(0, i + 1);
				}
			}
			return new DFELICPFJECDGJNKPN(buffer.bytes, buffer.start, 0);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00012FD4 File Offset: 0x000111D4
		private static void CutToMaxSignificantDigits(DFELICPFJECDGJNKPN buffer, int exponent, byte[] significant_buffer, out int significant_exponent)
		{
			for (int i = 0; i < 779; i++)
			{
				significant_buffer[i] = buffer.get_Item(i);
			}
			significant_buffer[779] = 49;
			significant_exponent = exponent + (buffer.length() - 780);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00013018 File Offset: 0x00011218
		private static void TrimAndCut(DFELICPFJECDGJNKPN buffer, int exponent, byte[] buffer_copy_space, int space_size, out DFELICPFJECDGJNKPN trimmed, out int updated_exponent)
		{
			DFELICPFJECDGJNKPN buffer2 = EMHOPOIONJBBHJKOEC.TrimLeadingZeros(buffer);
			DFELICPFJECDGJNKPN dfelicpfjecdgjnkpn = EMHOPOIONJBBHJKOEC.TrimTrailingZeros(buffer2);
			exponent += buffer2.length() - dfelicpfjecdgjnkpn.length();
			if (dfelicpfjecdgjnkpn.length() > 780)
			{
				EMHOPOIONJBBHJKOEC.CutToMaxSignificantDigits(dfelicpfjecdgjnkpn, exponent, buffer_copy_space, out updated_exponent);
				trimmed = new DFELICPFJECDGJNKPN(buffer_copy_space, 0, 780);
				return;
			}
			trimmed = dfelicpfjecdgjnkpn;
			updated_exponent = exponent;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00013080 File Offset: 0x00011280
		private static ulong ReadUint64(DFELICPFJECDGJNKPN buffer, out int number_of_read_digits)
		{
			ulong num = 0UL;
			int num2 = 0;
			while (num2 < buffer.length() && num <= 1844674407370955160UL)
			{
				int num3 = (int)(buffer.get_Item(num2++) - 48);
				num = 10UL * num + (ulong)((long)num3);
			}
			number_of_read_digits = num2;
			return num;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000130C8 File Offset: 0x000112C8
		private static void ReadDiyFp(DFELICPFJECDGJNKPN buffer, out HDHDIOINPIINFEHAMH result, out int remaining_decimals)
		{
			int num2;
			ulong num = EMHOPOIONJBBHJKOEC.ReadUint64(buffer, out num2);
			if (buffer.length() == num2)
			{
				result = new HDHDIOINPIINFEHAMH(num, 0);
				remaining_decimals = 0;
				return;
			}
			if (buffer.get_Item(num2) >= 53)
			{
				num += 1UL;
			}
			int exponent = 0;
			result = new HDHDIOINPIINFEHAMH(num, exponent);
			remaining_decimals = buffer.length() - num2;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00013124 File Offset: 0x00011324
		private static bool DoubleStrtod(DFELICPFJECDGJNKPN trimmed, int exponent, out double result)
		{
			if (trimmed.length() <= 15)
			{
				if (exponent < 0 && -exponent < EMHOPOIONJBBHJKOEC.kExactPowersOfTenSize)
				{
					int num;
					result = EMHOPOIONJBBHJKOEC.ReadUint64(trimmed, out num);
					result /= EMHOPOIONJBBHJKOEC.exact_powers_of_ten[-exponent];
					return true;
				}
				if (0 <= exponent && exponent < EMHOPOIONJBBHJKOEC.kExactPowersOfTenSize)
				{
					int num;
					result = EMHOPOIONJBBHJKOEC.ReadUint64(trimmed, out num);
					result *= EMHOPOIONJBBHJKOEC.exact_powers_of_ten[exponent];
					return true;
				}
				int num2 = 15 - trimmed.length();
				if (0 <= exponent && exponent - num2 < EMHOPOIONJBBHJKOEC.kExactPowersOfTenSize)
				{
					int num;
					result = EMHOPOIONJBBHJKOEC.ReadUint64(trimmed, out num);
					result *= EMHOPOIONJBBHJKOEC.exact_powers_of_ten[num2];
					result *= EMHOPOIONJBBHJKOEC.exact_powers_of_ten[exponent - num2];
					return true;
				}
			}
			result = 0.0;
			return false;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000131DC File Offset: 0x000113DC
		private static HDHDIOINPIINFEHAMH AdjustmentPowerOfTen(int exponent)
		{
			switch (exponent)
			{
			case 1:
				return new HDHDIOINPIINFEHAMH(11529215046068469760UL, -60);
			case 2:
				return new HDHDIOINPIINFEHAMH(14411518807585587200UL, -57);
			case 3:
				return new HDHDIOINPIINFEHAMH(18014398509481984000UL, -54);
			case 4:
				return new HDHDIOINPIINFEHAMH(11258999068426240000UL, -50);
			case 5:
				return new HDHDIOINPIINFEHAMH(14073748835532800000UL, -47);
			case 6:
				return new HDHDIOINPIINFEHAMH(17592186044416000000UL, -44);
			case 7:
				return new HDHDIOINPIINFEHAMH(10995116277760000000UL, -40);
			default:
				throw new Exception("unreached code.");
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00013290 File Offset: 0x00011490
		private static bool DiyFpStrtod(DFELICPFJECDGJNKPN buffer, int exponent, out double result)
		{
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh;
			int num;
			EMHOPOIONJBBHJKOEC.ReadDiyFp(buffer, out hdhdioinpiinfehamh, out num);
			exponent += num;
			ulong num2 = (ulong)((num == 0) ? 0L : 4L);
			int e = hdhdioinpiinfehamh.e;
			hdhdioinpiinfehamh.Normalize();
			num2 <<= e - hdhdioinpiinfehamh.e;
			if (exponent < -348)
			{
				result = 0.0;
				return true;
			}
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh2;
			int num3;
			NBGFGLNABDPFPOJAOB.GetCachedPowerForDecimalExponent(exponent, out hdhdioinpiinfehamh2, out num3);
			if (num3 != exponent)
			{
				int num4 = exponent - num3;
				HDHDIOINPIINFEHAMH hdhdioinpiinfehamh3 = EMHOPOIONJBBHJKOEC.AdjustmentPowerOfTen(num4);
				hdhdioinpiinfehamh.Multiply(ref hdhdioinpiinfehamh3);
				if (19 - buffer.length() < num4)
				{
					num2 += 4UL;
				}
			}
			hdhdioinpiinfehamh.Multiply(ref hdhdioinpiinfehamh2);
			int num5 = 4;
			int num6 = (num2 == 0UL) ? 0 : 1;
			int num7 = 4;
			num2 += (ulong)((long)(num5 + num6 + num7));
			e = hdhdioinpiinfehamh.e;
			hdhdioinpiinfehamh.Normalize();
			num2 <<= e - hdhdioinpiinfehamh.e;
			int num8 = MNKABGNLNPAALJMGKF.SignificandSizeForOrderOfMagnitude(64 + hdhdioinpiinfehamh.e);
			int num9 = 64 - num8;
			if (num9 + 3 >= 64)
			{
				int num10 = num9 + 3 - 64 + 1;
				hdhdioinpiinfehamh.f >>= num10;
				hdhdioinpiinfehamh.e += num10;
				num2 = (num2 >> num10) + 1UL + 8UL;
				num9 -= num10;
			}
			long num11 = 1L;
			ulong num12 = (ulong)((num11 << num9) - 1L);
			ulong num13 = hdhdioinpiinfehamh.f & num12;
			ulong num14 = (ulong)((ulong)num11 << num9 - 1);
			num13 *= 8UL;
			num14 *= 8UL;
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh4 = new HDHDIOINPIINFEHAMH(hdhdioinpiinfehamh.f >> num9, hdhdioinpiinfehamh.e + num9);
			if (num13 >= num14 + num2)
			{
				hdhdioinpiinfehamh4.f += 1UL;
			}
			result = new MNKABGNLNPAALJMGKF(hdhdioinpiinfehamh4).value();
			return num14 - num2 >= num13 || num13 >= num14 + num2;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00013450 File Offset: 0x00011650
		private static bool ComputeGuess(DFELICPFJECDGJNKPN trimmed, int exponent, out double guess)
		{
			if (trimmed.length() == 0)
			{
				guess = 0.0;
				return true;
			}
			if (exponent + trimmed.length() - 1 >= 309)
			{
				guess = MNKABGNLNPAALJMGKF.Infinity();
				return true;
			}
			if (exponent + trimmed.length() <= -324)
			{
				guess = 0.0;
				return true;
			}
			return EMHOPOIONJBBHJKOEC.DoubleStrtod(trimmed, exponent, out guess) || EMHOPOIONJBBHJKOEC.DiyFpStrtod(trimmed, exponent, out guess) || guess == MNKABGNLNPAALJMGKF.Infinity();
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000134D0 File Offset: 0x000116D0
		public static double? Strtod(DFELICPFJECDGJNKPN buffer, int exponent)
		{
			byte[] buffer_copy_space = EMHOPOIONJBBHJKOEC.GetCopyBuffer();
			DFELICPFJECDGJNKPN trimmed;
			int num;
			EMHOPOIONJBBHJKOEC.TrimAndCut(buffer, exponent, buffer_copy_space, 780, out trimmed, out num);
			exponent = num;
			double value;
			if (EMHOPOIONJBBHJKOEC.ComputeGuess(trimmed, exponent, out value))
			{
				return new double?(value);
			}
			return null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00013514 File Offset: 0x00011714
		public static float? Strtof(DFELICPFJECDGJNKPN buffer, int exponent)
		{
			byte[] buffer_copy_space = EMHOPOIONJBBHJKOEC.GetCopyBuffer();
			DFELICPFJECDGJNKPN trimmed;
			int num;
			EMHOPOIONJBBHJKOEC.TrimAndCut(buffer, exponent, buffer_copy_space, 780, out trimmed, out num);
			exponent = num;
			double num2;
			bool flag = EMHOPOIONJBBHJKOEC.ComputeGuess(trimmed, exponent, out num2);
			float num3 = (float)num2;
			if ((double)num3 == num2)
			{
				return new float?(num3);
			}
			double num4 = new MNKABGNLNPAALJMGKF(num2).NextDouble();
			float num5 = (float)new MNKABGNLNPAALJMGKF(num2).PreviousDouble();
			float num6 = (float)num4;
			float num7;
			if (flag)
			{
				num7 = num6;
			}
			else
			{
				num7 = (float)new MNKABGNLNPAALJMGKF(num4).NextDouble();
			}
			if (num5 == num7)
			{
				return new float?(num3);
			}
			return null;
		}

		// Token: 0x04000212 RID: 530
		[ThreadStatic]
		private static byte[] copyBuffer;

		// Token: 0x04000213 RID: 531
		private const int kMaxExactDoubleIntegerDecimalDigits = 15;

		// Token: 0x04000214 RID: 532
		private const int kMaxUint64DecimalDigits = 19;

		// Token: 0x04000215 RID: 533
		private const int kMaxDecimalPower = 309;

		// Token: 0x04000216 RID: 534
		private const int kMinDecimalPower = -324;

		// Token: 0x04000217 RID: 535
		private const ulong kMaxUint64 = 18446744073709551615UL;

		// Token: 0x04000218 RID: 536
		private static readonly double[] exact_powers_of_ten = new double[]
		{
			1.0,
			10.0,
			100.0,
			1000.0,
			10000.0,
			100000.0,
			1000000.0,
			10000000.0,
			100000000.0,
			1000000000.0,
			10000000000.0,
			100000000000.0,
			1000000000000.0,
			10000000000000.0,
			100000000000000.0,
			1000000000000000.0,
			10000000000000000.0,
			1E+17,
			1E+18,
			1E+19,
			1E+20,
			1E+21,
			1E+22
		};

		// Token: 0x04000219 RID: 537
		private static readonly int kExactPowersOfTenSize = EMHOPOIONJBBHJKOEC.exact_powers_of_ten.Length;

		// Token: 0x0400021A RID: 538
		private const int kMaxSignificantDecimalDigits = 780;
	}
}

using System;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000C3 RID: 195
	internal struct MNKABGNLNPAALJMGKF
	{
		// Token: 0x0600031E RID: 798 RVA: 0x00011E74 File Offset: 0x00010074
		public MNKABGNLNPAALJMGKF(double d)
		{
			this.d64_ = new BMLEBHBCBKLKGECLOF
			{
				d = d
			}.u64;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00004879 File Offset: 0x00002A79
		public MNKABGNLNPAALJMGKF(HDHDIOINPIINFEHAMH d)
		{
			this.d64_ = MNKABGNLNPAALJMGKF.DiyFpToUint64(d);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00004887 File Offset: 0x00002A87
		public HDHDIOINPIINFEHAMH AsDiyFp()
		{
			return new HDHDIOINPIINFEHAMH(this.Significand(), this.Exponent());
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00011EA0 File Offset: 0x000100A0
		public HDHDIOINPIINFEHAMH AsNormalizedDiyFp()
		{
			ulong num = this.Significand();
			int num2 = this.Exponent();
			while ((num & 4503599627370496UL) == 0UL)
			{
				num <<= 1;
				num2--;
			}
			num <<= 11;
			num2 -= 11;
			return new HDHDIOINPIINFEHAMH(num, num2);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000489A File Offset: 0x00002A9A
		public ulong AsUint64()
		{
			return this.d64_;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00011EE4 File Offset: 0x000100E4
		public double NextDouble()
		{
			if (this.d64_ == 9218868437227405312UL)
			{
				return new MNKABGNLNPAALJMGKF(9.218868437227405E+18).value();
			}
			if (this.Sign() < 0 && this.Significand() == 0UL)
			{
				return 0.0;
			}
			if (this.Sign() < 0)
			{
				return new MNKABGNLNPAALJMGKF(this.d64_ - 1UL).value();
			}
			return new MNKABGNLNPAALJMGKF(this.d64_ + 1UL).value();
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00011F70 File Offset: 0x00010170
		public double PreviousDouble()
		{
			if (this.d64_ == 18442240474082181120UL)
			{
				return -MNKABGNLNPAALJMGKF.Infinity();
			}
			if (this.Sign() < 0)
			{
				return new MNKABGNLNPAALJMGKF(this.d64_ + 1UL).value();
			}
			if (this.Significand() == 0UL)
			{
				return --0.0;
			}
			return new MNKABGNLNPAALJMGKF(this.d64_ - 1UL).value();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000048A2 File Offset: 0x00002AA2
		public int Exponent()
		{
			if (this.IsDenormal())
			{
				return -1074;
			}
			return (int)((this.AsUint64() & 9218868437227405312UL) >> 52) - 1075;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00011FE4 File Offset: 0x000101E4
		public ulong Significand()
		{
			ulong num = this.AsUint64() & 4503599627370495UL;
			if (!this.IsDenormal())
			{
				return num + 4503599627370496UL;
			}
			return num;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000048CC File Offset: 0x00002ACC
		public bool IsDenormal()
		{
			return (this.AsUint64() & 9218868437227405312UL) == 0UL;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000048E2 File Offset: 0x00002AE2
		public bool IsSpecial()
		{
			return (this.AsUint64() & 9218868437227405312UL) == 9218868437227405312UL;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00012018 File Offset: 0x00010218
		public bool IsNan()
		{
			ulong num = this.AsUint64();
			return (num & 9218868437227405312UL) == 9218868437227405312UL && (num & 4503599627370495UL) > 0UL;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00012054 File Offset: 0x00010254
		public bool IsInfinite()
		{
			ulong num = this.AsUint64();
			return (num & 9218868437227405312UL) == 9218868437227405312UL && (num & 4503599627370495UL) == 0UL;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000048FF File Offset: 0x00002AFF
		public int Sign()
		{
			if ((this.AsUint64() & 9223372036854775808UL) != 0UL)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00004916 File Offset: 0x00002B16
		public HDHDIOINPIINFEHAMH UpperBoundary()
		{
			return new HDHDIOINPIINFEHAMH(this.Significand() * 2UL + 1UL, this.Exponent() - 1);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00012090 File Offset: 0x00010290
		public void NormalizedBoundaries(out HDHDIOINPIINFEHAMH out_m_minus, out HDHDIOINPIINFEHAMH out_m_plus)
		{
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh = this.AsDiyFp();
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh2 = new HDHDIOINPIINFEHAMH((hdhdioinpiinfehamh.f << 1) + 1UL, hdhdioinpiinfehamh.e - 1);
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh3 = HDHDIOINPIINFEHAMH.Normalize(ref hdhdioinpiinfehamh2);
			HDHDIOINPIINFEHAMH hdhdioinpiinfehamh4;
			if (this.LowerBoundaryIsCloser())
			{
				hdhdioinpiinfehamh4 = new HDHDIOINPIINFEHAMH((hdhdioinpiinfehamh.f << 2) - 1UL, hdhdioinpiinfehamh.e - 2);
			}
			else
			{
				hdhdioinpiinfehamh4 = new HDHDIOINPIINFEHAMH((hdhdioinpiinfehamh.f << 1) - 1UL, hdhdioinpiinfehamh.e - 1);
			}
			hdhdioinpiinfehamh4.f <<= hdhdioinpiinfehamh4.e - hdhdioinpiinfehamh3.e;
			hdhdioinpiinfehamh4.e = hdhdioinpiinfehamh3.e;
			out_m_plus = hdhdioinpiinfehamh3;
			out_m_minus = hdhdioinpiinfehamh4;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00004931 File Offset: 0x00002B31
		public bool LowerBoundaryIsCloser()
		{
			return (this.AsUint64() & 4503599627370495UL) == 0UL && this.Exponent() != -1074;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00012140 File Offset: 0x00010340
		public double value()
		{
			return new BMLEBHBCBKLKGECLOF
			{
				u64 = this.d64_
			}.d;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000495B File Offset: 0x00002B5B
		public static int SignificandSizeForOrderOfMagnitude(int order)
		{
			if (order >= -1021)
			{
				return 53;
			}
			if (order <= -1074)
			{
				return 0;
			}
			return order - -1074;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00012168 File Offset: 0x00010368
		public static double Infinity()
		{
			return new MNKABGNLNPAALJMGKF(9.218868437227405E+18).value();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001218C File Offset: 0x0001038C
		public static double NaN()
		{
			return new MNKABGNLNPAALJMGKF(9.221120237041091E+18).value();
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000121B0 File Offset: 0x000103B0
		public static ulong DiyFpToUint64(HDHDIOINPIINFEHAMH diy_fp)
		{
			ulong num = diy_fp.f;
			int num2 = diy_fp.e;
			while (num > 9007199254740991UL)
			{
				num >>= 1;
				num2++;
			}
			if (num2 >= 972)
			{
				return 9218868437227405312UL;
			}
			if (num2 < -1074)
			{
				return 0UL;
			}
			while (num2 > -1074 && (num & 4503599627370496UL) == 0UL)
			{
				num <<= 1;
				num2--;
			}
			ulong num3;
			if (num2 == -1074 && (num & 4503599627370496UL) == 0UL)
			{
				num3 = 0UL;
			}
			else
			{
				num3 = (ulong)((long)(num2 + 1075));
			}
			return (num & 4503599627370495UL) | num3 << 52;
		}

		// Token: 0x040001EE RID: 494
		public const ulong kSignMask = 9223372036854775808UL;

		// Token: 0x040001EF RID: 495
		public const ulong kExponentMask = 9218868437227405312UL;

		// Token: 0x040001F0 RID: 496
		public const ulong kSignificandMask = 4503599627370495UL;

		// Token: 0x040001F1 RID: 497
		public const ulong kHiddenBit = 4503599627370496UL;

		// Token: 0x040001F2 RID: 498
		public const int kPhysicalSignificandSize = 52;

		// Token: 0x040001F3 RID: 499
		public const int kSignificandSize = 53;

		// Token: 0x040001F4 RID: 500
		private const int kExponentBias = 1075;

		// Token: 0x040001F5 RID: 501
		private const int kDenormalExponent = -1074;

		// Token: 0x040001F6 RID: 502
		private const int kMaxExponent = 972;

		// Token: 0x040001F7 RID: 503
		private const ulong kInfinity = 9218868437227405312UL;

		// Token: 0x040001F8 RID: 504
		private const ulong kNaN = 9221120237041090560UL;

		// Token: 0x040001F9 RID: 505
		private ulong d64_;
	}
}

using System;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000C4 RID: 196
	internal struct FMGHMOBIJHKCNEJIFN
	{
		// Token: 0x06000334 RID: 820 RVA: 0x00012250 File Offset: 0x00010450
		public FMGHMOBIJHKCNEJIFN(float f)
		{
			this.d32_ = new HFKALNCKGKOPDHDBMN
			{
				f = f
			}.u32;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00004979 File Offset: 0x00002B79
		public HDHDIOINPIINFEHAMH AsDiyFp()
		{
			return new HDHDIOINPIINFEHAMH((ulong)this.Significand(), this.Exponent());
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000498D File Offset: 0x00002B8D
		public uint AsUint32()
		{
			return this.d32_;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00004995 File Offset: 0x00002B95
		public int Exponent()
		{
			if (this.IsDenormal())
			{
				return -149;
			}
			return (int)(((this.AsUint32() & 2139095040U) >> 23) - 150U);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0001227C File Offset: 0x0001047C
		public uint Significand()
		{
			uint num = this.AsUint32() & 8388607U;
			if (!this.IsDenormal())
			{
				return num + 8388608U;
			}
			return num;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000049BA File Offset: 0x00002BBA
		public bool IsDenormal()
		{
			return (this.AsUint32() & 2139095040U) == 0U;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000049CB File Offset: 0x00002BCB
		public bool IsSpecial()
		{
			return (this.AsUint32() & 2139095040U) == 2139095040U;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000122A8 File Offset: 0x000104A8
		public bool IsNan()
		{
			uint num = this.AsUint32();
			return (num & 2139095040U) == 2139095040U && (num & 8388607U) > 0U;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000122D8 File Offset: 0x000104D8
		public bool IsInfinite()
		{
			uint num = this.AsUint32();
			return (num & 2139095040U) == 2139095040U && (num & 8388607U) == 0U;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000049E0 File Offset: 0x00002BE0
		public int Sign()
		{
			if ((this.AsUint32() & 2147483648U) != 0U)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00012308 File Offset: 0x00010508
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

		// Token: 0x0600033F RID: 831 RVA: 0x000049F3 File Offset: 0x00002BF3
		public HDHDIOINPIINFEHAMH UpperBoundary()
		{
			return new HDHDIOINPIINFEHAMH((ulong)(this.Significand() * 2U + 1U), this.Exponent() - 1);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00004A0D File Offset: 0x00002C0D
		public bool LowerBoundaryIsCloser()
		{
			return (this.AsUint32() & 8388607U) == 0U && this.Exponent() != -149;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000123B8 File Offset: 0x000105B8
		public float value()
		{
			return new HFKALNCKGKOPDHDBMN
			{
				u32 = this.d32_
			}.f;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000123E0 File Offset: 0x000105E0
		public static float Infinity()
		{
			return new FMGHMOBIJHKCNEJIFN(2.139095E+09f).value();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00012400 File Offset: 0x00010600
		public static float NaN()
		{
			return new FMGHMOBIJHKCNEJIFN(2.1432893E+09f).value();
		}

		// Token: 0x040001FA RID: 506
		private const int kExponentBias = 150;

		// Token: 0x040001FB RID: 507
		private const int kDenormalExponent = -149;

		// Token: 0x040001FC RID: 508
		private const int kMaxExponent = 105;

		// Token: 0x040001FD RID: 509
		private const uint kInfinity = 2139095040U;

		// Token: 0x040001FE RID: 510
		private const uint kNaN = 2143289344U;

		// Token: 0x040001FF RID: 511
		public const uint kSignMask = 2147483648U;

		// Token: 0x04000200 RID: 512
		public const uint kExponentMask = 2139095040U;

		// Token: 0x04000201 RID: 513
		public const uint kSignificandMask = 8388607U;

		// Token: 0x04000202 RID: 514
		public const uint kHiddenBit = 8388608U;

		// Token: 0x04000203 RID: 515
		public const int kPhysicalSignificandSize = 23;

		// Token: 0x04000204 RID: 516
		public const int kSignificandSize = 24;

		// Token: 0x04000205 RID: 517
		private uint d32_;
	}
}

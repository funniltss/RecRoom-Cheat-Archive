using System;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000BB RID: 187
	internal struct HDHDIOINPIINFEHAMH
	{
		// Token: 0x060002FE RID: 766 RVA: 0x000047E2 File Offset: 0x000029E2
		public HDHDIOINPIINFEHAMH(ulong significand, int exponent)
		{
			this.f = significand;
			this.e = exponent;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000047F2 File Offset: 0x000029F2
		public void Subtract(ref HDHDIOINPIINFEHAMH other)
		{
			this.f -= other.f;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000113B4 File Offset: 0x0000F5B4
		public static HDHDIOINPIINFEHAMH Minus(ref HDHDIOINPIINFEHAMH a, ref HDHDIOINPIINFEHAMH b)
		{
			HDHDIOINPIINFEHAMH result = a;
			result.Subtract(ref b);
			return result;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00004807 File Offset: 0x00002A07
		public static HDHDIOINPIINFEHAMH operator -(HDHDIOINPIINFEHAMH lhs, HDHDIOINPIINFEHAMH rhs)
		{
			return HDHDIOINPIINFEHAMH.Minus(ref lhs, ref rhs);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000113D4 File Offset: 0x0000F5D4
		public void Multiply(ref HDHDIOINPIINFEHAMH other)
		{
			ulong num = this.f >> 32;
			ulong num2 = this.f & (ulong)-1;
			ulong num3 = other.f >> 32;
			ulong num4 = other.f & (ulong)-1;
			ulong num5 = num * num3;
			ulong num6 = num2 * num3;
			ulong num7 = num * num4;
			ulong num8 = (num2 * num4 >> 32) + (num7 & (ulong)-1) + (num6 & (ulong)-1);
			num8 += (ulong)int.MinValue;
			ulong num9 = num5 + (num7 >> 32) + (num6 >> 32) + (num8 >> 32);
			this.e += other.e + 64;
			this.f = num9;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00011468 File Offset: 0x0000F668
		public static HDHDIOINPIINFEHAMH Times(ref HDHDIOINPIINFEHAMH a, ref HDHDIOINPIINFEHAMH b)
		{
			HDHDIOINPIINFEHAMH result = a;
			result.Multiply(ref b);
			return result;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00004812 File Offset: 0x00002A12
		public static HDHDIOINPIINFEHAMH operator *(HDHDIOINPIINFEHAMH lhs, HDHDIOINPIINFEHAMH rhs)
		{
			return HDHDIOINPIINFEHAMH.Times(ref lhs, ref rhs);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00011488 File Offset: 0x0000F688
		public void Normalize()
		{
			ulong num = this.f;
			int num2 = this.e;
			while ((num & 18428729675200069632UL) == 0UL)
			{
				num <<= 10;
				num2 -= 10;
			}
			while ((num & 9223372036854775808UL) == 0UL)
			{
				num <<= 1;
				num2--;
			}
			this.f = num;
			this.e = num2;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000114E4 File Offset: 0x0000F6E4
		public static HDHDIOINPIINFEHAMH Normalize(ref HDHDIOINPIINFEHAMH a)
		{
			HDHDIOINPIINFEHAMH result = a;
			result.Normalize();
			return result;
		}

		// Token: 0x040001C9 RID: 457
		public const int kSignificandSize = 64;

		// Token: 0x040001CA RID: 458
		public const ulong kUint64MSB = 9223372036854775808UL;

		// Token: 0x040001CB RID: 459
		public ulong f;

		// Token: 0x040001CC RID: 460
		public int e;
	}
}

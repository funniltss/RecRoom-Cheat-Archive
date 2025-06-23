using System;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000C5 RID: 197
	internal struct MNOLJABBCPCCAJOOBF
	{
		// Token: 0x06000344 RID: 836 RVA: 0x00004A32 File Offset: 0x00002C32
		public MNOLJABBCPCCAJOOBF(ulong significand, short binary_exponent, short decimal_exponent)
		{
			this.significand = significand;
			this.binary_exponent = binary_exponent;
			this.decimal_exponent = decimal_exponent;
		}

		// Token: 0x04000206 RID: 518
		public readonly ulong significand;

		// Token: 0x04000207 RID: 519
		public readonly short binary_exponent;

		// Token: 0x04000208 RID: 520
		public readonly short decimal_exponent;
	}
}

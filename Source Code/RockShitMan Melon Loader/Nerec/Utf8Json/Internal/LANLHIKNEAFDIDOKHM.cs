using System;

namespace Utf8Json.Internal
{
	// Token: 0x020000A0 RID: 160
	public static class LANLHIKNEAFDIDOKHM
	{
		// Token: 0x0600022F RID: 559 RVA: 0x0000E544 File Offset: 0x0000C744
		public static bool Equals(byte[] xs, int xsOffset, int xsCount, byte[] ys)
		{
			if (xs == null || ys == null || xsCount != ys.Length)
			{
				return false;
			}
			for (int i = 0; i < ys.Length; i++)
			{
				if (xs[xsOffset++] != ys[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000E580 File Offset: 0x0000C780
		public static bool Equals(byte[] xs, int xsOffset, int xsCount, byte[] ys, int ysOffset, int ysCount)
		{
			if (xs == null || ys == null || xsCount != ysCount)
			{
				return false;
			}
			for (int i = 0; i < xsCount; i++)
			{
				if (xs[xsOffset++] != ys[ysOffset++])
				{
					return false;
				}
			}
			return true;
		}
	}
}

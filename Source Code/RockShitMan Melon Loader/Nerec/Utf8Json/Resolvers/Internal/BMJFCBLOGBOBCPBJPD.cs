using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200006D RID: 109
	internal sealed class BMJFCBLOGBOBCPBJPD : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x00002B7C File Offset: 0x00000D7C
		private BMJFCBLOGBOBCPBJPD()
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000036EE File Offset: 0x000018EE
		public FLGKBGGCEAHKIBEKBN<NHBOFEIGJNNPGHNIMP> GetFormatter<NHBOFEIGJNNPGHNIMP>()
		{
			return BMJFCBLOGBOBCPBJPD<NHBOFEIGJNNPGHNIMP>.EEGLGHEBGFBMFJGGMD.formatter;
		}

		// Token: 0x04000108 RID: 264
		public static readonly LMCMANMFGJGJFPNBEN Instance = new BMJFCBLOGBOBCPBJPD();

		// Token: 0x04000109 RID: 265
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			BMJFCBLOGBOBCPBJPD.KOFHCLCBGPDDGENFNP.Instance
		});

		// Token: 0x0200006E RID: 110
		private static class EEGLGHEBGFBMFJGGMD<T>
		{
			// Token: 0x060001A5 RID: 421 RVA: 0x00003719 File Offset: 0x00001919
			static EEGLGHEBGFBMFJGGMD()
			{
				if (typeof(T) == typeof(object))
				{
					BMJFCBLOGBOBCPBJPD<T>.EEGLGHEBGFBMFJGGMD.formatter = (FLGKBGGCEAHKIBEKBN<T>)BMJFCBLOGBOBCPBJPD.fallbackFormatter;
					return;
				}
				BMJFCBLOGBOBCPBJPD<T>.EEGLGHEBGFBMFJGGMD.formatter = BMJFCBLOGBOBCPBJPD.KOFHCLCBGPDDGENFNP.Instance.GetFormatter<T>();
			}

			// Token: 0x0400010A RID: 266
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x0200006F RID: 111
		private sealed class KOFHCLCBGPDDGENFNP : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001A6 RID: 422 RVA: 0x00002B7C File Offset: 0x00000D7C
			private KOFHCLCBGPDDGENFNP()
			{
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00003755 File Offset: 0x00001955
			public FLGKBGGCEAHKIBEKBN<PGGEBCAPENGLAKKAGC> GetFormatter<PGGEBCAPENGLAKKAGC>()
			{
				return BMJFCBLOGBOBCPBJPD<PGGEBCAPENGLAKKAGC>.KOFHCLCBGPDDGENFNP.KOPAHJIGAOIPEEBIBJ.formatter;
			}

			// Token: 0x0400010B RID: 267
			public static readonly LMCMANMFGJGJFPNBEN Instance = new BMJFCBLOGBOBCPBJPD.KOFHCLCBGPDDGENFNP();

			// Token: 0x0400010C RID: 268
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.SnakeCase
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000070 RID: 112
			private static class KOPAHJIGAOIPEEBIBJ<T>
			{
				// Token: 0x060001A9 RID: 425 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
				static KOPAHJIGAOIPEEBIBJ()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = BMJFCBLOGBOBCPBJPD.KOFHCLCBGPDDGENFNP.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							BMJFCBLOGBOBCPBJPD<T>.KOFHCLCBGPDDGENFNP.KOPAHJIGAOIPEEBIBJ.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x0400010D RID: 269
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

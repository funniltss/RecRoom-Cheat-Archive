using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000079 RID: 121
	internal sealed class GOJFAPFDIABJIEFNFD : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00002B7C File Offset: 0x00000D7C
		private GOJFAPFDIABJIEFNFD()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000038C2 File Offset: 0x00001AC2
		public FLGKBGGCEAHKIBEKBN<PLDOBFNOCALHFEOHMM> GetFormatter<PLDOBFNOCALHFEOHMM>()
		{
			return GOJFAPFDIABJIEFNFD<PLDOBFNOCALHFEOHMM>.DMHJICIABGOIHCPLAG.formatter;
		}

		// Token: 0x0400011A RID: 282
		public static readonly LMCMANMFGJGJFPNBEN Instance = new GOJFAPFDIABJIEFNFD();

		// Token: 0x0400011B RID: 283
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			GOJFAPFDIABJIEFNFD.HPGFIMKCEBBCIOHDHC.Instance
		});

		// Token: 0x0200007A RID: 122
		private static class DMHJICIABGOIHCPLAG<T>
		{
			// Token: 0x060001BD RID: 445 RVA: 0x000038ED File Offset: 0x00001AED
			static DMHJICIABGOIHCPLAG()
			{
				if (typeof(T) == typeof(object))
				{
					GOJFAPFDIABJIEFNFD<T>.DMHJICIABGOIHCPLAG.formatter = (FLGKBGGCEAHKIBEKBN<T>)GOJFAPFDIABJIEFNFD.fallbackFormatter;
					return;
				}
				GOJFAPFDIABJIEFNFD<T>.DMHJICIABGOIHCPLAG.formatter = GOJFAPFDIABJIEFNFD.HPGFIMKCEBBCIOHDHC.Instance.GetFormatter<T>();
			}

			// Token: 0x0400011C RID: 284
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x0200007B RID: 123
		private sealed class HPGFIMKCEBBCIOHDHC : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001BE RID: 446 RVA: 0x00002B7C File Offset: 0x00000D7C
			private HPGFIMKCEBBCIOHDHC()
			{
			}

			// Token: 0x060001BF RID: 447 RVA: 0x00003929 File Offset: 0x00001B29
			public FLGKBGGCEAHKIBEKBN<NECKPAINPGFDGNDCGA> GetFormatter<NECKPAINPGFDGNDCGA>()
			{
				return GOJFAPFDIABJIEFNFD<NECKPAINPGFDGNDCGA>.HPGFIMKCEBBCIOHDHC.NANEBODIMCKOCNNDPM.formatter;
			}

			// Token: 0x0400011D RID: 285
			public static readonly LMCMANMFGJGJFPNBEN Instance = new GOJFAPFDIABJIEFNFD.HPGFIMKCEBBCIOHDHC();

			// Token: 0x0400011E RID: 286
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.ExcludeNullSnakeCase
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x0200007C RID: 124
			private static class NANEBODIMCKOCNNDPM<T>
			{
				// Token: 0x060001C1 RID: 449 RVA: 0x0000D240 File Offset: 0x0000B440
				static NANEBODIMCKOCNNDPM()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = GOJFAPFDIABJIEFNFD.HPGFIMKCEBBCIOHDHC.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							GOJFAPFDIABJIEFNFD<T>.HPGFIMKCEBBCIOHDHC.NANEBODIMCKOCNNDPM.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x0400011F RID: 287
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

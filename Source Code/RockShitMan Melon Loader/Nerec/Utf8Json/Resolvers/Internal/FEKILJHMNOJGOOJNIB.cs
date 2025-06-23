using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000075 RID: 117
	internal sealed class FEKILJHMNOJGOOJNIB : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00002B7C File Offset: 0x00000D7C
		private FEKILJHMNOJGOOJNIB()
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00003826 File Offset: 0x00001A26
		public FLGKBGGCEAHKIBEKBN<LFNPOMJJKKGMCGBHNO> GetFormatter<LFNPOMJJKKGMCGBHNO>()
		{
			return FEKILJHMNOJGOOJNIB<LFNPOMJJKKGMCGBHNO>.JNIOBEJEKNFDIOHCMF.formatter;
		}

		// Token: 0x04000114 RID: 276
		public static readonly LMCMANMFGJGJFPNBEN Instance = new FEKILJHMNOJGOOJNIB();

		// Token: 0x04000115 RID: 277
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			FEKILJHMNOJGOOJNIB.CEDPMMHMBBDOPDLDAD.Instance
		});

		// Token: 0x02000076 RID: 118
		private static class JNIOBEJEKNFDIOHCMF<T>
		{
			// Token: 0x060001B5 RID: 437 RVA: 0x00003851 File Offset: 0x00001A51
			static JNIOBEJEKNFDIOHCMF()
			{
				if (typeof(T) == typeof(object))
				{
					FEKILJHMNOJGOOJNIB<T>.JNIOBEJEKNFDIOHCMF.formatter = (FLGKBGGCEAHKIBEKBN<T>)FEKILJHMNOJGOOJNIB.fallbackFormatter;
					return;
				}
				FEKILJHMNOJGOOJNIB<T>.JNIOBEJEKNFDIOHCMF.formatter = FEKILJHMNOJGOOJNIB.CEDPMMHMBBDOPDLDAD.Instance.GetFormatter<T>();
			}

			// Token: 0x04000116 RID: 278
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x02000077 RID: 119
		private sealed class CEDPMMHMBBDOPDLDAD : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001B6 RID: 438 RVA: 0x00002B7C File Offset: 0x00000D7C
			private CEDPMMHMBBDOPDLDAD()
			{
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x0000388D File Offset: 0x00001A8D
			public FLGKBGGCEAHKIBEKBN<NHLEHIPHPIINPEMAGE> GetFormatter<NHLEHIPHPIINPEMAGE>()
			{
				return FEKILJHMNOJGOOJNIB<NHLEHIPHPIINPEMAGE>.CEDPMMHMBBDOPDLDAD.BPHCLFCENGMCMJKAHN.formatter;
			}

			// Token: 0x04000117 RID: 279
			public static readonly LMCMANMFGJGJFPNBEN Instance = new FEKILJHMNOJGOOJNIB.CEDPMMHMBBDOPDLDAD();

			// Token: 0x04000118 RID: 280
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.ExcludeNullCamelCase
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000078 RID: 120
			private static class BPHCLFCENGMCMJKAHN<T>
			{
				// Token: 0x060001B9 RID: 441 RVA: 0x0000D20C File Offset: 0x0000B40C
				static BPHCLFCENGMCMJKAHN()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = FEKILJHMNOJGOOJNIB.CEDPMMHMBBDOPDLDAD.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							FEKILJHMNOJGOOJNIB<T>.CEDPMMHMBBDOPDLDAD.BPHCLFCENGMCMJKAHN.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x04000119 RID: 281
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

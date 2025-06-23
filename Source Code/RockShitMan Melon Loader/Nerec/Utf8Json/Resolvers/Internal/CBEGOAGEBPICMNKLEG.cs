using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000089 RID: 137
	internal sealed class CBEGOAGEBPICMNKLEG : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001DA RID: 474 RVA: 0x00002B7C File Offset: 0x00000D7C
		private CBEGOAGEBPICMNKLEG()
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00003B32 File Offset: 0x00001D32
		public FLGKBGGCEAHKIBEKBN<NCCLDBEFMPNICPGODP> GetFormatter<NCCLDBEFMPNICPGODP>()
		{
			return CBEGOAGEBPICMNKLEG<NCCLDBEFMPNICPGODP>.MLGJICKIPGAFOJHFIF.formatter;
		}

		// Token: 0x04000132 RID: 306
		public static readonly LMCMANMFGJGJFPNBEN Instance = new CBEGOAGEBPICMNKLEG();

		// Token: 0x04000133 RID: 307
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			CBEGOAGEBPICMNKLEG.PPAMHMEFIIKAOBEHIH.Instance
		});

		// Token: 0x0200008A RID: 138
		private static class MLGJICKIPGAFOJHFIF<T>
		{
			// Token: 0x060001DD RID: 477 RVA: 0x00003B5D File Offset: 0x00001D5D
			static MLGJICKIPGAFOJHFIF()
			{
				if (typeof(T) == typeof(object))
				{
					CBEGOAGEBPICMNKLEG<T>.MLGJICKIPGAFOJHFIF.formatter = (FLGKBGGCEAHKIBEKBN<T>)CBEGOAGEBPICMNKLEG.fallbackFormatter;
					return;
				}
				CBEGOAGEBPICMNKLEG<T>.MLGJICKIPGAFOJHFIF.formatter = CBEGOAGEBPICMNKLEG.PPAMHMEFIIKAOBEHIH.Instance.GetFormatter<T>();
			}

			// Token: 0x04000134 RID: 308
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x0200008B RID: 139
		private sealed class PPAMHMEFIIKAOBEHIH : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001DE RID: 478 RVA: 0x00002B7C File Offset: 0x00000D7C
			private PPAMHMEFIIKAOBEHIH()
			{
			}

			// Token: 0x060001DF RID: 479 RVA: 0x00003B99 File Offset: 0x00001D99
			public FLGKBGGCEAHKIBEKBN<MEIAKAMNOHGNPIEKMD> GetFormatter<MEIAKAMNOHGNPIEKMD>()
			{
				return CBEGOAGEBPICMNKLEG<MEIAKAMNOHGNPIEKMD>.PPAMHMEFIIKAOBEHIH.OCEGHKKCNHFAFOJPDG.formatter;
			}

			// Token: 0x04000135 RID: 309
			public static readonly LMCMANMFGJGJFPNBEN Instance = new CBEGOAGEBPICMNKLEG.PPAMHMEFIIKAOBEHIH();

			// Token: 0x04000136 RID: 310
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.AllowPrivateExcludeNull
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x0200008C RID: 140
			private static class OCEGHKKCNHFAFOJPDG<T>
			{
				// Token: 0x060001E1 RID: 481 RVA: 0x0000D310 File Offset: 0x0000B510
				static OCEGHKKCNHFAFOJPDG()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = CBEGOAGEBPICMNKLEG.PPAMHMEFIIKAOBEHIH.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							CBEGOAGEBPICMNKLEG<T>.PPAMHMEFIIKAOBEHIH.OCEGHKKCNHFAFOJPDG.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x04000137 RID: 311
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

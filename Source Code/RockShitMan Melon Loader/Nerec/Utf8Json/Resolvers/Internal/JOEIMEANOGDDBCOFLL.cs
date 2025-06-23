using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000091 RID: 145
	internal sealed class JOEIMEANOGDDBCOFLL : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001EA RID: 490 RVA: 0x00002B7C File Offset: 0x00000D7C
		private JOEIMEANOGDDBCOFLL()
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00003C6A File Offset: 0x00001E6A
		public FLGKBGGCEAHKIBEKBN<KPCOEKJLADLNKAAFMC> GetFormatter<KPCOEKJLADLNKAAFMC>()
		{
			return JOEIMEANOGDDBCOFLL<KPCOEKJLADLNKAAFMC>.NHGBIFHCIJOFJODCCE.formatter;
		}

		// Token: 0x0400013E RID: 318
		public static readonly LMCMANMFGJGJFPNBEN Instance = new JOEIMEANOGDDBCOFLL();

		// Token: 0x0400013F RID: 319
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			JOEIMEANOGDDBCOFLL.ACOCCLMAMIFNIPAEKC.Instance
		});

		// Token: 0x02000092 RID: 146
		private static class NHGBIFHCIJOFJODCCE<T>
		{
			// Token: 0x060001ED RID: 493 RVA: 0x00003C95 File Offset: 0x00001E95
			static NHGBIFHCIJOFJODCCE()
			{
				if (typeof(T) == typeof(object))
				{
					JOEIMEANOGDDBCOFLL<T>.NHGBIFHCIJOFJODCCE.formatter = (FLGKBGGCEAHKIBEKBN<T>)JOEIMEANOGDDBCOFLL.fallbackFormatter;
					return;
				}
				JOEIMEANOGDDBCOFLL<T>.NHGBIFHCIJOFJODCCE.formatter = JOEIMEANOGDDBCOFLL.ACOCCLMAMIFNIPAEKC.Instance.GetFormatter<T>();
			}

			// Token: 0x04000140 RID: 320
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x02000093 RID: 147
		private sealed class ACOCCLMAMIFNIPAEKC : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001EE RID: 494 RVA: 0x00002B7C File Offset: 0x00000D7C
			private ACOCCLMAMIFNIPAEKC()
			{
			}

			// Token: 0x060001EF RID: 495 RVA: 0x00003CD1 File Offset: 0x00001ED1
			public FLGKBGGCEAHKIBEKBN<NKAAJCKHAIKCBLBAGL> GetFormatter<NKAAJCKHAIKCBLBAGL>()
			{
				return JOEIMEANOGDDBCOFLL<NKAAJCKHAIKCBLBAGL>.ACOCCLMAMIFNIPAEKC.LPILPODMBBKHPJEKEO.formatter;
			}

			// Token: 0x04000141 RID: 321
			public static readonly LMCMANMFGJGJFPNBEN Instance = new JOEIMEANOGDDBCOFLL.ACOCCLMAMIFNIPAEKC();

			// Token: 0x04000142 RID: 322
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.AllowPrivateExcludeNullSnakeCase
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000094 RID: 148
			private static class LPILPODMBBKHPJEKEO<T>
			{
				// Token: 0x060001F1 RID: 497 RVA: 0x0000D378 File Offset: 0x0000B578
				static LPILPODMBBKHPJEKEO()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = JOEIMEANOGDDBCOFLL.ACOCCLMAMIFNIPAEKC.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							JOEIMEANOGDDBCOFLL<T>.ACOCCLMAMIFNIPAEKC.LPILPODMBBKHPJEKEO.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x04000143 RID: 323
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000069 RID: 105
	internal sealed class GEPLMBKCJOBHPHHPNH : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00002B7C File Offset: 0x00000D7C
		private GEPLMBKCJOBHPHHPNH()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00003652 File Offset: 0x00001852
		public FLGKBGGCEAHKIBEKBN<BNLEFKHHEPPEPGBIJD> GetFormatter<BNLEFKHHEPPEPGBIJD>()
		{
			return GEPLMBKCJOBHPHHPNH<BNLEFKHHEPPEPGBIJD>.GAHMNHBMGEALFBCBOK.formatter;
		}

		// Token: 0x04000102 RID: 258
		public static readonly LMCMANMFGJGJFPNBEN Instance = new GEPLMBKCJOBHPHHPNH();

		// Token: 0x04000103 RID: 259
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			GEPLMBKCJOBHPHHPNH.IONMBAGMAOMOEOMALC.Instance
		});

		// Token: 0x0200006A RID: 106
		private static class GAHMNHBMGEALFBCBOK<T>
		{
			// Token: 0x0600019D RID: 413 RVA: 0x0000367D File Offset: 0x0000187D
			static GAHMNHBMGEALFBCBOK()
			{
				if (typeof(T) == typeof(object))
				{
					GEPLMBKCJOBHPHHPNH<T>.GAHMNHBMGEALFBCBOK.formatter = (FLGKBGGCEAHKIBEKBN<T>)GEPLMBKCJOBHPHHPNH.fallbackFormatter;
					return;
				}
				GEPLMBKCJOBHPHHPNH<T>.GAHMNHBMGEALFBCBOK.formatter = GEPLMBKCJOBHPHHPNH.IONMBAGMAOMOEOMALC.Instance.GetFormatter<T>();
			}

			// Token: 0x04000104 RID: 260
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x0200006B RID: 107
		private sealed class IONMBAGMAOMOEOMALC : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x0600019E RID: 414 RVA: 0x00002B7C File Offset: 0x00000D7C
			private IONMBAGMAOMOEOMALC()
			{
			}

			// Token: 0x0600019F RID: 415 RVA: 0x000036B9 File Offset: 0x000018B9
			public FLGKBGGCEAHKIBEKBN<LNJNHKIGKEPDBFLCHJ> GetFormatter<LNJNHKIGKEPDBFLCHJ>()
			{
				return GEPLMBKCJOBHPHHPNH<LNJNHKIGKEPDBFLCHJ>.IONMBAGMAOMOEOMALC.MAPLALFAKAIJMIBMHK.formatter;
			}

			// Token: 0x04000105 RID: 261
			public static readonly LMCMANMFGJGJFPNBEN Instance = new GEPLMBKCJOBHPHHPNH.IONMBAGMAOMOEOMALC();

			// Token: 0x04000106 RID: 262
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.CamelCase
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x0200006C RID: 108
			private static class MAPLALFAKAIJMIBMHK<T>
			{
				// Token: 0x060001A1 RID: 417 RVA: 0x0000D170 File Offset: 0x0000B370
				static MAPLALFAKAIJMIBMHK()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = GEPLMBKCJOBHPHHPNH.IONMBAGMAOMOEOMALC.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							GEPLMBKCJOBHPHHPNH<T>.IONMBAGMAOMOEOMALC.MAPLALFAKAIJMIBMHK.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x04000107 RID: 263
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

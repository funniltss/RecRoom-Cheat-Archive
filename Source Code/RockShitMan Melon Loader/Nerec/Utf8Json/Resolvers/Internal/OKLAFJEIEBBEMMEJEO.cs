using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000071 RID: 113
	internal sealed class OKLAFJEIEBBEMMEJEO : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00002B7C File Offset: 0x00000D7C
		private OKLAFJEIEBBEMMEJEO()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000378A File Offset: 0x0000198A
		public FLGKBGGCEAHKIBEKBN<DBDIHGIHKEDKPDGJGI> GetFormatter<DBDIHGIHKEDKPDGJGI>()
		{
			return OKLAFJEIEBBEMMEJEO<DBDIHGIHKEDKPDGJGI>.HGEABLBHMIOEPCENDA.formatter;
		}

		// Token: 0x0400010E RID: 270
		public static readonly LMCMANMFGJGJFPNBEN Instance = new OKLAFJEIEBBEMMEJEO();

		// Token: 0x0400010F RID: 271
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			OKLAFJEIEBBEMMEJEO.NOCFOLJJGMMJOAAHJP.Instance
		});

		// Token: 0x02000072 RID: 114
		private static class HGEABLBHMIOEPCENDA<T>
		{
			// Token: 0x060001AD RID: 429 RVA: 0x000037B5 File Offset: 0x000019B5
			static HGEABLBHMIOEPCENDA()
			{
				if (typeof(T) == typeof(object))
				{
					OKLAFJEIEBBEMMEJEO<T>.HGEABLBHMIOEPCENDA.formatter = (FLGKBGGCEAHKIBEKBN<T>)OKLAFJEIEBBEMMEJEO.fallbackFormatter;
					return;
				}
				OKLAFJEIEBBEMMEJEO<T>.HGEABLBHMIOEPCENDA.formatter = OKLAFJEIEBBEMMEJEO.NOCFOLJJGMMJOAAHJP.Instance.GetFormatter<T>();
			}

			// Token: 0x04000110 RID: 272
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x02000073 RID: 115
		private sealed class NOCFOLJJGMMJOAAHJP : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001AE RID: 430 RVA: 0x00002B7C File Offset: 0x00000D7C
			private NOCFOLJJGMMJOAAHJP()
			{
			}

			// Token: 0x060001AF RID: 431 RVA: 0x000037F1 File Offset: 0x000019F1
			public FLGKBGGCEAHKIBEKBN<DJDBJKIMKFPCDBNPFP> GetFormatter<DJDBJKIMKFPCDBNPFP>()
			{
				return OKLAFJEIEBBEMMEJEO<DJDBJKIMKFPCDBNPFP>.NOCFOLJJGMMJOAAHJP.DLDFAFIPHCLINFKJKD.formatter;
			}

			// Token: 0x04000111 RID: 273
			public static readonly LMCMANMFGJGJFPNBEN Instance = new OKLAFJEIEBBEMMEJEO.NOCFOLJJGMMJOAAHJP();

			// Token: 0x04000112 RID: 274
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.ExcludeNull
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000074 RID: 116
			private static class DLDFAFIPHCLINFKJKD<T>
			{
				// Token: 0x060001B1 RID: 433 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
				static DLDFAFIPHCLINFKJKD()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = OKLAFJEIEBBEMMEJEO.NOCFOLJJGMMJOAAHJP.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							OKLAFJEIEBBEMMEJEO<T>.NOCFOLJJGMMJOAAHJP.DLDFAFIPHCLINFKJKD.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x04000113 RID: 275
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

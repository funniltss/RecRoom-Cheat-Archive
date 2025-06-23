using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000085 RID: 133
	internal sealed class PFAPACLHMFAFCKANEO : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00002B7C File Offset: 0x00000D7C
		private PFAPACLHMFAFCKANEO()
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00003A96 File Offset: 0x00001C96
		public FLGKBGGCEAHKIBEKBN<BMLMELPHNNFBCABBGC> GetFormatter<BMLMELPHNNFBCABBGC>()
		{
			return PFAPACLHMFAFCKANEO<BMLMELPHNNFBCABBGC>.OKJNGFOPMNBPCNHCPG.formatter;
		}

		// Token: 0x0400012C RID: 300
		public static readonly LMCMANMFGJGJFPNBEN Instance = new PFAPACLHMFAFCKANEO();

		// Token: 0x0400012D RID: 301
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			PFAPACLHMFAFCKANEO.CAGIPOGNMJKCIOENOF.Instance
		});

		// Token: 0x02000086 RID: 134
		private static class OKJNGFOPMNBPCNHCPG<T>
		{
			// Token: 0x060001D5 RID: 469 RVA: 0x00003AC1 File Offset: 0x00001CC1
			static OKJNGFOPMNBPCNHCPG()
			{
				if (typeof(T) == typeof(object))
				{
					PFAPACLHMFAFCKANEO<T>.OKJNGFOPMNBPCNHCPG.formatter = (FLGKBGGCEAHKIBEKBN<T>)PFAPACLHMFAFCKANEO.fallbackFormatter;
					return;
				}
				PFAPACLHMFAFCKANEO<T>.OKJNGFOPMNBPCNHCPG.formatter = PFAPACLHMFAFCKANEO.CAGIPOGNMJKCIOENOF.Instance.GetFormatter<T>();
			}

			// Token: 0x0400012E RID: 302
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x02000087 RID: 135
		private sealed class CAGIPOGNMJKCIOENOF : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001D6 RID: 470 RVA: 0x00002B7C File Offset: 0x00000D7C
			private CAGIPOGNMJKCIOENOF()
			{
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x00003AFD File Offset: 0x00001CFD
			public FLGKBGGCEAHKIBEKBN<MKILEAKDICCCILJBLM> GetFormatter<MKILEAKDICCCILJBLM>()
			{
				return PFAPACLHMFAFCKANEO<MKILEAKDICCCILJBLM>.CAGIPOGNMJKCIOENOF.INNPCPHDAJHKPKIIOE.formatter;
			}

			// Token: 0x0400012F RID: 303
			public static readonly LMCMANMFGJGJFPNBEN Instance = new PFAPACLHMFAFCKANEO.CAGIPOGNMJKCIOENOF();

			// Token: 0x04000130 RID: 304
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.AllowPrivateSnakeCase
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000088 RID: 136
			private static class INNPCPHDAJHKPKIIOE<T>
			{
				// Token: 0x060001D9 RID: 473 RVA: 0x0000D2DC File Offset: 0x0000B4DC
				static INNPCPHDAJHKPKIIOE()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = PFAPACLHMFAFCKANEO.CAGIPOGNMJKCIOENOF.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							PFAPACLHMFAFCKANEO<T>.CAGIPOGNMJKCIOENOF.INNPCPHDAJHKPKIIOE.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x04000131 RID: 305
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

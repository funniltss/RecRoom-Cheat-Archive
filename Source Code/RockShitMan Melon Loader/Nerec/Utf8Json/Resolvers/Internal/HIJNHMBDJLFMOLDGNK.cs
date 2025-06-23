using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200008D RID: 141
	internal sealed class HIJNHMBDJLFMOLDGNK : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00002B7C File Offset: 0x00000D7C
		private HIJNHMBDJLFMOLDGNK()
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003BCE File Offset: 0x00001DCE
		public FLGKBGGCEAHKIBEKBN<FGCDHOBJMBNJBEJCJD> GetFormatter<FGCDHOBJMBNJBEJCJD>()
		{
			return HIJNHMBDJLFMOLDGNK<FGCDHOBJMBNJBEJCJD>.GNJOKOGFOIANIBMEGC.formatter;
		}

		// Token: 0x04000138 RID: 312
		public static readonly LMCMANMFGJGJFPNBEN Instance = new HIJNHMBDJLFMOLDGNK();

		// Token: 0x04000139 RID: 313
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			HIJNHMBDJLFMOLDGNK.NAEJFODCLIAMPFHMLL.Instance
		});

		// Token: 0x0200008E RID: 142
		private static class GNJOKOGFOIANIBMEGC<T>
		{
			// Token: 0x060001E5 RID: 485 RVA: 0x00003BF9 File Offset: 0x00001DF9
			static GNJOKOGFOIANIBMEGC()
			{
				if (typeof(T) == typeof(object))
				{
					HIJNHMBDJLFMOLDGNK<T>.GNJOKOGFOIANIBMEGC.formatter = (FLGKBGGCEAHKIBEKBN<T>)HIJNHMBDJLFMOLDGNK.fallbackFormatter;
					return;
				}
				HIJNHMBDJLFMOLDGNK<T>.GNJOKOGFOIANIBMEGC.formatter = HIJNHMBDJLFMOLDGNK.NAEJFODCLIAMPFHMLL.Instance.GetFormatter<T>();
			}

			// Token: 0x0400013A RID: 314
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x0200008F RID: 143
		private sealed class NAEJFODCLIAMPFHMLL : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001E6 RID: 486 RVA: 0x00002B7C File Offset: 0x00000D7C
			private NAEJFODCLIAMPFHMLL()
			{
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00003C35 File Offset: 0x00001E35
			public FLGKBGGCEAHKIBEKBN<IADJINLPEFPFKCPKGG> GetFormatter<IADJINLPEFPFKCPKGG>()
			{
				return HIJNHMBDJLFMOLDGNK<IADJINLPEFPFKCPKGG>.NAEJFODCLIAMPFHMLL.LGBKCLHLPKHOPLNGJM.formatter;
			}

			// Token: 0x0400013B RID: 315
			public static readonly LMCMANMFGJGJFPNBEN Instance = new HIJNHMBDJLFMOLDGNK.NAEJFODCLIAMPFHMLL();

			// Token: 0x0400013C RID: 316
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.AllowPrivateExcludeNullCamelCase
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000090 RID: 144
			private static class LGBKCLHLPKHOPLNGJM<T>
			{
				// Token: 0x060001E9 RID: 489 RVA: 0x0000D344 File Offset: 0x0000B544
				static LGBKCLHLPKHOPLNGJM()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = HIJNHMBDJLFMOLDGNK.NAEJFODCLIAMPFHMLL.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							HIJNHMBDJLFMOLDGNK<T>.NAEJFODCLIAMPFHMLL.LGBKCLHLPKHOPLNGJM.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x0400013D RID: 317
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

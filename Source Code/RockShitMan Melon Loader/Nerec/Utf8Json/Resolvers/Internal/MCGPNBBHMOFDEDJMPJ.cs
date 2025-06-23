using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000081 RID: 129
	internal sealed class MCGPNBBHMOFDEDJMPJ : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00002B7C File Offset: 0x00000D7C
		private MCGPNBBHMOFDEDJMPJ()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000039FA File Offset: 0x00001BFA
		public FLGKBGGCEAHKIBEKBN<IOGMODEFLCILDDCKGC> GetFormatter<IOGMODEFLCILDDCKGC>()
		{
			return MCGPNBBHMOFDEDJMPJ<IOGMODEFLCILDDCKGC>.LNAFKKDFKMMAJDMNAN.formatter;
		}

		// Token: 0x04000126 RID: 294
		public static readonly LMCMANMFGJGJFPNBEN Instance = new MCGPNBBHMOFDEDJMPJ();

		// Token: 0x04000127 RID: 295
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			MCGPNBBHMOFDEDJMPJ.BIJLPDEECHNAKPGEEA.Instance
		});

		// Token: 0x02000082 RID: 130
		private static class LNAFKKDFKMMAJDMNAN<T>
		{
			// Token: 0x060001CD RID: 461 RVA: 0x00003A25 File Offset: 0x00001C25
			static LNAFKKDFKMMAJDMNAN()
			{
				if (typeof(T) == typeof(object))
				{
					MCGPNBBHMOFDEDJMPJ<T>.LNAFKKDFKMMAJDMNAN.formatter = (FLGKBGGCEAHKIBEKBN<T>)MCGPNBBHMOFDEDJMPJ.fallbackFormatter;
					return;
				}
				MCGPNBBHMOFDEDJMPJ<T>.LNAFKKDFKMMAJDMNAN.formatter = MCGPNBBHMOFDEDJMPJ.BIJLPDEECHNAKPGEEA.Instance.GetFormatter<T>();
			}

			// Token: 0x04000128 RID: 296
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x02000083 RID: 131
		private sealed class BIJLPDEECHNAKPGEEA : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001CE RID: 462 RVA: 0x00002B7C File Offset: 0x00000D7C
			private BIJLPDEECHNAKPGEEA()
			{
			}

			// Token: 0x060001CF RID: 463 RVA: 0x00003A61 File Offset: 0x00001C61
			public FLGKBGGCEAHKIBEKBN<ONMFAJGIOFGHJDLKCN> GetFormatter<ONMFAJGIOFGHJDLKCN>()
			{
				return MCGPNBBHMOFDEDJMPJ<ONMFAJGIOFGHJDLKCN>.BIJLPDEECHNAKPGEEA.JILGKGPOJLAGAABIBL.formatter;
			}

			// Token: 0x04000129 RID: 297
			public static readonly LMCMANMFGJGJFPNBEN Instance = new MCGPNBBHMOFDEDJMPJ.BIJLPDEECHNAKPGEEA();

			// Token: 0x0400012A RID: 298
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.AllowPrivateCamelCase
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000084 RID: 132
			private static class JILGKGPOJLAGAABIBL<T>
			{
				// Token: 0x060001D1 RID: 465 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
				static JILGKGPOJLAGAABIBL()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = MCGPNBBHMOFDEDJMPJ.BIJLPDEECHNAKPGEEA.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							MCGPNBBHMOFDEDJMPJ<T>.BIJLPDEECHNAKPGEEA.JILGKGPOJLAGAABIBL.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x0400012B RID: 299
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200007D RID: 125
	internal sealed class IKLNHMGIHFIGKJOOFN : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00002B7C File Offset: 0x00000D7C
		private IKLNHMGIHFIGKJOOFN()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000395E File Offset: 0x00001B5E
		public FLGKBGGCEAHKIBEKBN<FFAIJJJPOHNHALNKKN> GetFormatter<FFAIJJJPOHNHALNKKN>()
		{
			return IKLNHMGIHFIGKJOOFN<FFAIJJJPOHNHALNKKN>.CNPGHOEOHCCMKNICJG.formatter;
		}

		// Token: 0x04000120 RID: 288
		public static readonly LMCMANMFGJGJFPNBEN Instance = new IKLNHMGIHFIGKJOOFN();

		// Token: 0x04000121 RID: 289
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			IKLNHMGIHFIGKJOOFN.PODPBHMJMJMLKFJGPF.Instance
		});

		// Token: 0x0200007E RID: 126
		private static class CNPGHOEOHCCMKNICJG<T>
		{
			// Token: 0x060001C5 RID: 453 RVA: 0x00003989 File Offset: 0x00001B89
			static CNPGHOEOHCCMKNICJG()
			{
				if (typeof(T) == typeof(object))
				{
					IKLNHMGIHFIGKJOOFN<T>.CNPGHOEOHCCMKNICJG.formatter = (FLGKBGGCEAHKIBEKBN<T>)IKLNHMGIHFIGKJOOFN.fallbackFormatter;
					return;
				}
				IKLNHMGIHFIGKJOOFN<T>.CNPGHOEOHCCMKNICJG.formatter = IKLNHMGIHFIGKJOOFN.PODPBHMJMJMLKFJGPF.Instance.GetFormatter<T>();
			}

			// Token: 0x04000122 RID: 290
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x0200007F RID: 127
		private sealed class PODPBHMJMJMLKFJGPF : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x060001C6 RID: 454 RVA: 0x00002B7C File Offset: 0x00000D7C
			private PODPBHMJMJMLKFJGPF()
			{
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x000039C5 File Offset: 0x00001BC5
			public FLGKBGGCEAHKIBEKBN<LGAPHBGNNJINFGPHBF> GetFormatter<LGAPHBGNNJINFGPHBF>()
			{
				return IKLNHMGIHFIGKJOOFN<LGAPHBGNNJINFGPHBF>.PODPBHMJMJMLKFJGPF.HMCGHNHLHPBMJPFNNN.formatter;
			}

			// Token: 0x04000123 RID: 291
			public static readonly LMCMANMFGJGJFPNBEN Instance = new IKLNHMGIHFIGKJOOFN.PODPBHMJMJMLKFJGPF();

			// Token: 0x04000124 RID: 292
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.AllowPrivate
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000080 RID: 128
			private static class HMCGHNHLHPBMJPFNNN<T>
			{
				// Token: 0x060001C9 RID: 457 RVA: 0x0000D274 File Offset: 0x0000B474
				static HMCGHNHLHPBMJPFNNN()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = IKLNHMGIHFIGKJOOFN.PODPBHMJMJMLKFJGPF.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							IKLNHMGIHFIGKJOOFN<T>.PODPBHMJMJMLKFJGPF.HMCGHNHLHPBMJPFNNN.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x04000125 RID: 293
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

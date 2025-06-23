using System;
using System.Linq;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000065 RID: 101
	internal sealed class JFKPDJJLAGELHJIPGA : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00002B7C File Offset: 0x00000D7C
		private JFKPDJJLAGELHJIPGA()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000035B6 File Offset: 0x000017B6
		public FLGKBGGCEAHKIBEKBN<MHABNJBKNFDMFIBFDC> GetFormatter<MHABNJBKNFDMFIBFDC>()
		{
			return JFKPDJJLAGELHJIPGA<MHABNJBKNFDMFIBFDC>.BENAAJHNIJHKGMFHAK.formatter;
		}

		// Token: 0x040000FC RID: 252
		public static readonly LMCMANMFGJGJFPNBEN Instance = new JFKPDJJLAGELHJIPGA();

		// Token: 0x040000FD RID: 253
		private static readonly FLGKBGGCEAHKIBEKBN<object> fallbackFormatter = new OPFOEFBJDEGNOONJBD(new LMCMANMFGJGJFPNBEN[]
		{
			JFKPDJJLAGELHJIPGA.KFIPBBOFJJIONDIPIE.Instance
		});

		// Token: 0x02000066 RID: 102
		private static class BENAAJHNIJHKGMFHAK<T>
		{
			// Token: 0x06000195 RID: 405 RVA: 0x000035E1 File Offset: 0x000017E1
			static BENAAJHNIJHKGMFHAK()
			{
				if (typeof(T) == typeof(object))
				{
					JFKPDJJLAGELHJIPGA<T>.BENAAJHNIJHKGMFHAK.formatter = (FLGKBGGCEAHKIBEKBN<T>)JFKPDJJLAGELHJIPGA.fallbackFormatter;
					return;
				}
				JFKPDJJLAGELHJIPGA<T>.BENAAJHNIJHKGMFHAK.formatter = JFKPDJJLAGELHJIPGA.KFIPBBOFJJIONDIPIE.Instance.GetFormatter<T>();
			}

			// Token: 0x040000FE RID: 254
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}

		// Token: 0x02000067 RID: 103
		private sealed class KFIPBBOFJJIONDIPIE : LMCMANMFGJGJFPNBEN
		{
			// Token: 0x06000196 RID: 406 RVA: 0x00002B7C File Offset: 0x00000D7C
			private KFIPBBOFJJIONDIPIE()
			{
			}

			// Token: 0x06000197 RID: 407 RVA: 0x0000361D File Offset: 0x0000181D
			public FLGKBGGCEAHKIBEKBN<MBGDBLMBPOBALCCHEL> GetFormatter<MBGDBLMBPOBALCCHEL>()
			{
				return JFKPDJJLAGELHJIPGA<MBGDBLMBPOBALCCHEL>.KFIPBBOFJJIONDIPIE.KDMNEPHEHMHOLCLOPI.formatter;
			}

			// Token: 0x040000FF RID: 255
			public static readonly LMCMANMFGJGJFPNBEN Instance = new JFKPDJJLAGELHJIPGA.KFIPBBOFJJIONDIPIE();

			// Token: 0x04000100 RID: 256
			private static readonly LMCMANMFGJGJFPNBEN[] resolvers = JEDCOLEOGMFNOGKCIB.CompositeResolverBase.Concat(new LMCMANMFGJGJFPNBEN[]
			{
				NPFADGFOHJFOELJADB.Default
			}).ToArray<LMCMANMFGJGJFPNBEN>();

			// Token: 0x02000068 RID: 104
			private static class KDMNEPHEHMHOLCLOPI<T>
			{
				// Token: 0x06000199 RID: 409 RVA: 0x0000D13C File Offset: 0x0000B33C
				static KDMNEPHEHMHOLCLOPI()
				{
					LMCMANMFGJGJFPNBEN[] resolvers = JFKPDJJLAGELHJIPGA.KFIPBBOFJJIONDIPIE.resolvers;
					for (int i = 0; i < resolvers.Length; i++)
					{
						FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
						if (flgkbggceahkibekbn != null)
						{
							JFKPDJJLAGELHJIPGA<T>.KFIPBBOFJJIONDIPIE.KDMNEPHEHMHOLCLOPI.formatter = flgkbggceahkibekbn;
							return;
						}
					}
				}

				// Token: 0x04000101 RID: 257
				public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
			}
		}
	}
}

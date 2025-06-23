using System;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000043 RID: 67
	internal sealed class FLJEMOBMCNAAMDKMDA : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00003314 File Offset: 0x00001514
		public FLGKBGGCEAHKIBEKBN<NKIJKGKKGFDGNFEGIO> GetFormatter<NKIJKGKKGFDGNFEGIO>()
		{
			return FLJEMOBMCNAAMDKMDA<NKIJKGKKGFDGNFEGIO>.BIOKHECHEHNCAKABJG.formatter;
		}

		// Token: 0x0400009C RID: 156
		public static readonly LMCMANMFGJGJFPNBEN Instance = new FLJEMOBMCNAAMDKMDA();

		// Token: 0x0400009D RID: 157
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.ToSnakeCase);

		// Token: 0x0400009E RID: 158
		private static readonly bool excludeNull = true;

		// Token: 0x02000044 RID: 68
		private static class BIOKHECHEHNCAKABJG<T>
		{
			// Token: 0x0400009F RID: 159
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToDynamicMethod<T>(FLJEMOBMCNAAMDKMDA.Instance, FLJEMOBMCNAAMDKMDA.nameMutator, FLJEMOBMCNAAMDKMDA.excludeNull, true);
		}
	}
}

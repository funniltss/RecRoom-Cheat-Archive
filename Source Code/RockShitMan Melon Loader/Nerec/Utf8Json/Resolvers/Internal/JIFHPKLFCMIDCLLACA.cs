using System;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000041 RID: 65
	internal sealed class JIFHPKLFCMIDCLLACA : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x0600012C RID: 300 RVA: 0x000032C9 File Offset: 0x000014C9
		public FLGKBGGCEAHKIBEKBN<DFFEMGOGGIEKKDNNBM> GetFormatter<DFFEMGOGGIEKKDNNBM>()
		{
			return JIFHPKLFCMIDCLLACA<DFFEMGOGGIEKKDNNBM>.MHKHNPKKEDHNFGGNMH.formatter;
		}

		// Token: 0x04000098 RID: 152
		public static readonly LMCMANMFGJGJFPNBEN Instance = new JIFHPKLFCMIDCLLACA();

		// Token: 0x04000099 RID: 153
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.ToCamelCase);

		// Token: 0x0400009A RID: 154
		private static readonly bool excludeNull = true;

		// Token: 0x02000042 RID: 66
		private static class MHKHNPKKEDHNFGGNMH<T>
		{
			// Token: 0x0400009B RID: 155
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToDynamicMethod<T>(JIFHPKLFCMIDCLLACA.Instance, JIFHPKLFCMIDCLLACA.nameMutator, JIFHPKLFCMIDCLLACA.excludeNull, true);
		}
	}
}

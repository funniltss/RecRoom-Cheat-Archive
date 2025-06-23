using System;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200003D RID: 61
	internal sealed class LKKPPPDMDLGGJPADNG : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00003233 File Offset: 0x00001433
		public FLGKBGGCEAHKIBEKBN<OLIONHIIBPLFLHBIEN> GetFormatter<OLIONHIIBPLFLHBIEN>()
		{
			return LKKPPPDMDLGGJPADNG<OLIONHIIBPLFLHBIEN>.CEPAAMHEHJMILBHLNL.formatter;
		}

		// Token: 0x04000090 RID: 144
		public static readonly LMCMANMFGJGJFPNBEN Instance = new LKKPPPDMDLGGJPADNG();

		// Token: 0x04000091 RID: 145
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.ToSnakeCase);

		// Token: 0x04000092 RID: 146
		private static readonly bool excludeNull = false;

		// Token: 0x0200003E RID: 62
		private static class CEPAAMHEHJMILBHLNL<T>
		{
			// Token: 0x04000093 RID: 147
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToDynamicMethod<T>(LKKPPPDMDLGGJPADNG.Instance, LKKPPPDMDLGGJPADNG.nameMutator, LKKPPPDMDLGGJPADNG.excludeNull, true);
		}
	}
}

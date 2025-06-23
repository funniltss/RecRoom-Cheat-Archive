using System;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200003F RID: 63
	internal sealed class KMAPELJNNCLMJGCLAF : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000128 RID: 296 RVA: 0x0000327E File Offset: 0x0000147E
		public FLGKBGGCEAHKIBEKBN<OHPAHPJELIMIBKEKDF> GetFormatter<OHPAHPJELIMIBKEKDF>()
		{
			return KMAPELJNNCLMJGCLAF<OHPAHPJELIMIBKEKDF>.NEPFLDILBLEFMJNABJ.formatter;
		}

		// Token: 0x04000094 RID: 148
		public static readonly LMCMANMFGJGJFPNBEN Instance = new KMAPELJNNCLMJGCLAF();

		// Token: 0x04000095 RID: 149
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.Original);

		// Token: 0x04000096 RID: 150
		private static readonly bool excludeNull = true;

		// Token: 0x02000040 RID: 64
		private static class NEPFLDILBLEFMJNABJ<T>
		{
			// Token: 0x04000097 RID: 151
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToDynamicMethod<T>(KMAPELJNNCLMJGCLAF.Instance, KMAPELJNNCLMJGCLAF.nameMutator, KMAPELJNNCLMJGCLAF.excludeNull, true);
		}
	}
}

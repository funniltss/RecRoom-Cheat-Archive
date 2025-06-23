using System;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000039 RID: 57
	internal sealed class ANNOOAIAEFHIDFNMNG : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000319D File Offset: 0x0000139D
		public FLGKBGGCEAHKIBEKBN<COEPKOPJIHCBPPBKKI> GetFormatter<COEPKOPJIHCBPPBKKI>()
		{
			return ANNOOAIAEFHIDFNMNG<COEPKOPJIHCBPPBKKI>.JDOBJBCHBOMEMKGAIL.formatter;
		}

		// Token: 0x04000088 RID: 136
		public static readonly LMCMANMFGJGJFPNBEN Instance = new ANNOOAIAEFHIDFNMNG();

		// Token: 0x04000089 RID: 137
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.Original);

		// Token: 0x0400008A RID: 138
		private static readonly bool excludeNull = false;

		// Token: 0x0200003A RID: 58
		private static class JDOBJBCHBOMEMKGAIL<T>
		{
			// Token: 0x0400008B RID: 139
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToDynamicMethod<T>(ANNOOAIAEFHIDFNMNG.Instance, ANNOOAIAEFHIDFNMNG.nameMutator, ANNOOAIAEFHIDFNMNG.excludeNull, true);
		}
	}
}

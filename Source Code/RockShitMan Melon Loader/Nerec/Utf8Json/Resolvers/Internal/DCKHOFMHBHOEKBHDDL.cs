using System;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200003B RID: 59
	internal sealed class DCKHOFMHBHOEKBHDDL : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000120 RID: 288 RVA: 0x000031E8 File Offset: 0x000013E8
		public FLGKBGGCEAHKIBEKBN<DGKOPOHHGIOCHCBAMO> GetFormatter<DGKOPOHHGIOCHCBAMO>()
		{
			return DCKHOFMHBHOEKBHDDL<DGKOPOHHGIOCHCBAMO>.BJDKEAAGFHNKCEIOPL.formatter;
		}

		// Token: 0x0400008C RID: 140
		public static readonly LMCMANMFGJGJFPNBEN Instance = new DCKHOFMHBHOEKBHDDL();

		// Token: 0x0400008D RID: 141
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.ToCamelCase);

		// Token: 0x0400008E RID: 142
		private static readonly bool excludeNull = false;

		// Token: 0x0200003C RID: 60
		private static class BJDKEAAGFHNKCEIOPL<T>
		{
			// Token: 0x0400008F RID: 143
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToDynamicMethod<T>(DCKHOFMHBHOEKBHDDL.Instance, DCKHOFMHBHOEKBHDDL.nameMutator, DCKHOFMHBHOEKBHDDL.excludeNull, true);
		}
	}
}

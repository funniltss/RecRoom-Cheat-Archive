using System;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200002F RID: 47
	internal sealed class KEFBLEBFHMANHNLJJL : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00002B7C File Offset: 0x00000D7C
		private KEFBLEBFHMANHNLJJL()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002FF9 File Offset: 0x000011F9
		public FLGKBGGCEAHKIBEKBN<FHMOFDLAEDMDDMCGNO> GetFormatter<FHMOFDLAEDMDDMCGNO>()
		{
			return KEFBLEBFHMANHNLJJL<FHMOFDLAEDMDDMCGNO>.LFENKOHJDFCNINAMMK.formatter;
		}

		// Token: 0x0400006A RID: 106
		public static readonly LMCMANMFGJGJFPNBEN Instance = new KEFBLEBFHMANHNLJJL();

		// Token: 0x0400006B RID: 107
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.ToCamelCase);

		// Token: 0x0400006C RID: 108
		private static readonly bool excludeNull = false;

		// Token: 0x0400006D RID: 109
		private const string ModuleName = "Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullFalseNameMutateCamelCase";

		// Token: 0x0400006E RID: 110
		private static readonly DILDNPCNJDCNMBMPHO assembly = new DILDNPCNJDCNMBMPHO("Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullFalseNameMutateCamelCase");

		// Token: 0x02000030 RID: 48
		private static class LFENKOHJDFCNINAMMK<T>
		{
			// Token: 0x0400006F RID: 111
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToAssembly<T>(KEFBLEBFHMANHNLJJL.assembly, KEFBLEBFHMANHNLJJL.Instance, KEFBLEBFHMANHNLJJL.nameMutator, KEFBLEBFHMANHNLJJL.excludeNull);
		}
	}
}

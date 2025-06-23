using System;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200002D RID: 45
	internal sealed class OEGIKLPFMADMDFDAKC : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00002B7C File Offset: 0x00000D7C
		private OEGIKLPFMADMDFDAKC()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002F9B File Offset: 0x0000119B
		public FLGKBGGCEAHKIBEKBN<NCKHBALKFKJAAOKGOP> GetFormatter<NCKHBALKFKJAAOKGOP>()
		{
			return OEGIKLPFMADMDFDAKC<NCKHBALKFKJAAOKGOP>.AGGNGMHOIOHLNOFJJG.formatter;
		}

		// Token: 0x04000064 RID: 100
		public static readonly LMCMANMFGJGJFPNBEN Instance = new OEGIKLPFMADMDFDAKC();

		// Token: 0x04000065 RID: 101
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.Original);

		// Token: 0x04000066 RID: 102
		private static readonly bool excludeNull = false;

		// Token: 0x04000067 RID: 103
		private const string ModuleName = "Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullFalseNameMutateOriginal";

		// Token: 0x04000068 RID: 104
		private static readonly DILDNPCNJDCNMBMPHO assembly = new DILDNPCNJDCNMBMPHO("Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullFalseNameMutateOriginal");

		// Token: 0x0200002E RID: 46
		private static class AGGNGMHOIOHLNOFJJG<T>
		{
			// Token: 0x04000069 RID: 105
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToAssembly<T>(OEGIKLPFMADMDFDAKC.assembly, OEGIKLPFMADMDFDAKC.Instance, OEGIKLPFMADMDFDAKC.nameMutator, OEGIKLPFMADMDFDAKC.excludeNull);
		}
	}
}

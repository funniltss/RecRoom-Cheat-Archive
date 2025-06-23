using System;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000031 RID: 49
	internal sealed class MDOLACOFFFEAAFEIIC : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00002B7C File Offset: 0x00000D7C
		private MDOLACOFFFEAAFEIIC()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00003057 File Offset: 0x00001257
		public FLGKBGGCEAHKIBEKBN<EIMLPMPOOBLGKNDHKC> GetFormatter<EIMLPMPOOBLGKNDHKC>()
		{
			return MDOLACOFFFEAAFEIIC<EIMLPMPOOBLGKNDHKC>.LPMJHGNNDPJBEIDLED.formatter;
		}

		// Token: 0x04000070 RID: 112
		public static readonly LMCMANMFGJGJFPNBEN Instance = new MDOLACOFFFEAAFEIIC();

		// Token: 0x04000071 RID: 113
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.ToSnakeCase);

		// Token: 0x04000072 RID: 114
		private static readonly bool excludeNull = false;

		// Token: 0x04000073 RID: 115
		private const string ModuleName = "Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullFalseNameMutateSnakeCase";

		// Token: 0x04000074 RID: 116
		private static readonly DILDNPCNJDCNMBMPHO assembly = new DILDNPCNJDCNMBMPHO("Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullFalseNameMutateSnakeCase");

		// Token: 0x02000032 RID: 50
		private static class LPMJHGNNDPJBEIDLED<T>
		{
			// Token: 0x04000075 RID: 117
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToAssembly<T>(MDOLACOFFFEAAFEIIC.assembly, MDOLACOFFFEAAFEIIC.Instance, MDOLACOFFFEAAFEIIC.nameMutator, MDOLACOFFFEAAFEIIC.excludeNull);
		}
	}
}

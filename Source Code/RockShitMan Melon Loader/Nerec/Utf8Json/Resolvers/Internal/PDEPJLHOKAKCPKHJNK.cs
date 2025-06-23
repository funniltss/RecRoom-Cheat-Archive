using System;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000037 RID: 55
	internal sealed class PDEPJLHOKAKCPKHJNK : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00002B7C File Offset: 0x00000D7C
		private PDEPJLHOKAKCPKHJNK()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00003171 File Offset: 0x00001371
		public FLGKBGGCEAHKIBEKBN<FBKEJEODEDFOJIEGJA> GetFormatter<FBKEJEODEDFOJIEGJA>()
		{
			return PDEPJLHOKAKCPKHJNK<FBKEJEODEDFOJIEGJA>.HHEJLIHKLCCAEOECCB.formatter;
		}

		// Token: 0x04000082 RID: 130
		public static readonly LMCMANMFGJGJFPNBEN Instance = new PDEPJLHOKAKCPKHJNK();

		// Token: 0x04000083 RID: 131
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.ToSnakeCase);

		// Token: 0x04000084 RID: 132
		private static readonly bool excludeNull = true;

		// Token: 0x04000085 RID: 133
		private const string ModuleName = "Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullTrueNameMutateSnakeCase";

		// Token: 0x04000086 RID: 134
		private static readonly DILDNPCNJDCNMBMPHO assembly = new DILDNPCNJDCNMBMPHO("Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullTrueNameMutateSnakeCase");

		// Token: 0x02000038 RID: 56
		private static class HHEJLIHKLCCAEOECCB<T>
		{
			// Token: 0x04000087 RID: 135
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToAssembly<T>(PDEPJLHOKAKCPKHJNK.assembly, PDEPJLHOKAKCPKHJNK.Instance, PDEPJLHOKAKCPKHJNK.nameMutator, PDEPJLHOKAKCPKHJNK.excludeNull);
		}
	}
}

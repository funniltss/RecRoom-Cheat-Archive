using System;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000035 RID: 53
	internal sealed class HMNAMLBBPKJCICJADD : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00002B7C File Offset: 0x00000D7C
		private HMNAMLBBPKJCICJADD()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003113 File Offset: 0x00001313
		public FLGKBGGCEAHKIBEKBN<DICPKFKPHBAPBJPDDK> GetFormatter<DICPKFKPHBAPBJPDDK>()
		{
			return HMNAMLBBPKJCICJADD<DICPKFKPHBAPBJPDDK>.GFDPDPPBFAPNEGOMIF.formatter;
		}

		// Token: 0x0400007C RID: 124
		public static readonly LMCMANMFGJGJFPNBEN Instance = new HMNAMLBBPKJCICJADD();

		// Token: 0x0400007D RID: 125
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.ToCamelCase);

		// Token: 0x0400007E RID: 126
		private static readonly bool excludeNull = true;

		// Token: 0x0400007F RID: 127
		private const string ModuleName = "Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullTrueNameMutateCamelCase";

		// Token: 0x04000080 RID: 128
		private static readonly DILDNPCNJDCNMBMPHO assembly = new DILDNPCNJDCNMBMPHO("Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullTrueNameMutateCamelCase");

		// Token: 0x02000036 RID: 54
		private static class GFDPDPPBFAPNEGOMIF<T>
		{
			// Token: 0x04000081 RID: 129
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToAssembly<T>(HMNAMLBBPKJCICJADD.assembly, HMNAMLBBPKJCICJADD.Instance, HMNAMLBBPKJCICJADD.nameMutator, HMNAMLBBPKJCICJADD.excludeNull);
		}
	}
}

using System;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000033 RID: 51
	internal sealed class MIPMNNKELCBHAGKJBH : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00002B7C File Offset: 0x00000D7C
		private MIPMNNKELCBHAGKJBH()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000030B5 File Offset: 0x000012B5
		public FLGKBGGCEAHKIBEKBN<NJLFLODOJNHGPCGGBI> GetFormatter<NJLFLODOJNHGPCGGBI>()
		{
			return MIPMNNKELCBHAGKJBH<NJLFLODOJNHGPCGGBI>.PPLMOFMOICKLIADNOL.formatter;
		}

		// Token: 0x04000076 RID: 118
		public static readonly LMCMANMFGJGJFPNBEN Instance = new MIPMNNKELCBHAGKJBH();

		// Token: 0x04000077 RID: 119
		private static readonly Func<string, string> nameMutator = new Func<string, string>(MHBOKPBBKJJEANGOOI.Original);

		// Token: 0x04000078 RID: 120
		private static readonly bool excludeNull = true;

		// Token: 0x04000079 RID: 121
		private const string ModuleName = "Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullTrueNameMutateOriginal";

		// Token: 0x0400007A RID: 122
		private static readonly DILDNPCNJDCNMBMPHO assembly = new DILDNPCNJDCNMBMPHO("Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullTrueNameMutateOriginal");

		// Token: 0x02000034 RID: 52
		private static class PPLMOFMOICKLIADNOL<T>
		{
			// Token: 0x0400007B RID: 123
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)POKNKMIEJNDGDMNHJH.BuildFormatterToAssembly<T>(MIPMNNKELCBHAGKJBH.assembly, MIPMNNKELCBHAGKJBH.Instance, MIPMNNKELCBHAGKJBH.nameMutator, MIPMNNKELCBHAGKJBH.excludeNull);
		}
	}
}

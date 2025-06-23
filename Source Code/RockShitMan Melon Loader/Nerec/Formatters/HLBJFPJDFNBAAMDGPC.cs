using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D9 RID: 217
	public sealed class HLBJFPJDFNBAAMDGPC<T> : BODNBPGEAMAPLAAPDJ<T, List<T>, IList<T>>
	{
		// Token: 0x060003AC RID: 940 RVA: 0x00004E45 File Offset: 0x00003045
		protected override void Add(ref List<T> collection, int index, T value)
		{
			collection.Add(value);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00004E4F File Offset: 0x0000304F
		protected override List<T> Create()
		{
			return new List<T>();
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00004DB1 File Offset: 0x00002FB1
		protected override IList<T> Complete(ref List<T> intermediateCollection)
		{
			return intermediateCollection;
		}
	}
}

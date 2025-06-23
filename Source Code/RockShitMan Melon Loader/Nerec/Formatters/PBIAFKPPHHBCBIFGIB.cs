using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000DA RID: 218
	public sealed class PBIAFKPPHHBCBIFGIB<T> : BODNBPGEAMAPLAAPDJ<T, List<T>, ICollection<T>>
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00004E45 File Offset: 0x00003045
		protected override void Add(ref List<T> collection, int index, T value)
		{
			collection.Add(value);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00004E4F File Offset: 0x0000304F
		protected override List<T> Create()
		{
			return new List<T>();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00004DB1 File Offset: 0x00002FB1
		protected override ICollection<T> Complete(ref List<T> intermediateCollection)
		{
			return intermediateCollection;
		}
	}
}

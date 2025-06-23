using System;
using System.Collections.Generic;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000DB RID: 219
	public sealed class CBDAEKAEHDCJBGEKKH<T> : BODNBPGEAMAPLAAPDJ<T, MGIMFHAGEKMNFOIMFL<T>, IEnumerable<T>>
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x00004DED File Offset: 0x00002FED
		protected override void Add(ref MGIMFHAGEKMNFOIMFL<T> collection, int index, T value)
		{
			collection.Add(value);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00004DF6 File Offset: 0x00002FF6
		protected override MGIMFHAGEKMNFOIMFL<T> Create()
		{
			return new MGIMFHAGEKMNFOIMFL<T>(4);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00004E66 File Offset: 0x00003066
		protected override IEnumerable<T> Complete(ref MGIMFHAGEKMNFOIMFL<T> intermediateCollection)
		{
			return intermediateCollection.ToArray();
		}
	}
}

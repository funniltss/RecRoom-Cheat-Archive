using System;
using System.Collections.ObjectModel;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D8 RID: 216
	public sealed class MGHBGMHOKOJJAJGPKE<T> : BODNBPGEAMAPLAAPDJ<T, MGIMFHAGEKMNFOIMFL<T>, ReadOnlyCollection<T>>
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00004DED File Offset: 0x00002FED
		protected override void Add(ref MGIMFHAGEKMNFOIMFL<T> collection, int index, T value)
		{
			collection.Add(value);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00004E30 File Offset: 0x00003030
		protected override ReadOnlyCollection<T> Complete(ref MGIMFHAGEKMNFOIMFL<T> intermediateCollection)
		{
			return new ReadOnlyCollection<T>(intermediateCollection.ToArray());
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00004DF6 File Offset: 0x00002FF6
		protected override MGIMFHAGEKMNFOIMFL<T> Create()
		{
			return new MGIMFHAGEKMNFOIMFL<T>(4);
		}
	}
}

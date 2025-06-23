using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D2 RID: 210
	public abstract class KICPACHNOFKGNMLENA<TElement, TCollection> : BODNBPGEAMAPLAAPDJ<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
	{
		// Token: 0x0600038F RID: 911 RVA: 0x00004D78 File Offset: 0x00002F78
		protected sealed override TCollection Complete(ref TCollection intermediateCollection)
		{
			return intermediateCollection;
		}
	}
}

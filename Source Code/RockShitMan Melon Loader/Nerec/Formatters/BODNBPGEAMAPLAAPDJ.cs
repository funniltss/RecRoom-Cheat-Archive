using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D1 RID: 209
	public abstract class BODNBPGEAMAPLAAPDJ<TElement, TIntermediate, TCollection> : KMJIGPGHPFKEJDLOHL<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00004D63 File Offset: 0x00002F63
		protected override IEnumerator<TElement> GetSourceEnumerator(TCollection source)
		{
			return source.GetEnumerator();
		}
	}
}

using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D3 RID: 211
	public sealed class GAPOAJPJNIPCNCCMDH<TElement, TCollection> : KICPACHNOFKGNMLENA<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
	{
		// Token: 0x06000391 RID: 913 RVA: 0x00004D88 File Offset: 0x00002F88
		protected override TCollection Create()
		{
			return Activator.CreateInstance<TCollection>();
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00004D8F File Offset: 0x00002F8F
		protected override void Add(ref TCollection collection, int index, TElement value)
		{
			collection.Add(value);
		}
	}
}

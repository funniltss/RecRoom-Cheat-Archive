using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F4 RID: 244
	public sealed class HABDEDLGNFJLHLADBN<TKey, TValue> : EMJKLPGBBKPMHCFOLM<TKey, TValue, SortedList<TKey, TValue>>
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x00005135 File Offset: 0x00003335
		protected override void Add(ref SortedList<TKey, TValue> collection, int index, TKey key, TValue value)
		{
			collection.Add(key, value);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00005141 File Offset: 0x00003341
		protected override SortedList<TKey, TValue> Create()
		{
			return new SortedList<TKey, TValue>();
		}
	}
}

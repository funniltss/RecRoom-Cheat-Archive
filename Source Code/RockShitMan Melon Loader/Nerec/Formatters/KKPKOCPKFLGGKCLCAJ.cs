using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F5 RID: 245
	public sealed class KKPKOCPKFLGGKCLCAJ<TKey, TValue> : NCINKFFFBMOHMKKGFA<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
	{
		// Token: 0x06000417 RID: 1047 RVA: 0x00005150 File Offset: 0x00003350
		protected override void Add(ref SortedDictionary<TKey, TValue> collection, int index, TKey key, TValue value)
		{
			collection.Add(key, value);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00004DB1 File Offset: 0x00002FB1
		protected override SortedDictionary<TKey, TValue> Complete(ref SortedDictionary<TKey, TValue> intermediateCollection)
		{
			return intermediateCollection;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000515C File Offset: 0x0000335C
		protected override SortedDictionary<TKey, TValue> Create()
		{
			return new SortedDictionary<TKey, TValue>();
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00005163 File Offset: 0x00003363
		protected override SortedDictionary<TKey, TValue>.Enumerator GetSourceEnumerator(SortedDictionary<TKey, TValue> source)
		{
			return source.GetEnumerator();
		}
	}
}

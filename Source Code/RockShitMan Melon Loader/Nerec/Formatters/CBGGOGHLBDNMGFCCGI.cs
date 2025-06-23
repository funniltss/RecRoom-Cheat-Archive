using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F1 RID: 241
	public sealed class CBGGOGHLBDNMGFCCGI<TKey, TValue> : NCINKFFFBMOHMKKGFA<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x000050EA File Offset: 0x000032EA
		protected override void Add(ref Dictionary<TKey, TValue> collection, int index, TKey key, TValue value)
		{
			collection.Add(key, value);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00004DB1 File Offset: 0x00002FB1
		protected override Dictionary<TKey, TValue> Complete(ref Dictionary<TKey, TValue> intermediateCollection)
		{
			return intermediateCollection;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000050F6 File Offset: 0x000032F6
		protected override Dictionary<TKey, TValue> Create()
		{
			return new Dictionary<TKey, TValue>();
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000050FD File Offset: 0x000032FD
		protected override Dictionary<TKey, TValue>.Enumerator GetSourceEnumerator(Dictionary<TKey, TValue> source)
		{
			return source.GetEnumerator();
		}
	}
}

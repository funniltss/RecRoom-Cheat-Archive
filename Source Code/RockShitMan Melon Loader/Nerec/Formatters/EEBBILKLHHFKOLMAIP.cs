using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F3 RID: 243
	public sealed class EEBBILKLHHFKOLMAIP<TKey, TValue> : HAOGNLGKHHMGNHFKJO<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x000050EA File Offset: 0x000032EA
		protected override void Add(ref Dictionary<TKey, TValue> collection, int index, TKey key, TValue value)
		{
			collection.Add(key, value);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000050F6 File Offset: 0x000032F6
		protected override Dictionary<TKey, TValue> Create()
		{
			return new Dictionary<TKey, TValue>();
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00004DB1 File Offset: 0x00002FB1
		protected override IDictionary<TKey, TValue> Complete(ref Dictionary<TKey, TValue> intermediateCollection)
		{
			return intermediateCollection;
		}
	}
}

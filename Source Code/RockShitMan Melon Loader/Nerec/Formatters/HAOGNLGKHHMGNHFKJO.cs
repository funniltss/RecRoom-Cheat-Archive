using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000EF RID: 239
	public abstract class HAOGNLGKHHMGNHFKJO<TKey, TValue, TIntermediate, TDictionary> : NCINKFFFBMOHMKKGFA<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x000050C5 File Offset: 0x000032C5
		protected override IEnumerator<KeyValuePair<TKey, TValue>> GetSourceEnumerator(TDictionary source)
		{
			return source.GetEnumerator();
		}
	}
}

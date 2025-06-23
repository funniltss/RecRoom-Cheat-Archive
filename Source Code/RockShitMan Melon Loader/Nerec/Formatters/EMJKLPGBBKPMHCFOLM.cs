using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F0 RID: 240
	public abstract class EMJKLPGBBKPMHCFOLM<TKey, TValue, TDictionary> : HAOGNLGKHHMGNHFKJO<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x000050DA File Offset: 0x000032DA
		protected override TDictionary Complete(ref TDictionary intermediateCollection)
		{
			return intermediateCollection;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F2 RID: 242
	public sealed class PJECGAHIBHLCGHLAAN<TKey, TValue, TDictionary> : EMJKLPGBBKPMHCFOLM<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x0000510D File Offset: 0x0000330D
		protected override void Add(ref TDictionary collection, int index, TKey key, TValue value)
		{
			collection.Add(key, value);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000511E File Offset: 0x0000331E
		protected override TDictionary Create()
		{
			return Activator.CreateInstance<TDictionary>();
		}
	}
}

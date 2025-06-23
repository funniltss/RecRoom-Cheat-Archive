using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Utf8Json.Formatters
{
	// Token: 0x020000DE RID: 222
	internal class MFIHBGGKNFMEDBBAOB<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x060003BE RID: 958 RVA: 0x00004E95 File Offset: 0x00003095
		public MFIHBGGKNFMEDBBAOB(TKey key, IEnumerable<TElement> elements)
		{
			this.key = key;
			this.elements = elements;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00004EAB File Offset: 0x000030AB
		public TKey DBPAMJMALEIEPJJBGB
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00004EB3 File Offset: 0x000030B3
		public IEnumerator<TElement> GetEnumerator()
		{
			return this.elements.GetEnumerator();
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00004EC0 File Offset: 0x000030C0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000237 RID: 567
		private readonly TKey key;

		// Token: 0x04000238 RID: 568
		private readonly IEnumerable<TElement> elements;
	}
}

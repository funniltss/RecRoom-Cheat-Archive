using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Utf8Json.Formatters
{
	// Token: 0x020000DF RID: 223
	[DefaultMember("Item")]
	internal class KAMJEJLOOCODKADEDK<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		// Token: 0x060003C2 RID: 962 RVA: 0x00004EC8 File Offset: 0x000030C8
		public KAMJEJLOOCODKADEDK(Dictionary<TKey, IGrouping<TKey, TElement>> groupings)
		{
			this.groupings = groupings;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00004ED7 File Offset: 0x000030D7
		public IEnumerable<TElement> OOIMAPMNMAECNFFAJH
		{
			get
			{
				return this.groupings[key];
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00004EE5 File Offset: 0x000030E5
		public int IKENKLFIHMMOILKMOJ
		{
			get
			{
				return this.groupings.Count;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00004EF2 File Offset: 0x000030F2
		public bool Contains(TKey key)
		{
			return this.groupings.ContainsKey(key);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00004F00 File Offset: 0x00003100
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			return this.groupings.Values.GetEnumerator();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00004F00 File Offset: 0x00003100
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.groupings.Values.GetEnumerator();
		}

		// Token: 0x04000239 RID: 569
		private readonly Dictionary<TKey, IGrouping<TKey, TElement>> groupings;
	}
}

using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D7 RID: 215
	public sealed class LNMEBOIPBGJCJGDHGO<T> : KMJIGPGHPFKEJDLOHL<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00004E0E File Offset: 0x0000300E
		protected override void Add(ref HashSet<T> collection, int index, T value)
		{
			collection.Add(value);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00004DB1 File Offset: 0x00002FB1
		protected override HashSet<T> Complete(ref HashSet<T> intermediateCollection)
		{
			return intermediateCollection;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00004E19 File Offset: 0x00003019
		protected override HashSet<T> Create()
		{
			return new HashSet<T>();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00004E20 File Offset: 0x00003020
		protected override HashSet<T>.Enumerator GetSourceEnumerator(HashSet<T> source)
		{
			return source.GetEnumerator();
		}
	}
}

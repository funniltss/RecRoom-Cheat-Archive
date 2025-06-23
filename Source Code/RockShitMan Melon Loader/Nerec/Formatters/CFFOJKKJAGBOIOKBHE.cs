using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D5 RID: 213
	public sealed class CFFOJKKJAGBOIOKBHE<T> : KMJIGPGHPFKEJDLOHL<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
	{
		// Token: 0x06000399 RID: 921 RVA: 0x00004DCC File Offset: 0x00002FCC
		protected override void Add(ref Queue<T> collection, int index, T value)
		{
			collection.Enqueue(value);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00004DD6 File Offset: 0x00002FD6
		protected override Queue<T> Create()
		{
			return new Queue<T>();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00004DDD File Offset: 0x00002FDD
		protected override Queue<T>.Enumerator GetSourceEnumerator(Queue<T> source)
		{
			return source.GetEnumerator();
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00004DB1 File Offset: 0x00002FB1
		protected override Queue<T> Complete(ref Queue<T> intermediateCollection)
		{
			return intermediateCollection;
		}
	}
}

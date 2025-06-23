using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D4 RID: 212
	public sealed class LDFPPDOGGFGHOGJPLE<T> : KMJIGPGHPFKEJDLOHL<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
	{
		// Token: 0x06000394 RID: 916 RVA: 0x00004DA6 File Offset: 0x00002FA6
		protected override void Add(ref LinkedList<T> collection, int index, T value)
		{
			collection.AddLast(value);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00004DB1 File Offset: 0x00002FB1
		protected override LinkedList<T> Complete(ref LinkedList<T> intermediateCollection)
		{
			return intermediateCollection;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00004DB5 File Offset: 0x00002FB5
		protected override LinkedList<T> Create()
		{
			return new LinkedList<T>();
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00004DBC File Offset: 0x00002FBC
		protected override LinkedList<T>.Enumerator GetSourceEnumerator(LinkedList<T> source)
		{
			return source.GetEnumerator();
		}
	}
}

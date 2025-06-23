using System;
using System.Collections.Generic;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D6 RID: 214
	public sealed class AJIKGNJFKKJFMDBILE<T> : KMJIGPGHPFKEJDLOHL<T, MGIMFHAGEKMNFOIMFL<T>, Stack<T>.Enumerator, Stack<T>>
	{
		// Token: 0x0600039E RID: 926 RVA: 0x00004DED File Offset: 0x00002FED
		protected override void Add(ref MGIMFHAGEKMNFOIMFL<T> collection, int index, T value)
		{
			collection.Add(value);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00004DF6 File Offset: 0x00002FF6
		protected override MGIMFHAGEKMNFOIMFL<T> Create()
		{
			return new MGIMFHAGEKMNFOIMFL<T>(4);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00004DFE File Offset: 0x00002FFE
		protected override Stack<T>.Enumerator GetSourceEnumerator(Stack<T> source)
		{
			return source.GetEnumerator();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00014118 File Offset: 0x00012318
		protected override Stack<T> Complete(ref MGIMFHAGEKMNFOIMFL<T> intermediateCollection)
		{
			T[] buffer = intermediateCollection.Buffer;
			Stack<T> stack = new Stack<T>(intermediateCollection.Size);
			for (int i = intermediateCollection.Size - 1; i >= 0; i--)
			{
				stack.Push(buffer[i]);
			}
			return stack;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000D0 RID: 208
	public abstract class KMJIGPGHPFKEJDLOHL<TElement, TIntermediate, TEnumerator, TCollection> : FLGKBGGCEAHKIBEKBN<TCollection>, DDGADMMMOKKMDLNAEK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
	{
		// Token: 0x06000386 RID: 902 RVA: 0x00014030 File Offset: 0x00012230
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, TCollection value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			FLGKBGGCEAHKIBEKBN<TElement> formatterWithVerify = formatterResolver.GetFormatterWithVerify<TElement>();
			TEnumerator sourceEnumerator = this.GetSourceEnumerator(value);
			try
			{
				bool flag = true;
				while (sourceEnumerator.MoveNext())
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						writer.WriteValueSeparator();
					}
					formatterWithVerify.Serialize(ref writer, sourceEnumerator.Current, formatterResolver);
				}
			}
			finally
			{
				sourceEnumerator.Dispose();
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000140BC File Offset: 0x000122BC
		public TCollection Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return default(TCollection);
			}
			FLGKBGGCEAHKIBEKBN<TElement> formatterWithVerify = formatterResolver.GetFormatterWithVerify<TElement>();
			TIntermediate tintermediate = this.Create();
			int num = 0;
			reader.ReadIsBeginArrayWithVerify();
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				this.Add(ref tintermediate, num - 1, formatterWithVerify.Deserialize(ref reader, formatterResolver));
			}
			return this.Complete(ref tintermediate);
		}

		// Token: 0x06000388 RID: 904
		protected abstract TEnumerator GetSourceEnumerator(TCollection source);

		// Token: 0x06000389 RID: 905
		protected abstract TIntermediate Create();

		// Token: 0x0600038A RID: 906
		protected abstract void Add(ref TIntermediate collection, int index, TElement value);

		// Token: 0x0600038B RID: 907
		protected abstract TCollection Complete(ref TIntermediate intermediateCollection);
	}
}

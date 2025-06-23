using System;
using System.Collections.Generic;
using System.Linq;

namespace Utf8Json.Formatters
{
	// Token: 0x020000DD RID: 221
	public sealed class DEONKGNPBNOBJKKEFD<TKey, TElement> : FLGKBGGCEAHKIBEKBN<ILookup<TKey, TElement>>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00004E76 File Offset: 0x00003076
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ILookup<TKey, TElement> value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			formatterResolver.GetFormatterWithVerify<IEnumerable<IGrouping<TKey, TElement>>>().Serialize(ref writer, value.AsEnumerable<IGrouping<TKey, TElement>>(), formatterResolver);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00014240 File Offset: 0x00012440
		public ILookup<TKey, TElement> Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			if (reader.ReadIsNull())
			{
				return null;
			}
			int num = 0;
			FLGKBGGCEAHKIBEKBN<IGrouping<TKey, TElement>> formatterWithVerify = formatterResolver.GetFormatterWithVerify<IGrouping<TKey, TElement>>();
			Dictionary<TKey, IGrouping<TKey, TElement>> dictionary = new Dictionary<TKey, IGrouping<TKey, TElement>>();
			reader.ReadIsBeginArrayWithVerify();
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				IGrouping<TKey, TElement> grouping = formatterWithVerify.Deserialize(ref reader, formatterResolver);
				dictionary.Add(grouping.Key, grouping);
			}
			return new KAMJEJLOOCODKADEDK<TKey, TElement>(dictionary);
		}
	}
}

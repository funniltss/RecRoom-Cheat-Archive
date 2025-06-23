using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000CF RID: 207
	public class BMKCBCOMGEOPJCGDLE<T> : FLGKBGGCEAHKIBEKBN<List<T>>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000383 RID: 899 RVA: 0x00013F80 File Offset: 0x00012180
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, List<T> value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			if (value.Count != 0)
			{
				formatterWithVerify.Serialize(ref writer, value[0], formatterResolver);
			}
			for (int i = 1; i < value.Count; i++)
			{
				writer.WriteValueSeparator();
				formatterWithVerify.Serialize(ref writer, value[i], formatterResolver);
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00013FE8 File Offset: 0x000121E8
		public List<T> Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			int num = 0;
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			List<T> list = new List<T>();
			reader.ReadIsBeginArrayWithVerify();
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				list.Add(formatterWithVerify.Deserialize(ref reader, formatterResolver));
			}
			return list;
		}
	}
}

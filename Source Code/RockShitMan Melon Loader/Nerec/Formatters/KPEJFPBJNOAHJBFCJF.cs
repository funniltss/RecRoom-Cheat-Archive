using System;
using System.Collections;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E3 RID: 227
	public sealed class KPEJFPBJNOAHJBFCJF : FLGKBGGCEAHKIBEKBN<IList>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x000144C4 File Offset: 0x000126C4
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, IList value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			FLGKBGGCEAHKIBEKBN<object> formatterWithVerify = formatterResolver.GetFormatterWithVerify<object>();
			writer.WriteBeginArray();
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

		// Token: 0x060003D4 RID: 980 RVA: 0x000143F4 File Offset: 0x000125F4
		public IList Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			int num = 0;
			FLGKBGGCEAHKIBEKBN<object> formatterWithVerify = formatterResolver.GetFormatterWithVerify<object>();
			List<object> list = new List<object>();
			reader.ReadIsBeginArrayWithVerify();
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				list.Add(formatterWithVerify.Deserialize(ref reader, formatterResolver));
			}
			return list;
		}

		// Token: 0x0400023C RID: 572
		public static readonly FLGKBGGCEAHKIBEKBN<IList> Default = new KPEJFPBJNOAHJBFCJF();
	}
}

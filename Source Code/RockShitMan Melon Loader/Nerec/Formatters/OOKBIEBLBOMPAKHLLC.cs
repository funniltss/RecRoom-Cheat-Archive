using System;
using System.Collections;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E1 RID: 225
	public sealed class OOKBIEBLBOMPAKHLLC : FLGKBGGCEAHKIBEKBN<IEnumerable>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003CB RID: 971 RVA: 0x00014378 File Offset: 0x00012578
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, IEnumerable value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			FLGKBGGCEAHKIBEKBN<object> formatterWithVerify = formatterResolver.GetFormatterWithVerify<object>();
			writer.WriteBeginArray();
			int num = 0;
			foreach (object value2 in value)
			{
				if (num != 0)
				{
					writer.WriteValueSeparator();
				}
				formatterWithVerify.Serialize(ref writer, value2, formatterResolver);
			}
			writer.WriteEndArray();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000143F4 File Offset: 0x000125F4
		public IEnumerable Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
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

		// Token: 0x0400023A RID: 570
		public static readonly FLGKBGGCEAHKIBEKBN<IEnumerable> Default = new OOKBIEBLBOMPAKHLLC();
	}
}

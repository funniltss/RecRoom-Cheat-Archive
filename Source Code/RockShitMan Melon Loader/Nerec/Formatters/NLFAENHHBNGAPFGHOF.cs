using System;
using System.Collections;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E2 RID: 226
	public sealed class NLFAENHHBNGAPFGHOF : FLGKBGGCEAHKIBEKBN<ICollection>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003CF RID: 975 RVA: 0x0001443C File Offset: 0x0001263C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ICollection value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			FLGKBGGCEAHKIBEKBN<object> formatterWithVerify = formatterResolver.GetFormatterWithVerify<object>();
			writer.WriteBeginArray();
			using (IEnumerator enumerator = value.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					formatterWithVerify.Serialize(ref writer, enumerator.Current, formatterResolver);
					while (enumerator.MoveNext())
					{
						writer.WriteValueSeparator();
						formatterWithVerify.Serialize(ref writer, enumerator.Current, formatterResolver);
					}
				}
			}
			writer.WriteEndArray();
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000143F4 File Offset: 0x000125F4
		public ICollection Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
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

		// Token: 0x0400023B RID: 571
		public static readonly FLGKBGGCEAHKIBEKBN<ICollection> Default = new NLFAENHHBNGAPFGHOF();
	}
}

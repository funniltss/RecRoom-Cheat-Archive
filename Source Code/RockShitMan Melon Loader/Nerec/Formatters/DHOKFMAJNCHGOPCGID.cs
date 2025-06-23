using System;
using System.Collections;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E0 RID: 224
	public sealed class DHOKFMAJNCHGOPCGID<T> : FLGKBGGCEAHKIBEKBN<T>, DDGADMMMOKKMDLNAEK where T : class, IList, new()
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x000142A0 File Offset: 0x000124A0
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN formatterResolver)
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

		// Token: 0x060003C9 RID: 969 RVA: 0x00014320 File Offset: 0x00012520
		public T Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return default(T);
			}
			int num = 0;
			FLGKBGGCEAHKIBEKBN<object> formatterWithVerify = formatterResolver.GetFormatterWithVerify<object>();
			T t = Activator.CreateInstance<T>();
			reader.ReadIsBeginArrayWithVerify();
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				t.Add(formatterWithVerify.Deserialize(ref reader, formatterResolver));
			}
			return t;
		}
	}
}

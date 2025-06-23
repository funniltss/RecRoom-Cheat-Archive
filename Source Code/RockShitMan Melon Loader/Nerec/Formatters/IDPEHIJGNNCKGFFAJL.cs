using System;
using System.Collections;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F6 RID: 246
	public sealed class IDPEHIJGNNCKGFFAJL<T> : FLGKBGGCEAHKIBEKBN<T>, DDGADMMMOKKMDLNAEK where T : class, IDictionary, new()
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00015D20 File Offset: 0x00013F20
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			FLGKBGGCEAHKIBEKBN<object> formatterWithVerify = formatterResolver.GetFormatterWithVerify<object>();
			writer.WriteBeginObject();
			using (IDictionaryEnumerator enumerator = value.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator.Current;
					writer.WritePropertyName(dictionaryEntry.Key.ToString());
					formatterWithVerify.Serialize(ref writer, dictionaryEntry.Value, formatterResolver);
					while (enumerator.MoveNext())
					{
						writer.WriteValueSeparator();
						DictionaryEntry dictionaryEntry2 = (DictionaryEntry)enumerator.Current;
						writer.WritePropertyName(dictionaryEntry2.Key.ToString());
						formatterWithVerify.Serialize(ref writer, dictionaryEntry2.Value, formatterResolver);
					}
				}
			}
			writer.WriteEndObject();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00015DF8 File Offset: 0x00013FF8
		public T Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return default(T);
			}
			FLGKBGGCEAHKIBEKBN<object> formatterWithVerify = formatterResolver.GetFormatterWithVerify<object>();
			reader.ReadIsBeginObjectWithVerify();
			T t = Activator.CreateInstance<T>();
			int num = 0;
			while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref num))
			{
				string key = reader.ReadPropertyName();
				object value = formatterWithVerify.Deserialize(ref reader, formatterResolver);
				t.Add(key, value);
			}
			return t;
		}
	}
}

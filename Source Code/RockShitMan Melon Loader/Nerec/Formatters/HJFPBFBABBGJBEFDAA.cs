using System;
using System.Collections;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F7 RID: 247
	public sealed class HJFPBFBABBGJBEFDAA : FLGKBGGCEAHKIBEKBN<IDictionary>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600041F RID: 1055 RVA: 0x00015E5C File Offset: 0x0001405C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, IDictionary value, LMCMANMFGJGJFPNBEN formatterResolver)
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

		// Token: 0x06000420 RID: 1056 RVA: 0x00015F28 File Offset: 0x00014128
		public IDictionary Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			FLGKBGGCEAHKIBEKBN<object> formatterWithVerify = formatterResolver.GetFormatterWithVerify<object>();
			reader.ReadIsBeginObjectWithVerify();
			Dictionary<object, object> dictionary = new Dictionary<object, object>();
			int num = 0;
			while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref num))
			{
				string key = reader.ReadPropertyName();
				object value = formatterWithVerify.Deserialize(ref reader, formatterResolver);
				dictionary.Add(key, value);
			}
			return dictionary;
		}

		// Token: 0x04000247 RID: 583
		public static readonly FLGKBGGCEAHKIBEKBN<IDictionary> Default = new HJFPBFBABBGJBEFDAA();
	}
}

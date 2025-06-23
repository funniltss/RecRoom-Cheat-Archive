using System;
using System.Collections.Generic;
using Utf8Json.Formatters.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000133 RID: 307
	public sealed class OLDICEJCINFNADGBBI<TKey, TValue> : FLGKBGGCEAHKIBEKBN<KeyValuePair<TKey, TValue>>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x000183F0 File Offset: 0x000165F0
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, KeyValuePair<TKey, TValue> value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteRaw(JBLAEPIEBLCLLAIFCH.keyValuePairName[0]);
			formatterResolver.GetFormatterWithVerify<TKey>().Serialize(ref writer, value.Key, formatterResolver);
			writer.WriteRaw(JBLAEPIEBLCLLAIFCH.keyValuePairName[1]);
			formatterResolver.GetFormatterWithVerify<TValue>().Serialize(ref writer, value.Value, formatterResolver);
			writer.WriteEndObject();
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00018448 File Offset: 0x00016648
		public KeyValuePair<TKey, TValue> Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				throw new InvalidOperationException("Data is Nil, KeyValuePair can not be null.");
			}
			TKey key = default(TKey);
			TValue value = default(TValue);
			reader.ReadIsBeginObjectWithVerify();
			int num = 0;
			while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref num))
			{
				ArraySegment<byte> key2 = reader.ReadPropertyNameSegmentRaw();
				int num2;
				JBLAEPIEBLCLLAIFCH.keyValuePairAutomata.TryGetValueSafe(key2, out num2);
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						reader.ReadNextBlock();
					}
					else
					{
						value = formatterResolver.GetFormatterWithVerify<TValue>().Deserialize(ref reader, formatterResolver);
					}
				}
				else
				{
					key = formatterResolver.GetFormatterWithVerify<TKey>().Deserialize(ref reader, formatterResolver);
				}
			}
			return new KeyValuePair<TKey, TValue>(key, value);
		}
	}
}

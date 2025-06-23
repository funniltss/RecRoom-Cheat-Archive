using System;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x020000EE RID: 238
	public abstract class NCINKFFFBMOHMKKGFA<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : FLGKBGGCEAHKIBEKBN<TDictionary>, DDGADMMMOKKMDLNAEK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00015AC0 File Offset: 0x00013CC0
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, TDictionary value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			OJKBDJBONOCKIDIKGG<TKey> ojkbdjbonockidikgg = formatterResolver.GetFormatterWithVerify<TKey>() as OJKBDJBONOCKIDIKGG<TKey>;
			FLGKBGGCEAHKIBEKBN<TValue> formatterWithVerify = formatterResolver.GetFormatterWithVerify<TValue>();
			writer.WriteBeginObject();
			TEnumerator sourceEnumerator = this.GetSourceEnumerator(value);
			try
			{
				if (ojkbdjbonockidikgg != null)
				{
					if (sourceEnumerator.MoveNext())
					{
						KeyValuePair<TKey, TValue> keyValuePair = sourceEnumerator.Current;
						ojkbdjbonockidikgg.SerializeToPropertyName(ref writer, keyValuePair.Key, formatterResolver);
						writer.WriteNameSeparator();
						formatterWithVerify.Serialize(ref writer, keyValuePair.Value, formatterResolver);
						while (sourceEnumerator.MoveNext())
						{
							writer.WriteValueSeparator();
							KeyValuePair<TKey, TValue> keyValuePair2 = sourceEnumerator.Current;
							ojkbdjbonockidikgg.SerializeToPropertyName(ref writer, keyValuePair2.Key, formatterResolver);
							writer.WriteNameSeparator();
							formatterWithVerify.Serialize(ref writer, keyValuePair2.Value, formatterResolver);
						}
					}
				}
				else if (sourceEnumerator.MoveNext())
				{
					KeyValuePair<TKey, TValue> keyValuePair3 = sourceEnumerator.Current;
					TKey key = keyValuePair3.Key;
					writer.WriteString(key.ToString());
					writer.WriteNameSeparator();
					formatterWithVerify.Serialize(ref writer, keyValuePair3.Value, formatterResolver);
					while (sourceEnumerator.MoveNext())
					{
						writer.WriteValueSeparator();
						KeyValuePair<TKey, TValue> keyValuePair4 = sourceEnumerator.Current;
						key = keyValuePair4.Key;
						writer.WriteString(key.ToString());
						writer.WriteNameSeparator();
						formatterWithVerify.Serialize(ref writer, keyValuePair4.Value, formatterResolver);
					}
				}
			}
			finally
			{
				sourceEnumerator.Dispose();
			}
			writer.WriteEndObject();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00015C74 File Offset: 0x00013E74
		public TDictionary Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return default(TDictionary);
			}
			OJKBDJBONOCKIDIKGG<TKey> ojkbdjbonockidikgg = formatterResolver.GetFormatterWithVerify<TKey>() as OJKBDJBONOCKIDIKGG<TKey>;
			if (ojkbdjbonockidikgg == null)
			{
				Type typeFromHandle = typeof(TKey);
				throw new InvalidOperationException(((typeFromHandle != null) ? typeFromHandle.ToString() : null) + " does not support dictionary key deserialize.");
			}
			FLGKBGGCEAHKIBEKBN<TValue> formatterWithVerify = formatterResolver.GetFormatterWithVerify<TValue>();
			reader.ReadIsBeginObjectWithVerify();
			TIntermediate tintermediate = this.Create();
			int num = 0;
			while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref num))
			{
				TKey key = ojkbdjbonockidikgg.DeserializeFromPropertyName(ref reader, formatterResolver);
				reader.ReadIsNameSeparatorWithVerify();
				TValue value = formatterWithVerify.Deserialize(ref reader, formatterResolver);
				this.Add(ref tintermediate, num - 1, key, value);
			}
			return this.Complete(ref tintermediate);
		}

		// Token: 0x060003FF RID: 1023
		protected abstract TEnumerator GetSourceEnumerator(TDictionary source);

		// Token: 0x06000400 RID: 1024
		protected abstract TIntermediate Create();

		// Token: 0x06000401 RID: 1025
		protected abstract void Add(ref TIntermediate collection, int index, TKey key, TValue value);

		// Token: 0x06000402 RID: 1026
		protected abstract TDictionary Complete(ref TIntermediate intermediateCollection);
	}
}

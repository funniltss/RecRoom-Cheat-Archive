using System;
using System.Collections.Generic;
using System.Linq;
using Utf8Json.Formatters.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000DC RID: 220
	public sealed class OBPPHDGBJEHNLHMKCM<TKey, TElement> : FLGKBGGCEAHKIBEKBN<IGrouping<TKey, TElement>>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003B8 RID: 952 RVA: 0x0001415C File Offset: 0x0001235C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, IGrouping<TKey, TElement> value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteRaw(CALNGPEONCMKOFIDMF.groupingName[0]);
			formatterResolver.GetFormatterWithVerify<TKey>().Serialize(ref writer, value.Key, formatterResolver);
			writer.WriteRaw(CALNGPEONCMKOFIDMF.groupingName[1]);
			formatterResolver.GetFormatterWithVerify<IEnumerable<TElement>>().Serialize(ref writer, value.AsEnumerable<TElement>(), formatterResolver);
			writer.WriteEndObject();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000141BC File Offset: 0x000123BC
		public IGrouping<TKey, TElement> Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			TKey key = default(TKey);
			IEnumerable<TElement> elements = null;
			reader.ReadIsBeginObjectWithVerify();
			int num = 0;
			while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref num))
			{
				ArraySegment<byte> key2 = reader.ReadPropertyNameSegmentRaw();
				int num2;
				CALNGPEONCMKOFIDMF.groupingAutomata.TryGetValueSafe(key2, out num2);
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						reader.ReadNextBlock();
					}
					else
					{
						elements = formatterResolver.GetFormatterWithVerify<IEnumerable<TElement>>().Deserialize(ref reader, formatterResolver);
					}
				}
				else
				{
					key = formatterResolver.GetFormatterWithVerify<TKey>().Deserialize(ref reader, formatterResolver);
				}
			}
			return new MFIHBGGKNFMEDBBAOB<TKey, TElement>(key, elements);
		}
	}
}

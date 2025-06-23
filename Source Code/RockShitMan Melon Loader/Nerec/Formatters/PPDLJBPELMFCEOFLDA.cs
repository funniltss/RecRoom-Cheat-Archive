using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000102 RID: 258
	public sealed class PPDLJBPELMFCEOFLDA<T> : FLGKBGGCEAHKIBEKBN<T[,]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x000168DC File Offset: 0x00014ADC
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T[,] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			int length = value.GetLength(0);
			int length2 = value.GetLength(1);
			writer.WriteBeginArray();
			for (int i = 0; i < length; i++)
			{
				if (i != 0)
				{
					writer.WriteValueSeparator();
				}
				writer.WriteBeginArray();
				for (int j = 0; j < length2; j++)
				{
					if (j != 0)
					{
						writer.WriteValueSeparator();
					}
					formatterWithVerify.Serialize(ref writer, value[i, j], formatterResolver);
				}
				writer.WriteEndArray();
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00016964 File Offset: 0x00014B64
		public T[,] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>> mgimfhagekmnfoimfl = new MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>(4);
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			int num = 0;
			int num2 = 0;
			reader.ReadIsBeginArrayWithVerify();
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num2))
			{
				MGIMFHAGEKMNFOIMFL<T> mgimfhagekmnfoimfl2 = new MGIMFHAGEKMNFOIMFL<T>((num == 0) ? 4 : num);
				int num3 = 0;
				reader.ReadIsBeginArrayWithVerify();
				while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num3))
				{
					mgimfhagekmnfoimfl2.Add(formatterWithVerify.Deserialize(ref reader, formatterResolver));
				}
				num = mgimfhagekmnfoimfl2.Size;
				mgimfhagekmnfoimfl.Add(mgimfhagekmnfoimfl2);
			}
			T[,] array = new T[mgimfhagekmnfoimfl.Size, num];
			for (int i = 0; i < mgimfhagekmnfoimfl.Size; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[i, j] = mgimfhagekmnfoimfl.Buffer[i].Buffer[j];
				}
			}
			return array;
		}
	}
}

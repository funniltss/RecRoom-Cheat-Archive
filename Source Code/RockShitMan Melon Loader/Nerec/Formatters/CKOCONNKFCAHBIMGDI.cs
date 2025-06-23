using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000103 RID: 259
	public sealed class CKOCONNKFCAHBIMGDI<T> : FLGKBGGCEAHKIBEKBN<T[,,]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x00016A3C File Offset: 0x00014C3C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T[,,] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			int length = value.GetLength(0);
			int length2 = value.GetLength(1);
			int length3 = value.GetLength(2);
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
					writer.WriteBeginArray();
					for (int k = 0; k < length3; k++)
					{
						if (k != 0)
						{
							writer.WriteValueSeparator();
						}
						formatterWithVerify.Serialize(ref writer, value[i, j, k], formatterResolver);
					}
					writer.WriteEndArray();
				}
				writer.WriteEndArray();
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00016AF8 File Offset: 0x00014CF8
		public T[,,] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>> mgimfhagekmnfoimfl = new MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>>(4);
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			reader.ReadIsBeginArrayWithVerify();
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num3))
			{
				MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>> mgimfhagekmnfoimfl2 = new MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>((num2 == 0) ? 4 : num2);
				int num4 = 0;
				reader.ReadIsBeginArrayWithVerify();
				while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num4))
				{
					MGIMFHAGEKMNFOIMFL<T> mgimfhagekmnfoimfl3 = new MGIMFHAGEKMNFOIMFL<T>((num == 0) ? 4 : num);
					int num5 = 0;
					reader.ReadIsBeginArrayWithVerify();
					while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num5))
					{
						mgimfhagekmnfoimfl3.Add(formatterWithVerify.Deserialize(ref reader, formatterResolver));
					}
					num = mgimfhagekmnfoimfl3.Size;
					mgimfhagekmnfoimfl2.Add(mgimfhagekmnfoimfl3);
				}
				num2 = mgimfhagekmnfoimfl2.Size;
				mgimfhagekmnfoimfl.Add(mgimfhagekmnfoimfl2);
			}
			T[,,] array = new T[mgimfhagekmnfoimfl.Size, num2, num];
			for (int i = 0; i < mgimfhagekmnfoimfl.Size; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i, j, k] = mgimfhagekmnfoimfl.Buffer[i].Buffer[j].Buffer[k];
					}
				}
			}
			return array;
		}
	}
}

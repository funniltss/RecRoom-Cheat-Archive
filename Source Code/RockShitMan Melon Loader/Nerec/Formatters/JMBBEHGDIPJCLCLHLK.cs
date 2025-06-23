using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000104 RID: 260
	public sealed class JMBBEHGDIPJCLCLHLK<T> : FLGKBGGCEAHKIBEKBN<T[,,,]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x00016C2C File Offset: 0x00014E2C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T[,,,] value, LMCMANMFGJGJFPNBEN formatterResolver)
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
			int length4 = value.GetLength(3);
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
						writer.WriteBeginArray();
						for (int l = 0; l < length4; l++)
						{
							if (l != 0)
							{
								writer.WriteValueSeparator();
							}
							formatterWithVerify.Serialize(ref writer, value[i, j, k, l], formatterResolver);
						}
						writer.WriteEndArray();
					}
					writer.WriteEndArray();
				}
				writer.WriteEndArray();
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00016D20 File Offset: 0x00014F20
		public T[,,,] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>>> mgimfhagekmnfoimfl = new MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>>>(4);
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			reader.ReadIsBeginArrayWithVerify();
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num4))
			{
				MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>> mgimfhagekmnfoimfl2 = new MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>>((num3 == 0) ? 4 : num3);
				int num5 = 0;
				reader.ReadIsBeginArrayWithVerify();
				while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num5))
				{
					MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>> mgimfhagekmnfoimfl3 = new MGIMFHAGEKMNFOIMFL<MGIMFHAGEKMNFOIMFL<T>>((num2 == 0) ? 4 : num2);
					int num6 = 0;
					reader.ReadIsBeginArrayWithVerify();
					while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num6))
					{
						MGIMFHAGEKMNFOIMFL<T> mgimfhagekmnfoimfl4 = new MGIMFHAGEKMNFOIMFL<T>((num == 0) ? 4 : num);
						int num7 = 0;
						reader.ReadIsBeginArrayWithVerify();
						while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num7))
						{
							mgimfhagekmnfoimfl4.Add(formatterWithVerify.Deserialize(ref reader, formatterResolver));
						}
						num = mgimfhagekmnfoimfl4.Size;
						mgimfhagekmnfoimfl3.Add(mgimfhagekmnfoimfl4);
					}
					num2 = mgimfhagekmnfoimfl3.Size;
					mgimfhagekmnfoimfl2.Add(mgimfhagekmnfoimfl3);
				}
				num3 = mgimfhagekmnfoimfl2.Size;
				mgimfhagekmnfoimfl.Add(mgimfhagekmnfoimfl2);
			}
			T[,,,] array = new T[mgimfhagekmnfoimfl.Size, num3, num2, num];
			for (int i = 0; i < mgimfhagekmnfoimfl.Size; i++)
			{
				for (int j = 0; j < num3; j++)
				{
					for (int k = 0; k < num2; k++)
					{
						for (int l = 0; l < num; l++)
						{
							array[i, j, k, l] = mgimfhagekmnfoimfl.Buffer[i].Buffer[j].Buffer[k].Buffer[l];
						}
					}
				}
			}
			return array;
		}
	}
}

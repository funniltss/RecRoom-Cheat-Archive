using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000CE RID: 206
	public class AKLJJAIHCEBHKDNMDE<T> : FLGKBGGCEAHKIBEKBN<ArraySegment<T>>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600037F RID: 895 RVA: 0x00013E3C File Offset: 0x0001203C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ArraySegment<T> value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value.Array == null)
			{
				writer.WriteNull();
				return;
			}
			T[] array = value.Array;
			int offset = value.Offset;
			int count = value.Count;
			writer.WriteBeginArray();
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			if (count != 0)
			{
				formatterWithVerify.Serialize(ref writer, value.Array[offset], formatterResolver);
			}
			for (int i = 1; i < count; i++)
			{
				writer.WriteValueSeparator();
				formatterWithVerify.Serialize(ref writer, array[offset + i], formatterResolver);
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00013EC4 File Offset: 0x000120C4
		public ArraySegment<T> Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<T> result;
			if (reader.ReadIsNull())
			{
				result = default(ArraySegment<T>);
				return result;
			}
			int num = 0;
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			T[] array = AKLJJAIHCEBHKDNMDE<T>.arrayPool.Rent();
			try
			{
				T[] array2 = array;
				reader.ReadIsBeginArrayWithVerify();
				while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
				{
					if (array2.Length < num)
					{
						Array.Resize<T>(ref array2, array2.Length * 2);
					}
					array2[num - 1] = formatterWithVerify.Deserialize(ref reader, formatterResolver);
				}
				T[] array3 = new T[num];
				Array.Copy(array2, array3, num);
				Array.Clear(array, 0, Math.Min(num, array.Length));
				result = new ArraySegment<T>(array3, 0, array3.Length);
			}
			finally
			{
				AKLJJAIHCEBHKDNMDE<T>.arrayPool.Return(array);
			}
			return result;
		}

		// Token: 0x04000236 RID: 566
		private static readonly FLKLOHJCFNJIBPBADP<T> arrayPool = new FLKLOHJCFNJIBPBADP<T>(99);
	}
}

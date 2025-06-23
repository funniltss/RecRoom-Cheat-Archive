using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000CD RID: 205
	public class IJEPOEPIFGICIEIIDC<T> : FLGKBGGCEAHKIBEKBN<T[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600037B RID: 891 RVA: 0x00013D34 File Offset: 0x00011F34
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			if (value.Length != 0)
			{
				formatterWithVerify.Serialize(ref writer, value[0], formatterResolver);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				formatterWithVerify.Serialize(ref writer, value[i], formatterResolver);
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00013D94 File Offset: 0x00011F94
		public T[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			int num = 0;
			FLGKBGGCEAHKIBEKBN<T> formatterWithVerify = formatterResolver.GetFormatterWithVerify<T>();
			T[] array = IJEPOEPIFGICIEIIDC<T>.arrayPool.Rent();
			T[] result;
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
				result = array3;
			}
			finally
			{
				IJEPOEPIFGICIEIIDC<T>.arrayPool.Return(array);
			}
			return result;
		}

		// Token: 0x04000235 RID: 565
		private static readonly FLKLOHJCFNJIBPBADP<T> arrayPool = new FLKLOHJCFNJIBPBADP<T>(99);
	}
}

using System;

namespace Utf8Json.Formatters
{
	// Token: 0x0200012B RID: 299
	public sealed class FNFLLANKOLKONBIAJO : FLGKBGGCEAHKIBEKBN<string[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x0001816C File Offset: 0x0001636C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, string[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteString(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteString(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000181BC File Offset: 0x000163BC
		public string[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			string[] array = new string[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<string>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadString();
			}
			Array.Resize<string>(ref array, num);
			return array;
		}

		// Token: 0x0400028E RID: 654
		public static readonly FNFLLANKOLKONBIAJO Default = new FNFLLANKOLKONBIAJO();
	}
}

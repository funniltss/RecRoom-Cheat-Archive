using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000120 RID: 288
	public sealed class PCKGPJFBBEPGMDADGH : FLGKBGGCEAHKIBEKBN<float[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060004E9 RID: 1257 RVA: 0x00017960 File Offset: 0x00015B60
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, float[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteSingle(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteSingle(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000179B0 File Offset: 0x00015BB0
		public float[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			float[] array = new float[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<float>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadSingle();
			}
			Array.Resize<float>(ref array, num);
			return array;
		}

		// Token: 0x04000282 RID: 642
		public static readonly PCKGPJFBBEPGMDADGH Default = new PCKGPJFBBEPGMDADGH();
	}
}

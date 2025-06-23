using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000123 RID: 291
	public sealed class IFALDHKCBPMBIPPKII : FLGKBGGCEAHKIBEKBN<double[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00017AA0 File Offset: 0x00015CA0
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, double[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteDouble(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteDouble(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00017AF0 File Offset: 0x00015CF0
		public double[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			double[] array = new double[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<double>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadDouble();
			}
			Array.Resize<double>(ref array, num);
			return array;
		}

		// Token: 0x04000285 RID: 645
		public static readonly IFALDHKCBPMBIPPKII Default = new IFALDHKCBPMBIPPKII();
	}
}

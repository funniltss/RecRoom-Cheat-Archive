using System;

namespace Utf8Json.Formatters
{
	// Token: 0x0200011D RID: 285
	public sealed class FPOKECPOKBPDPMADDG : FLGKBGGCEAHKIBEKBN<ulong[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x00017820 File Offset: 0x00015A20
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ulong[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteUInt64(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteUInt64(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00017870 File Offset: 0x00015A70
		public ulong[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			ulong[] array = new ulong[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<ulong>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadUInt64();
			}
			Array.Resize<ulong>(ref array, num);
			return array;
		}

		// Token: 0x0400027F RID: 639
		public static readonly FPOKECPOKBPDPMADDG Default = new FPOKECPOKBPDPMADDG();
	}
}

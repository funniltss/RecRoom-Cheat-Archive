using System;

namespace Utf8Json.Formatters
{
	// Token: 0x0200010F RID: 271
	public sealed class KLLCCAJMPEMBKHPFNC : FLGKBGGCEAHKIBEKBN<int[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x00017288 File Offset: 0x00015488
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, int[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteInt32(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteInt32(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000172D8 File Offset: 0x000154D8
		public int[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			int[] array = new int[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<int>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadInt32();
			}
			Array.Resize<int>(ref array, num);
			return array;
		}

		// Token: 0x04000271 RID: 625
		public static readonly KLLCCAJMPEMBKHPFNC Default = new KLLCCAJMPEMBKHPFNC();
	}
}

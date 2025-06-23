using System;

namespace Utf8Json.Formatters
{
	// Token: 0x0200010C RID: 268
	public sealed class DPJPIDAFGGIHMNLHAE : FLGKBGGCEAHKIBEKBN<short[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x00017148 File Offset: 0x00015348
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, short[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteInt16(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteInt16(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00017198 File Offset: 0x00015398
		public short[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			short[] array = new short[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<short>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadInt16();
			}
			Array.Resize<short>(ref array, num);
			return array;
		}

		// Token: 0x0400026E RID: 622
		public static readonly DPJPIDAFGGIHMNLHAE Default = new DPJPIDAFGGIHMNLHAE();
	}
}

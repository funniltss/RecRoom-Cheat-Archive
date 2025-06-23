using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000109 RID: 265
	public sealed class GMMAAGDBDNGLLGBIMI : FLGKBGGCEAHKIBEKBN<sbyte[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600046D RID: 1133 RVA: 0x00017008 File Offset: 0x00015208
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, sbyte[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteSByte(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteSByte(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00017058 File Offset: 0x00015258
		public sbyte[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			sbyte[] array = new sbyte[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<sbyte>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadSByte();
			}
			Array.Resize<sbyte>(ref array, num);
			return array;
		}

		// Token: 0x0400026B RID: 619
		public static readonly GMMAAGDBDNGLLGBIMI Default = new GMMAAGDBDNGLLGBIMI();
	}
}

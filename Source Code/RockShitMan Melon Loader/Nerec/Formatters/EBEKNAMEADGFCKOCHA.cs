using System;

namespace Utf8Json.Formatters
{
	// Token: 0x0200011A RID: 282
	public sealed class EBEKNAMEADGFCKOCHA : FLGKBGGCEAHKIBEKBN<uint[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x000176E0 File Offset: 0x000158E0
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, uint[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteUInt32(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteUInt32(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00017730 File Offset: 0x00015930
		public uint[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			uint[] array = new uint[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<uint>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadUInt32();
			}
			Array.Resize<uint>(ref array, num);
			return array;
		}

		// Token: 0x0400027C RID: 636
		public static readonly EBEKNAMEADGFCKOCHA Default = new EBEKNAMEADGFCKOCHA();
	}
}

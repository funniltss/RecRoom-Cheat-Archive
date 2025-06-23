using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000126 RID: 294
	public sealed class DIPILMBALLFAEKKJBA : FLGKBGGCEAHKIBEKBN<bool[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x00017BE0 File Offset: 0x00015DE0
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, bool[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteBoolean(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteBoolean(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00017C30 File Offset: 0x00015E30
		public bool[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			bool[] array = new bool[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<bool>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadBoolean();
			}
			Array.Resize<bool>(ref array, num);
			return array;
		}

		// Token: 0x04000288 RID: 648
		public static readonly DIPILMBALLFAEKKJBA Default = new DIPILMBALLFAEKKJBA();
	}
}

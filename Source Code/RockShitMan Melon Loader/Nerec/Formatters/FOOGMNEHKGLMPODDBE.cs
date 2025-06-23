using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000117 RID: 279
	public sealed class FOOGMNEHKGLMPODDBE : FLGKBGGCEAHKIBEKBN<ushort[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x000175A0 File Offset: 0x000157A0
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ushort[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteUInt16(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteUInt16(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000175F0 File Offset: 0x000157F0
		public ushort[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			ushort[] array = new ushort[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<ushort>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadUInt16();
			}
			Array.Resize<ushort>(ref array, num);
			return array;
		}

		// Token: 0x04000279 RID: 633
		public static readonly FOOGMNEHKGLMPODDBE Default = new FOOGMNEHKGLMPODDBE();
	}
}

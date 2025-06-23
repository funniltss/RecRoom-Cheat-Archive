using System;

namespace Utf8Json.Formatters
{
	// Token: 0x0200012E RID: 302
	public sealed class EGNHBAONECIEHONHOI : FLGKBGGCEAHKIBEKBN<char[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600052B RID: 1323 RVA: 0x00018244 File Offset: 0x00016444
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, char[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				BIBEOBCPDOHAHEBHGB.Default.Serialize(ref writer, value[0], formatterResolver);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				BIBEOBCPDOHAHEBHGB.Default.Serialize(ref writer, value[i], formatterResolver);
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000182A0 File Offset: 0x000164A0
		public char[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			char[] array = new char[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<char>(ref array, num * 2);
				}
				array[num - 1] = BIBEOBCPDOHAHEBHGB.Default.Deserialize(ref reader, formatterResolver);
			}
			Array.Resize<char>(ref array, num);
			return array;
		}

		// Token: 0x04000291 RID: 657
		public static readonly EGNHBAONECIEHONHOI Default = new EGNHBAONECIEHONHOI();
	}
}

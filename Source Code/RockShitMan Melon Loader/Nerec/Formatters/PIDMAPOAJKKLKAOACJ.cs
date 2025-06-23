using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000112 RID: 274
	public sealed class PIDMAPOAJKKLKAOACJ : FLGKBGGCEAHKIBEKBN<long[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x000173C8 File Offset: 0x000155C8
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, long[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			if (value.Length != 0)
			{
				writer.WriteInt64(value[0]);
			}
			for (int i = 1; i < value.Length; i++)
			{
				writer.WriteValueSeparator();
				writer.WriteInt64(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00017418 File Offset: 0x00015618
		public long[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			long[] array = new long[4];
			int num = 0;
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				if (array.Length < num)
				{
					Array.Resize<long>(ref array, num * 2);
				}
				array[num - 1] = reader.ReadInt64();
			}
			Array.Resize<long>(ref array, num);
			return array;
		}

		// Token: 0x04000274 RID: 628
		public static readonly PIDMAPOAJKKLKAOACJ Default = new PIDMAPOAJKKLKAOACJ();
	}
}

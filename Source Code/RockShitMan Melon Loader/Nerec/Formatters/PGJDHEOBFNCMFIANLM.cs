using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000129 RID: 297
	public sealed class PGJDHEOBFNCMFIANLM : FLGKBGGCEAHKIBEKBN<ArraySegment<byte>>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x00005A40 File Offset: 0x00003C40
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ArraySegment<byte> value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value.Array == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteString(Convert.ToBase64String(value.Array, value.Offset, value.Count, Base64FormattingOptions.None));
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00018134 File Offset: 0x00016334
		public ArraySegment<byte> Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return default(ArraySegment<byte>);
			}
			byte[] array = Convert.FromBase64String(reader.ReadString());
			return new ArraySegment<byte>(array, 0, array.Length);
		}

		// Token: 0x0400028C RID: 652
		public static readonly FLGKBGGCEAHKIBEKBN<ArraySegment<byte>> Default = new PGJDHEOBFNCMFIANLM();
	}
}

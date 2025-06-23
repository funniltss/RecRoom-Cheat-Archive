using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000128 RID: 296
	public sealed class JPJCGHBIBCANKABLPB : FLGKBGGCEAHKIBEKBN<byte[]>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00005A04 File Offset: 0x00003C04
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, byte[] value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteString(Convert.ToBase64String(value, Base64FormattingOptions.None));
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00005A1D File Offset: 0x00003C1D
		public byte[] Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return Convert.FromBase64String(reader.ReadString());
		}

		// Token: 0x0400028B RID: 651
		public static readonly FLGKBGGCEAHKIBEKBN<byte[]> Default = new JPJCGHBIBCANKABLPB();
	}
}

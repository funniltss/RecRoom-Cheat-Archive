using System;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E5 RID: 229
	public sealed class OHANNICJAMDLIFELPF : FLGKBGGCEAHKIBEKBN<DateTime?>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003DB RID: 987 RVA: 0x00004F6E File Offset: 0x0000316E
		public OHANNICJAMDLIFELPF()
		{
			this.innerFormatter = new ICAIPKKEFMGOBDLGNB();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00004F81 File Offset: 0x00003181
		public OHANNICJAMDLIFELPF(string formatString)
		{
			this.innerFormatter = new ICAIPKKEFMGOBDLGNB(formatString);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00004F95 File Offset: 0x00003195
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, DateTime? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			this.innerFormatter.Serialize(ref writer, value.Value, formatterResolver);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00014568 File Offset: 0x00012768
		public DateTime? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new DateTime?(this.innerFormatter.Deserialize(ref reader, formatterResolver));
		}

		// Token: 0x0400023E RID: 574
		private readonly ICAIPKKEFMGOBDLGNB innerFormatter;
	}
}

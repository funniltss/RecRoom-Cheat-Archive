using System;

namespace Utf8Json.Formatters
{
	// Token: 0x0200012A RID: 298
	public sealed class JKKPKILCICOPILBOOM : FLGKBGGCEAHKIBEKBN<string>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<string>
	{
		// Token: 0x06000519 RID: 1305 RVA: 0x00005A7F File Offset: 0x00003C7F
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, string value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteString(value);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00005A88 File Offset: 0x00003C88
		public string Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadString();
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00005A7F File Offset: 0x00003C7F
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, string value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteString(value);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00005A88 File Offset: 0x00003C88
		public string DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadString();
		}

		// Token: 0x0400028D RID: 653
		public static readonly FLGKBGGCEAHKIBEKBN<string> Default = new JKKPKILCICOPILBOOM();
	}
}

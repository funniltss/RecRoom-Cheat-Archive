using System;

namespace Utf8Json.Formatters
{
	// Token: 0x020000EB RID: 235
	public sealed class BANMBBILGINALLANGK : FLGKBGGCEAHKIBEKBN<TimeSpan>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x0000506A File Offset: 0x0000326A
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, TimeSpan value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteString(value.ToString());
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000507F File Offset: 0x0000327F
		public TimeSpan Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return TimeSpan.Parse(reader.ReadString());
		}
	}
}

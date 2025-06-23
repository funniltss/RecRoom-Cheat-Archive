using System;

namespace Utf8Json.Formatters
{
	// Token: 0x020000EC RID: 236
	public sealed class EHPIFJOFFDNBOEBMMO : FLGKBGGCEAHKIBEKBN<TimeSpan?>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003F6 RID: 1014 RVA: 0x0000508C File Offset: 0x0000328C
		public EHPIFJOFFDNBOEBMMO()
		{
			this.innerFormatter = new BANMBBILGINALLANGK();
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000509F File Offset: 0x0000329F
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, TimeSpan? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			this.innerFormatter.Serialize(ref writer, value.Value, formatterResolver);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00015648 File Offset: 0x00013848
		public TimeSpan? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new TimeSpan?(this.innerFormatter.Deserialize(ref reader, formatterResolver));
		}

		// Token: 0x04000244 RID: 580
		private readonly BANMBBILGINALLANGK innerFormatter;
	}
}

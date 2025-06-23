using System;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E9 RID: 233
	public sealed class MHBKJELGBJKJEKGMNM : FLGKBGGCEAHKIBEKBN<DateTimeOffset?>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x00005011 File Offset: 0x00003211
		public MHBKJELGBJKJEKGMNM()
		{
			this.innerFormatter = new PGDBPPMMBNEHAMOLIB();
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00005024 File Offset: 0x00003224
		public MHBKJELGBJKJEKGMNM(string formatString)
		{
			this.innerFormatter = new PGDBPPMMBNEHAMOLIB(formatString);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00005038 File Offset: 0x00003238
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, DateTimeOffset? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			this.innerFormatter.Serialize(ref writer, value.Value, formatterResolver);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00014E74 File Offset: 0x00013074
		public DateTimeOffset? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new DateTimeOffset?(this.innerFormatter.Deserialize(ref reader, formatterResolver));
		}

		// Token: 0x04000242 RID: 578
		private readonly PGDBPPMMBNEHAMOLIB innerFormatter;
	}
}

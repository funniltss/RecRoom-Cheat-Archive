using System;
using System.Globalization;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E8 RID: 232
	public sealed class PGDBPPMMBNEHAMOLIB : FLGKBGGCEAHKIBEKBN<DateTimeOffset>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x00004FDE File Offset: 0x000031DE
		public PGDBPPMMBNEHAMOLIB()
		{
			this.formatString = null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00004FED File Offset: 0x000031ED
		public PGDBPPMMBNEHAMOLIB(string formatString)
		{
			this.formatString = formatString;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00004FFC File Offset: 0x000031FC
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, DateTimeOffset value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteString(value.ToString(this.formatString));
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00014E38 File Offset: 0x00013038
		public DateTimeOffset Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			string input = reader.ReadString();
			if (this.formatString == null)
			{
				return DateTimeOffset.Parse(input, CultureInfo.InvariantCulture);
			}
			return DateTimeOffset.ParseExact(input, this.formatString, CultureInfo.InvariantCulture);
		}

		// Token: 0x04000241 RID: 577
		private readonly string formatString;
	}
}

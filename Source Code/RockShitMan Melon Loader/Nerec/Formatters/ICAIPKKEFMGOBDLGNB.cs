using System;
using System.Globalization;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E4 RID: 228
	public sealed class ICAIPKKEFMGOBDLGNB : FLGKBGGCEAHKIBEKBN<DateTime>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x00004F3B File Offset: 0x0000313B
		public ICAIPKKEFMGOBDLGNB()
		{
			this.formatString = null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00004F4A File Offset: 0x0000314A
		public ICAIPKKEFMGOBDLGNB(string formatString)
		{
			this.formatString = formatString;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00004F59 File Offset: 0x00003159
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, DateTime value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteString(value.ToString(this.formatString));
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001452C File Offset: 0x0001272C
		public DateTime Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			string s = reader.ReadString();
			if (this.formatString == null)
			{
				return DateTime.Parse(s, CultureInfo.InvariantCulture);
			}
			return DateTime.ParseExact(s, this.formatString, CultureInfo.InvariantCulture);
		}

		// Token: 0x0400023D RID: 573
		private readonly string formatString;
	}
}

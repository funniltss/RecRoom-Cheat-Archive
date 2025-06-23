using System;
using System.Globalization;

namespace Utf8Json.Formatters
{
	// Token: 0x0200012C RID: 300
	public sealed class BIBEOBCPDOHAHEBHGB : FLGKBGGCEAHKIBEKBN<char>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, char value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteString(value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00005ABC File Offset: 0x00003CBC
		public char Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadString()[0];
		}

		// Token: 0x0400028F RID: 655
		public static readonly BIBEOBCPDOHAHEBHGB Default = new BIBEOBCPDOHAHEBHGB();
	}
}

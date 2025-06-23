using System;
using System.Text;

namespace Utf8Json.Formatters
{
	// Token: 0x02000134 RID: 308
	public sealed class PBIAGDAMFKDEDPEIPO : FLGKBGGCEAHKIBEKBN<StringBuilder>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x00005C14 File Offset: 0x00003E14
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, StringBuilder value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteString(value.ToString());
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00005C2C File Offset: 0x00003E2C
		public StringBuilder Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new StringBuilder(reader.ReadString());
		}

		// Token: 0x04000297 RID: 663
		public static readonly FLGKBGGCEAHKIBEKBN<StringBuilder> Default = new PBIAGDAMFKDEDPEIPO();
	}
}

using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000132 RID: 306
	public sealed class PFKAAEIEJKDOFKHAOA : FLGKBGGCEAHKIBEKBN<Version>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x00005BD3 File Offset: 0x00003DD3
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, Version value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteString(value.ToString());
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00005BF1 File Offset: 0x00003DF1
		public Version Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new Version(reader.ReadString());
		}

		// Token: 0x04000296 RID: 662
		public static readonly FLGKBGGCEAHKIBEKBN<Version> Default = new PFKAAEIEJKDOFKHAOA();
	}
}

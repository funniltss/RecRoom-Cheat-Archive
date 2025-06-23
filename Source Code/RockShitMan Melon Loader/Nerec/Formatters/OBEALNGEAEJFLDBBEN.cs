using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000131 RID: 305
	public sealed class OBEALNGEAEJFLDBBEN : FLGKBGGCEAHKIBEKBN<Uri>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x00005B91 File Offset: 0x00003D91
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, Uri value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteString(value.ToString());
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00005BAF File Offset: 0x00003DAF
		public Uri Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new Uri(reader.ReadString(), UriKind.RelativeOrAbsolute);
		}

		// Token: 0x04000295 RID: 661
		public static readonly FLGKBGGCEAHKIBEKBN<Uri> Default = new OBEALNGEAEJFLDBBEN();
	}
}

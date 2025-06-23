using System;

namespace Utf8Json.Formatters
{
	// Token: 0x0200012D RID: 301
	public sealed class OKFEHAMDJMGDLEJKEN : FLGKBGGCEAHKIBEKBN<char?>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x00005AD6 File Offset: 0x00003CD6
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, char? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			BIBEOBCPDOHAHEBHGB.Default.Serialize(ref writer, value.Value, formatterResolver);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00018214 File Offset: 0x00016414
		public char? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new char?(BIBEOBCPDOHAHEBHGB.Default.Deserialize(ref reader, formatterResolver));
		}

		// Token: 0x04000290 RID: 656
		public static readonly OKFEHAMDJMGDLEJKEN Default = new OKFEHAMDJMGDLEJKEN();
	}
}

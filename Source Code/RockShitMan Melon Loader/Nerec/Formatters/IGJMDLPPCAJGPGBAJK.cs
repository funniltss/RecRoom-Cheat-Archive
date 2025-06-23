using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200011B RID: 283
	public sealed class IGJMDLPPCAJGPGBAJK : FLGKBGGCEAHKIBEKBN<ulong>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<ulong>
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x000057B4 File Offset: 0x000039B4
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ulong value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteUInt64(value);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000057BD File Offset: 0x000039BD
		public ulong Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadUInt64();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000057C5 File Offset: 0x000039C5
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, ulong value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteUInt64(value);
			writer.WriteQuotation();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00017788 File Offset: 0x00015988
		public ulong DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadUInt64(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x0400027D RID: 637
		public static readonly IGJMDLPPCAJGPGBAJK Default = new IGJMDLPPCAJGPGBAJK();
	}
}

using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000107 RID: 263
	public sealed class IMJGNHMCICEJCFGNDI : FLGKBGGCEAHKIBEKBN<sbyte>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<sbyte>
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x000053B4 File Offset: 0x000035B4
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, sbyte value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteSByte(value);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000053BD File Offset: 0x000035BD
		public sbyte Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadSByte();
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000053C5 File Offset: 0x000035C5
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, sbyte value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteSByte(value);
			writer.WriteQuotation();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00016F70 File Offset: 0x00015170
		public sbyte DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadSByte(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x04000269 RID: 617
		public static readonly IMJGNHMCICEJCFGNDI Default = new IMJGNHMCICEJCFGNDI();
	}
}

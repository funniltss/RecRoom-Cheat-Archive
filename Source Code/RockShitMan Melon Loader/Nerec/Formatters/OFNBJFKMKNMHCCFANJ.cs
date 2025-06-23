using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000115 RID: 277
	public sealed class OFNBJFKMKNMHCCFANJ : FLGKBGGCEAHKIBEKBN<ushort>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<ushort>
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x0000568C File Offset: 0x0000388C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ushort value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteUInt16(value);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00005695 File Offset: 0x00003895
		public ushort Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadUInt16();
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000569D File Offset: 0x0000389D
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, ushort value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteUInt16(value);
			writer.WriteQuotation();
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00017508 File Offset: 0x00015708
		public ushort DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadUInt16(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x04000277 RID: 631
		public static readonly OFNBJFKMKNMHCCFANJ Default = new OFNBJFKMKNMHCCFANJ();
	}
}

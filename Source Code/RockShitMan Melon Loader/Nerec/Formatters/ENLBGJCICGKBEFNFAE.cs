using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000110 RID: 272
	public sealed class ENLBGJCICGKBEFNFAE : FLGKBGGCEAHKIBEKBN<long>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<long>
	{
		// Token: 0x06000491 RID: 1169 RVA: 0x00005570 File Offset: 0x00003770
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, long value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteInt64(value);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00005579 File Offset: 0x00003779
		public long Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadInt64();
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00005581 File Offset: 0x00003781
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, long value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteInt64(value);
			writer.WriteQuotation();
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00017330 File Offset: 0x00015530
		public long DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadInt64(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x04000272 RID: 626
		public static readonly ENLBGJCICGKBEFNFAE Default = new ENLBGJCICGKBEFNFAE();
	}
}

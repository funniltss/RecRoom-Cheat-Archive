using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000118 RID: 280
	public sealed class GIMAMOBODNKDLPJLFH : FLGKBGGCEAHKIBEKBN<uint>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<uint>
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00005720 File Offset: 0x00003920
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, uint value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteUInt32(value);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00005729 File Offset: 0x00003929
		public uint Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadUInt32();
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00005731 File Offset: 0x00003931
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, uint value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteUInt32(value);
			writer.WriteQuotation();
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00017648 File Offset: 0x00015848
		public uint DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadUInt32(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x0400027A RID: 634
		public static readonly GIMAMOBODNKDLPJLFH Default = new GIMAMOBODNKDLPJLFH();
	}
}

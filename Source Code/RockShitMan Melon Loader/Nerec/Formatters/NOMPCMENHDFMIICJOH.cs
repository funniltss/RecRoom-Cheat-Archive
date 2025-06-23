using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000113 RID: 275
	public sealed class NOMPCMENHDFMIICJOH : FLGKBGGCEAHKIBEKBN<byte>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<byte>
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x00005604 File Offset: 0x00003804
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, byte value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteByte(value);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000560D File Offset: 0x0000380D
		public byte Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadByte();
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00005615 File Offset: 0x00003815
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, byte value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteByte(value);
			writer.WriteQuotation();
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00017470 File Offset: 0x00015670
		public byte DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadByte(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x04000275 RID: 629
		public static readonly NOMPCMENHDFMIICJOH Default = new NOMPCMENHDFMIICJOH();
	}
}

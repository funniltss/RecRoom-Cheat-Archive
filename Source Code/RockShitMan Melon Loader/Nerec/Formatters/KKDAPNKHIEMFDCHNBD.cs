using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200010A RID: 266
	public sealed class KKDAPNKHIEMFDCHNBD : FLGKBGGCEAHKIBEKBN<short>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<short>
	{
		// Token: 0x06000471 RID: 1137 RVA: 0x00005448 File Offset: 0x00003648
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, short value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteInt16(value);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00005451 File Offset: 0x00003651
		public short Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadInt16();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00005459 File Offset: 0x00003659
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, short value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteInt16(value);
			writer.WriteQuotation();
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000170B0 File Offset: 0x000152B0
		public short DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadInt16(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x0400026C RID: 620
		public static readonly KKDAPNKHIEMFDCHNBD Default = new KKDAPNKHIEMFDCHNBD();
	}
}

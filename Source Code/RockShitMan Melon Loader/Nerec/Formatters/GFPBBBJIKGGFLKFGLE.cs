using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200010D RID: 269
	public sealed class GFPBBBJIKGGFLKFGLE : FLGKBGGCEAHKIBEKBN<int>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<int>
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x000054DC File Offset: 0x000036DC
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, int value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteInt32(value);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000054E5 File Offset: 0x000036E5
		public int Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadInt32();
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000054ED File Offset: 0x000036ED
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, int value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteInt32(value);
			writer.WriteQuotation();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000171F0 File Offset: 0x000153F0
		public int DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadInt32(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x0400026F RID: 623
		public static readonly GFPBBBJIKGGFLKFGLE Default = new GFPBBBJIKGGFLKFGLE();
	}
}

using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000124 RID: 292
	public sealed class PKJMJJMLCBICLOGOJI : FLGKBGGCEAHKIBEKBN<bool>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<bool>
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x00005970 File Offset: 0x00003B70
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, bool value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteBoolean(value);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00005979 File Offset: 0x00003B79
		public bool Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadBoolean();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00005981 File Offset: 0x00003B81
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, bool value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteBoolean(value);
			writer.WriteQuotation();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00017B48 File Offset: 0x00015D48
		public bool DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadBoolean(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x04000286 RID: 646
		public static readonly PKJMJJMLCBICLOGOJI Default = new PKJMJJMLCBICLOGOJI();
	}
}

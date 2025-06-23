using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200011E RID: 286
	public sealed class LNGJKFEBMOLLNKPPKM : FLGKBGGCEAHKIBEKBN<float>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<float>
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x00005848 File Offset: 0x00003A48
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, float value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteSingle(value);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00005851 File Offset: 0x00003A51
		public float Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadSingle();
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00005859 File Offset: 0x00003A59
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, float value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteSingle(value);
			writer.WriteQuotation();
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000178C8 File Offset: 0x00015AC8
		public float DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadSingle(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x04000280 RID: 640
		public static readonly LNGJKFEBMOLLNKPPKM Default = new LNGJKFEBMOLLNKPPKM();
	}
}

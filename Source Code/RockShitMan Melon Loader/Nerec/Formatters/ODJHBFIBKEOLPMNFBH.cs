using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000121 RID: 289
	public sealed class ODJHBFIBKEOLPMNFBH : FLGKBGGCEAHKIBEKBN<double>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<double>
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x000058DC File Offset: 0x00003ADC
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, double value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteDouble(value);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000058E5 File Offset: 0x00003AE5
		public double Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return reader.ReadDouble();
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000058ED File Offset: 0x00003AED
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, double value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteQuotation();
			writer.WriteDouble(value);
			writer.WriteQuotation();
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00017A08 File Offset: 0x00015C08
		public double DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return OCPOKGPLBCLIEHKKHN.ReadDouble(arraySegment.Array, arraySegment.Offset, out num);
		}

		// Token: 0x04000283 RID: 643
		public static readonly ODJHBFIBKEOLPMNFBH Default = new ODJHBFIBKEOLPMNFBH();
	}
}

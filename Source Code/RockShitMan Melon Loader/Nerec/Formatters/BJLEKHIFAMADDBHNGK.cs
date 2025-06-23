using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000122 RID: 290
	public sealed class BJLEKHIFAMADDBHNGK : FLGKBGGCEAHKIBEKBN<double?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<double?>
	{
		// Token: 0x060004F3 RID: 1267 RVA: 0x0000590E File Offset: 0x00003B0E
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, double? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteDouble(value.Value);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00017A34 File Offset: 0x00015C34
		public double? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new double?(reader.ReadDouble());
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000592D File Offset: 0x00003B2D
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, double? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteDouble(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00017A60 File Offset: 0x00015C60
		public double? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new double?(OCPOKGPLBCLIEHKKHN.ReadDouble(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x04000284 RID: 644
		public static readonly BJLEKHIFAMADDBHNGK Default = new BJLEKHIFAMADDBHNGK();
	}
}

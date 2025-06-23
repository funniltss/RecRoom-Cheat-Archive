using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200011F RID: 287
	public sealed class DFELCGIFFJGKPOLHBG : FLGKBGGCEAHKIBEKBN<float?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<float?>
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x0000587A File Offset: 0x00003A7A
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, float? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteSingle(value.Value);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000178F4 File Offset: 0x00015AF4
		public float? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new float?(reader.ReadSingle());
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00005899 File Offset: 0x00003A99
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, float? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteSingle(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00017920 File Offset: 0x00015B20
		public float? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new float?(OCPOKGPLBCLIEHKKHN.ReadSingle(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x04000281 RID: 641
		public static readonly DFELCGIFFJGKPOLHBG Default = new DFELCGIFFJGKPOLHBG();
	}
}

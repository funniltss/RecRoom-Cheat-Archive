using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000116 RID: 278
	public sealed class LBIMCNIBNIJKDCNNFB : FLGKBGGCEAHKIBEKBN<ushort?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<ushort?>
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x000056BE File Offset: 0x000038BE
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ushort? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteUInt16(value.Value);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00017534 File Offset: 0x00015734
		public ushort? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new ushort?(reader.ReadUInt16());
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000056DD File Offset: 0x000038DD
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, ushort? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteUInt16(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00017560 File Offset: 0x00015760
		public ushort? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new ushort?(OCPOKGPLBCLIEHKKHN.ReadUInt16(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x04000278 RID: 632
		public static readonly LBIMCNIBNIJKDCNNFB Default = new LBIMCNIBNIJKDCNNFB();
	}
}

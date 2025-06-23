using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200011C RID: 284
	public sealed class JDKMENEBBPMBIKPJNH : FLGKBGGCEAHKIBEKBN<ulong?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<ulong?>
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x000057E6 File Offset: 0x000039E6
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, ulong? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteUInt64(value.Value);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000177B4 File Offset: 0x000159B4
		public ulong? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new ulong?(reader.ReadUInt64());
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00005805 File Offset: 0x00003A05
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, ulong? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteUInt64(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000177E0 File Offset: 0x000159E0
		public ulong? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new ulong?(OCPOKGPLBCLIEHKKHN.ReadUInt64(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x0400027E RID: 638
		public static readonly JDKMENEBBPMBIKPJNH Default = new JDKMENEBBPMBIKPJNH();
	}
}

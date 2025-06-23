using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000119 RID: 281
	public sealed class HKEBKNGGDLPBAKMEEJ : FLGKBGGCEAHKIBEKBN<uint?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<uint?>
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00005752 File Offset: 0x00003952
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, uint? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteUInt32(value.Value);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00017674 File Offset: 0x00015874
		public uint? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new uint?(reader.ReadUInt32());
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00005771 File Offset: 0x00003971
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, uint? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteUInt32(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000176A0 File Offset: 0x000158A0
		public uint? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new uint?(OCPOKGPLBCLIEHKKHN.ReadUInt32(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x0400027B RID: 635
		public static readonly HKEBKNGGDLPBAKMEEJ Default = new HKEBKNGGDLPBAKMEEJ();
	}
}

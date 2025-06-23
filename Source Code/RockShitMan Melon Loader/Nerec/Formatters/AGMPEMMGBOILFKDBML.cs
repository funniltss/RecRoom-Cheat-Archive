using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200010B RID: 267
	public sealed class AGMPEMMGBOILFKDBML : FLGKBGGCEAHKIBEKBN<short?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<short?>
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x0000547A File Offset: 0x0000367A
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, short? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteInt16(value.Value);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000170DC File Offset: 0x000152DC
		public short? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new short?(reader.ReadInt16());
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00005499 File Offset: 0x00003699
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, short? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteInt16(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00017108 File Offset: 0x00015308
		public short? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new short?(OCPOKGPLBCLIEHKKHN.ReadInt16(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x0400026D RID: 621
		public static readonly AGMPEMMGBOILFKDBML Default = new AGMPEMMGBOILFKDBML();
	}
}

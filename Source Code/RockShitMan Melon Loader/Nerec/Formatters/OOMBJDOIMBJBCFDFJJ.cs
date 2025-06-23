using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200010E RID: 270
	public sealed class OOMBJDOIMBJBCFDFJJ : FLGKBGGCEAHKIBEKBN<int?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<int?>
	{
		// Token: 0x06000487 RID: 1159 RVA: 0x0000550E File Offset: 0x0000370E
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, int? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteInt32(value.Value);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001721C File Offset: 0x0001541C
		public int? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new int?(reader.ReadInt32());
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000552D File Offset: 0x0000372D
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, int? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteInt32(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00017248 File Offset: 0x00015448
		public int? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new int?(OCPOKGPLBCLIEHKKHN.ReadInt32(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x04000270 RID: 624
		public static readonly OOMBJDOIMBJBCFDFJJ Default = new OOMBJDOIMBJBCFDFJJ();
	}
}

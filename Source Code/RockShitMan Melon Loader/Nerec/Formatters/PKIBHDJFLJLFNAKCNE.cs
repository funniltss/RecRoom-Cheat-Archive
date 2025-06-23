using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000108 RID: 264
	public sealed class PKIBHDJFLJLFNAKCNE : FLGKBGGCEAHKIBEKBN<sbyte?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<sbyte?>
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x000053E6 File Offset: 0x000035E6
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, sbyte? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteSByte(value.Value);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00016F9C File Offset: 0x0001519C
		public sbyte? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new sbyte?(reader.ReadSByte());
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00005405 File Offset: 0x00003605
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, sbyte? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteSByte(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00016FC8 File Offset: 0x000151C8
		public sbyte? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new sbyte?(OCPOKGPLBCLIEHKKHN.ReadSByte(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x0400026A RID: 618
		public static readonly PKIBHDJFLJLFNAKCNE Default = new PKIBHDJFLJLFNAKCNE();
	}
}

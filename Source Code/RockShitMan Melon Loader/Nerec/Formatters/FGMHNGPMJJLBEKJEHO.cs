using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000114 RID: 276
	public sealed class FGMHNGPMJJLBEKJEHO : FLGKBGGCEAHKIBEKBN<byte?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<byte?>
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x00005636 File Offset: 0x00003836
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, byte? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteByte(value.Value);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001749C File Offset: 0x0001569C
		public byte? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new byte?(reader.ReadByte());
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00005655 File Offset: 0x00003855
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, byte? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteByte(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000174C8 File Offset: 0x000156C8
		public byte? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new byte?(OCPOKGPLBCLIEHKKHN.ReadByte(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x04000276 RID: 630
		public static readonly FGMHNGPMJJLBEKJEHO Default = new FGMHNGPMJJLBEKJEHO();
	}
}

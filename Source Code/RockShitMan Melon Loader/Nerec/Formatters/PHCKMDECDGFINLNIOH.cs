using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000111 RID: 273
	public sealed class PHCKMDECDGFINLNIOH : FLGKBGGCEAHKIBEKBN<long?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<long?>
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x000055A2 File Offset: 0x000037A2
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, long? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteInt64(value.Value);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001735C File Offset: 0x0001555C
		public long? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new long?(reader.ReadInt64());
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000055C1 File Offset: 0x000037C1
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, long? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteInt64(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00017388 File Offset: 0x00015588
		public long? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new long?(OCPOKGPLBCLIEHKKHN.ReadInt64(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x04000273 RID: 627
		public static readonly PHCKMDECDGFINLNIOH Default = new PHCKMDECDGFINLNIOH();
	}
}

using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x0200012F RID: 303
	public sealed class LCAAILBDJOKGFOKBAP : FLGKBGGCEAHKIBEKBN<Guid>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<Guid>
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x000182FC File Offset: 0x000164FC
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, Guid value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.EnsureCapacity(38);
			writer.WriteRawUnsafe(34);
			ArraySegment<byte> buffer = writer.GetBuffer();
			new LNMOFFKENDGOEDLKBN(ref value).Write(buffer.Array, writer.IPKBDDBJOANCNNAFJP);
			writer.AdvanceOffset(36);
			writer.WriteRawUnsafe(34);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001834C File Offset: 0x0001654C
		public Guid Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentUnsafe();
			return new LNMOFFKENDGOEDLKBN(ref arraySegment).Value;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00005B13 File Offset: 0x00003D13
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, Guid value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			this.Serialize(ref writer, value, formatterResolver);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00005B1E File Offset: 0x00003D1E
		public Guid DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return this.Deserialize(ref reader, formatterResolver);
		}

		// Token: 0x04000292 RID: 658
		public static readonly FLGKBGGCEAHKIBEKBN<Guid> Default = new LCAAILBDJOKGFOKBAP();
	}
}

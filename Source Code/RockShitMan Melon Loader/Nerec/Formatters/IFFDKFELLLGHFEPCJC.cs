using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E7 RID: 231
	public sealed class IFFDKFELLLGHFEPCJC : FLGKBGGCEAHKIBEKBN<DateTime>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x00014DC0 File Offset: 0x00012FC0
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, DateTime value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			long value2 = (long)(value.ToUniversalTime() - IFFDKFELLLGHFEPCJC.UnixEpoch).TotalSeconds;
			writer.WriteQuotation();
			writer.WriteInt64(value2);
			writer.WriteQuotation();
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00014DFC File Offset: 0x00012FFC
		public DateTime Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentUnsafe();
			int num2;
			ulong num = OCPOKGPLBCLIEHKKHN.ReadUInt64(arraySegment.Array, arraySegment.Offset, out num2);
			return IFFDKFELLLGHFEPCJC.UnixEpoch.AddSeconds(num);
		}

		// Token: 0x04000240 RID: 576
		private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	}
}

using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000101 RID: 257
	public sealed class EEGEGBBHADFJPDNCHK<T> : FLGKBGGCEAHKIBEKBN<T>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x00005351 File Offset: 0x00003551
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			writer.WriteNull();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000168C0 File Offset: 0x00014AC0
		public T Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			reader.ReadNextBlock();
			return default(T);
		}
	}
}

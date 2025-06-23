using System;

namespace Utf8Json.Formatters
{
	// Token: 0x020000CC RID: 204
	public sealed class BOIHDJICFGNOEACKGP<T> : FLGKBGGCEAHKIBEKBN<T>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00004CCC File Offset: 0x00002ECC
		public BOIHDJICFGNOEACKGP(OJFAAEDNBNAMBCPLED<T> serialize, PCPKEIOPEDBCBJAJCJ<T> deserialize)
		{
			this.serialize = serialize;
			this.deserialize = deserialize;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00004CE2 File Offset: 0x00002EE2
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (this.serialize == null)
			{
				throw new InvalidOperationException(base.GetType().Name + " does not support Serialize.");
			}
			this.serialize(ref writer, value, formatterResolver);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00004D15 File Offset: 0x00002F15
		public T Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (this.deserialize == null)
			{
				throw new InvalidOperationException(base.GetType().Name + " does not support Deserialize.");
			}
			return this.deserialize(ref reader, formatterResolver);
		}

		// Token: 0x04000233 RID: 563
		private readonly OJFAAEDNBNAMBCPLED<T> serialize;

		// Token: 0x04000234 RID: 564
		private readonly PCPKEIOPEDBCBJAJCJ<T> deserialize;
	}
}

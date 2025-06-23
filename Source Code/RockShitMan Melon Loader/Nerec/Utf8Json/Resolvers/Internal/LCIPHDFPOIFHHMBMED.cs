using System;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200005F RID: 95
	internal class LCIPHDFPOIFHHMBMED<T> : FLGKBGGCEAHKIBEKBN<T>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000186 RID: 390 RVA: 0x000034BF File Offset: 0x000016BF
		public LCIPHDFPOIFHHMBMED(byte[][] stringByteKeysField, object[] serializeCustomFormatters, object[] deserializeCustomFormatters, NOICGFGCECKIDDMBKC<T> serialize, POONOLDLJBGBIPLHLJ<T> deserialize)
		{
			this.stringByteKeysField = stringByteKeysField;
			this.serializeCustomFormatters = serializeCustomFormatters;
			this.deserializeCustomFormatters = deserializeCustomFormatters;
			this.serialize = serialize;
			this.deserialize = deserialize;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000034EC File Offset: 0x000016EC
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (this.serialize == null)
			{
				throw new InvalidOperationException(base.GetType().Name + " does not support Serialize.");
			}
			this.serialize(this.stringByteKeysField, this.serializeCustomFormatters, ref writer, value, formatterResolver);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000352B File Offset: 0x0000172B
		public T Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (this.deserialize == null)
			{
				throw new InvalidOperationException(base.GetType().Name + " does not support Deserialize.");
			}
			return this.deserialize(this.deserializeCustomFormatters, ref reader, formatterResolver);
		}

		// Token: 0x040000F2 RID: 242
		private readonly byte[][] stringByteKeysField;

		// Token: 0x040000F3 RID: 243
		private readonly object[] serializeCustomFormatters;

		// Token: 0x040000F4 RID: 244
		private readonly object[] deserializeCustomFormatters;

		// Token: 0x040000F5 RID: 245
		private readonly NOICGFGCECKIDDMBKC<T> serialize;

		// Token: 0x040000F6 RID: 246
		private readonly POONOLDLJBGBIPLHLJ<T> deserialize;
	}
}

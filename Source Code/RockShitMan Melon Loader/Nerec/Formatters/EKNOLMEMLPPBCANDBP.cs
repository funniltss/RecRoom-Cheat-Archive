using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000106 RID: 262
	public sealed class EKNOLMEMLPPBCANDBP<T> : FLGKBGGCEAHKIBEKBN<T?>, DDGADMMMOKKMDLNAEK where T : struct
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x0000537F File Offset: 0x0000357F
		public EKNOLMEMLPPBCANDBP(FLGKBGGCEAHKIBEKBN<T> underlyingFormatter)
		{
			this.underlyingFormatter = underlyingFormatter;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00016EEC File Offset: 0x000150EC
		public EKNOLMEMLPPBCANDBP(Type formatterType, object[] formatterArguments)
		{
			try
			{
				this.underlyingFormatter = (FLGKBGGCEAHKIBEKBN<T>)Activator.CreateInstance(formatterType, formatterArguments);
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("Can not create formatter from JsonFormatterAttribute, check the target formatter is public and has constructor with right argument. FormatterType:" + formatterType.Name, innerException);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000538E File Offset: 0x0000358E
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			this.underlyingFormatter.Serialize(ref writer, value.Value, formatterResolver);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00016F3C File Offset: 0x0001513C
		public T? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new T?(this.underlyingFormatter.Deserialize(ref reader, formatterResolver));
		}

		// Token: 0x04000268 RID: 616
		private readonly FLGKBGGCEAHKIBEKBN<T> underlyingFormatter;
	}
}

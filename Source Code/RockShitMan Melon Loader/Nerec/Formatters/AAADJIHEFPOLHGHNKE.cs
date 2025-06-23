using System;

namespace Utf8Json.Formatters
{
	// Token: 0x02000105 RID: 261
	public sealed class AAADJIHEFPOLHGHNKE<T> : FLGKBGGCEAHKIBEKBN<T?>, DDGADMMMOKKMDLNAEK where T : struct
	{
		// Token: 0x0600045A RID: 1114 RVA: 0x00005359 File Offset: 0x00003559
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			formatterResolver.GetFormatterWithVerify<T>().Serialize(ref writer, value.Value, formatterResolver);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00016EB8 File Offset: 0x000150B8
		public T? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new T?(formatterResolver.GetFormatterWithVerify<T>().Deserialize(ref reader, formatterResolver));
		}
	}
}

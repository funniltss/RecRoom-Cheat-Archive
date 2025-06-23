using System;
using System.Reflection;

namespace Utf8Json.Resolvers
{
	// Token: 0x0200001E RID: 30
	public sealed class KNNODPPCNHCIHAIDAO : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002B7C File Offset: 0x00000D7C
		private KNNODPPCNHCIHAIDAO()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002D66 File Offset: 0x00000F66
		public FLGKBGGCEAHKIBEKBN<NLIEMHPJDAAONMOAEA> GetFormatter<NLIEMHPJDAAONMOAEA>()
		{
			return KNNODPPCNHCIHAIDAO<NLIEMHPJDAAONMOAEA>.GIBJBGCJGDONKMNCNO.formatter;
		}

		// Token: 0x04000032 RID: 50
		public static LMCMANMFGJGJFPNBEN Instance = new KNNODPPCNHCIHAIDAO();

		// Token: 0x0200001F RID: 31
		private static class GIBJBGCJGDONKMNCNO<T>
		{
			// Token: 0x060000D9 RID: 217 RVA: 0x00008ED4 File Offset: 0x000070D4
			static GIBJBGCJGDONKMNCNO()
			{
				BHBMDGIJKJJJKFJCIF customAttribute = typeof(T).GetTypeInfo().GetCustomAttribute<BHBMDGIJKJJJKFJCIF>();
				if (customAttribute == null)
				{
					return;
				}
				try
				{
					if (customAttribute.APIMLHBDDPMHACKCOL.IsGenericType && !customAttribute.APIMLHBDDPMHACKCOL.GetTypeInfo().IsConstructedGenericType)
					{
						KNNODPPCNHCIHAIDAO<T>.GIBJBGCJGDONKMNCNO.formatter = (FLGKBGGCEAHKIBEKBN<T>)Activator.CreateInstance(customAttribute.APIMLHBDDPMHACKCOL.MakeGenericType(new Type[]
						{
							typeof(T)
						}), customAttribute.BMPCIPDFFCMMAJMCLM);
					}
					else
					{
						KNNODPPCNHCIHAIDAO<T>.GIBJBGCJGDONKMNCNO.formatter = (FLGKBGGCEAHKIBEKBN<T>)Activator.CreateInstance(customAttribute.APIMLHBDDPMHACKCOL, customAttribute.BMPCIPDFFCMMAJMCLM);
					}
				}
				catch (Exception innerException)
				{
					throw new InvalidOperationException("Can not create formatter from JsonFormatterAttribute, check the target formatter is public and has constructor with right argument. FormatterType:" + customAttribute.APIMLHBDDPMHACKCOL.Name, innerException);
				}
			}

			// Token: 0x04000033 RID: 51
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}
	}
}

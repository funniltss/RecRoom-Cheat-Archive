using System;
using System.Reflection;
using Utf8Json.Formatters;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000062 RID: 98
	internal sealed class MJMIEGBINDDBGFDGKP : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00002B7C File Offset: 0x00000D7C
		private MJMIEGBINDDBGFDGKP()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00003576 File Offset: 0x00001776
		public FLGKBGGCEAHKIBEKBN<DPLBDLGMOCFDDPMKPJ> GetFormatter<DPLBDLGMOCFDDPMKPJ>()
		{
			return MJMIEGBINDDBGFDGKP<DPLBDLGMOCFDDPMKPJ>.NOMGOEOPAMJDPFMFPN.formatter;
		}

		// Token: 0x040000F9 RID: 249
		public static readonly LMCMANMFGJGJFPNBEN Instance = new MJMIEGBINDDBGFDGKP();

		// Token: 0x02000063 RID: 99
		private static class NOMGOEOPAMJDPFMFPN<T>
		{
			// Token: 0x06000190 RID: 400 RVA: 0x0000D090 File Offset: 0x0000B290
			static NOMGOEOPAMJDPFMFPN()
			{
				TypeInfo typeInfo = typeof(T).GetTypeInfo();
				if (!typeInfo.IsNullable())
				{
					if (typeof(T).IsEnum)
					{
						MJMIEGBINDDBGFDGKP<T>.NOMGOEOPAMJDPFMFPN.formatter = (FLGKBGGCEAHKIBEKBN<T>)new ANPOJLPNLDMLJLENIE<T>(false);
					}
					return;
				}
				typeInfo = typeInfo.GenericTypeArguments[0].GetTypeInfo();
				if (!typeInfo.IsEnum)
				{
					return;
				}
				object formatterDynamic = MJMIEGBINDDBGFDGKP.Instance.GetFormatterDynamic(typeInfo.AsType());
				if (formatterDynamic == null)
				{
					return;
				}
				MJMIEGBINDDBGFDGKP<T>.NOMGOEOPAMJDPFMFPN.formatter = (FLGKBGGCEAHKIBEKBN<T>)Activator.CreateInstance(typeof(EKNOLMEMLPPBCANDBP<>).MakeGenericType(new Type[]
				{
					typeInfo.AsType()
				}), new object[]
				{
					formatterDynamic
				});
			}

			// Token: 0x040000FA RID: 250
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}
	}
}

using System;
using System.Reflection;
using Utf8Json.Formatters;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000060 RID: 96
	internal sealed class ELMHKABIGCEAPECEEE : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x06000189 RID: 393 RVA: 0x00002B7C File Offset: 0x00000D7C
		private ELMHKABIGCEAPECEEE()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003563 File Offset: 0x00001763
		public FLGKBGGCEAHKIBEKBN<NMOLFNKCIIIFAFMFPG> GetFormatter<NMOLFNKCIIIFAFMFPG>()
		{
			return ELMHKABIGCEAPECEEE<NMOLFNKCIIIFAFMFPG>.EKGAKLLLEFIPGMMMLJ.formatter;
		}

		// Token: 0x040000F7 RID: 247
		public static readonly LMCMANMFGJGJFPNBEN Instance = new ELMHKABIGCEAPECEEE();

		// Token: 0x02000061 RID: 97
		private static class EKGAKLLLEFIPGMMMLJ<T>
		{
			// Token: 0x0600018C RID: 396 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
			static EKGAKLLLEFIPGMMMLJ()
			{
				TypeInfo typeInfo = typeof(T).GetTypeInfo();
				if (!typeInfo.IsNullable())
				{
					if (typeof(T).IsEnum)
					{
						ELMHKABIGCEAPECEEE<T>.EKGAKLLLEFIPGMMMLJ.formatter = (FLGKBGGCEAHKIBEKBN<T>)new ANPOJLPNLDMLJLENIE<T>(true);
					}
					return;
				}
				typeInfo = typeInfo.GenericTypeArguments[0].GetTypeInfo();
				if (!typeInfo.IsEnum)
				{
					return;
				}
				object formatterDynamic = ELMHKABIGCEAPECEEE.Instance.GetFormatterDynamic(typeInfo.AsType());
				if (formatterDynamic == null)
				{
					return;
				}
				ELMHKABIGCEAPECEEE<T>.EKGAKLLLEFIPGMMMLJ.formatter = (FLGKBGGCEAHKIBEKBN<T>)Activator.CreateInstance(typeof(EKNOLMEMLPPBCANDBP<>).MakeGenericType(new Type[]
				{
					typeInfo.AsType()
				}), new object[]
				{
					formatterDynamic
				});
			}

			// Token: 0x040000F8 RID: 248
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}
	}
}

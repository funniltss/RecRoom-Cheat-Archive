using System;
using System.Reflection;

namespace Utf8Json.Resolvers
{
	// Token: 0x02000023 RID: 35
	public sealed class CMFIPLBNCIJEKGIFHM : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002B7C File Offset: 0x00000D7C
		private CMFIPLBNCIJEKGIFHM()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002DA7 File Offset: 0x00000FA7
		public static void Register(params LMCMANMFGJGJFPNBEN[] resolvers)
		{
			if (CMFIPLBNCIJEKGIFHM.isFreezed)
			{
				throw new InvalidOperationException("Register must call on startup(before use GetFormatter<T>).");
			}
			CMFIPLBNCIJEKGIFHM.resolvers = resolvers;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public static void Register(params DDGADMMMOKKMDLNAEK[] formatters)
		{
			if (CMFIPLBNCIJEKGIFHM.isFreezed)
			{
				throw new InvalidOperationException("Register must call on startup(before use GetFormatter<T>).");
			}
			CMFIPLBNCIJEKGIFHM.formatters = formatters;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002DDB File Offset: 0x00000FDB
		public static void Register(DDGADMMMOKKMDLNAEK[] formatters, LMCMANMFGJGJFPNBEN[] resolvers)
		{
			if (CMFIPLBNCIJEKGIFHM.isFreezed)
			{
				throw new InvalidOperationException("Register must call on startup(before use GetFormatter<T>).");
			}
			CMFIPLBNCIJEKGIFHM.resolvers = resolvers;
			CMFIPLBNCIJEKGIFHM.formatters = formatters;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002DFB File Offset: 0x00000FFB
		public static void RegisterAndSetAsDefault(params LMCMANMFGJGJFPNBEN[] resolvers)
		{
			CMFIPLBNCIJEKGIFHM.Register(resolvers);
			CLAPLAKGMOAABEOHEI.SetDefaultResolver(CMFIPLBNCIJEKGIFHM.Instance);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002E0D File Offset: 0x0000100D
		public static void RegisterAndSetAsDefault(params DDGADMMMOKKMDLNAEK[] formatters)
		{
			CMFIPLBNCIJEKGIFHM.Register(formatters);
			CLAPLAKGMOAABEOHEI.SetDefaultResolver(CMFIPLBNCIJEKGIFHM.Instance);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002E1F File Offset: 0x0000101F
		public static void RegisterAndSetAsDefault(DDGADMMMOKKMDLNAEK[] formatters, LMCMANMFGJGJFPNBEN[] resolvers)
		{
			CMFIPLBNCIJEKGIFHM.Register(formatters);
			CMFIPLBNCIJEKGIFHM.Register(resolvers);
			CLAPLAKGMOAABEOHEI.SetDefaultResolver(CMFIPLBNCIJEKGIFHM.Instance);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002E37 File Offset: 0x00001037
		public static LMCMANMFGJGJFPNBEN Create(params DDGADMMMOKKMDLNAEK[] formatters)
		{
			return CMFIPLBNCIJEKGIFHM.Create(formatters, new LMCMANMFGJGJFPNBEN[0]);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002E45 File Offset: 0x00001045
		public static LMCMANMFGJGJFPNBEN Create(params LMCMANMFGJGJFPNBEN[] resolvers)
		{
			return CMFIPLBNCIJEKGIFHM.Create(new DDGADMMMOKKMDLNAEK[0], resolvers);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002E53 File Offset: 0x00001053
		public static LMCMANMFGJGJFPNBEN Create(DDGADMMMOKKMDLNAEK[] formatters, LMCMANMFGJGJFPNBEN[] resolvers)
		{
			return DOANHKOAOIHLFEJPCI.Create(formatters, resolvers);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002E5C File Offset: 0x0000105C
		public FLGKBGGCEAHKIBEKBN<BIKABKOOKPIFAPNFHF> GetFormatter<BIKABKOOKPIFAPNFHF>()
		{
			return CMFIPLBNCIJEKGIFHM<BIKABKOOKPIFAPNFHF>.DACJMPLNJJHHCMLHIO.formatter;
		}

		// Token: 0x04000037 RID: 55
		public static readonly CMFIPLBNCIJEKGIFHM Instance = new CMFIPLBNCIJEKGIFHM();

		// Token: 0x04000038 RID: 56
		private static bool isFreezed = false;

		// Token: 0x04000039 RID: 57
		private static DDGADMMMOKKMDLNAEK[] formatters = new DDGADMMMOKKMDLNAEK[0];

		// Token: 0x0400003A RID: 58
		private static LMCMANMFGJGJFPNBEN[] resolvers = new LMCMANMFGJGJFPNBEN[0];

		// Token: 0x02000024 RID: 36
		private static class DACJMPLNJJHHCMLHIO<T>
		{
			// Token: 0x060000EC RID: 236 RVA: 0x0000959C File Offset: 0x0000779C
			static DACJMPLNJJHHCMLHIO()
			{
				CMFIPLBNCIJEKGIFHM.isFreezed = true;
				foreach (DDGADMMMOKKMDLNAEK ddgadmmmokkmdlnaek in CMFIPLBNCIJEKGIFHM.formatters)
				{
					foreach (Type type in ddgadmmmokkmdlnaek.GetType().GetTypeInfo().ImplementedInterfaces)
					{
						TypeInfo typeInfo = type.GetTypeInfo();
						if (typeInfo.IsGenericType && typeInfo.GenericTypeArguments[0] == typeof(T))
						{
							CMFIPLBNCIJEKGIFHM<T>.DACJMPLNJJHHCMLHIO.formatter = (FLGKBGGCEAHKIBEKBN<T>)ddgadmmmokkmdlnaek;
							return;
						}
					}
				}
				LMCMANMFGJGJFPNBEN[] resolvers = CMFIPLBNCIJEKGIFHM.resolvers;
				for (int i = 0; i < resolvers.Length; i++)
				{
					FLGKBGGCEAHKIBEKBN<T> flgkbggceahkibekbn = resolvers[i].GetFormatter<T>();
					if (flgkbggceahkibekbn != null)
					{
						CMFIPLBNCIJEKGIFHM<T>.DACJMPLNJJHHCMLHIO.formatter = flgkbggceahkibekbn;
						return;
					}
				}
			}

			// Token: 0x0400003B RID: 59
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter;
		}
	}
}

using System;
using System.Reflection;

namespace Utf8Json
{
	// Token: 0x0200000E RID: 14
	public static class PMCLMDICJEBPLHOBNK
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00006914 File Offset: 0x00004B14
		public static FLGKBGGCEAHKIBEKBN<KEPLEJPPHHODKDDENN> GetFormatterWithVerify<KEPLEJPPHHODKDDENN>(this LMCMANMFGJGJFPNBEN resolver)
		{
			FLGKBGGCEAHKIBEKBN<KEPLEJPPHHODKDDENN> formatter;
			try
			{
				formatter = resolver.GetFormatter<KEPLEJPPHHODKDDENN>();
			}
			catch (TypeInitializationException innerException)
			{
				while (innerException.InnerException != null)
				{
					innerException = innerException.InnerException;
				}
				throw innerException;
			}
			if (formatter == null)
			{
				throw new NODLCKMOHBBPIMOOAB(typeof(KEPLEJPPHHODKDDENN).FullName + " is not registered in this resolver. resolver:" + resolver.GetType().Name);
			}
			return formatter;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023BF File Offset: 0x000005BF
		public static object GetFormatterDynamic(this LMCMANMFGJGJFPNBEN resolver, Type type)
		{
			return typeof(LMCMANMFGJGJFPNBEN).GetRuntimeMethod("GetFormatter", Type.EmptyTypes).MakeGenericMethod(new Type[]
			{
				type
			}).Invoke(resolver, null);
		}
	}
}

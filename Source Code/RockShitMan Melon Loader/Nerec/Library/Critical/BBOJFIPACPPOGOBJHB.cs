using System;
using HarmonyLib;
using Il2CppBestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls;

namespace Nerec.Library.Critical
{
	// Token: 0x0200018C RID: 396
	[HarmonyPatch(typeof(TlsAuthentication), "NotifyServerCertificate")]
	public class BBOJFIPACPPOGOBJHB
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x00006889 File Offset: 0x00004A89
		[HarmonyPrefix]
		private static bool Prefix()
		{
			return false;
		}
	}
}

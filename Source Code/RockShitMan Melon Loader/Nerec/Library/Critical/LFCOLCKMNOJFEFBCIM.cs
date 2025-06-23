using System;
using HarmonyLib;
using Il2CppBestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls;

namespace Nerec.Library.Critical
{
	// Token: 0x0200018A RID: 394
	[HarmonyPatch(typeof(ServerOnlyTlsAuthentication), "NotifyServerCertificate")]
	public class LFCOLCKMNOJFEFBCIM
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x00006889 File Offset: 0x00004A89
		[HarmonyPrefix]
		private static bool Prefix()
		{
			return false;
		}
	}
}

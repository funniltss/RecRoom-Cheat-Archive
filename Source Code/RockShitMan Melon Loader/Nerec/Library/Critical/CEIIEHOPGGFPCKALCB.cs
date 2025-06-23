using System;
using HarmonyLib;
using Il2CppOrg.BouncyCastle.Crypto.Tls;

namespace Nerec.Library.Critical
{
	// Token: 0x02000189 RID: 393
	[HarmonyPatch(typeof(LegacyTlsAuthentication), "NotifyServerCertificate")]
	public class CEIIEHOPGGFPCKALCB
	{
		// Token: 0x060006B4 RID: 1716 RVA: 0x00006889 File Offset: 0x00004A89
		[HarmonyPrefix]
		private static bool Prefix()
		{
			return false;
		}
	}
}

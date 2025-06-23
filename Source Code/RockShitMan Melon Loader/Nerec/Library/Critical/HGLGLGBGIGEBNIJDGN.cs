using System;
using HarmonyLib;
using Il2CppOrg.BouncyCastle.Crypto.Tls;

namespace Nerec.Library.Critical
{
	// Token: 0x0200018B RID: 395
	[HarmonyPatch(typeof(ICertificateVerifyer), "IsValid")]
	public class HGLGLGBGIGEBNIJDGN
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x0000688C File Offset: 0x00004A8C
		[HarmonyPrefix]
		private static bool Prefix(ref bool __result)
		{
			__result = true;
			return false;
		}
	}
}

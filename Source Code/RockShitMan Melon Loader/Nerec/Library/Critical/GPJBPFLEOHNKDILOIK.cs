using System;
using HarmonyLib;
using Il2CppOrg.BouncyCastle.Crypto.Tls;

namespace Nerec.Library.Critical
{
	// Token: 0x02000188 RID: 392
	[HarmonyPatch(typeof(TimeValidVerifyer), "IsValid")]
	public class GPJBPFLEOHNKDILOIK
	{
		// Token: 0x060006B2 RID: 1714 RVA: 0x0000688C File Offset: 0x00004A8C
		[HarmonyPrefix]
		private static bool Prefix(ref bool __result)
		{
			__result = true;
			return false;
		}
	}
}

using System;
using HarmonyLib;
using Il2CppOrg.BouncyCastle.Crypto.Tls;

namespace Nerec.Library.Critical
{
	// Token: 0x02000187 RID: 391
	[HarmonyPatch(typeof(AlwaysValidVerifyer), "IsValid")]
	public class JEIIJOGEFFHNANFFBE
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x0000688C File Offset: 0x00004A8C
		[HarmonyPrefix]
		private static bool Prefix(ref bool __result)
		{
			__result = true;
			return false;
		}
	}
}

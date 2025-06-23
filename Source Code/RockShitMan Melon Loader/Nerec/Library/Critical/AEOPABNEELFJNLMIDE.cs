using System;
using HarmonyLib;
using Il2Cpp;

namespace Nerec.Library.Critical
{
	// Token: 0x02000186 RID: 390
	[HarmonyPatch(typeof(BKDCAOOJBAE.PJGFBKDGPNM), "IsValid")]
	public class AEOPABNEELFJNLMIDE
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x0000688C File Offset: 0x00004A8C
		[HarmonyPrefix]
		private static bool Prefix(ref bool __result)
		{
			__result = true;
			return false;
		}
	}
}

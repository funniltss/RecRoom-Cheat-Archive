using System;
using HarmonyLib;
using Il2Cpp;
using MelonLoader;

namespace TestMod
{
	// Token: 0x0200000F RID: 15
	[HarmonyPatch(typeof(BBEHOHAGEFP.GONMKNIIDNC), "IsValid")]
	public class Hysteria1
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000229A File Offset: 0x0000049A
		[HarmonyPostfix]
		public static void PostFix(ref bool __result)
		{
			MelonLogger.Msg("Hysteria Check");
			__result = true;
		}
	}
}

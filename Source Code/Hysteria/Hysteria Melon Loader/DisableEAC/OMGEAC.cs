using System;
using HarmonyLib;
using Il2CppEasyAntiCheat.Client.Hydra;
using MelonLoader;

namespace TestMod
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(Runtime), "Release")]
	public class OMGEAC
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000207A File Offset: 0x0000027A
		[HarmonyPrefix]
		public static bool Prefix()
		{
			MelonLogger.Msg("EAC Release Attempted");
			return false;
		}
	}
}

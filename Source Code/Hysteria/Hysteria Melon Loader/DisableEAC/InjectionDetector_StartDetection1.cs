using System;
using HarmonyLib;
using Il2CppCodeStage.AntiCheat.Detectors;
using Il2CppSystem;
using MelonLoader;

namespace TestMod
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(InjectionDetector), "StartDetection", new Type[]
	{
		typeof(Action<string>)
	})]
	public class InjectionDetector_StartDetection1
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002065 File Offset: 0x00000265
		[HarmonyPrefix]
		public static bool Prefix()
		{
			MelonLogger.Msg("lol");
			return false;
		}
	}
}

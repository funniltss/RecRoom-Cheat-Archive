using System;
using HarmonyLib;
using Il2CppCodeStage.AntiCheat.Detectors;
using MelonLoader;

namespace TestMod
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(InjectionDetector), "StartDetection", new Type[]
	{

	})]
	public class InjectionDetector_StartDetection
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[HarmonyPrefix]
		public static bool Prefix()
		{
			MelonLogger.Msg("lol");
			return false;
		}
	}
}

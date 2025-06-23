using System;
using HarmonyLib;
using Il2Cpp;
using MelonLoader;

namespace TestMod
{
	// Token: 0x0200000A RID: 10
	[HarmonyPatch(typeof(JIAFNBHBPFE.__c), "_CheckHashesInBackground_b__10_3")]
	public class FileSignatureChecks4
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000020FA File Offset: 0x000002FA
		[HarmonyPrefix]
		public static bool Prefix()
		{
			MelonLogger.Msg("File Checks Rejected.");
			return false;
		}
	}
}

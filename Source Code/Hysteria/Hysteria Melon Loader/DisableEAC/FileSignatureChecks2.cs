using System;
using HarmonyLib;
using Il2Cpp;
using MelonLoader;

namespace TestMod
{
	// Token: 0x0200000D RID: 13
	[HarmonyPatch(typeof(JIAFNBHBPFE.PLNFLHBFJGL), "_CheckHashesInBackground_b__1")]
	public class FileSignatureChecks2
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002139 File Offset: 0x00000339
		[HarmonyPrefix]
		public static bool Prefix()
		{
			MelonLogger.Msg("File Checks Rejected.");
			return false;
		}
	}
}

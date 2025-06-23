using System;
using HarmonyLib;
using Il2Cpp;
using MelonLoader;

namespace TestMod
{
	// Token: 0x0200000B RID: 11
	[HarmonyPatch(typeof(DEPPECCHIAF.BHCKAHFKHLP), "_InitializeFileHashChecker_b__0")]
	public class FileSignatureChecks3
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000210F File Offset: 0x0000030F
		[HarmonyPrefix]
		public static bool Prefix()
		{
			MelonLogger.Msg("File Checks Rejected.");
			return false;
		}
	}
}

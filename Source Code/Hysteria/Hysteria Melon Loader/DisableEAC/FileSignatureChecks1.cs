using System;
using HarmonyLib;
using Il2Cpp;
using MelonLoader;

namespace TestMod
{
	// Token: 0x0200000C RID: 12
	[HarmonyPatch(typeof(JIAFNBHBPFE.PLNFLHBFJGL), "_CheckHashesInBackground_b__0")]
	public class FileSignatureChecks1
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002124 File Offset: 0x00000324
		[HarmonyPrefix]
		public static bool Prefix()
		{
			MelonLogger.Msg("File Checks Rejected.");
			return false;
		}
	}
}

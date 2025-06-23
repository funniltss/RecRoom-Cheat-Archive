using System;
using HarmonyLib;
using Il2CppRecRoom.AntiCheat;
using MelonLoader;

namespace Nerec.Library.Critical.ClientAuth
{
	// Token: 0x0200018F RID: 399
	[HarmonyPatch(typeof(EACManager), "GenerateChallengeResponse")]
	public class DONAJGKGPNKECDGDOG
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x0001A7EC File Offset: 0x000189EC
		[HarmonyPrefix]
		private static bool Prefix(string NICBKKPGIKM, ref string __result)
		{
			MelonLogger.Warning("Generating spoofed challenge response");
			byte[] array = Convert.FromBase64String(NICBKKPGIKM);
			byte[] array2 = new byte[array.Length];
			Entry.ENPDNECGKBBAPMJNBK.GenerateChallenge(array, array2);
			__result = Convert.ToBase64String(array2);
			MelonLogger.Msg(__result);
			return false;
		}
	}
}

using System;
using System.Net;
using HarmonyLib;
using Il2CppRecRoom.AntiCheat;
using MelonLoader;

namespace TestMod
{
	// Token: 0x02000006 RID: 6
	[HarmonyPatch(typeof(EACManager), "GenerateChallengeResponse")]
	public class EAC
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002090 File Offset: 0x00000290
		[HarmonyPrefix]
		public static bool Prefix(ref string __result)
		{
			MelonLogger.Msg("Eac Requested");
			string text = new WebClient().DownloadString("https://auth.rec.net/eac/challenge");
			__result = text.Replace("\"", string.Empty);
			MelonLogger.Msg(__result);
			return false;
		}
	}
}

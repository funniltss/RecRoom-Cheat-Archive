using System;
using HarmonyLib;
using Il2CppRecRoom.Debugging;

namespace Nerec.Debugging
{
	// Token: 0x02000193 RID: 403
	[HarmonyPatch(typeof(DebugConsole), "Awake")]
	public static class BPKKODCJMHBMHEGJJE
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x00006889 File Offset: 0x00004A89
		[HarmonyPrefix]
		public static bool Prefix()
		{
			return false;
		}
	}
}

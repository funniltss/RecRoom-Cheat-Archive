using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;

namespace Nerec.Library.ServerOverride
{
	// Token: 0x02000166 RID: 358
	[HarmonyPatch(typeof(EIFDHOGHLMO), "PHIAOKHCHLJ")]
	internal class NHPKLNKJKKGEFCHFEA
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x000063FA File Offset: 0x000045FA
		[HarmonyPrefix]
		private static bool Prefix(string BMJPEHBAIPC, ref bool __result)
		{
			__result = !NHPKLNKJKKGEFCHFEA._falseFlags.Contains(BMJPEHBAIPC);
			return false;
		}

		// Token: 0x04000387 RID: 903
		private static List<string> _falseFlags = new List<string>
		{
			"junior",
			"BanVChat",
			"BanRmChat"
		};
	}
}

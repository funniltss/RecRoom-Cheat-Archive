using System;
using HarmonyLib;
using Il2Cpp;

namespace Nerec.Library.Critical
{
	// Token: 0x02000185 RID: 389
	[HarmonyPatch(typeof(PPEMHCMPNMG), "PGIHAENGDGO")]
	public class NLGBPDFPKEDFNAFANH
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x00006889 File Offset: 0x00004A89
		[HarmonyPrefix]
		private static bool Prefix()
		{
			return false;
		}
	}
}

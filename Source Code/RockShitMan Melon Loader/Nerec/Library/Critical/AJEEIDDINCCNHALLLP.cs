using System;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Nerec.Library.Critical
{
	// Token: 0x02000184 RID: 388
	[HarmonyPatch(typeof(PDPEKJKLFIH), "EHBHLFHNKGD")]
	public class AJEEIDDINCCNHALLLP
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x00006889 File Offset: 0x00004A89
		[HarmonyPrefix]
		private static bool Prefix(string DGNEBPIKCDO, Il2CppStructArray<byte> PHHBPOOMOKI, Il2CppStructArray<byte> LKNMLICIFNI, Il2CppStructArray<byte> KPBHFJGANEL, Il2CppStructArray<byte> NPMKACBFFHH)
		{
			return false;
		}
	}
}

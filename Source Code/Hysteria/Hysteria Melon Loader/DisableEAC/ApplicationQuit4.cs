using System;
using HarmonyLib;
using UnityEngine;

namespace TestMod
{
	// Token: 0x02000008 RID: 8
	[HarmonyPatch(typeof(Application), "Quit", new Type[]
	{
		typeof(int)
	})]
	public class ApplicationQuit4
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000020E4 File Offset: 0x000002E4
		[HarmonyPrefix]
		public static bool Prefix(int exitCode)
		{
			return false;
		}
	}
}

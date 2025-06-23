using System;
using HarmonyLib;
using UnityEngine;

namespace TestMod
{
	// Token: 0x02000007 RID: 7
	[HarmonyPatch(typeof(Application), "Internal_ApplicationQuit")]
	public class ApplicationQuit
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000020D9 File Offset: 0x000002D9
		[HarmonyPrefix]
		public static bool Prefix()
		{
			return false;
		}
	}
}

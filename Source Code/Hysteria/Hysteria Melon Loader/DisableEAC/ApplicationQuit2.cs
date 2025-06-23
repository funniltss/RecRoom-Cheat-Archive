using System;
using HarmonyLib;
using UnityEngine;

namespace TestMod
{
	// Token: 0x02000009 RID: 9
	[HarmonyPatch(typeof(Application), "Quit", new Type[]
	{

	})]
	public class ApplicationQuit2
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000020EF File Offset: 0x000002EF
		[HarmonyPrefix]
		public static bool Prefix()
		{
			return false;
		}
	}
}

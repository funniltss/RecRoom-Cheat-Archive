using System;
using HarmonyLib;
using Il2Cpp;
using Il2CppBestHTTP;
using Il2CppSystem;
using MelonLoader;

namespace Nerec.Library.ServerOverride
{
	// Token: 0x02000161 RID: 353
	[HarmonyPatch(typeof(FGCCDOCAKJA), "FIHNDLMJEAD")]
	public class ONKFJNMENILDGIEPFF
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x0001A248 File Offset: 0x00018448
		[HarmonyPrefix]
		public static bool Prefix(FGCCDOCAKJA __instance, ref ValueTuple<string, Action<JGBFOACILMB>> __result)
		{
			HTTPMethods iioiclggmbj = __instance.IIOICLGGMBJ;
			CLKLKFHFEFG ikamjbjgejg = __instance.IKAMJBJGEJG;
			string text = __instance.EEFMLPGODJO;
			if (!text.StartsWith("/"))
			{
				text = "/" + text;
			}
			string arg = IPPGJCBBICAGMIPDAP.HFIGDGAAOLFOABOPBO[ikamjbjgejg] + text;
			if (IPPGJCBBICAGMIPDAP.LNDJNPLEJMKPBLJBJN.Contains(text))
			{
				MelonLogger.Error(string.Format("[RecNetRequestBuilder.Build()] [{0}] Blocking request '{1}'", iioiclggmbj.ToString(), arg));
				__result = new ValueTuple<string, Action<JGBFOACILMB>>(null, null);
				return false;
			}
			MelonLogger.Warning(string.Format("[RecNetRequestBuilder.Build()] [{0}] Sending request '{1}'", iioiclggmbj.ToString(), arg));
			return true;
		}
	}
}

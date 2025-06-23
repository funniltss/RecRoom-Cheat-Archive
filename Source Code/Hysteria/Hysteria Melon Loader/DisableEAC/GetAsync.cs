using System;
using HarmonyLib;
using Il2CppBestHTTP;
using Il2CppSystem;
using MelonLoader;

namespace TestMod
{
	// Token: 0x0200000E RID: 14
	[HarmonyPatch(typeof(HTTPRequest), "Send")]
	public class GetAsync
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002150 File Offset: 0x00000350
		[HarmonyPrefix]
		public static bool Prefix(ref HTTPRequest __instance, ref dynamic __result)
		{
			string text = __instance.Uri.ToString();
			if (text.ToString().StartsWith("https://api.rec.net"))
			{
				text = text.ToString().Replace("https://api.rec.net", "https://npapi.neptuneq.repl.co");
				MelonLogger.Log("====== Get Request ======");
				MelonLogger.Log(text.ToString());
			}
			else if (text.ToString().StartsWith("https://auth.rec.net/connect/token"))
			{
				text = "https://npa.neptuneq.repl.co/connect/token";
			}
			else if (text.ToString().StartsWith("https://econ.rec.net"))
			{
				text = text.ToString().Replace("https://econ.rec.net", "https://npapi.neptuneq.repl.co/z");
				MelonLogger.Log("====== Get Request ======");
				MelonLogger.Log(text.ToString());
			}
			else if (text.ToString().StartsWith("https://auth.rec.net"))
			{
				text = text.ToString().Replace("https://auth.rec.net", "https://npapi.neptuneq.repl.co/zek");
			}
			else if (text.ToString().StartsWith("https://moderation.rec.net"))
			{
				text = text.ToString().Replace("https://moderation.rec.net", "https://npapi.neptuneq.repl.co/xmodrtn");
			}
			else if (text.ToString().StartsWith("https://rooms.rec.net"))
			{
				text = text.ToString().Replace("https://rooms.rec.net", "https://npapi.neptuneq.repl.co/zk");
			}
			__instance.Uri = new Uri(text);
			return true;
		}
	}
}

using System;
using Il2Cpp;
using Il2CppRecRoom.AntiCheat;
using MelonLoader;
using Nerec.Inject.Cheat;
using Nerec.Library;
using Nerec.Library.Callbacks;
using Nerec.Library.Critical.ClientAuth;
using Nerec.Library.UnityGUI;
using Nerec.Library.UnityGUI.Custom;
using UnityEngine;

namespace Nerec
{
	// Token: 0x0200013A RID: 314
	public class Entry : MelonMod
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x00005CD1 File Offset: 0x00003ED1
		public override void OnInitializeMelon()
		{
			base.OnInitializeMelon();
			Entry._eacAuthManager = new ACKDMFFONHEGBBJLKK();
			Debug.developerConsoleVisible = true;
			BHCDOPIGBJGDONCCFH.Initialize();
			HDPAGNMBHIAPALFBDG.RegisterMonoBehavioursToIl2cppDomain();
			OCCOJOPOBEEJAKEOMB.InitializeDIRoot();
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00018678 File Offset: 0x00016878
		public override void OnSceneWasLoaded(int buildindex, string sceneName)
		{
			if (Entry._mainLauncher == null)
			{
				Entry._mainLauncher = DJMEEHCEBDFOKODOCD.Create("Nerec Mod Launcher");
				Entry._mainLauncher.Add(KDMLJLIJNANBIKHKCO.EconomyMenuTabId, "Economy", new Rect(100f, 100f, 300f, 250f), new Action<int>(MCIFPFEMOIIKHCOPMB.Draw));
				Entry._mainLauncher.Add(KDMLJLIJNANBIKHKCO.PlayerModsMenuTabId, "Player Mods", new Rect(100f, 100f, 300f, 250f), new Action<int>(NLPAFJIBPHJKGCMKMH.Draw));
				Entry._mainLauncher.Add(KDMLJLIJNANBIKHKCO.WatchModsMenuTabId, "Watch Mods", new Rect(100f, 100f, 300f, 250f), new Action<int>(CLEADJDDHNHJPCKBLC.Draw));
				Entry._mainLauncher.Add(KDMLJLIJNANBIKHKCO.WorldModsMenuTabId, "World Mods", new Rect(100f, 100f, 300f, 250f), new Action<int>(OIFDMGCKGNDLJCPEDO.Draw));
			}
			if (Entry._photonCallbackManager == null)
			{
				Entry._photonCallbackManager = new GameObject("[Photon Callback Manager](internal)").AddComponent<JMGPLEBEJDLEKELDHK>();
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000187AC File Offset: 0x000169AC
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (Time.time - Entry._lastEacCheatUpdate > 1f)
			{
				Entry._lastEacCheatUpdate = Time.time;
				if ((Entry._cheatManager = Object.FindObjectOfType<CheatManager>()) != null)
				{
					Object.Destroy(Entry._cheatManager.gameObject);
					MelonLogger.Msg("Deleting CheatManager from GameRoot");
				}
				if ((Entry._eacManager = Object.FindObjectOfType<EACManager>()) != null)
				{
					Object.Destroy(Entry._eacManager.gameObject);
					MelonLogger.Msg("Deleting EACManager from GameRoot");
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public static JMGPLEBEJDLEKELDHK PGHJENCIHMFOFFNDLB
		{
			get
			{
				return Entry._photonCallbackManager;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00005CFF File Offset: 0x00003EFF
		public static HMLHHOLDAFJBNAKPPD ENPDNECGKBBAPMJNBK
		{
			get
			{
				return Entry._eacAuthManager;
			}
		}

		// Token: 0x040002A8 RID: 680
		private static float _lastEacCheatUpdate;

		// Token: 0x040002A9 RID: 681
		private static CheatManager _cheatManager;

		// Token: 0x040002AA RID: 682
		private static EACManager _eacManager;

		// Token: 0x040002AB RID: 683
		private static HMLHHOLDAFJBNAKPPD _eacAuthManager;

		// Token: 0x040002AC RID: 684
		private static DJMEEHCEBDFOKODOCD _mainLauncher;

		// Token: 0x040002AD RID: 685
		private static JMGPLEBEJDLEKELDHK _photonCallbackManager;
	}
}

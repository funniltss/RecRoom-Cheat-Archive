using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using HarmonyLib;
using Il2CppAGUI.StackedUI;
using Il2CppRRUI.Navigation;
using MelonLoader;
using UnityEngine;

namespace Nerec.Library.UnityGUI.Custom
{
	// Token: 0x0200015E RID: 350
	public static class CLEADJDDHNHJPCKBLC
	{
		// Token: 0x060005E2 RID: 1506 RVA: 0x00019AD4 File Offset: 0x00017CD4
		private static void Initialize(uint tabId)
		{
			IPDMLDCHOFKILLMKLE.Run(LLHALDELIJLHMBBGID.Update, new Action(CLEADJDDHNHJPCKBLC.Update));
			CLEADJDDHNHJPCKBLC._routeDropdown = new OFMPAOLHNHKHKFPADJ(tabId);
			Traverse traverse = Traverse.Create(Object.FindObjectOfType<RRUIRootScreen>());
			foreach (string text in traverse.Properties())
			{
				if (CLEADJDDHNHJPCKBLC._allRouteFields.Contains(text))
				{
					MelonLogger.Msg("field name: " + text);
					Route value = traverse.Property<Route>(text, null).Value;
					if (!CLEADJDDHNHJPCKBLC._routeMap.ContainsKey(text))
					{
						CLEADJDDHNHJPCKBLC._routeMap.Add(text, value);
					}
				}
			}
			CLEADJDDHNHJPCKBLC._routeDropdown.SetStrings(CLEADJDDHNHJPCKBLC._routeMap.Select(delegate(KeyValuePair<string, Route> x)
			{
				KeyValuePair<string, Route> keyValuePair = x;
				return keyValuePair.Key;
			}).ToList<string>());
			CLEADJDDHNHJPCKBLC._initialized = true;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00019BCC File Offset: 0x00017DCC
		public static void Draw(int windowId)
		{
			if (!CLEADJDDHNHJPCKBLC._initialized)
			{
				CLEADJDDHNHJPCKBLC.Initialize(KDMLJLIJNANBIKHKCO.WatchModsMenuTabId);
				return;
			}
			GUI.skin.label.richText = true;
			GUILayout.Space(20f);
			GUILayout.Label("<b>Watch Menu</b>", null);
			CLEADJDDHNHJPCKBLC._routeDropdown.Draw();
			if (GUILayout.Button("Set Menu As Route", null))
			{
				RRUIRootScreen rruirootScreen = Object.FindObjectOfType<RRUIRootScreen>();
				rruirootScreen.WatchUI.PushFlow(rruirootScreen, null);
				Route value = CLEADJDDHNHJPCKBLC._routeMap.FirstOrDefault((KeyValuePair<string, Route> x) => x.Key.ToString() == CLEADJDDHNHJPCKBLC._routeDropdown.MPFFHOJOKEHBAMPOJB).Value;
				MelonLogger.Msg("Loading " + value.ToString());
				rruirootScreen.BrowserModel.ResetAndGoTo(value);
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00003EE1 File Offset: 0x000020E1
		private static void Update()
		{
		}

		// Token: 0x04000369 RID: 873
		private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		// Token: 0x0400036A RID: 874
		private static Dictionary<string, Route> _routeMap = new Dictionary<string, Route>();

		// Token: 0x0400036B RID: 875
		private static Vector2 _playerKickingScrollPosition;

		// Token: 0x0400036C RID: 876
		private static OFMPAOLHNHKHKFPADJ _routeDropdown;

		// Token: 0x0400036D RID: 877
		private static bool _initialized;

		// Token: 0x0400036E RID: 878
		private static string[] _allUris = new string[]
		{
			"homeUri",
			"playUri",
			"backpackUri",
			"backpackOtherUri",
			"eventsUri",
			"thisRoomUri",
			"myProfileUri",
			"peopleUri",
			"peopleFriendsTabDefaultUri",
			"partyUri",
			"friendUri",
			"storeFeaturedUri",
			"createUri",
			"escMenuUri"
		};

		// Token: 0x0400036F RID: 879
		private static string[] _allRouteFields = new string[]
		{
			"clubsRoute",
			"newPlayerChallengesRoute",
			"progressionEventsRoute",
			"keepsakeEventsRoute",
			"settingsRoute",
			"settingsRouteMiscTab",
			"minimalSettingsRoute",
			"notificationSettingsRoute",
			"clubDetailsRoute",
			"eventsBrowserRoute",
			"eventInstancesRoute",
			"eventSetupRoute",
			"eventDetailsRoute",
			"highlightRoomsRoute",
			"roomJackpotRoute",
			"searchRoomsRoute",
			"roomCategorySelectRoute",
			"roomSettingsEarningDistributionRoute",
			"subscriptionsRoute",
			"portfolioRoute",
			"profileRoute",
			"savedOutfitsRoute",
			"debugRoute",
			"storeDormSkinsRoute",
			"avatarCustomizationRoute",
			"resolveBundleTrialsRoute",
			"rewardSelectionRoute",
			"emailPromptRoute",
			"phonePromptRoute",
			"actionCodeRoute",
			"enterCodeRoute",
			"inviteRoute",
			"referralRewardsRoute",
			"chatRoute",
			"notificationsRoute",
			"testCaseManagementRoute",
			"bugReportingRoute",
			"bannedScreenRoute",
			"warnedScreenRoute",
			"reportPlayerRoute",
			"roomKeysBrowserRoute",
			"roomKeysCreateRoute",
			"roomKeyStoreRoute",
			"roomCurrencyBrowserRoute",
			"roomCurrencyCreateRoute",
			"roomCurrencyStoreRoute",
			"roomConsumableBrowserRoute",
			"roomConsumableCreateRoute",
			"roomConsumableStoreRoute",
			"roomConsumableBackpackRoute",
			"ugcStorefrontRoute",
			"customAvatarItemDetailsRoute",
			"customAvatarItemFeaturedRoute",
			"customAvatarItemSearchRoute",
			"customAvatarItemStoreRoute",
			"storeFeaturedRoute",
			"storeClothingRoute",
			"storeInventionsRoute",
			"inventionDetailsRoute",
			"inventionSearchRoute",
			"storeItemSearchRoute",
			"itemDetailsRoute",
			"tokenStoreRoute",
			"rrPlusSignUpRoute",
			"starterPackDetailsRoute",
			"wishlistRoute",
			"friendotronMainRoute",
			"outfitRoute"
		};

		// Token: 0x0200015F RID: 351
		[CompilerGenerated]
		[Serializable]
		private sealed class HLKIGBMAHHAJFGKBGK
		{
			// Token: 0x060005E8 RID: 1512 RVA: 0x00019F9C File Offset: 0x0001819C
			internal string <Initialize>b__0_0(KeyValuePair<string, Route> x)
			{
				KeyValuePair<string, Route> keyValuePair = x;
				return keyValuePair.Key;
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x00006313 File Offset: 0x00004513
			internal bool <Draw>b__1_0(KeyValuePair<string, Route> x)
			{
				return x.Key.ToString() == CLEADJDDHNHJPCKBLC._routeDropdown.MPFFHOJOKEHBAMPOJB;
			}

			// Token: 0x04000370 RID: 880
			public static readonly CLEADJDDHNHJPCKBLC.HLKIGBMAHHAJFGKBGK <>9 = new CLEADJDDHNHJPCKBLC.HLKIGBMAHHAJFGKBGK();

			// Token: 0x04000371 RID: 881
			public static Func<KeyValuePair<string, Route>, string> <>9__0_0;

			// Token: 0x04000372 RID: 882
			public static Func<KeyValuePair<string, Route>, bool> <>9__1_0;
		}
	}
}

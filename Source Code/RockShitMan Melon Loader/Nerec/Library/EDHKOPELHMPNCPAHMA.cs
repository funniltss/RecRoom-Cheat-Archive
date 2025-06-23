using System;
using Il2CppRRUI.Navigation;

namespace Nerec.Library
{
	// Token: 0x02000143 RID: 323
	public class EDHKOPELHMPNCPAHMA
	{
		// Token: 0x040002C3 RID: 707
		private Uri homeUri;

		// Token: 0x040002C4 RID: 708
		private Uri playUri;

		// Token: 0x040002C5 RID: 709
		private Route newPlayerChallengesRoute;

		// Token: 0x040002C6 RID: 710
		private Route progressionEventsRoute;

		// Token: 0x040002C7 RID: 711
		private Route keepsakeEventsRoute;

		// Token: 0x040002C8 RID: 712
		private Route settingsRoute;

		// Token: 0x040002C9 RID: 713
		private Route settingsRouteMiscTab;

		// Token: 0x040002CA RID: 714
		private Route minimalSettingsRoute;

		// Token: 0x040002CB RID: 715
		private Route notificationSettingsRoute;

		// Token: 0x040002CC RID: 716
		private RoutesConfig settingsRouteConfig;

		// Token: 0x040002CD RID: 717
		private RoutesConfig backpackRouteConfig;

		// Token: 0x040002CE RID: 718
		private Uri backpackUri;

		// Token: 0x040002CF RID: 719
		private Uri backpackOtherUri;

		// Token: 0x040002D0 RID: 720
		private Route clubsRoute;

		// Token: 0x040002D1 RID: 721
		private Route clubDetailsRoute;

		// Token: 0x040002D2 RID: 722
		private Route eventsBrowserRoute;

		// Token: 0x040002D3 RID: 723
		private Route eventInstancesRoute;

		// Token: 0x040002D4 RID: 724
		private Route eventSetupRoute;

		// Token: 0x040002D5 RID: 725
		private Route eventDetailsRoute;

		// Token: 0x040002D6 RID: 726
		private Uri eventsUri;

		// Token: 0x040002D7 RID: 727
		private Route highlightRoomsRoute;

		// Token: 0x040002D8 RID: 728
		private Route roomJackpotRoute;

		// Token: 0x040002D9 RID: 729
		private Route searchRoomsRoute;

		// Token: 0x040002DA RID: 730
		private Route roomCategorySelectRoute;

		// Token: 0x040002DB RID: 731
		private Route roomSettingsEarningDistributionRoute;

		// Token: 0x040002DC RID: 732
		private Uri thisRoomUri;

		// Token: 0x040002DD RID: 733
		private Route subscriptionsRoute;

		// Token: 0x040002DE RID: 734
		private Route portfolioRoute;

		// Token: 0x040002DF RID: 735
		private Route profileRoute;

		// Token: 0x040002E0 RID: 736
		private Uri myProfileUri;

		// Token: 0x040002E1 RID: 737
		private Route savedOutfitsRoute;

		// Token: 0x040002E2 RID: 738
		private Uri peopleUri;

		// Token: 0x040002E3 RID: 739
		private Uri peopleFriendsTabDefaultUri;

		// Token: 0x040002E4 RID: 740
		private Uri partyUri;

		// Token: 0x040002E5 RID: 741
		private Uri friendUri;

		// Token: 0x040002E6 RID: 742
		private Route roomKeysBrowserRoute;

		// Token: 0x040002E7 RID: 743
		private Route roomKeysCreateRoute;

		// Token: 0x040002E8 RID: 744
		private Route roomKeyStoreRoute;

		// Token: 0x040002E9 RID: 745
		private Route roomCurrencyBrowserRoute;

		// Token: 0x040002EA RID: 746
		private Route roomCurrencyCreateRoute;

		// Token: 0x040002EB RID: 747
		private Route roomCurrencyStoreRoute;

		// Token: 0x040002EC RID: 748
		private Route roomConsumableBrowserRoute;

		// Token: 0x040002ED RID: 749
		private Route roomConsumableCreateRoute;

		// Token: 0x040002EE RID: 750
		private Route roomConsumableStoreRoute;

		// Token: 0x040002EF RID: 751
		private Route roomConsumableBackpackRoute;

		// Token: 0x040002F0 RID: 752
		private Route ugcStorefrontRoute;

		// Token: 0x040002F1 RID: 753
		private Route customAvatarItemDetailsRoute;

		// Token: 0x040002F2 RID: 754
		private Route customAvatarItemFeaturedRoute;

		// Token: 0x040002F3 RID: 755
		private Route customAvatarItemSearchRoute;

		// Token: 0x040002F4 RID: 756
		private Route customAvatarItemStoreRoute;

		// Token: 0x040002F5 RID: 757
		private Route storeFeaturedRoute;

		// Token: 0x040002F6 RID: 758
		private Route storeClothingRoute;

		// Token: 0x040002F7 RID: 759
		private Route storeInventionsRoute;

		// Token: 0x040002F8 RID: 760
		private Route inventionDetailsRoute;

		// Token: 0x040002F9 RID: 761
		private Route inventionSearchRoute;

		// Token: 0x040002FA RID: 762
		private Route storeItemSearchRoute;

		// Token: 0x040002FB RID: 763
		private Route itemDetailsRoute;

		// Token: 0x040002FC RID: 764
		private Route tokenStoreRoute;

		// Token: 0x040002FD RID: 765
		private Route rrPlusSignUpRoute;

		// Token: 0x040002FE RID: 766
		private Route starterPackDetailsRoute;

		// Token: 0x040002FF RID: 767
		private Route wishlistRoute;

		// Token: 0x04000300 RID: 768
		private Route friendotronMainRoute;

		// Token: 0x04000301 RID: 769
		private Route outfitRoute;

		// Token: 0x04000302 RID: 770
		private Uri storeFeaturedUri;

		// Token: 0x04000303 RID: 771
		private Route storeDormSkinsRoute;

		// Token: 0x04000304 RID: 772
		private Route avatarCustomizationRoute;

		// Token: 0x04000305 RID: 773
		private Route resolveBundleTrialsRoute;

		// Token: 0x04000306 RID: 774
		private Route rewardSelectionRoute;

		// Token: 0x04000307 RID: 775
		private Route emailPromptRoute;

		// Token: 0x04000308 RID: 776
		private Route phonePromptRoute;

		// Token: 0x04000309 RID: 777
		private Route actionCodeRoute;

		// Token: 0x0400030A RID: 778
		private Route enterCodeRoute;

		// Token: 0x0400030B RID: 779
		private Route inviteRoute;

		// Token: 0x0400030C RID: 780
		private Route referralRewardsRoute;

		// Token: 0x0400030D RID: 781
		private Route chatRoute;

		// Token: 0x0400030E RID: 782
		private Route notificationsRoute;

		// Token: 0x0400030F RID: 783
		private Route testCaseManagementRoute;

		// Token: 0x04000310 RID: 784
		private Uri createUri;

		// Token: 0x04000311 RID: 785
		private Uri escMenuUri;

		// Token: 0x04000312 RID: 786
		private Route bannedScreenRoute;

		// Token: 0x04000313 RID: 787
		private Route warnedScreenRoute;

		// Token: 0x04000314 RID: 788
		private Route reportPlayerRoute;
	}
}

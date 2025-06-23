using System;
using System.Threading;
using Il2Cpp;
using Il2CppRecRoom;
using Il2CppRecRoom.Core.Combat;
using Il2CppRecRoom.Core.Controllers.ScreenBehaviors;
using Il2CppRecRoom.Players;
using Nerec.Library.Includes;
using Nerec.Library.Unity;
using UnityEngine;

namespace Nerec.Library.UnityGUI.Custom
{
	// Token: 0x02000159 RID: 345
	public static class NLPAFJIBPHJKGCMKMH
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x0000627C File Offset: 0x0000447C
		private static void Initialize(uint tabId)
		{
			IPDMLDCHOFKILLMKLE.Run(LLHALDELIJLHMBBGID.Update, new Action(NLPAFJIBPHJKGCMKMH.Update));
			NLPAFJIBPHJKGCMKMH._rapidFireTypeDropdown = new PEIKILBNEBPOGFOEJJ<PDHGBIOADHKGKNMIDL>(tabId);
			NLPAFJIBPHJKGCMKMH._ammoReserveTypeDropdown = new PEIKILBNEBPOGFOEJJ<AHEMBDADDAIGKKCHLP>(tabId);
			NLPAFJIBPHJKGCMKMH._weaponRecoilOptionTypeDropdown = new PEIKILBNEBPOGFOEJJ<HEBJBLHGIHOAAGLKDE>(tabId);
			NLPAFJIBPHJKGCMKMH._initialized = true;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00019620 File Offset: 0x00017820
		public static void Draw(int windowId)
		{
			if (!NLPAFJIBPHJKGCMKMH._initialized)
			{
				NLPAFJIBPHJKGCMKMH.Initialize(KDMLJLIJNANBIKHKCO.PlayerModsMenuTabId);
				return;
			}
			GUI.skin.label.richText = true;
			GUILayout.Space(20f);
			try
			{
				GUILayout.Label("<b>Player List</b>", null);
				NLPAFJIBPHJKGCMKMH._playerKickingScrollPosition = GUILayout.BeginScrollView(NLPAFJIBPHJKGCMKMH._playerKickingScrollPosition, null);
				if (NLPAFJIBPHJKGCMKMH._playerList.Length != 0)
				{
					foreach (OKOEJLJNIMHOGIEDFP okoejljnimhogiedfp in NLPAFJIBPHJKGCMKMH._playerList)
					{
						GUILayout.BeginVertical(null);
						GDHIDEPCCBEBPAPBBK photonPlayer = okoejljnimhogiedfp.get_Player().get_PhotonPlayer();
						string text = photonPlayer.get_NickName();
						bool flag = photonPlayer.get_ActorNumber() == NLPAFJIBPHJKGCMKMH._masterClientPlayer.get_ActorNumber();
						bool flag2 = photonPlayer.get_ActorNumber() == NLPAFJIBPHJKGCMKMH._myPhotonPlayer.get_ActorNumber();
						if (flag)
						{
							text += " <color=yellow><b>(Authority)</b></color>";
						}
						GUILayout.Label(text, null);
						GUILayout.BeginHorizontal(null);
						if (!flag2)
						{
							if (GUILayout.Button("Remove", null))
							{
								JKGLHAAMDAFFCEKMOC.SetMasterClient(NLPAFJIBPHJKGCMKMH._myPlayer.get_PhotonPlayer());
								JKGLHAAMDAFFCEKMOC.DestroyPlayerObjects(photonPlayer);
							}
							if (GUILayout.Button("Authority", null))
							{
								JKGLHAAMDAFFCEKMOC.SetMasterClient(photonPlayer);
							}
						}
						else
						{
							GUILayout.Label("<b>You cannot do photon actions on yourself.</b>", null);
						}
						GUILayout.EndHorizontal();
						GUILayout.EndVertical();
					}
				}
				else
				{
					GUILayout.Label("<b>No players in lobby. Are you connected?</b>", null);
				}
			}
			catch
			{
			}
			try
			{
				GUILayout.Label("<b>Player Weapon Options</b>", null);
				NLPAFJIBPHJKGCMKMH._doRapidFire = GUILayout.Toggle(NLPAFJIBPHJKGCMKMH._doRapidFire, "Rapid Fire", null);
				if (NLPAFJIBPHJKGCMKMH._doRapidFire)
				{
					NLPAFJIBPHJKGCMKMH._rapidFireTypeDropdown.Draw();
				}
			}
			catch
			{
			}
			try
			{
				GUILayout.BeginHorizontal(null);
				GUILayout.Label("Weapon Ammo Reserve", null);
				NLPAFJIBPHJKGCMKMH._ammoReserveTypeDropdown.Draw();
				GUILayout.EndHorizontal();
			}
			catch
			{
			}
			try
			{
				GUILayout.BeginHorizontal(null);
				GUILayout.Label("Weapon Recoil", null);
				NLPAFJIBPHJKGCMKMH._weaponRecoilOptionTypeDropdown.Draw();
				GUILayout.EndHorizontal();
			}
			catch
			{
			}
			GUILayout.EndScrollView();
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00019814 File Offset: 0x00017A14
		private static void Update()
		{
			if (Time.time - NLPAFJIBPHJKGCMKMH._lastUpdateTime > 1f)
			{
				NLPAFJIBPHJKGCMKMH._lastUpdateTime = Time.time;
				NLPAFJIBPHJKGCMKMH._myPlayer = JELGILABEGAPMCJHFF.LocalPlayer();
				NLPAFJIBPHJKGCMKMH._myPhotonPlayer = JKGLHAAMDAFFCEKMOC.get_LocalPlayer();
				NLPAFJIBPHJKGCMKMH._masterClientPlayer = JKGLHAAMDAFFCEKMOC.get_MasterClient();
				PlayerBody[] array = IINAFDNNOGOKGGOKHM.JHFFFJLIFAIJPEDFPD.Do<PlayerBody>();
				NLPAFJIBPHJKGCMKMH._playerList = new OKOEJLJNIMHOGIEDFP[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					NLPAFJIBPHJKGCMKMH._playerList[i] = OKOEJLJNIMHOGIEDFP.NativeCreate(array[i]);
				}
			}
			if (NLPAFJIBPHJKGCMKMH._doRapidFire)
			{
				NLPAFJIBPHJKGCMKMH.DoRapidFireForHand(LCOEGINFMGNENBCEGC.KDFHELNJKMIFMJKFBE.Left, NLPAFJIBPHJKGCMKMH._myPlayer.get_LeftHand());
				NLPAFJIBPHJKGCMKMH.DoRapidFireForHand(LCOEGINFMGNENBCEGC.KDFHELNJKMIFMJKFBE.Right, NLPAFJIBPHJKGCMKMH._myPlayer.get_RightHand());
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000198B4 File Offset: 0x00017AB4
		private static void DoRapidFireForHand(LCOEGINFMGNENBCEGC.KDFHELNJKMIFMJKFBE type, LCOEGINFMGNENBCEGC hand)
		{
			Tool heldTool;
			if ((heldTool = hand.get_HeldTool()) == null)
			{
				return;
			}
			RangedWeapon component;
			if ((component = heldTool.GetComponent<RangedWeapon>()) == null)
			{
				return;
			}
			if ((NLPAFJIBPHJKGCMKMH._rapidFireTypeDropdown.FJNKIPMKDFIPPHPNJN == PDHGBIOADHKGKNMIDL.VR) ? (hand.get_OpenCloseAxis() > 0.5f) : Input.GetKey((type == LCOEGINFMGNENBCEGC.KDFHELNJKMIFMJKFBE.Left) ? 323 : 324))
			{
				if (NLPAFJIBPHJKGCMKMH._ammoReserveTypeDropdown.FJNKIPMKDFIPPHPNJN != AHEMBDADDAIGKKCHLP.Normal)
				{
					if (NLPAFJIBPHJKGCMKMH._ammoReserveTypeDropdown.FJNKIPMKDFIPPHPNJN == AHEMBDADDAIGKKCHLP.Infinite)
					{
						component.hasInfiniteReserveAmmunition = true;
					}
					component.defaultMagazineAmmunition = OOBFDCHGGKFKMGFLOK.GetReserveBox(NLPAFJIBPHJKGCMKMH._ammoReserveTypeDropdown.FJNKIPMKDFIPPHPNJN);
					component.ammunitionMagazineSize = component.defaultMagazineAmmunition;
				}
				NLPAFJIBPHJKGCMKMH.RemoveRecoilFromProceedingRangedWeaponConfigs();
				component.Fire(999f);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001996C File Offset: 0x00017B6C
		private static void RemoveRecoilFromProceedingRangedWeaponConfigs()
		{
			ScreenPlayerBehaviorConfigBase[] array = SingletonMonoBehaviour<LocalPlayerController>.DMDACHFLMCK.screenController.globalPlayerBehaviors;
			if (NLPAFJIBPHJKGCMKMH._changedConfigs)
			{
				return;
			}
			NLPAFJIBPHJKGCMKMH._changedConfigs = true;
			foreach (ScreenPlayerBehaviorConfigBase screenPlayerBehaviorConfigBase in array)
			{
				if (screenPlayerBehaviorConfigBase.name.Contains("ScreenToolBehaviorConfig") && screenPlayerBehaviorConfigBase.GetType().BaseType == typeof(RangedWeaponScreenToolBehaviorConfig))
				{
					RangedWeaponScreenToolBehaviorConfig rangedWeaponScreenToolBehaviorConfig = (RangedWeaponScreenToolBehaviorConfig)screenPlayerBehaviorConfigBase;
					rangedWeaponScreenToolBehaviorConfig.applyRecoil = false;
					AHHKOKNPDHN.CameraShakeConfig onFireCameraShake = default(AHHKOKNPDHN.CameraShakeConfig);
					onFireCameraShake.NormalizedAmplitude = 0f;
					onFireCameraShake.Duration = 0f;
					onFireCameraShake.Frequency = 0f;
					rangedWeaponScreenToolBehaviorConfig.onFireCameraShake = onFireCameraShake;
				}
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00019A20 File Offset: 0x00017C20
		private static void RevertRecoilFromProceedingRangedWeaponConfigs()
		{
			ScreenPlayerBehaviorConfigBase[] array = SingletonMonoBehaviour<LocalPlayerController>.DMDACHFLMCK.screenController.globalPlayerBehaviors;
			if (!NLPAFJIBPHJKGCMKMH._changedConfigs)
			{
				return;
			}
			NLPAFJIBPHJKGCMKMH._changedConfigs = false;
			foreach (ScreenPlayerBehaviorConfigBase screenPlayerBehaviorConfigBase in array)
			{
				if (screenPlayerBehaviorConfigBase.name.Contains("ScreenToolBehaviorConfig") && screenPlayerBehaviorConfigBase.GetType().BaseType == typeof(RangedWeaponScreenToolBehaviorConfig))
				{
					RangedWeaponScreenToolBehaviorConfig rangedWeaponScreenToolBehaviorConfig = (RangedWeaponScreenToolBehaviorConfig)screenPlayerBehaviorConfigBase;
					rangedWeaponScreenToolBehaviorConfig.applyRecoil = true;
					AHHKOKNPDHN.CameraShakeConfig onFireCameraShake = default(AHHKOKNPDHN.CameraShakeConfig);
					onFireCameraShake.NormalizedAmplitude = 0.33f;
					onFireCameraShake.Duration = 0.33f;
					onFireCameraShake.Frequency = 45f;
					rangedWeaponScreenToolBehaviorConfig.onFireCameraShake = onFireCameraShake;
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000062B7 File Offset: 0x000044B7
		public static bool EADCHHECFAIFLPHPEP
		{
			get
			{
				return NLPAFJIBPHJKGCMKMH._doRapidFire;
			}
		}

		// Token: 0x0400034E RID: 846
		private static bool _changedConfigs;

		// Token: 0x0400034F RID: 847
		private static bool _isConfigsDirty;

		// Token: 0x04000350 RID: 848
		private static bool _doRapidFire;

		// Token: 0x04000351 RID: 849
		private static float _lastUpdateTime;

		// Token: 0x04000352 RID: 850
		private static OKOEJLJNIMHOGIEDFP[] _playerList;

		// Token: 0x04000353 RID: 851
		private static GDHIDEPCCBEBPAPBBK _masterClientPlayer;

		// Token: 0x04000354 RID: 852
		private static GDHIDEPCCBEBPAPBBK _myPhotonPlayer;

		// Token: 0x04000355 RID: 853
		private static HKLDGGMCANEIPNDPIB _myPlayer;

		// Token: 0x04000356 RID: 854
		private static PEIKILBNEBPOGFOEJJ<PDHGBIOADHKGKNMIDL> _rapidFireTypeDropdown;

		// Token: 0x04000357 RID: 855
		private static PEIKILBNEBPOGFOEJJ<AHEMBDADDAIGKKCHLP> _ammoReserveTypeDropdown;

		// Token: 0x04000358 RID: 856
		private static PEIKILBNEBPOGFOEJJ<HEBJBLHGIHOAAGLKDE> _weaponRecoilOptionTypeDropdown;

		// Token: 0x04000359 RID: 857
		private static HEBJBLHGIHOAAGLKDE _previousRecoilOptionType;

		// Token: 0x0400035A RID: 858
		private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		// Token: 0x0400035B RID: 859
		private static Vector2 _playerKickingScrollPosition;

		// Token: 0x0400035C RID: 860
		private static bool _initialized;

		// Token: 0x0400035D RID: 861
		private const float PHOTON_LIST_UPDATE_COOLDOWN = 1f;
	}
}

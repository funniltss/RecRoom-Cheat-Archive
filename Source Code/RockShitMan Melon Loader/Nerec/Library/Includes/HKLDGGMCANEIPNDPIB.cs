using System;
using Il2Cpp;

namespace Nerec.Library.Includes
{
	// Token: 0x02000178 RID: 376
	[GLOMGGIOCDALLIEGAB]
	public class HKLDGGMCANEIPNDPIB : FJPLJPFGCPEFCNJGNK
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x000067D1 File Offset: 0x000049D1
		private HKLDGGMCANEIPNDPIB(Player player) : base(player)
		{
			this._localPlayer = player;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001A5B0 File Offset: 0x000187B0
		public MMMKOGEMMAMANCCAIL get_Head()
		{
			MMMKOGEMMAMANCCAIL result;
			if ((result = this._head) == null)
			{
				result = (this._head = MMMKOGEMMAMANCCAIL.NativeCreate(this._localPlayer.head));
			}
			return result;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001A5E0 File Offset: 0x000187E0
		public OKOEJLJNIMHOGIEDFP get_Body()
		{
			OKOEJLJNIMHOGIEDFP result;
			if ((result = this._body) == null)
			{
				result = (this._body = OKOEJLJNIMHOGIEDFP.NativeCreate(this._localPlayer.body));
			}
			return result;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001A610 File Offset: 0x00018810
		public LCOEGINFMGNENBCEGC get_LeftHand()
		{
			LCOEGINFMGNENBCEGC result;
			if ((result = this._leftHand) == null)
			{
				result = (this._leftHand = LCOEGINFMGNENBCEGC.NativeCreate(this._localPlayer.leftHand));
			}
			return result;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001A640 File Offset: 0x00018840
		public LCOEGINFMGNENBCEGC get_RightHand()
		{
			LCOEGINFMGNENBCEGC result;
			if ((result = this._rightHand) == null)
			{
				result = (this._rightHand = LCOEGINFMGNENBCEGC.NativeCreate(this._localPlayer.rightHand));
			}
			return result;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001A670 File Offset: 0x00018870
		public GDHIDEPCCBEBPAPBBK get_PhotonPlayer()
		{
			GDHIDEPCCBEBPAPBBK result;
			if ((result = this._photonPlayer) == null)
			{
				result = (this._photonPlayer = new GDHIDEPCCBEBPAPBBK(this._localPlayer.pvCache.Owner));
			}
			return result;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0001A6A8 File Offset: 0x000188A8
		public long get_PlayerId()
		{
			return (long)((this._playerId == 0) ? (this._playerId = KPEDLOGCLIIMEFHOJC.Decrypt(this.get_NativeObscuredInt_PlayerId())) : this._playerId);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001A6DC File Offset: 0x000188DC
		private KPEDLOGCLIIMEFHOJC get_NativeObscuredInt_PlayerId()
		{
			KPEDLOGCLIIMEFHOJC result;
			if ((result = this._obscuredInt) == null)
			{
				result = (this._obscuredInt = KPEDLOGCLIIMEFHOJC.NativeCreate(this._localPlayer._playerId));
			}
			return result;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000067E1 File Offset: 0x000049E1
		public static HKLDGGMCANEIPNDPIB get_LocalPlayer()
		{
			return new HKLDGGMCANEIPNDPIB(Player.LocalPlayer);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000067ED File Offset: 0x000049ED
		public static HKLDGGMCANEIPNDPIB NativeCreate(Player player)
		{
			return new HKLDGGMCANEIPNDPIB(player);
		}

		// Token: 0x04000392 RID: 914
		private MMMKOGEMMAMANCCAIL _head;

		// Token: 0x04000393 RID: 915
		private OKOEJLJNIMHOGIEDFP _body;

		// Token: 0x04000394 RID: 916
		private LCOEGINFMGNENBCEGC _rightHand;

		// Token: 0x04000395 RID: 917
		private LCOEGINFMGNENBCEGC _leftHand;

		// Token: 0x04000396 RID: 918
		private GDHIDEPCCBEBPAPBBK _photonPlayer;

		// Token: 0x04000397 RID: 919
		private int _playerId;

		// Token: 0x04000398 RID: 920
		private KPEDLOGCLIIMEFHOJC _obscuredInt;

		// Token: 0x04000399 RID: 921
		private Player _localPlayer;
	}
}

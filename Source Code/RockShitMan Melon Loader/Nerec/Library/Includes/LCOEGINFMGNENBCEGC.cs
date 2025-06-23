using System;
using Il2Cpp;

namespace Nerec.Library.Includes
{
	// Token: 0x0200017B RID: 379
	[GLOMGGIOCDALLIEGAB]
	public class LCOEGINFMGNENBCEGC : AEOJIKIFPKKJCOMBAO
	{
		// Token: 0x0600066D RID: 1645 RVA: 0x00006825 File Offset: 0x00004A25
		private LCOEGINFMGNENBCEGC(PlayerHand hand) : base(hand)
		{
			this._hand = hand;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001A76C File Offset: 0x0001896C
		public HKLDGGMCANEIPNDPIB get_Player()
		{
			HKLDGGMCANEIPNDPIB result;
			if ((result = this._player) == null)
			{
				result = (this._player = HKLDGGMCANEIPNDPIB.NativeCreate(this._hand._thisPlayer));
			}
			return result;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00006835 File Offset: 0x00004A35
		public Tool get_HeldTool()
		{
			return this._hand.HeldTool;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00006842 File Offset: 0x00004A42
		public float get_OpenCloseAxis()
		{
			return this._hand.OpenClosedAxis;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0000684F File Offset: 0x00004A4F
		public static LCOEGINFMGNENBCEGC NativeCreate(PlayerHand hand)
		{
			return new LCOEGINFMGNENBCEGC(hand);
		}

		// Token: 0x0400039E RID: 926
		private HKLDGGMCANEIPNDPIB _player;

		// Token: 0x0400039F RID: 927
		private PlayerHand _hand;

		// Token: 0x0200017C RID: 380
		public enum KDFHELNJKMIFMJKFBE
		{
			// Token: 0x040003A1 RID: 929
			Unknown = -1,
			// Token: 0x040003A2 RID: 930
			Left,
			// Token: 0x040003A3 RID: 931
			Right
		}
	}
}

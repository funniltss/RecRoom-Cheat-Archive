using System;
using Il2Cpp;

namespace Nerec.Library.Includes
{
	// Token: 0x02000179 RID: 377
	[GLOMGGIOCDALLIEGAB]
	public class MMMKOGEMMAMANCCAIL : AEOJIKIFPKKJCOMBAO
	{
		// Token: 0x06000667 RID: 1639 RVA: 0x000067F5 File Offset: 0x000049F5
		private MMMKOGEMMAMANCCAIL(PlayerHead head) : base(head)
		{
			this._head = head;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001A70C File Offset: 0x0001890C
		public HKLDGGMCANEIPNDPIB get_Player()
		{
			HKLDGGMCANEIPNDPIB result;
			if ((result = this._player) == null)
			{
				result = (this._player = HKLDGGMCANEIPNDPIB.NativeCreate(this._head.Player));
			}
			return result;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00006805 File Offset: 0x00004A05
		public static MMMKOGEMMAMANCCAIL NativeCreate(PlayerHead hand)
		{
			return new MMMKOGEMMAMANCCAIL(hand);
		}

		// Token: 0x0400039A RID: 922
		private HKLDGGMCANEIPNDPIB _player;

		// Token: 0x0400039B RID: 923
		private PlayerHead _head;
	}
}

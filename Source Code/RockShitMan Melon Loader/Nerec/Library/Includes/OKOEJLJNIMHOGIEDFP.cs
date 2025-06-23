using System;
using Il2CppRecRoom.Players;

namespace Nerec.Library.Includes
{
	// Token: 0x0200017A RID: 378
	[GLOMGGIOCDALLIEGAB]
	public class OKOEJLJNIMHOGIEDFP : AEOJIKIFPKKJCOMBAO
	{
		// Token: 0x0600066A RID: 1642 RVA: 0x0000680D File Offset: 0x00004A0D
		private OKOEJLJNIMHOGIEDFP(PlayerBody body) : base(body)
		{
			this._body = body;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001A73C File Offset: 0x0001893C
		public HKLDGGMCANEIPNDPIB get_Player()
		{
			HKLDGGMCANEIPNDPIB result;
			if ((result = this._player) == null)
			{
				result = (this._player = HKLDGGMCANEIPNDPIB.NativeCreate(this._body.Player));
			}
			return result;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0000681D File Offset: 0x00004A1D
		public static OKOEJLJNIMHOGIEDFP NativeCreate(PlayerBody body)
		{
			return new OKOEJLJNIMHOGIEDFP(body);
		}

		// Token: 0x0400039C RID: 924
		private HKLDGGMCANEIPNDPIB _player;

		// Token: 0x0400039D RID: 925
		private PlayerBody _body;
	}
}

using System;
using System.Collections.Generic;
using Il2Cpp;

namespace Nerec.Library.Includes
{
	// Token: 0x02000175 RID: 373
	[GLOMGGIOCDALLIEGAB]
	public class GDHIDEPCCBEBPAPBBK : MICKGCLEMINKBHGPHG
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x00006708 File Offset: 0x00004908
		public GDHIDEPCCBEBPAPBBK(LKFKEMBCBJC player)
		{
			this._player = player;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00006717 File Offset: 0x00004917
		public int get_ActorNumber()
		{
			return this._player.GFMEFMPLCLP();
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00006724 File Offset: 0x00004924
		public bool get_IsLocal()
		{
			return this._player.HKDNJLHCCHC;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00006731 File Offset: 0x00004931
		public IDictionary<object, object> get_CustomProperties()
		{
			return (IDictionary<object, object>)this._player.KFGEMDMMJBJ();
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00006743 File Offset: 0x00004943
		public string get_NickName()
		{
			return this._player.PKAGKKEALFF();
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00006750 File Offset: 0x00004950
		public int get_RecNetAccountId()
		{
			return this._player.NMAJKIIFNJF();
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000675D File Offset: 0x0000495D
		public bool get_IsBroadcasted()
		{
			return this._player.MCHBLAMOCIC();
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0000676A File Offset: 0x0000496A
		public LKFKEMBCBJC PLOFKGBIGLNOJJKGNI
		{
			get
			{
				return this._player;
			}
		}

		// Token: 0x04000391 RID: 913
		private LKFKEMBCBJC _player;
	}
}

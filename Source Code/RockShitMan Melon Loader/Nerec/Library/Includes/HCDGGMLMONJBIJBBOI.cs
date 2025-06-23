using System;
using UnityEngine;

namespace Nerec.Library.Includes
{
	// Token: 0x0200016D RID: 365
	[GLOMGGIOCDALLIEGAB]
	public class HCDGGMLMONJBIJBBOI : ODIOKAECHIOGGGGLPC
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x0000660C File Offset: 0x0000480C
		public HCDGGMLMONJBIJBBOI(Behaviour behaviour) : base(behaviour)
		{
			this._behaviour = behaviour;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000661C File Offset: 0x0000481C
		public bool get_Enabled()
		{
			return this._behaviour.enabled;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00006629 File Offset: 0x00004829
		public bool get_IsActiveAndEnabled()
		{
			return this._behaviour.isActiveAndEnabled;
		}

		// Token: 0x0400038C RID: 908
		private Behaviour _behaviour;
	}
}

using System;
using UnityEngine;

namespace Nerec.Library.Includes
{
	// Token: 0x0200016E RID: 366
	[GLOMGGIOCDALLIEGAB]
	public class ODIOKAECHIOGGGGLPC : KHDFGFMBCOEIABGDGP
	{
		// Token: 0x06000635 RID: 1589 RVA: 0x00006636 File Offset: 0x00004836
		public ODIOKAECHIOGGGGLPC(Component component) : base(component)
		{
			this._component = component;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00006646 File Offset: 0x00004846
		public IFENNLNKLIGMDDCPLM get_Transform()
		{
			return new IFENNLNKLIGMDDCPLM(this._component.transform);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00006658 File Offset: 0x00004858
		public PNHGDGLPIHCIEIDLCI get_GameObject()
		{
			return new PNHGDGLPIHCIEIDLCI(this._component.gameObject);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0000666A File Offset: 0x0000486A
		public string get_Tag()
		{
			return this._component.tag;
		}

		// Token: 0x0400038D RID: 909
		private Component _component;
	}
}

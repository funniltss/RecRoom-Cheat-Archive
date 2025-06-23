using System;
using System.Collections.Generic;

namespace Nerec.Library.UnityGUI.Custom
{
	// Token: 0x0200015D RID: 349
	public static class OOBFDCHGGKFKMGFLOK
	{
		// Token: 0x060005DF RID: 1503 RVA: 0x000062CA File Offset: 0x000044CA
		public static int GetReserveBox(AHEMBDADDAIGKKCHLP type)
		{
			return OOBFDCHGGKFKMGFLOK.LLKLBBMNBFCJNKNNKH[type];
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x000062D7 File Offset: 0x000044D7
		public static Dictionary<AHEMBDADDAIGKKCHLP, int> LLKLBBMNBFCJNKNNKH
		{
			get
			{
				return OOBFDCHGGKFKMGFLOK._currentReserves;
			}
		}

		// Token: 0x04000368 RID: 872
		private static Dictionary<AHEMBDADDAIGKKCHLP, int> _currentReserves = new Dictionary<AHEMBDADDAIGKKCHLP, int>
		{
			{
				AHEMBDADDAIGKKCHLP.Normal,
				-1
			},
			{
				AHEMBDADDAIGKKCHLP.Fixed,
				100
			},
			{
				AHEMBDADDAIGKKCHLP.Infinite,
				int.MaxValue
			}
		};
	}
}

using System;
using Il2CppCodeStage.AntiCheat.ObscuredTypes;

namespace Nerec.Library.Includes
{
	// Token: 0x02000170 RID: 368
	[GLOMGGIOCDALLIEGAB]
	public class KPEDLOGCLIIMEFHOJC
	{
		// Token: 0x0600063C RID: 1596 RVA: 0x000066A0 File Offset: 0x000048A0
		public KPEDLOGCLIIMEFHOJC(ObscuredInt obscuredInt)
		{
			this._obscuredInt = obscuredInt;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000066AF File Offset: 0x000048AF
		public static int Decrypt(KPEDLOGCLIIMEFHOJC obscuredInt)
		{
			return obscuredInt._obscuredInt.OKOEPBECMOD();
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000066BC File Offset: 0x000048BC
		public static KPEDLOGCLIIMEFHOJC NativeCreate(ObscuredInt obscuredInt)
		{
			return new KPEDLOGCLIIMEFHOJC(obscuredInt);
		}

		// Token: 0x0400038F RID: 911
		private ObscuredInt _obscuredInt;
	}
}

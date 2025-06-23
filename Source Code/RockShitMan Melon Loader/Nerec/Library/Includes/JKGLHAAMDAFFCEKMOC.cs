using System;
using Il2Cpp;
using Il2CppSystem;
using UnityEngine;

namespace Nerec.Library.Includes
{
	// Token: 0x02000176 RID: 374
	[GLOMGGIOCDALLIEGAB]
	public static class JKGLHAAMDAFFCEKMOC
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x00006772 File Offset: 0x00004972
		public static void Instantiate(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group = 0, object[] data = null, bool destroyOnLeave = true)
		{
			GLKIAEDIJGI.GLCFKEABDII(prefabName, position, rotation, scale, group, (Object[])data, destroyOnLeave);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000678E File Offset: 0x0000498E
		public static void DestroyPlayerObjects(GDHIDEPCCBEBPAPBBK player)
		{
			GLKIAEDIJGI.MLNFPCFAIGB(player.ToIl2cpp());
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000679B File Offset: 0x0000499B
		public static void SetMasterClient(GDHIDEPCCBEBPAPBBK player)
		{
			GLKIAEDIJGI.BBAAEPAOOON(player.ToIl2cpp());
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x000067A9 File Offset: 0x000049A9
		public static GDHIDEPCCBEBPAPBBK get_LocalPlayer()
		{
			return GLKIAEDIJGI.NMGEBEKGEBM().ToNative();
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000067B5 File Offset: 0x000049B5
		public static GDHIDEPCCBEBPAPBBK get_MasterClient()
		{
			return GLKIAEDIJGI.DLPGDPEKKBD().ToNative();
		}
	}
}

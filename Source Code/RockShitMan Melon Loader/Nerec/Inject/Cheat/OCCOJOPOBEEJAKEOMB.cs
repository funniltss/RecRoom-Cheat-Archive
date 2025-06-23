using System;
using Il2Cpp;
using Il2CppRecRoom.AntiCheat;
using Nerec.Library.Unity;
using UJect;
using UnityEngine;

namespace Nerec.Inject.Cheat
{
	// Token: 0x02000191 RID: 401
	public class OCCOJOPOBEEJAKEOMB : PDFNNALBNPGMIBLPFG
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x0001A830 File Offset: 0x00018A30
		public static void InitializeDIRoot()
		{
			OCCOJOPOBEEJAKEOMB occojopobeejakeomb = new OCCOJOPOBEEJAKEOMB();
			DI.Root.Bind<PDFNNALBNPGMIBLPFG>().ToInstance<OCCOJOPOBEEJAKEOMB>(occojopobeejakeomb);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001A854 File Offset: 0x00018A54
		public void DestroyExistingObjects()
		{
			Debug.Log("Destroying objects");
			EACManager[] array = IINAFDNNOGOKGGOKHM.JHFFFJLIFAIJPEDFPD.Do<EACManager>();
			for (int i = 0; i < array.Length; i++)
			{
				Object.Destroy(array[i].gameObject);
			}
			CheatManager[] array2 = IINAFDNNOGOKGGOKHM.JHFFFJLIFAIJPEDFPD.Do<CheatManager>();
			for (int i = 0; i < array2.Length; i++)
			{
				Object.Destroy(array2[i].gameObject);
			}
		}
	}
}

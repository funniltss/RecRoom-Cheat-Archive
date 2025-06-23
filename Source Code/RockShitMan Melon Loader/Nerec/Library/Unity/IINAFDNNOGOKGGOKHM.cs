using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nerec.Library.Unity
{
	// Token: 0x02000144 RID: 324
	public static class IINAFDNNOGOKGGOKHM
	{
		// Token: 0x02000145 RID: 325
		public static class JHFFFJLIFAIJPEDFPD
		{
			// Token: 0x0600056F RID: 1391 RVA: 0x00018B70 File Offset: 0x00016D70
			public static DLAKDNPEPBPAOJILIC[] Do<DLAKDNPEPBPAOJILIC>() where DLAKDNPEPBPAOJILIC : Component
			{
				Type typeFromHandle = typeof(DLAKDNPEPBPAOJILIC);
				if (IINAFDNNOGOKGGOKHM.JHFFFJLIFAIJPEDFPD.cachedObjects.ContainsKey(typeFromHandle))
				{
					return IINAFDNNOGOKGGOKHM.JHFFFJLIFAIJPEDFPD.cachedObjects[typeFromHandle].ToArray() as DLAKDNPEPBPAOJILIC[];
				}
				DLAKDNPEPBPAOJILIC[] array = Object.FindObjectsOfType<DLAKDNPEPBPAOJILIC>();
				List<Component> list = new List<Component>(array.Length);
				foreach (DLAKDNPEPBPAOJILIC dlakdnpepbpaojilic in array)
				{
					list.Add(dlakdnpepbpaojilic);
				}
				IINAFDNNOGOKGGOKHM.JHFFFJLIFAIJPEDFPD.cachedObjects.Add(typeFromHandle, list);
				return array;
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00005E25 File Offset: 0x00004025
			public static void ClearCache()
			{
				IINAFDNNOGOKGGOKHM.JHFFFJLIFAIJPEDFPD.cachedObjects.Clear();
			}

			// Token: 0x04000315 RID: 789
			private static Dictionary<Type, List<Component>> cachedObjects = new Dictionary<Type, List<Component>>();
		}
	}
}

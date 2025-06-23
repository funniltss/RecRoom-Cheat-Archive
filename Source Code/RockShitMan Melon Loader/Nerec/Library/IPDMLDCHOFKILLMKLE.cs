using System;
using UnityEngine;

namespace Nerec.Library
{
	// Token: 0x0200013E RID: 318
	public static class IPDMLDCHOFKILLMKLE
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00005DC2 File Offset: 0x00003FC2
		private static void Initialize()
		{
			if (!IPDMLDCHOFKILLMKLE._initialized)
			{
				new GameObject("[Nerec Scheduler](internal)").AddComponent<DGLGKLKIPNINGHGFPM>();
				IPDMLDCHOFKILLMKLE._initialized = true;
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00005DE1 File Offset: 0x00003FE1
		public static void Run(LLHALDELIJLHMBBGID queueType, Action action)
		{
			IPDMLDCHOFKILLMKLE.Initialize();
			DGLGKLKIPNINGHGFPM.NKKJAGFJPKGHJMNDBJ.AddToQueue(queueType, action);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00003EE1 File Offset: 0x000020E1
		public static void UpdateHz(float period, Action action)
		{
		}

		// Token: 0x040002B6 RID: 694
		private static bool _initialized;
	}
}

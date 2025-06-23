using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nerec.Library
{
	// Token: 0x0200013C RID: 316
	[ODCFJDIDECFCPJJAAL]
	public class DGLGKLKIPNINGHGFPM : MonoBehaviour
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00005D2E File Offset: 0x00003F2E
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00005D35 File Offset: 0x00003F35
		public static DGLGKLKIPNINGHGFPM NKKJAGFJPKGHJMNDBJ { get; private set; }

		// Token: 0x0600055F RID: 1375 RVA: 0x0001889C File Offset: 0x00016A9C
		private void Awake()
		{
			DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.OneFrame] = new List<Action>();
			DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.Update] = new List<Action>();
			DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.LateUpdate] = new List<Action>();
			DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.FixedUpdate] = new List<Action>();
			if (DGLGKLKIPNINGHGFPM.NKKJAGFJPKGHJMNDBJ == null)
			{
				DGLGKLKIPNINGHGFPM.NKKJAGFJPKGHJMNDBJ = this;
				Object.DontDestroyOnLoad(base.gameObject);
				return;
			}
			Object.Destroy(base.gameObject);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00005D3D File Offset: 0x00003F3D
		public void AddToQueue(LLHALDELIJLHMBBGID queueType, Action action)
		{
			if (!DGLGKLKIPNINGHGFPM._queue.ContainsKey(queueType))
			{
				DGLGKLKIPNINGHGFPM._queue[queueType] = new List<Action>();
			}
			DGLGKLKIPNINGHGFPM._queue[queueType].Add(action);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00005D6D File Offset: 0x00003F6D
		public void AddToHzQueue(float period, Action action)
		{
			DGLGKLKIPNINGHGFPM._queueHz.Add(new KHPHJIOMCFBENNMEKI
			{
				period = period,
				action = action,
				hz = 1f / period,
				current = 0f
			});
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00018914 File Offset: 0x00016B14
		private void Update()
		{
			List<Action> list = new List<Action>();
			foreach (Action action in DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.OneFrame])
			{
				action();
				list.Add(action);
			}
			foreach (Action item in list)
			{
				DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.OneFrame].Remove(item);
			}
			foreach (Action action2 in DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.Update])
			{
				action2();
			}
			foreach (KHPHJIOMCFBENNMEKI khphjiomcfbennmeki in DGLGKLKIPNINGHGFPM._queueHz)
			{
				khphjiomcfbennmeki.current += 0.016666668f;
				if (khphjiomcfbennmeki.current > khphjiomcfbennmeki.period)
				{
					khphjiomcfbennmeki.current = 0f;
					khphjiomcfbennmeki.action();
				}
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00018A7C File Offset: 0x00016C7C
		private void LateUpdate()
		{
			foreach (Action action in DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.LateUpdate])
			{
				action();
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00018AD4 File Offset: 0x00016CD4
		private void FixedUpdate()
		{
			foreach (Action action in DGLGKLKIPNINGHGFPM._queue[LLHALDELIJLHMBBGID.FixedUpdate])
			{
				action();
			}
		}

		// Token: 0x040002B0 RID: 688
		public static Dictionary<LLHALDELIJLHMBBGID, List<Action>> _queue = new Dictionary<LLHALDELIJLHMBBGID, List<Action>>();

		// Token: 0x040002B1 RID: 689
		public static List<KHPHJIOMCFBENNMEKI> _queueHz = new List<KHPHJIOMCFBENNMEKI>();
	}
}

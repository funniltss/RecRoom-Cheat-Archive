using System;
using Il2CppPhoton.Pun;
using Nerec.Library.Unity;
using UnityEngine;

namespace Nerec.Library.Callbacks
{
	// Token: 0x02000190 RID: 400
	public sealed class JMGPLEBEJDLEKELDHK : MonoBehaviourPunCallbacks
	{
		// Token: 0x060006C3 RID: 1731 RVA: 0x000068C5 File Offset: 0x00004AC5
		public JMGPLEBEJDLEKELDHK(IntPtr intPtr) : base(intPtr)
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000068CE File Offset: 0x00004ACE
		public override void Awake()
		{
			base.Awake();
			Object.DontDestroyOnLoad(base.gameObject);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000068E1 File Offset: 0x00004AE1
		public override void OnLeftRoom()
		{
			IINAFDNNOGOKGGOKHM.JHFFFJLIFAIJPEDFPD.ClearCache();
		}
	}
}

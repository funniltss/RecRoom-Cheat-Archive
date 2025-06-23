using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nerec.Library.Includes
{
	// Token: 0x0200016A RID: 362
	[GLOMGGIOCDALLIEGAB]
	public class PNHGDGLPIHCIEIDLCI : KHDFGFMBCOEIABGDGP
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x00006447 File Offset: 0x00004647
		public PNHGDGLPIHCIEIDLCI(GameObject gameObject) : base(gameObject)
		{
			this._gameObject = gameObject;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00006457 File Offset: 0x00004657
		public bool get_Active()
		{
			return this._gameObject.active;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00006464 File Offset: 0x00004664
		public bool get_ActiveSelf()
		{
			return this._gameObject.activeSelf;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00006471 File Offset: 0x00004671
		public bool get_ActiveInHierarchy()
		{
			return this._gameObject.activeInHierarchy;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000647E File Offset: 0x0000467E
		public bool get_IsStatic()
		{
			return this._gameObject.isStatic;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000648B File Offset: 0x0000468B
		public bool get_IsStaticBatchable()
		{
			return this._gameObject.isStaticBatchable;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00006498 File Offset: 0x00004698
		public int get_Layer()
		{
			return this._gameObject.layer;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000064A5 File Offset: 0x000046A5
		public Scene get_Scene()
		{
			return this._gameObject.scene;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000064B2 File Offset: 0x000046B2
		public ulong get_SceneCullingMask()
		{
			return this._gameObject.sceneCullingMask;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000064BF File Offset: 0x000046BF
		public string get_Tag()
		{
			return this._gameObject.tag;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000064CC File Offset: 0x000046CC
		public IFENNLNKLIGMDDCPLM get_Transform()
		{
			return new IFENNLNKLIGMDDCPLM(this._gameObject.transform);
		}

		// Token: 0x04000389 RID: 905
		private GameObject _gameObject;
	}
}

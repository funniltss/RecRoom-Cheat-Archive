using System;
using UnityEngine;

namespace Nerec.Library.Includes
{
	// Token: 0x0200016B RID: 363
	[GLOMGGIOCDALLIEGAB]
	public class IFENNLNKLIGMDDCPLM : ODIOKAECHIOGGGGLPC
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x000064DE File Offset: 0x000046DE
		public IFENNLNKLIGMDDCPLM(Transform transform) : base(transform)
		{
			this._transform = transform;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000064EE File Offset: 0x000046EE
		public IFENNLNKLIGMDDCPLM get_Root()
		{
			return new IFENNLNKLIGMDDCPLM(this._transform.root);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00006500 File Offset: 0x00004700
		public int get_ChildCount()
		{
			return this._transform.childCount;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000650D File Offset: 0x0000470D
		public bool get_HasChanged()
		{
			return this._transform.hasChanged;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000651A File Offset: 0x0000471A
		public int get_HierarchyCount()
		{
			return this._transform.hierarchyCount;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00006527 File Offset: 0x00004727
		public int get_HierarchyCapacity()
		{
			return this._transform.hierarchyCapacity;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00006534 File Offset: 0x00004734
		public Vector3 get_Position()
		{
			return this._transform.position;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00006541 File Offset: 0x00004741
		public Vector3 get_LocalPosition()
		{
			return this._transform.localPosition;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000654E File Offset: 0x0000474E
		public Vector3 get_EulerAngles()
		{
			return this._transform.eulerAngles;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000655B File Offset: 0x0000475B
		public Vector3 get_LocalEulerAngles()
		{
			return this._transform.localEulerAngles;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00006568 File Offset: 0x00004768
		public Vector3 get_Right()
		{
			return this._transform.right;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00006575 File Offset: 0x00004775
		public Vector3 get_Up()
		{
			return this._transform.up;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00006582 File Offset: 0x00004782
		public Vector3 get_Forward()
		{
			return this._transform.forward;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000658F File Offset: 0x0000478F
		public Quaternion get_Rotation()
		{
			return this._transform.rotation;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000659C File Offset: 0x0000479C
		public Quaternion get_LocalRotation()
		{
			return this._transform.localRotation;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000065A9 File Offset: 0x000047A9
		public Vector3 get_LocalScale()
		{
			return this._transform.localScale;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000065B6 File Offset: 0x000047B6
		public Vector3 get_LossyScale()
		{
			return this._transform.lossyScale;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000065C3 File Offset: 0x000047C3
		public IFENNLNKLIGMDDCPLM get_Parent()
		{
			return new IFENNLNKLIGMDDCPLM(this._transform.parent);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000065D5 File Offset: 0x000047D5
		public Matrix4x4 get_WorldToLocalMatrix()
		{
			return this._transform.worldToLocalMatrix;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000065E2 File Offset: 0x000047E2
		public Matrix4x4 get_LocalToWorldMatrix()
		{
			return this._transform.localToWorldMatrix;
		}

		// Token: 0x0400038A RID: 906
		private Transform _transform;
	}
}

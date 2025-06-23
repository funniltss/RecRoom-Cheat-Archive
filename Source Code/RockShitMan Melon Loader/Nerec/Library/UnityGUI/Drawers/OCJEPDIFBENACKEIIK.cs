using System;
using UnityEngine;

namespace Nerec.Library.UnityGUI.Drawers
{
	// Token: 0x02000154 RID: 340
	public class OCJEPDIFBENACKEIIK
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00019424 File Offset: 0x00017624
		public void Draw()
		{
			GUILayout.BeginHorizontal(null);
			string s = GUILayout.TextField(this._x.ToString(), null);
			string s2 = GUILayout.TextField(this._y.ToString(), null);
			string s3 = GUILayout.TextField(this._z.ToString(), null);
			float x;
			if (float.TryParse(s, out x))
			{
				this._x = x;
			}
			float y;
			if (float.TryParse(s2, out y))
			{
				this._y = y;
			}
			float z;
			if (float.TryParse(s3, out z))
			{
				this._z = z;
			}
			GUILayout.EndHorizontal();
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000061E6 File Offset: 0x000043E6
		public Vector3 EBPONMOBJHOOPHGKGF
		{
			get
			{
				return new Vector3(this._x, this._y, this._z);
			}
		}

		// Token: 0x04000341 RID: 833
		private float _x;

		// Token: 0x04000342 RID: 834
		private float _y;

		// Token: 0x04000343 RID: 835
		private float _z;
	}
}

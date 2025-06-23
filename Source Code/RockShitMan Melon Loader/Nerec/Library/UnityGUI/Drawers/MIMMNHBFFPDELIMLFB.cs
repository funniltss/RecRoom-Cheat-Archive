using System;
using UnityEngine;

namespace Nerec.Library.UnityGUI.Drawers
{
	// Token: 0x02000153 RID: 339
	public class MIMMNHBFFPDELIMLFB
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x000193C8 File Offset: 0x000175C8
		public void Draw()
		{
			GUILayout.BeginHorizontal(null);
			string s = GUILayout.TextField(this._x.ToString(), null);
			string s2 = GUILayout.TextField(this._z.ToString(), null);
			float x;
			if (float.TryParse(s, out x))
			{
				this._x = x;
			}
			float z;
			if (float.TryParse(s2, out z))
			{
				this._z = z;
			}
			GUILayout.EndHorizontal();
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000061D3 File Offset: 0x000043D3
		public Vector2 BGDLGEDEFCIBOKOKOO
		{
			get
			{
				return new Vector2(this._x, this._z);
			}
		}

		// Token: 0x0400033F RID: 831
		private float _x;

		// Token: 0x04000340 RID: 832
		private float _z;
	}
}

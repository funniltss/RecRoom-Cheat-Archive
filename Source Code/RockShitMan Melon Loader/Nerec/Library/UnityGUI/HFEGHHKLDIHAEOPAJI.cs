using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Nerec.Library.UnityGUI
{
	// Token: 0x0200014B RID: 331
	[ODCFJDIDECFCPJJAAL]
	public class HFEGHHKLDIHAEOPAJI : PIMOHOCBLANOOCHIOK
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x00005E3D File Offset: 0x0000403D
		public HFEGHHKLDIHAEOPAJI(IntPtr intPtr) : base(intPtr)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00005F5A File Offset: 0x0000415A
		public void SetStrings(FPILPOPAMHBJOIIGKM dropdown, List<string> options)
		{
			this.CAHDFHAAMCJCDGKBBG = dropdown;
			this.NNIPOKMMIJKKELCMGI = options;
			this.FGCIHABFNPBIMNNEJK = options.First<string>();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00005F76 File Offset: 0x00004176
		public override void OnWindowStart()
		{
			base.OnDrawWindow += this.WindowGUI_EnumDropdown_DrawWindow;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00018DF0 File Offset: 0x00016FF0
		private void WindowGUI_EnumDropdown_DrawWindow(int windowId)
		{
			GUILayout.Space(20f);
			this._scrollPosition = GUILayout.BeginScrollView(this._scrollPosition, null);
			foreach (string text in this.NNIPOKMMIJKKELCMGI)
			{
				if (GUILayout.Button(text, null))
				{
					this.FGCIHABFNPBIMNNEJK = text;
					this.CAHDFHAAMCJCDGKBBG.FOLLPAJPCGIENBNKHM = this.FGCIHABFNPBIMNNEJK;
					base.OFFIOCIKHNOANLAOKL = false;
				}
			}
			GUILayout.EndScrollView();
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00005F8A File Offset: 0x0000418A
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00005F92 File Offset: 0x00004192
		public List<string> NNIPOKMMIJKKELCMGI { get; private set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00005F9B File Offset: 0x0000419B
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00005FA3 File Offset: 0x000041A3
		public string FGCIHABFNPBIMNNEJK { get; private set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00005FAC File Offset: 0x000041AC
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00005FB4 File Offset: 0x000041B4
		public FPILPOPAMHBJOIIGKM CAHDFHAAMCJCDGKBBG { get; private set; }

		// Token: 0x04000322 RID: 802
		private Vector2 _scrollPosition;
	}
}

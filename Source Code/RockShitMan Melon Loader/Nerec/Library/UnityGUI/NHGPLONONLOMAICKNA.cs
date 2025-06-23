using System;
using UnityEngine;

namespace Nerec.Library.UnityGUI
{
	// Token: 0x02000146 RID: 326
	[ODCFJDIDECFCPJJAAL]
	public class NHGPLONONLOMAICKNA : PIMOHOCBLANOOCHIOK
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x00005E3D File Offset: 0x0000403D
		public NHGPLONONLOMAICKNA(IntPtr intPtr) : base(intPtr)
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00005E46 File Offset: 0x00004046
		public void SetEnumType(FPILPOPAMHBJOIIGKM dropdown, Type enumType)
		{
			this.PCOIJLLONAJIHLDHBI = dropdown;
			this.DKHNHEGJBJAENEJABJ = enumType;
			this.GOOFFDCKOBCPNLPGKA = Enum.GetValues(this.DKHNHEGJBJAENEJABJ).GetValue(0);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00005E6D File Offset: 0x0000406D
		public override void OnWindowStart()
		{
			base.OnDrawWindow += this.WindowGUI_EnumDropdown_DrawWindow;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00018BF8 File Offset: 0x00016DF8
		private void WindowGUI_EnumDropdown_DrawWindow(int windowId)
		{
			GUILayout.Space(20f);
			this._scrollPosition = GUILayout.BeginScrollView(this._scrollPosition, null);
			foreach (object obj in Enum.GetValues(this.DKHNHEGJBJAENEJABJ))
			{
				if (GUILayout.Button(obj.ToString(), null))
				{
					this.GOOFFDCKOBCPNLPGKA = obj;
					this.PCOIJLLONAJIHLDHBI.FOLLPAJPCGIENBNKHM = this.GOOFFDCKOBCPNLPGKA;
					base.OFFIOCIKHNOANLAOKL = false;
				}
			}
			GUILayout.EndScrollView();
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00005E81 File Offset: 0x00004081
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00005E89 File Offset: 0x00004089
		public object GOOFFDCKOBCPNLPGKA { get; private set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00005E92 File Offset: 0x00004092
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00005E9A File Offset: 0x0000409A
		public Type DKHNHEGJBJAENEJABJ { get; private set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00005EA3 File Offset: 0x000040A3
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00005EAB File Offset: 0x000040AB
		public FPILPOPAMHBJOIIGKM PCOIJLLONAJIHLDHBI { get; private set; }

		// Token: 0x04000316 RID: 790
		private Vector2 _scrollPosition;
	}
}

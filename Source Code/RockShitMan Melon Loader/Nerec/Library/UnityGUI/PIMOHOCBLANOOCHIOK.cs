using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nerec.Library.UnityGUI
{
	// Token: 0x0200014E RID: 334
	[ODCFJDIDECFCPJJAAL]
	public class PIMOHOCBLANOOCHIOK : MonoBehaviour
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x00018F78 File Offset: 0x00017178
		public PIMOHOCBLANOOCHIOK(IntPtr intPtr) : base(intPtr)
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00006055 File Offset: 0x00004255
		public void SetData(uint tabId, string name, Rect size, Action<int> onDraw)
		{
			this._tabId = tabId;
			this._windowName = name;
			this._windowRect = size;
			this.OnDrawWindow = onDraw;
			PIMOHOCBLANOOCHIOK._allWindows.Add(this.CDMPNKJHOBGAKAJGFI, this);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00006085 File Offset: 0x00004285
		private void Start()
		{
			Object.DontDestroyOnLoad(base.gameObject);
			base.transform.parent = LEENAFEMLNIDFDHFBO.AELNIFOEKEPMDCMHJF;
			this.OnWindowStart();
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000060A8 File Offset: 0x000042A8
		private void OnGUI()
		{
			this._windowRect = GUI.Window(this._windowId, this._windowRect, delegate(int windowId)
			{
				if (GUILayout.Button("Close Window", null))
				{
					this._shouldDrawWindow = false;
				}
				if (this._shouldDrawWindow)
				{
					this._scrollPosition = GUILayout.BeginScrollView(this._scrollPosition, null);
					if (this.OnDrawWindow != null)
					{
						this.OnDrawWindow(windowId);
					}
					GUILayout.EndScrollView();
					GUI.DragWindow(new Rect(0f, 0f, 10000f, 20f));
					return;
				}
				Object.Destroy(base.gameObject);
			}, this._windowName);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000060D8 File Offset: 0x000042D8
		private void OnDestroy()
		{
			PIMOHOCBLANOOCHIOK._allWindows.Remove(this.CDMPNKJHOBGAKAJGFI);
			this.OnWindowDestroy();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00003EE1 File Offset: 0x000020E1
		public virtual void OnWindowStart()
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00003EE1 File Offset: 0x000020E1
		public virtual void OnWindowDestroy()
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000060F1 File Offset: 0x000042F1
		public static PIMOHOCBLANOOCHIOK GetWindow(uint tabId)
		{
			return PIMOHOCBLANOOCHIOK._allWindows[tabId];
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000060FE File Offset: 0x000042FE
		public uint CDMPNKJHOBGAKAJGFI
		{
			get
			{
				return this._tabId;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00006106 File Offset: 0x00004306
		public int EMALMPCGOOCMCLGIAA
		{
			get
			{
				return this._windowId;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0000610E File Offset: 0x0000430E
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00006116 File Offset: 0x00004316
		public Rect GIKELJOOPIBCJKNHKE
		{
			get
			{
				return this._windowRect;
			}
			set
			{
				this._windowRect = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0000611F File Offset: 0x0000431F
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00006127 File Offset: 0x00004327
		public string BECGCCJJOEPDLEBJAA
		{
			get
			{
				return this._windowName;
			}
			set
			{
				this._windowName = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00006130 File Offset: 0x00004330
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00006138 File Offset: 0x00004338
		public bool OFFIOCIKHNOANLAOKL
		{
			get
			{
				return this._shouldDrawWindow;
			}
			set
			{
				this._shouldDrawWindow = value;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060005B1 RID: 1457 RVA: 0x00018FD0 File Offset: 0x000171D0
		// (remove) Token: 0x060005B2 RID: 1458 RVA: 0x00019008 File Offset: 0x00017208
		public event Action<int> OnDrawWindow;

		// Token: 0x0400032D RID: 813
		private static Dictionary<uint, PIMOHOCBLANOOCHIOK> _allWindows = new Dictionary<uint, PIMOHOCBLANOOCHIOK>();

		// Token: 0x0400032E RID: 814
		private Vector2 _scrollPosition;

		// Token: 0x04000330 RID: 816
		private uint _tabId;

		// Token: 0x04000331 RID: 817
		private int _windowId = Random.Range(1, 10000);

		// Token: 0x04000332 RID: 818
		private Rect _windowRect = new Rect(100f, 100f, 300f, 250f);

		// Token: 0x04000333 RID: 819
		private string _windowName = "New Window";

		// Token: 0x04000334 RID: 820
		private bool _shouldDrawWindow = true;
	}
}

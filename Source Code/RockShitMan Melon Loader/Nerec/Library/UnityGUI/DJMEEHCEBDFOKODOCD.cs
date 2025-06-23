using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nerec.Library.UnityGUI.Sanitizers;
using UnityEngine;

namespace Nerec.Library.UnityGUI
{
	// Token: 0x0200014F RID: 335
	[ODCFJDIDECFCPJJAAL]
	public class DJMEEHCEBDFOKODOCD : MonoBehaviour
	{
		// Token: 0x060005B5 RID: 1461 RVA: 0x000190C0 File Offset: 0x000172C0
		public DJMEEHCEBDFOKODOCD(IntPtr intPtr) : base(intPtr)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000614D File Offset: 0x0000434D
		public static DJMEEHCEBDFOKODOCD Create(string name)
		{
			DJMEEHCEBDFOKODOCD djmeehcebdfokodocd = new GameObject(string.Format("[WindowLaunchers - {0}](internal)", name)).AddComponent<DJMEEHCEBDFOKODOCD>();
			djmeehcebdfokodocd.SetName(name);
			return djmeehcebdfokodocd;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000616B File Offset: 0x0000436B
		private void Start()
		{
			Object.DontDestroyOnLoad(base.gameObject);
			base.transform.parent = LEENAFEMLNIDFDHFBO.AELNIFOEKEPMDCMHJF;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00006188 File Offset: 0x00004388
		public void SetName(string name = "New Window Launcher")
		{
			this._windowName = name;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00019110 File Offset: 0x00017310
		public void Add(uint tabId, string name, Rect size, Action<int> drawAction)
		{
			this._tabDescriptors.Add(new NBKBLKAEBNKKNKKHIN
			{
				tabId = tabId,
				title = name,
				size = size,
				drawAction = drawAction
			});
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00019154 File Offset: 0x00017354
		public void Remove(uint tabId)
		{
			this._tabDescriptors.RemoveAll((NBKBLKAEBNKKNKKHIN x) => x.tabId == tabId);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00019188 File Offset: 0x00017388
		private void OnGUI()
		{
			if (this._shouldDrawWindow)
			{
				GUI.color = new Color(53f, 54f, 53f);
				this._windowRect = GUI.Window(1, this._windowRect, delegate(int windowId)
				{
					GUILayout.Label("Press 'L' to deactivate and reactive the window", null);
					foreach (NBKBLKAEBNKKNKKHIN nbkblkaebnkknkkhin in this._tabDescriptors)
					{
						if (GUILayout.Button(nbkblkaebnkknkkhin.title, null))
						{
							if (!this.DoesWindowExistInWorld(nbkblkaebnkknkkhin.tabId) && !this._createSpamProtection)
							{
								PIMOHOCBLANOOCHIOK pimohocblanoochiok = new GameObject(string.Format("[WindowGUI - {0}](internal {1})", nbkblkaebnkknkkhin.title, nbkblkaebnkknkkhin.tabId)).AddComponent<PIMOHOCBLANOOCHIOK>();
								Rect size = GFEFJAFLCAOHNNEIPA.Resolve(this._windowRect, nbkblkaebnkknkkhin.size);
								pimohocblanoochiok.SetData(nbkblkaebnkknkkhin.tabId, nbkblkaebnkknkkhin.title, size, nbkblkaebnkknkkhin.drawAction);
								this._createSpamProtection = true;
							}
						}
						else if (this._createSpamProtection)
						{
							this._createSpamProtection = false;
						}
					}
					GUI.DragWindow(new Rect(0f, 0f, 10000f, 20f));
				}, this._windowName);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00006191 File Offset: 0x00004391
		private void Update()
		{
			if (Input.GetKeyDown(108))
			{
				this._shouldDrawWindow = !this._shouldDrawWindow;
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000191E0 File Offset: 0x000173E0
		private bool DoesWindowExistInWorld(uint tabId)
		{
			using (IEnumerator<PIMOHOCBLANOOCHIOK> enumerator = Object.FindObjectsOfType<PIMOHOCBLANOOCHIOK>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.CDMPNKJHOBGAKAJGFI == tabId)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x000061AB File Offset: 0x000043AB
		public string IGOLFIKEBGIJLNADAN
		{
			get
			{
				return this._windowName;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x000061B3 File Offset: 0x000043B3
		public Rect DJNBBMHAHBEHPMHNKK
		{
			get
			{
				return this._windowRect;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x000061BB File Offset: 0x000043BB
		public List<NBKBLKAEBNKKNKKHIN> EHBIBHKNBANMMDCIPC
		{
			get
			{
				return this._tabDescriptors;
			}
		}

		// Token: 0x04000335 RID: 821
		private bool _shouldDrawWindow = true;

		// Token: 0x04000336 RID: 822
		private bool _createSpamProtection;

		// Token: 0x04000337 RID: 823
		private string _windowName = "New Window Launcher";

		// Token: 0x04000338 RID: 824
		private Rect _windowRect = new Rect(100f, 100f, 300f, 250f);

		// Token: 0x04000339 RID: 825
		private List<NBKBLKAEBNKKNKKHIN> _tabDescriptors = new List<NBKBLKAEBNKKNKKHIN>();

		// Token: 0x02000150 RID: 336
		[CompilerGenerated]
		private sealed class BINLAMBOPGHJBLPEGE
		{
			// Token: 0x060005C3 RID: 1475 RVA: 0x000061C3 File Offset: 0x000043C3
			internal bool <Remove>b__0(NBKBLKAEBNKKNKKHIN x)
			{
				return x.tabId == this.tabId;
			}

			// Token: 0x0400033A RID: 826
			public uint tabId;
		}
	}
}

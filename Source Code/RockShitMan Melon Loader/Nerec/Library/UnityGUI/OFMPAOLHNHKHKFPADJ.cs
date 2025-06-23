using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Nerec.Library.UnityGUI
{
	// Token: 0x0200014C RID: 332
	public class OFMPAOLHNHKHKFPADJ : FPILPOPAMHBJOIIGKM
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x00005FBD File Offset: 0x000041BD
		public OFMPAOLHNHKHKFPADJ(uint tabId)
		{
			this._parentWindow = PIMOHOCBLANOOCHIOK.GetWindow(tabId);
			OFMPAOLHNHKHKFPADJ._windowRects[tabId] = this.EOMFDGFGPJHLCIMDMF.GIKELJOOPIBCJKNHKE;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00005FE7 File Offset: 0x000041E7
		public void SetStrings(List<string> options)
		{
			this._options = options;
			if (this._guiWindow != null)
			{
				this._guiWindow.SetStrings(this, this._options);
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00018E88 File Offset: 0x00017088
		public void Draw()
		{
			if (GUILayout.Button(string.Format("{0}", (base.FOLLPAJPCGIENBNKHM == null) ? "Invalid String Value" : base.FOLLPAJPCGIENBNKHM.ToString()), null) && this._thisGuiWindowObject == null)
			{
				this._thisGuiWindowObject = new GameObject("[WindowGUI (StringDropdown)](internal of " + this._parentWindow.CDMPNKJHOBGAKAJGFI.ToString() + ")");
				HFEGHHKLDIHAEOPAJI hfeghhkldihaeopaji = this._guiWindow = this._thisGuiWindowObject.AddComponent<HFEGHHKLDIHAEOPAJI>();
				hfeghhkldihaeopaji.SetStrings(this, this._options);
				hfeghhkldihaeopaji.SetData(this._parentWindow.CDMPNKJHOBGAKAJGFI + 1U, "StringDropdown", OFMPAOLHNHKHKFPADJ._windowRects[this.EOMFDGFGPJHLCIMDMF.CDMPNKJHOBGAKAJGFI], delegate(int wId)
				{
				});
				hfeghhkldihaeopaji.OFFIOCIKHNOANLAOKL = true;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00006010 File Offset: 0x00004210
		public string MPFFHOJOKEHBAMPOJB
		{
			get
			{
				return (string)base.FOLLPAJPCGIENBNKHM;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0000601D File Offset: 0x0000421D
		public override PIMOHOCBLANOOCHIOK NPNHFHJFJMDKAFDNHB
		{
			get
			{
				return this._parentWindow;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00006025 File Offset: 0x00004225
		public HFEGHHKLDIHAEOPAJI BIGJHLANLLBKLFINII
		{
			get
			{
				return this._guiWindow;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0000602D File Offset: 0x0000422D
		public GameObject FCBOHPIKGLCPCOKDLA
		{
			get
			{
				return this._thisGuiWindowObject;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00006035 File Offset: 0x00004235
		public List<string> CMBMAMMAMCBKHPBKCD
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x04000326 RID: 806
		private PIMOHOCBLANOOCHIOK _parentWindow;

		// Token: 0x04000327 RID: 807
		private HFEGHHKLDIHAEOPAJI _guiWindow;

		// Token: 0x04000328 RID: 808
		private GameObject _thisGuiWindowObject;

		// Token: 0x04000329 RID: 809
		private List<string> _options;

		// Token: 0x0400032A RID: 810
		private static Dictionary<uint, Rect> _windowRects = new Dictionary<uint, Rect>();

		// Token: 0x0200014D RID: 333
		[CompilerGenerated]
		[Serializable]
		private sealed class POBJMKLOJFGGCAIOGA
		{
			// Token: 0x060005A0 RID: 1440 RVA: 0x00003EE1 File Offset: 0x000020E1
			internal void <Draw>b__2_0(int wId)
			{
			}

			// Token: 0x0400032B RID: 811
			public static readonly OFMPAOLHNHKHKFPADJ.POBJMKLOJFGGCAIOGA <>9 = new OFMPAOLHNHKHKFPADJ.POBJMKLOJFGGCAIOGA();

			// Token: 0x0400032C RID: 812
			public static Action<int> <>9__2_0;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Nerec.Library.UnityGUI
{
	// Token: 0x02000148 RID: 328
	public class PEIKILBNEBPOGFOEJJ<T> : FPILPOPAMHBJOIIGKM where T : struct, IConvertible
	{
		// Token: 0x06000580 RID: 1408 RVA: 0x00005EC5 File Offset: 0x000040C5
		public PEIKILBNEBPOGFOEJJ(uint tabId)
		{
			this._parentWindow = PIMOHOCBLANOOCHIOK.GetWindow(tabId);
			PEIKILBNEBPOGFOEJJ<T>._windowRects[tabId] = this.EOMFDGFGPJHLCIMDMF.GIKELJOOPIBCJKNHKE;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00018C98 File Offset: 0x00016E98
		public void Draw()
		{
			if (base.FOLLPAJPCGIENBNKHM == null)
			{
				base.FOLLPAJPCGIENBNKHM = Enum.GetValues(typeof(T)).GetValue(0);
			}
			if (GUILayout.Button(string.Format("{0}", (base.FOLLPAJPCGIENBNKHM == null) ? "Invalid Enum Value" : base.FOLLPAJPCGIENBNKHM.ToString()), null) && this._thisGuiWindowObject == null)
			{
				this._thisGuiWindowObject = new GameObject(string.Concat(new string[]
				{
					"[WindowGUI (EnumDropdown<",
					typeof(T).Name,
					">)](internal of ",
					this._parentWindow.CDMPNKJHOBGAKAJGFI.ToString(),
					")"
				}));
				NHGPLONONLOMAICKNA nhgplononlomaickna = this._guiWindow = this._thisGuiWindowObject.AddComponent<NHGPLONONLOMAICKNA>();
				nhgplononlomaickna.SetEnumType(this, typeof(T));
				nhgplononlomaickna.SetData(this._parentWindow.CDMPNKJHOBGAKAJGFI + 1U, "EnumDropdown<" + typeof(T).Name + ">", PEIKILBNEBPOGFOEJJ<T>._windowRects[this.EOMFDGFGPJHLCIMDMF.CDMPNKJHOBGAKAJGFI], delegate(int wId)
				{
				});
				nhgplononlomaickna.OFFIOCIKHNOANLAOKL = true;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00005EEF File Offset: 0x000040EF
		public T FJNKIPMKDFIPPHPNJN
		{
			get
			{
				return (T)((object)base.FOLLPAJPCGIENBNKHM);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00005EFC File Offset: 0x000040FC
		public override PIMOHOCBLANOOCHIOK MIPJHPMDLPEHDBDFMO
		{
			get
			{
				return this._parentWindow;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00005F04 File Offset: 0x00004104
		public NHGPLONONLOMAICKNA FCEDGHPOKOADJCGKCN
		{
			get
			{
				return this._guiWindow;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00005F0C File Offset: 0x0000410C
		public GameObject CDPLFFBNLMHEBGKAIH
		{
			get
			{
				return this._thisGuiWindowObject;
			}
		}

		// Token: 0x0400031B RID: 795
		private PIMOHOCBLANOOCHIOK _parentWindow;

		// Token: 0x0400031C RID: 796
		private NHGPLONONLOMAICKNA _guiWindow;

		// Token: 0x0400031D RID: 797
		private GameObject _thisGuiWindowObject;

		// Token: 0x0400031E RID: 798
		private static Dictionary<uint, Rect> _windowRects = new Dictionary<uint, Rect>();

		// Token: 0x02000149 RID: 329
		[CompilerGenerated]
		[Serializable]
		private sealed class JAMGJJEMIFPMPGCPLC
		{
			// Token: 0x06000589 RID: 1417 RVA: 0x00003EE1 File Offset: 0x000020E1
			internal void <Draw>b__1_0(int wId)
			{
			}

			// Token: 0x0400031F RID: 799
			public static readonly PEIKILBNEBPOGFOEJJ<T>.JAMGJJEMIFPMPGCPLC <>9 = new PEIKILBNEBPOGFOEJJ<T>.JAMGJJEMIFPMPGCPLC();

			// Token: 0x04000320 RID: 800
			public static Action<int> <>9__1_0;
		}
	}
}

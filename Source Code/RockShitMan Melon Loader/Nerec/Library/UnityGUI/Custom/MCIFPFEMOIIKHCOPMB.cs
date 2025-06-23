using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace Nerec.Library.UnityGUI.Custom
{
	// Token: 0x02000155 RID: 341
	public static class MCIFPFEMOIIKHCOPMB
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x000061FF File Offset: 0x000043FF
		private static void Initialize(uint tabId)
		{
			MCIFPFEMOIIKHCOPMB._tokenGenerationDropdown = new PEIKILBNEBPOGFOEJJ<MKMPCEKEFLK>(tabId);
			IPDMLDCHOFKILLMKLE.Run(LLHALDELIJLHMBBGID.Update, new Action(MCIFPFEMOIIKHCOPMB.Update));
			MCIFPFEMOIIKHCOPMB._initialized = true;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000194A4 File Offset: 0x000176A4
		public static void Draw(int windowId)
		{
			if (!MCIFPFEMOIIKHCOPMB._initialized)
			{
				MCIFPFEMOIIKHCOPMB.Initialize(KDMLJLIJNANBIKHKCO.EconomyMenuTabId);
				return;
			}
			GUI.skin.label.richText = true;
			GUILayout.Label("<b>Token Generation</b>", null);
			MCIFPFEMOIIKHCOPMB._tokenGenerationDropdown.Draw();
			MCIFPFEMOIIKHCOPMB._isTokenGenerationEnabled = GUILayout.Toggle(MCIFPFEMOIIKHCOPMB._isTokenGenerationEnabled, "Generate tokens", null);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00006224 File Offset: 0x00004424
		private static void Update()
		{
			MCIFPFEMOIIKHCOPMB.UpdateTokenGeneration();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00019500 File Offset: 0x00017700
		private static void UpdateTokenGeneration()
		{
			if (MCIFPFEMOIIKHCOPMB._isTokenGenerationEnabled)
			{
				OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP> item2 = IMJOKBMHMJL.PLKIOHGHHBJ(MCIFPFEMOIIKHCOPMB._tokenGenerationDropdown.FJNKIPMKDFIPPHPNJN, "A gift for you! <3").DCHBBJGACAN(delegate(IMJOKBMHMJL.CGGJJIKBPOP item)
				{
					IMJOKBMHMJL.KPKLNLDPKBD(item);
				});
				MCIFPFEMOIIKHCOPMB._allActivePromises.Add(item2);
				return;
			}
			List<OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP>> allCancelledPromises = new List<OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP>>();
			if (MCIFPFEMOIIKHCOPMB._allActivePromises.Count > 1)
			{
				using (List<OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP>>.Enumerator enumerator = MCIFPFEMOIIKHCOPMB._allActivePromises.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP> promise = enumerator.Current;
						MPMEFAHKLDG.DNANDBDJNNA<IMJOKBMHMJL.CGGJJIKBPOP>(promise, MCIFPFEMOIIKHCOPMB._cancellationTokenSource.Token, 0).ContinueWith(delegate(Task A_0)
						{
							allCancelledPromises.Add(promise);
						});
					}
				}
			}
			if (allCancelledPromises.Count > 0)
			{
				MCIFPFEMOIIKHCOPMB._allActivePromises.RemoveAll((OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP> x) => allCancelledPromises.Contains(x));
			}
		}

		// Token: 0x04000344 RID: 836
		private static List<OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP>> _allActivePromises = new List<OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP>>();

		// Token: 0x04000345 RID: 837
		private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		// Token: 0x04000346 RID: 838
		private static bool _initialized;

		// Token: 0x04000347 RID: 839
		private static bool _isTokenGenerationEnabled;

		// Token: 0x04000348 RID: 840
		private static PEIKILBNEBPOGFOEJJ<MKMPCEKEFLK> _tokenGenerationDropdown;

		// Token: 0x02000156 RID: 342
		[CompilerGenerated]
		[Serializable]
		private sealed class CNCKJDOFFCINJLKLPO
		{
			// Token: 0x060005D2 RID: 1490 RVA: 0x0000624D File Offset: 0x0000444D
			internal void <UpdateTokenGeneration>b__3_0(IMJOKBMHMJL.CGGJJIKBPOP item)
			{
				IMJOKBMHMJL.KPKLNLDPKBD(item);
			}

			// Token: 0x04000349 RID: 841
			public static readonly MCIFPFEMOIIKHCOPMB.CNCKJDOFFCINJLKLPO <>9 = new MCIFPFEMOIIKHCOPMB.CNCKJDOFFCINJLKLPO();

			// Token: 0x0400034A RID: 842
			public static Action<IMJOKBMHMJL.CGGJJIKBPOP> <>9__3_0;
		}

		// Token: 0x02000157 RID: 343
		[CompilerGenerated]
		private sealed class AIGNJMBKKFEECEJMLI
		{
			// Token: 0x060005D4 RID: 1492 RVA: 0x00006256 File Offset: 0x00004456
			internal bool <UpdateTokenGeneration>b__1(OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP> x)
			{
				return this.allCancelledPromises.Contains(x);
			}

			// Token: 0x0400034B RID: 843
			public List<OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP>> allCancelledPromises;
		}

		// Token: 0x02000158 RID: 344
		[CompilerGenerated]
		private sealed class LNCMOKHCGIELLDNNOK
		{
			// Token: 0x060005D6 RID: 1494 RVA: 0x00006264 File Offset: 0x00004464
			internal void <UpdateTokenGeneration>b__2(Task A_0)
			{
				this.CS$<>8__locals1.allCancelledPromises.Add(this.promise);
			}

			// Token: 0x0400034C RID: 844
			public OOLBMJPBBIG<IMJOKBMHMJL.CGGJJIKBPOP> promise;

			// Token: 0x0400034D RID: 845
			public MCIFPFEMOIIKHCOPMB.AIGNJMBKKFEECEJMLI CS$<>8__locals1;
		}
	}
}

using System;
using UnityEngine;

namespace Nerec.Library.UnityGUI
{
	// Token: 0x0200014A RID: 330
	public static class LEENAFEMLNIDFDHFBO
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00005F2C File Offset: 0x0000412C
		public static Transform AELNIFOEKEPMDCMHJF
		{
			get
			{
				if (LEENAFEMLNIDFDHFBO._root == null)
				{
					GameObject gameObject = new GameObject("[Nerec UI Root](internal)");
					Object.DontDestroyOnLoad(gameObject);
					LEENAFEMLNIDFDHFBO._root = gameObject.transform;
				}
				return LEENAFEMLNIDFDHFBO._root;
			}
		}

		// Token: 0x04000321 RID: 801
		private static Transform _root;
	}
}

using System;
using UnityEngine;

namespace Nerec.Library.UnityGUI.Sanitizers
{
	// Token: 0x02000152 RID: 338
	public static class GFEFJAFLCAOHNNEIPA
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x0001933C File Offset: 0x0001753C
		public static Rect Resolve(Rect parentWindowRect, Rect thisWindowRect)
		{
			Rect result = thisWindowRect;
			float x = result.x;
			result.x = parentWindowRect.x + parentWindowRect.width + 25f;
			result.y = parentWindowRect.y;
			if (result.x >= (float)Screen.width || result.x + result.width >= (float)Screen.width)
			{
				result.x = x;
				result.x = parentWindowRect.x - parentWindowRect.width - 25f;
			}
			return result;
		}
	}
}

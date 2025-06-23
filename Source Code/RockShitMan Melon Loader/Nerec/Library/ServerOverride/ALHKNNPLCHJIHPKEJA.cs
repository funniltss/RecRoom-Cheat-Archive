using System;
using System.Text;
using Il2Cpp;
using Utf8Json;

namespace Nerec.Library.ServerOverride
{
	// Token: 0x02000162 RID: 354
	public struct ALHKNNPLCHJIHPKEJA
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00006348 File Offset: 0x00004548
		public byte[] MNHNMFLDJEAOHDFHIJ
		{
			get
			{
				if (this.objectData == null)
				{
					return Encoding.UTF8.GetBytes(this.data);
				}
				return CLAPLAKGMOAABEOHEI.Serialize<object>(this.objectData);
			}
		}

		// Token: 0x04000377 RID: 887
		public CLKLKFHFEFG service;

		// Token: 0x04000378 RID: 888
		public string url;

		// Token: 0x04000379 RID: 889
		public int statusCode;

		// Token: 0x0400037A RID: 890
		public string errorMessage;

		// Token: 0x0400037B RID: 891
		public string data;

		// Token: 0x0400037C RID: 892
		public object objectData;
	}
}

using System;
using Utf8Json.Internal;

namespace Utf8Json
{
	// Token: 0x02000012 RID: 18
	public class AAOCAAJHAGCFOOIPCG : Exception
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000271F File Offset: 0x0000091F
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002727 File Offset: 0x00000927
		public int JBNPJBLPLNDPLCCMAI { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002738 File Offset: 0x00000938
		public string GJJHDIFFPLIJEFCDBI { get; set; }

		// Token: 0x06000058 RID: 88 RVA: 0x000023F0 File Offset: 0x000005F0
		public AAOCAAJHAGCFOOIPCG(string message) : base(message)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002741 File Offset: 0x00000941
		public AAOCAAJHAGCFOOIPCG(string message, byte[] underlyingBytes, int offset, int limit, string actualChar) : base(message)
		{
			this.underyingBytes = new WeakReference(underlyingBytes);
			this.JBNPJBLPLNDPLCCMAI = offset;
			this.GJJHDIFFPLIJEFCDBI = actualChar;
			this.limit = limit;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000276D File Offset: 0x0000096D
		public byte[] GetUnderlyingByteArrayUnsafe()
		{
			return this.underyingBytes.Target as byte[];
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007B98 File Offset: 0x00005D98
		public string GetUnderlyingStringUnsafe()
		{
			byte[] array = this.underyingBytes.Target as byte[];
			if (array != null)
			{
				return CHFCLNEOCDIHMILKOP.UTF8.GetString(array, 0, this.limit) + "...";
			}
			return null;
		}

		// Token: 0x0400000B RID: 11
		private WeakReference underyingBytes;

		// Token: 0x0400000C RID: 12
		private int limit;
	}
}

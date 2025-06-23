using System;

namespace Utf8Json
{
	// Token: 0x02000002 RID: 2
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public class BHBMDGIJKJJJKFJCIF : Attribute
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002378 File Offset: 0x00000578
		public Type APIMLHBDDPMHACKCOL { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002381 File Offset: 0x00000581
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002389 File Offset: 0x00000589
		public object[] BMPCIPDFFCMMAJMCLM { get; private set; }

		// Token: 0x06000005 RID: 5 RVA: 0x00002392 File Offset: 0x00000592
		public BHBMDGIJKJJJKFJCIF(Type formatterType)
		{
			this.APIMLHBDDPMHACKCOL = formatterType;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023A1 File Offset: 0x000005A1
		public BHBMDGIJKJJJKFJCIF(Type formatterType, params object[] arguments)
		{
			this.APIMLHBDDPMHACKCOL = formatterType;
			this.BMPCIPDFFCMMAJMCLM = arguments;
		}
	}
}

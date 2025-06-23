using System;
using System.Runtime.InteropServices;

namespace Nerec.Library.Includes
{
	// Token: 0x02000180 RID: 384
	[GLOMGGIOCDALLIEGAB]
	public interface FFACMGPJKHNBKLCJEK : IOPBKGMNPFHIEIFCEA
	{
		// Token: 0x06000674 RID: 1652
		bool get_IsCompleted();

		// Token: 0x06000675 RID: 1653
		bool get_HasSucceeded();

		// Token: 0x06000676 RID: 1654
		bool get_HasError();

		// Token: 0x06000677 RID: 1655
		FFACMGPJKHNBKLCJEK Then(Action thenFunc);

		// Token: 0x06000678 RID: 1656
		FFACMGPJKHNBKLCJEK Error(Action<string> errorFunc);

		// Token: 0x06000679 RID: 1657
		FFACMGPJKHNBKLCJEK Finally(Action finallyFunc);

		// Token: 0x0600067A RID: 1658
		PAPGFFIAEPDMAOFCHH<TNew> ContinueWith<TNew>(Func<PAPGFFIAEPDMAOFCHH<TNew>> transformFunc, [Optional] Func<string, PAPGFFIAEPDMAOFCHH<TNew>> transformErrorFunc);

		// Token: 0x0600067B RID: 1659
		FFACMGPJKHNBKLCJEK ContinueWith(Func<FFACMGPJKHNBKLCJEK> transformFunc, [Optional] Func<string, FFACMGPJKHNBKLCJEK> transformErrorFunc);

		// Token: 0x0600067C RID: 1660
		PAPGFFIAEPDMAOFCHH<TNew> Transform<TNew>(Func<TNew> transformFunc);

		// Token: 0x0600067D RID: 1661
		FFACMGPJKHNBKLCJEK TransformError(Func<string, string> transformFunc);
	}
}

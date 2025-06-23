using System;
using System.Runtime.InteropServices;

namespace Nerec.Library.Includes
{
	// Token: 0x02000181 RID: 385
	[GLOMGGIOCDALLIEGAB]
	public interface PAPGFFIAEPDMAOFCHH<T> : FFACMGPJKHNBKLCJEK, IOPBKGMNPFHIEIFCEA
	{
		// Token: 0x0600067E RID: 1662
		PAPGFFIAEPDMAOFCHH<T> Then(Action<T> thenFunc);

		// Token: 0x0600067F RID: 1663
		PAPGFFIAEPDMAOFCHH<T> Then(Action thenFunc);

		// Token: 0x06000680 RID: 1664
		PAPGFFIAEPDMAOFCHH<T> Error(Action<string> errorFunc);

		// Token: 0x06000681 RID: 1665
		PAPGFFIAEPDMAOFCHH<T> Finally(Action finallyFunc);

		// Token: 0x06000682 RID: 1666
		PAPGFFIAEPDMAOFCHH<TNew> ContinueWith<TNew>(Func<T, PAPGFFIAEPDMAOFCHH<TNew>> transformFunc, [Optional] Func<string, PAPGFFIAEPDMAOFCHH<TNew>> transformErrorFunc);

		// Token: 0x06000683 RID: 1667
		FFACMGPJKHNBKLCJEK ContinueWith(Func<T, FFACMGPJKHNBKLCJEK> transformFunc, [Optional] Func<string, FFACMGPJKHNBKLCJEK> transformErrorFunc);

		// Token: 0x06000684 RID: 1668
		PAPGFFIAEPDMAOFCHH<TNew> Transform<TNew>(Func<T, TNew> transformFunc);

		// Token: 0x06000685 RID: 1669
		PAPGFFIAEPDMAOFCHH<T> TransformError(Func<string, string> transformFunc);
	}
}

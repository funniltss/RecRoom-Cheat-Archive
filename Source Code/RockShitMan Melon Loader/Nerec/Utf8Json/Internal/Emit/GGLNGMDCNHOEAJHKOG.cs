using System;
using System.Reflection.Emit;

namespace Utf8Json.Internal.Emit
{
	// Token: 0x020000B1 RID: 177
	internal struct GGLNGMDCNHOEAJHKOG
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x000042FB File Offset: 0x000024FB
		public GGLNGMDCNHOEAJHKOG(ILGenerator il, int i, bool @ref = false)
		{
			this.il = il;
			this.i = i;
			this.@ref = @ref;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00004312 File Offset: 0x00002512
		public GGLNGMDCNHOEAJHKOG(ILGenerator il, int i, Type type)
		{
			this.il = il;
			this.i = i;
			this.@ref = (!type.IsClass && !type.IsInterface && !type.IsAbstract);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00004344 File Offset: 0x00002544
		public void EmitLoad()
		{
			if (this.@ref)
			{
				this.il.EmitLdarga(this.i);
				return;
			}
			this.il.EmitLdarg(this.i);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00004371 File Offset: 0x00002571
		public void EmitStore()
		{
			this.il.EmitStarg(this.i);
		}

		// Token: 0x040001A5 RID: 421
		private readonly int i;

		// Token: 0x040001A6 RID: 422
		private readonly bool @ref;

		// Token: 0x040001A7 RID: 423
		private readonly ILGenerator il;
	}
}

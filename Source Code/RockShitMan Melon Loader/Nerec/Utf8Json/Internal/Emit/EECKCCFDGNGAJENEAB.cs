using System;
using System.Reflection.Emit;

namespace Utf8Json.Internal.Emit
{
	// Token: 0x020000B6 RID: 182
	internal class EECKCCFDGNGAJENEAB : GMPKOFIBGBNJPLELDP
	{
		// Token: 0x060002DD RID: 733 RVA: 0x00004671 File Offset: 0x00002871
		public EECKCCFDGNGAJENEAB(string name, string constant) : base(typeof(string), name, name, false, true)
		{
			this.constant = constant;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000468E File Offset: 0x0000288E
		public override void EmitLoadValue(ILGenerator il)
		{
			il.Emit(OpCodes.Pop);
			il.Emit(OpCodes.Ldstr, this.constant);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00003EEB File Offset: 0x000020EB
		public override void EmitStoreValue(ILGenerator il)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040001B5 RID: 437
		private readonly string constant;
	}
}

using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Utf8Json.Internal.Emit
{
	// Token: 0x020000B7 RID: 183
	internal class BGIPGFFBOJDBGFMMAD : GMPKOFIBGBNJPLELDP
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x000046AC File Offset: 0x000028AC
		public BGIPGFFBOJDBGFMMAD(string name) : base(typeof(Exception), name, name, false, true)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000046C2 File Offset: 0x000028C2
		public override void EmitLoadValue(ILGenerator il)
		{
			il.Emit(OpCodes.Callvirt, BGIPGFFBOJDBGFMMAD.getInnerException);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003EEB File Offset: 0x000020EB
		public override void EmitStoreValue(ILGenerator il)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000046D4 File Offset: 0x000028D4
		public void EmitSerializeDirectly(ILGenerator il)
		{
			this.argWriter.EmitLoad();
			this.argValue.EmitLoad();
			il.Emit(OpCodes.Callvirt, BGIPGFFBOJDBGFMMAD.getInnerException);
			this.argResolver.EmitLoad();
			il.EmitCall(BGIPGFFBOJDBGFMMAD.nongenericSerialize);
		}

		// Token: 0x040001B6 RID: 438
		private static readonly MethodInfo getInnerException = HAGIHFGIGMOBLEDDGC.GetPropertyInfo<Exception, Exception>((Exception ex) => ex.InnerException).GetGetMethod();

		// Token: 0x040001B7 RID: 439
		private static readonly MethodInfo nongenericSerialize = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BJLLMLPIIIPIEPLCJH>((BJLLMLPIIIPIEPLCJH writer) => CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(writer, null, null));

		// Token: 0x040001B8 RID: 440
		internal GGLNGMDCNHOEAJHKOG argWriter;

		// Token: 0x040001B9 RID: 441
		internal GGLNGMDCNHOEAJHKOG argValue;

		// Token: 0x040001BA RID: 442
		internal GGLNGMDCNHOEAJHKOG argResolver;

		// Token: 0x020000B8 RID: 184
		[CompilerGenerated]
		[Serializable]
		private sealed class HGCAFDBIGPEALMDPBG
		{
			// Token: 0x040001BB RID: 443
			public static readonly BGIPGFFBOJDBGFMMAD.HGCAFDBIGPEALMDPBG <>9 = new BGIPGFFBOJDBGFMMAD.HGCAFDBIGPEALMDPBG();
		}
	}
}

using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Utf8Json.Internal.Emit
{
	// Token: 0x020000B2 RID: 178
	internal static class FDPLNNAFBFLOPLGOKL
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x00010910 File Offset: 0x0000EB10
		public static void EmitLdloc(this ILGenerator il, int index)
		{
			switch (index)
			{
			case 0:
				il.Emit(OpCodes.Ldloc_0);
				return;
			case 1:
				il.Emit(OpCodes.Ldloc_1);
				return;
			case 2:
				il.Emit(OpCodes.Ldloc_2);
				return;
			case 3:
				il.Emit(OpCodes.Ldloc_3);
				return;
			default:
				if (index <= 255)
				{
					il.Emit(OpCodes.Ldloc_S, (byte)index);
					return;
				}
				il.Emit(OpCodes.Ldloc, (short)index);
				return;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00004384 File Offset: 0x00002584
		public static void EmitLdloc(this ILGenerator il, LocalBuilder local)
		{
			il.EmitLdloc(local.LocalIndex);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00010988 File Offset: 0x0000EB88
		public static void EmitStloc(this ILGenerator il, int index)
		{
			switch (index)
			{
			case 0:
				il.Emit(OpCodes.Stloc_0);
				return;
			case 1:
				il.Emit(OpCodes.Stloc_1);
				return;
			case 2:
				il.Emit(OpCodes.Stloc_2);
				return;
			case 3:
				il.Emit(OpCodes.Stloc_3);
				return;
			default:
				if (index <= 255)
				{
					il.Emit(OpCodes.Stloc_S, (byte)index);
					return;
				}
				il.Emit(OpCodes.Stloc, (short)index);
				return;
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00004392 File Offset: 0x00002592
		public static void EmitStloc(this ILGenerator il, LocalBuilder local)
		{
			il.EmitStloc(local.LocalIndex);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000043A0 File Offset: 0x000025A0
		public static void EmitLdloca(this ILGenerator il, int index)
		{
			if (index <= 255)
			{
				il.Emit(OpCodes.Ldloca_S, (byte)index);
				return;
			}
			il.Emit(OpCodes.Ldloca, (short)index);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000043C5 File Offset: 0x000025C5
		public static void EmitLdloca(this ILGenerator il, LocalBuilder local)
		{
			il.EmitLdloca(local.LocalIndex);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000043D3 File Offset: 0x000025D3
		public static void EmitTrue(this ILGenerator il)
		{
			il.EmitBoolean(true);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000043DC File Offset: 0x000025DC
		public static void EmitFalse(this ILGenerator il)
		{
			il.EmitBoolean(false);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000043E5 File Offset: 0x000025E5
		public static void EmitBoolean(this ILGenerator il, bool value)
		{
			il.EmitLdc_I4(value ? 1 : 0);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00010A00 File Offset: 0x0000EC00
		public static void EmitLdc_I4(this ILGenerator il, int value)
		{
			switch (value)
			{
			case -1:
				il.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				il.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				il.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				il.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				il.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				il.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				il.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				il.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				il.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				il.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (value >= -128 && value <= 127)
				{
					il.Emit(OpCodes.Ldc_I4_S, (sbyte)value);
					return;
				}
				il.Emit(OpCodes.Ldc_I4, value);
				return;
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000043F4 File Offset: 0x000025F4
		public static void EmitUnboxOrCast(this ILGenerator il, Type type)
		{
			if (type.IsValueType)
			{
				il.Emit(OpCodes.Unbox_Any, type);
				return;
			}
			il.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00004417 File Offset: 0x00002617
		public static void EmitBoxOrDoNothing(this ILGenerator il, Type type)
		{
			if (type.IsValueType)
			{
				il.Emit(OpCodes.Box, type);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00010ADC File Offset: 0x0000ECDC
		public static void EmitLdarg(this ILGenerator il, int index)
		{
			switch (index)
			{
			case 0:
				il.Emit(OpCodes.Ldarg_0);
				return;
			case 1:
				il.Emit(OpCodes.Ldarg_1);
				return;
			case 2:
				il.Emit(OpCodes.Ldarg_2);
				return;
			case 3:
				il.Emit(OpCodes.Ldarg_3);
				return;
			default:
				if (index <= 255)
				{
					il.Emit(OpCodes.Ldarg_S, (byte)index);
					return;
				}
				il.Emit(OpCodes.Ldarg, index);
				return;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000442D File Offset: 0x0000262D
		public static void EmitLoadThis(this ILGenerator il)
		{
			il.EmitLdarg(0);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00004436 File Offset: 0x00002636
		public static void EmitLdarga(this ILGenerator il, int index)
		{
			if (index <= 255)
			{
				il.Emit(OpCodes.Ldarga_S, (byte)index);
				return;
			}
			il.Emit(OpCodes.Ldarga, index);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000445A File Offset: 0x0000265A
		public static void EmitStarg(this ILGenerator il, int index)
		{
			if (index <= 255)
			{
				il.Emit(OpCodes.Starg_S, (byte)index);
				return;
			}
			il.Emit(OpCodes.Starg, index);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00010B54 File Offset: 0x0000ED54
		public static void EmitPop(this ILGenerator il, int count)
		{
			for (int i = 0; i < count; i++)
			{
				il.Emit(OpCodes.Pop);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000447E File Offset: 0x0000267E
		public static void EmitCall(this ILGenerator il, MethodInfo methodInfo)
		{
			if (methodInfo.IsFinal || !methodInfo.IsVirtual)
			{
				il.Emit(OpCodes.Call, methodInfo);
				return;
			}
			il.Emit(OpCodes.Callvirt, methodInfo);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000044A9 File Offset: 0x000026A9
		public static void EmitLdfld(this ILGenerator il, FieldInfo fieldInfo)
		{
			il.Emit(OpCodes.Ldfld, fieldInfo);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000044B7 File Offset: 0x000026B7
		public static void EmitLdsfld(this ILGenerator il, FieldInfo fieldInfo)
		{
			il.Emit(OpCodes.Ldsfld, fieldInfo);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000044C5 File Offset: 0x000026C5
		public static void EmitRet(this ILGenerator il)
		{
			il.Emit(OpCodes.Ret);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000044D2 File Offset: 0x000026D2
		public static void EmitIntZeroReturn(this ILGenerator il)
		{
			il.EmitLdc_I4(0);
			il.Emit(OpCodes.Ret);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000044E6 File Offset: 0x000026E6
		public static void EmitNullReturn(this ILGenerator il)
		{
			il.Emit(OpCodes.Ldnull);
			il.Emit(OpCodes.Ret);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000044FE File Offset: 0x000026FE
		public static void EmitULong(this ILGenerator il, ulong value)
		{
			il.Emit(OpCodes.Ldc_I8, (long)value);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00010B78 File Offset: 0x0000ED78
		public static void EmitThrowNotimplemented(this ILGenerator il)
		{
			il.Emit(OpCodes.Newobj, typeof(NotImplementedException).GetTypeInfo().DeclaredConstructors.First((ConstructorInfo x) => x.GetParameters().Length == 0));
			il.Emit(OpCodes.Throw);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		public static void EmitIncrementFor(this ILGenerator il, LocalBuilder conditionGreater, Action<LocalBuilder> emitBody)
		{
			Label label = il.DefineLabel();
			Label label2 = il.DefineLabel();
			LocalBuilder localBuilder = il.DeclareLocal(typeof(int));
			il.EmitLdc_I4(0);
			il.EmitStloc(localBuilder);
			il.Emit(OpCodes.Br, label2);
			il.MarkLabel(label);
			emitBody(localBuilder);
			il.EmitLdloc(localBuilder);
			il.EmitLdc_I4(1);
			il.Emit(OpCodes.Add);
			il.EmitStloc(localBuilder);
			il.MarkLabel(label2);
			il.EmitLdloc(localBuilder);
			il.EmitLdloc(conditionGreater);
			il.Emit(OpCodes.Blt, label);
		}

		// Token: 0x020000B3 RID: 179
		[CompilerGenerated]
		[Serializable]
		private sealed class AIHLMIMAOLNCBBLHAM
		{
			// Token: 0x060002C1 RID: 705 RVA: 0x00002F37 File Offset: 0x00001137
			internal bool <EmitThrowNotimplemented>b__24_0(ConstructorInfo x)
			{
				return x.GetParameters().Length == 0;
			}

			// Token: 0x040001A8 RID: 424
			public static readonly FDPLNNAFBFLOPLGOKL.AIHLMIMAOLNCBBLHAM <>9 = new FDPLNNAFBFLOPLGOKL.AIHLMIMAOLNCBBLHAM();

			// Token: 0x040001A9 RID: 425
			public static Func<ConstructorInfo, bool> <>9__24_0;
		}
	}
}

using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Utf8Json.Internal.Emit
{
	// Token: 0x020000B4 RID: 180
	internal class GMPKOFIBGBNJPLELDP
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00004518 File Offset: 0x00002718
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00004520 File Offset: 0x00002720
		public string LNKALLJDEAKLDIPONI { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00004529 File Offset: 0x00002729
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00004531 File Offset: 0x00002731
		public string CFFGNPGGDKDKBBKIMG { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000453A File Offset: 0x0000273A
		public bool MFNJGOAAOFABIGHKDL
		{
			get
			{
				return this.HBHBEIOJOHELICCHFJ != null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00004548 File Offset: 0x00002748
		public bool KPDBNLGHBOLNNBPHDD
		{
			get
			{
				return this.HBJDLMAJOCKDANKPMA != null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00004556 File Offset: 0x00002756
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000455E File Offset: 0x0000275E
		public bool NCJDJAJEIKHAIBPJBG { get; private set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00004567 File Offset: 0x00002767
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0000456F File Offset: 0x0000276F
		public bool EAKBJPKGFOKCEHFJJD { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00004578 File Offset: 0x00002778
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00004580 File Offset: 0x00002780
		public Type ADADCDGIIONHFKEJOC { get; private set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00004589 File Offset: 0x00002789
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00004591 File Offset: 0x00002791
		public FieldInfo HBJDLMAJOCKDANKPMA { get; private set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000459A File Offset: 0x0000279A
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000045A2 File Offset: 0x000027A2
		public PropertyInfo HBHBEIOJOHELICCHFJ { get; private set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000045AB File Offset: 0x000027AB
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000045B3 File Offset: 0x000027B3
		public MethodInfo NJEMFCEBFFHHOGPKMH { get; private set; }

		// Token: 0x060002D4 RID: 724 RVA: 0x000045BC File Offset: 0x000027BC
		protected GMPKOFIBGBNJPLELDP(Type type, string name, string memberName, bool isWritable, bool isReadable)
		{
			this.LNKALLJDEAKLDIPONI = name;
			this.CFFGNPGGDKDKBBKIMG = memberName;
			this.ADADCDGIIONHFKEJOC = type;
			this.NCJDJAJEIKHAIBPJBG = isWritable;
			this.EAKBJPKGFOKCEHFJJD = isReadable;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00010C6C File Offset: 0x0000EE6C
		public GMPKOFIBGBNJPLELDP(FieldInfo info, string name, bool allowPrivate)
		{
			this.LNKALLJDEAKLDIPONI = name;
			this.CFFGNPGGDKDKBBKIMG = info.Name;
			this.HBJDLMAJOCKDANKPMA = info;
			this.ADADCDGIIONHFKEJOC = info.FieldType;
			this.EAKBJPKGFOKCEHFJJD = (allowPrivate || info.IsPublic);
			this.NCJDJAJEIKHAIBPJBG = (allowPrivate || (info.IsPublic && !info.IsInitOnly));
			this.NJEMFCEBFFHHOGPKMH = GMPKOFIBGBNJPLELDP.GetShouldSerialize(info);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00010CE4 File Offset: 0x0000EEE4
		public GMPKOFIBGBNJPLELDP(PropertyInfo info, string name, bool allowPrivate)
		{
			this.getMethod = info.GetGetMethod(true);
			this.setMethod = info.GetSetMethod(true);
			this.LNKALLJDEAKLDIPONI = name;
			this.CFFGNPGGDKDKBBKIMG = info.Name;
			this.HBHBEIOJOHELICCHFJ = info;
			this.ADADCDGIIONHFKEJOC = info.PropertyType;
			this.EAKBJPKGFOKCEHFJJD = (this.getMethod != null && (allowPrivate || this.getMethod.IsPublic) && !this.getMethod.IsStatic);
			this.NCJDJAJEIKHAIBPJBG = (this.setMethod != null && (allowPrivate || this.setMethod.IsPublic) && !this.setMethod.IsStatic);
			this.NJEMFCEBFFHHOGPKMH = GMPKOFIBGBNJPLELDP.GetShouldSerialize(info);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00010DB0 File Offset: 0x0000EFB0
		private static MethodInfo GetShouldSerialize(MemberInfo info)
		{
			string shouldSerialize = "ShouldSerialize" + info.Name;
			return (from x in info.DeclaringType.GetMethods(BindingFlags.Instance | BindingFlags.Public)
			where x.Name == shouldSerialize && x.ReturnType == typeof(bool) && x.GetParameters().Length == 0
			select x).FirstOrDefault<MethodInfo>();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00010DFC File Offset: 0x0000EFFC
		public OHBDKPLGOGEFIJLDHI GetCustomAttribute<OHBDKPLGOGEFIJLDHI>(bool inherit) where OHBDKPLGOGEFIJLDHI : Attribute
		{
			if (this.MFNJGOAAOFABIGHKDL)
			{
				return this.HBHBEIOJOHELICCHFJ.GetCustomAttribute(inherit);
			}
			if (this.HBJDLMAJOCKDANKPMA != null)
			{
				return this.HBJDLMAJOCKDANKPMA.GetCustomAttribute(inherit);
			}
			return default(OHBDKPLGOGEFIJLDHI);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000045E9 File Offset: 0x000027E9
		public virtual void EmitLoadValue(ILGenerator il)
		{
			if (this.MFNJGOAAOFABIGHKDL)
			{
				il.EmitCall(this.getMethod);
				return;
			}
			il.Emit(OpCodes.Ldfld, this.HBJDLMAJOCKDANKPMA);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00004611 File Offset: 0x00002811
		public virtual void EmitStoreValue(ILGenerator il)
		{
			if (this.MFNJGOAAOFABIGHKDL)
			{
				il.EmitCall(this.setMethod);
				return;
			}
			il.Emit(OpCodes.Stfld, this.HBJDLMAJOCKDANKPMA);
		}

		// Token: 0x040001B2 RID: 434
		private MethodInfo getMethod;

		// Token: 0x040001B3 RID: 435
		private MethodInfo setMethod;

		// Token: 0x020000B5 RID: 181
		[CompilerGenerated]
		private sealed class FOAIPKOMPBIFJOAMGH
		{
			// Token: 0x060002DC RID: 732 RVA: 0x00004639 File Offset: 0x00002839
			internal bool <GetShouldSerialize>b__0(MethodInfo x)
			{
				return x.Name == this.shouldSerialize && x.ReturnType == typeof(bool) && x.GetParameters().Length == 0;
			}

			// Token: 0x040001B4 RID: 436
			public string shouldSerialize;
		}
	}
}

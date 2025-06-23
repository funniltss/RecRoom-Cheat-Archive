using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Utf8Json.Internal.Emit
{
	// Token: 0x020000B9 RID: 185
	internal class OENLDEHMHHEPGDFHKG
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000471E File Offset: 0x0000291E
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00004726 File Offset: 0x00002926
		public Type JJKOCCJAHBLABJNMMG { get; private set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000472F File Offset: 0x0000292F
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00004737 File Offset: 0x00002937
		public bool EGBBNEFIEAGFKPDKFC { get; private set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00004740 File Offset: 0x00002940
		public bool KKIMLDNNFMPOFHDIDN
		{
			get
			{
				return !this.EGBBNEFIEAGFKPDKFC;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000474B File Offset: 0x0000294B
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00004753 File Offset: 0x00002953
		public bool KNJAAALOFFPDMBEHPI { get; private set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000475C File Offset: 0x0000295C
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00004764 File Offset: 0x00002964
		public ConstructorInfo NOECADOFLINBMAHPKL { get; internal set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000476D File Offset: 0x0000296D
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00004775 File Offset: 0x00002975
		public GMPKOFIBGBNJPLELDP[] LAIICILJOEOLHINKFE { get; internal set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000477E File Offset: 0x0000297E
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00004786 File Offset: 0x00002986
		public GMPKOFIBGBNJPLELDP[] OAFLAMGNCFIPDCHAPF { get; internal set; }

		// Token: 0x060002F4 RID: 756 RVA: 0x00010F0C File Offset: 0x0000F10C
		public OENLDEHMHHEPGDFHKG(Type type, Func<string, string> nameMutetor, bool allowPrivate)
		{
			TypeInfo typeInfo = type.GetTypeInfo();
			bool flag = typeInfo.IsClass || typeInfo.IsInterface || typeInfo.IsAbstract;
			this.JJKOCCJAHBLABJNMMG = type;
			Dictionary<string, GMPKOFIBGBNJPLELDP> dictionary = new Dictionary<string, GMPKOFIBGBNJPLELDP>();
			foreach (PropertyInfo propertyInfo in type.GetAllProperties())
			{
				if (propertyInfo.GetIndexParameters().Length == 0 && propertyInfo.GetCustomAttribute(true) == null)
				{
					GLJJNJDFMBPNMFKPAP customAttribute = propertyInfo.GetCustomAttribute(true);
					string name = (customAttribute != null && customAttribute.Name != null) ? customAttribute.Name : nameMutetor(propertyInfo.Name);
					GMPKOFIBGBNJPLELDP gmpkofibgbnjpleldp = new GMPKOFIBGBNJPLELDP(propertyInfo, name, allowPrivate);
					if (gmpkofibgbnjpleldp.EAKBJPKGFOKCEHFJJD || gmpkofibgbnjpleldp.NCJDJAJEIKHAIBPJBG)
					{
						if (dictionary.ContainsKey(gmpkofibgbnjpleldp.LNKALLJDEAKLDIPONI))
						{
							throw new InvalidOperationException("same (custom)name is in type. Type:" + type.Name + " Name:" + gmpkofibgbnjpleldp.LNKALLJDEAKLDIPONI);
						}
						dictionary.Add(gmpkofibgbnjpleldp.LNKALLJDEAKLDIPONI, gmpkofibgbnjpleldp);
					}
				}
			}
			foreach (FieldInfo fieldInfo in type.GetAllFields())
			{
				if (fieldInfo.GetCustomAttribute(true) == null && fieldInfo.GetCustomAttribute(true) == null && !fieldInfo.IsStatic && !fieldInfo.Name.StartsWith("<"))
				{
					GLJJNJDFMBPNMFKPAP customAttribute2 = fieldInfo.GetCustomAttribute(true);
					string name2 = (customAttribute2 != null && customAttribute2.Name != null) ? customAttribute2.Name : nameMutetor(fieldInfo.Name);
					GMPKOFIBGBNJPLELDP gmpkofibgbnjpleldp2 = new GMPKOFIBGBNJPLELDP(fieldInfo, name2, allowPrivate);
					if (gmpkofibgbnjpleldp2.EAKBJPKGFOKCEHFJJD || gmpkofibgbnjpleldp2.NCJDJAJEIKHAIBPJBG)
					{
						if (dictionary.ContainsKey(gmpkofibgbnjpleldp2.LNKALLJDEAKLDIPONI))
						{
							throw new InvalidOperationException("same (custom)name is in type. Type:" + type.Name + " Name:" + gmpkofibgbnjpleldp2.LNKALLJDEAKLDIPONI);
						}
						dictionary.Add(gmpkofibgbnjpleldp2.LNKALLJDEAKLDIPONI, gmpkofibgbnjpleldp2);
					}
				}
			}
			ConstructorInfo constructorInfo = (from x in typeInfo.DeclaredConstructors
			where x.IsPublic
			select x).SingleOrDefault((ConstructorInfo x) => x.GetCustomAttribute(false) != null);
			List<GMPKOFIBGBNJPLELDP> list = new List<GMPKOFIBGBNJPLELDP>();
			IEnumerator<ConstructorInfo> enumerator3 = null;
			if (constructorInfo == null)
			{
				enumerator3 = (from x in typeInfo.DeclaredConstructors
				where x.IsPublic
				orderby x.GetParameters().Length descending
				select x).GetEnumerator();
				if (enumerator3.MoveNext())
				{
					constructorInfo = enumerator3.Current;
				}
			}
			if (constructorInfo != null)
			{
				ILookup<string, KeyValuePair<string, GMPKOFIBGBNJPLELDP>> lookup = dictionary.ToLookup((KeyValuePair<string, GMPKOFIBGBNJPLELDP> x) => x.Key, (KeyValuePair<string, GMPKOFIBGBNJPLELDP> x) => x, StringComparer.OrdinalIgnoreCase);
				for (;;)
				{
					list.Clear();
					int num = 0;
					foreach (ParameterInfo parameterInfo in constructorInfo.GetParameters())
					{
						IEnumerable<KeyValuePair<string, GMPKOFIBGBNJPLELDP>> source = lookup[parameterInfo.Name];
						int num2 = source.Count<KeyValuePair<string, GMPKOFIBGBNJPLELDP>>();
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								if (enumerator3 == null)
								{
									goto IL_37E;
								}
								constructorInfo = null;
							}
							else
							{
								GMPKOFIBGBNJPLELDP value = source.First<KeyValuePair<string, GMPKOFIBGBNJPLELDP>>().Value;
								if (parameterInfo.ParameterType == value.ADADCDGIIONHFKEJOC && value.EAKBJPKGFOKCEHFJJD)
								{
									list.Add(value);
									num++;
								}
								else
								{
									constructorInfo = null;
								}
							}
						}
						else
						{
							constructorInfo = null;
						}
					}
					if (!OENLDEHMHHEPGDFHKG.TryGetNextConstructor(enumerator3, ref constructorInfo))
					{
						goto IL_431;
					}
				}
				IL_37E:
				ParameterInfo parameterInfo;
				throw new InvalidOperationException(string.Concat(new string[]
				{
					"duplicate matched constructor parameter name:",
					type.FullName,
					" parameterName:",
					parameterInfo.Name,
					" paramterType:",
					parameterInfo.ParameterType.Name
				}));
			}
			IL_431:
			this.EGBBNEFIEAGFKPDKFC = flag;
			this.KNJAAALOFFPDMBEHPI = (flag && !typeInfo.IsAbstract && !typeInfo.IsInterface);
			this.NOECADOFLINBMAHPKL = constructorInfo;
			this.LAIICILJOEOLHINKFE = list.ToArray();
			this.OAFLAMGNCFIPDCHAPF = dictionary.Values.ToArray<GMPKOFIBGBNJPLELDP>();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000478F File Offset: 0x0000298F
		private static bool TryGetNextConstructor(IEnumerator<ConstructorInfo> ctorEnumerator, ref ConstructorInfo ctor)
		{
			if (ctorEnumerator == null || ctor != null)
			{
				return false;
			}
			if (ctorEnumerator.MoveNext())
			{
				ctor = ctorEnumerator.Current;
				return true;
			}
			ctor = null;
			return false;
		}

		// Token: 0x020000BA RID: 186
		[CompilerGenerated]
		[Serializable]
		private sealed class DIEBJCIHGCAIGBPJAI
		{
			// Token: 0x060002F8 RID: 760 RVA: 0x000047C2 File Offset: 0x000029C2
			internal bool <.ctor>b__26_0(ConstructorInfo x)
			{
				return x.IsPublic;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x000047CA File Offset: 0x000029CA
			internal bool <.ctor>b__26_1(ConstructorInfo x)
			{
				return x.GetCustomAttribute(false) != null;
			}

			// Token: 0x060002FA RID: 762 RVA: 0x000047C2 File Offset: 0x000029C2
			internal bool <.ctor>b__26_2(ConstructorInfo x)
			{
				return x.IsPublic;
			}

			// Token: 0x060002FB RID: 763 RVA: 0x000033ED File Offset: 0x000015ED
			internal int <.ctor>b__26_3(ConstructorInfo x)
			{
				return x.GetParameters().Length;
			}

			// Token: 0x060002FC RID: 764 RVA: 0x000047D6 File Offset: 0x000029D6
			internal string <.ctor>b__26_4(KeyValuePair<string, GMPKOFIBGBNJPLELDP> x)
			{
				return x.Key;
			}

			// Token: 0x060002FD RID: 765 RVA: 0x000047DF File Offset: 0x000029DF
			internal KeyValuePair<string, GMPKOFIBGBNJPLELDP> <.ctor>b__26_5(KeyValuePair<string, GMPKOFIBGBNJPLELDP> x)
			{
				return x;
			}

			// Token: 0x040001C2 RID: 450
			public static readonly OENLDEHMHHEPGDFHKG.DIEBJCIHGCAIGBPJAI <>9 = new OENLDEHMHHEPGDFHKG.DIEBJCIHGCAIGBPJAI();

			// Token: 0x040001C3 RID: 451
			public static Func<ConstructorInfo, bool> <>9__26_0;

			// Token: 0x040001C4 RID: 452
			public static Func<ConstructorInfo, bool> <>9__26_1;

			// Token: 0x040001C5 RID: 453
			public static Func<ConstructorInfo, bool> <>9__26_2;

			// Token: 0x040001C6 RID: 454
			public static Func<ConstructorInfo, int> <>9__26_3;

			// Token: 0x040001C7 RID: 455
			public static Func<KeyValuePair<string, GMPKOFIBGBNJPLELDP>, string> <>9__26_4;

			// Token: 0x040001C8 RID: 456
			public static Func<KeyValuePair<string, GMPKOFIBGBNJPLELDP>, KeyValuePair<string, GMPKOFIBGBNJPLELDP>> <>9__26_5;
		}
	}
}

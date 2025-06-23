using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Utf8Json.Formatters;
using Utf8Json.Internal;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x0200002B RID: 43
	internal static class HKKLOFJMAMHLJLDJMI
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00009AB8 File Offset: 0x00007CB8
		internal static object GetFormatter(Type t)
		{
			TypeInfo typeInfo = t.GetTypeInfo();
			if (!t.IsArray)
			{
				if (typeInfo.IsGenericType)
				{
					Type genericTypeDefinition = typeInfo.GetGenericTypeDefinition();
					bool flag = genericTypeDefinition.GetTypeInfo().IsNullable();
					Type type = flag ? typeInfo.GenericTypeArguments[0] : null;
					if (genericTypeDefinition == typeof(KeyValuePair<, >))
					{
						return HKKLOFJMAMHLJLDJMI.CreateInstance(typeof(OLDICEJCINFNADGBBI<, >), typeInfo.GenericTypeArguments, Array.Empty<object>());
					}
					if (flag && type.GetTypeInfo().IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >))
					{
						return HKKLOFJMAMHLJLDJMI.CreateInstance(typeof(AAADJIHEFPOLHGHNKE<>), new Type[]
						{
							type
						}, Array.Empty<object>());
					}
					if (genericTypeDefinition == typeof(ArraySegment<>))
					{
						if (typeInfo.GenericTypeArguments[0] == typeof(byte))
						{
							return PGJDHEOBFNCMFIANLM.Default;
						}
						return HKKLOFJMAMHLJLDJMI.CreateInstance(typeof(AKLJJAIHCEBHKDNMDE<>), typeInfo.GenericTypeArguments, Array.Empty<object>());
					}
					else if (flag && type.GetTypeInfo().IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(ArraySegment<>))
					{
						if (type == typeof(ArraySegment<byte>))
						{
							return new EKNOLMEMLPPBCANDBP<ArraySegment<byte>>(PGJDHEOBFNCMFIANLM.Default);
						}
						return HKKLOFJMAMHLJLDJMI.CreateInstance(typeof(AAADJIHEFPOLHGHNKE<>), new Type[]
						{
							type
						}, Array.Empty<object>());
					}
					else
					{
						Type genericType;
						if (HKKLOFJMAMHLJLDJMI.formatterMap.TryGetValue(genericTypeDefinition, out genericType))
						{
							return HKKLOFJMAMHLJLDJMI.CreateInstance(genericType, typeInfo.GenericTypeArguments, Array.Empty<object>());
						}
						if (typeInfo.GenericTypeArguments.Length == 1)
						{
							if (typeInfo.ImplementedInterfaces.Any((Type x) => x.GetTypeInfo().IsConstructedGenericType && x.GetGenericTypeDefinition() == typeof(ICollection<>)))
							{
								if (typeInfo.DeclaredConstructors.Any((ConstructorInfo x) => x.GetParameters().Length == 0))
								{
									Type type2 = typeInfo.GenericTypeArguments[0];
									return HKKLOFJMAMHLJLDJMI.CreateInstance(typeof(GAPOAJPJNIPCNCCMDH<, >), new Type[]
									{
										type2,
										t
									}, Array.Empty<object>());
								}
							}
						}
						if (typeInfo.GenericTypeArguments.Length == 2)
						{
							if (typeInfo.ImplementedInterfaces.Any((Type x) => x.GetTypeInfo().IsConstructedGenericType && x.GetGenericTypeDefinition() == typeof(IDictionary<, >)))
							{
								if (typeInfo.DeclaredConstructors.Any((ConstructorInfo x) => x.GetParameters().Length == 0))
								{
									Type type3 = typeInfo.GenericTypeArguments[0];
									Type type4 = typeInfo.GenericTypeArguments[1];
									return HKKLOFJMAMHLJLDJMI.CreateInstance(typeof(PJECGAHIBHLCGHLAAN<, , >), new Type[]
									{
										type3,
										type4,
										t
									}, Array.Empty<object>());
								}
							}
						}
					}
				}
				else
				{
					if (t == typeof(IEnumerable))
					{
						return OOKBIEBLBOMPAKHLLC.Default;
					}
					if (t == typeof(ICollection))
					{
						return NLFAENHHBNGAPFGHOF.Default;
					}
					if (t == typeof(IList))
					{
						return KPEJFPBJNOAHJBFCJF.Default;
					}
					if (t == typeof(IDictionary))
					{
						return HJFPBFBABBGJBEFDAA.Default;
					}
					if (typeof(IList).GetTypeInfo().IsAssignableFrom(typeInfo))
					{
						if (typeInfo.DeclaredConstructors.Any((ConstructorInfo x) => x.GetParameters().Length == 0))
						{
							return Activator.CreateInstance(typeof(DHOKFMAJNCHGOPCGID<>).MakeGenericType(new Type[]
							{
								t
							}));
						}
					}
					if (typeof(IDictionary).GetTypeInfo().IsAssignableFrom(typeInfo))
					{
						if (typeInfo.DeclaredConstructors.Any((ConstructorInfo x) => x.GetParameters().Length == 0))
						{
							return Activator.CreateInstance(typeof(IDPEHIJGNNCKGFFAJL<>).MakeGenericType(new Type[]
							{
								t
							}));
						}
					}
				}
				return null;
			}
			int arrayRank = t.GetArrayRank();
			if (arrayRank == 1)
			{
				if (t.GetElementType() == typeof(byte))
				{
					return JPJCGHBIBCANKABLPB.Default;
				}
				return Activator.CreateInstance(typeof(IJEPOEPIFGICIEIIDC<>).MakeGenericType(new Type[]
				{
					t.GetElementType()
				}));
			}
			else
			{
				if (arrayRank == 2)
				{
					return Activator.CreateInstance(typeof(PPDLJBPELMFCEOFLDA<>).MakeGenericType(new Type[]
					{
						t.GetElementType()
					}));
				}
				if (arrayRank == 3)
				{
					return Activator.CreateInstance(typeof(CKOCONNKFCAHBIMGDI<>).MakeGenericType(new Type[]
					{
						t.GetElementType()
					}));
				}
				if (arrayRank == 4)
				{
					return Activator.CreateInstance(typeof(JMBBEHGDIPJCLCLHLK<>).MakeGenericType(new Type[]
					{
						t.GetElementType()
					}));
				}
				return null;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002EF6 File Offset: 0x000010F6
		private static object CreateInstance(Type genericType, Type[] genericTypeArguments, params object[] arguments)
		{
			return Activator.CreateInstance(genericType.MakeGenericType(genericTypeArguments), arguments);
		}

		// Token: 0x0400005C RID: 92
		private static readonly Dictionary<Type, Type> formatterMap = new Dictionary<Type, Type>
		{
			{
				typeof(List<>),
				typeof(BMKCBCOMGEOPJCGDLE<>)
			},
			{
				typeof(LinkedList<>),
				typeof(LDFPPDOGGFGHOGJPLE<>)
			},
			{
				typeof(Queue<>),
				typeof(CFFOJKKJAGBOIOKBHE<>)
			},
			{
				typeof(Stack<>),
				typeof(AJIKGNJFKKJFMDBILE<>)
			},
			{
				typeof(HashSet<>),
				typeof(LNMEBOIPBGJCJGDHGO<>)
			},
			{
				typeof(ReadOnlyCollection<>),
				typeof(MGHBGMHOKOJJAJGPKE<>)
			},
			{
				typeof(IList<>),
				typeof(HLBJFPJDFNBAAMDGPC<>)
			},
			{
				typeof(ICollection<>),
				typeof(PBIAFKPPHHBCBIFGIB<>)
			},
			{
				typeof(IEnumerable<>),
				typeof(CBDAEKAEHDCJBGEKKH<>)
			},
			{
				typeof(Dictionary<, >),
				typeof(CBGGOGHLBDNMGFCCGI<, >)
			},
			{
				typeof(IDictionary<, >),
				typeof(EEBBILKLHHFKOLMAIP<, >)
			},
			{
				typeof(SortedDictionary<, >),
				typeof(KKPKOCPKFLGGKCLCAJ<, >)
			},
			{
				typeof(SortedList<, >),
				typeof(HABDEDLGNFJLHLADBN<, >)
			},
			{
				typeof(ILookup<, >),
				typeof(DEONKGNPBNOBJKKEFD<, >)
			},
			{
				typeof(IGrouping<, >),
				typeof(OBPPHDGBJEHNLHMKCM<, >)
			}
		};

		// Token: 0x0200002C RID: 44
		[CompilerGenerated]
		[Serializable]
		private sealed class LJPNHNKHPJOMGIDLBD
		{
			// Token: 0x060000FE RID: 254 RVA: 0x00002F11 File Offset: 0x00001111
			internal bool <GetFormatter>b__1_2(Type x)
			{
				return x.GetTypeInfo().IsConstructedGenericType && x.GetGenericTypeDefinition() == typeof(ICollection<>);
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00002F37 File Offset: 0x00001137
			internal bool <GetFormatter>b__1_3(ConstructorInfo x)
			{
				return x.GetParameters().Length == 0;
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00002F43 File Offset: 0x00001143
			internal bool <GetFormatter>b__1_4(Type x)
			{
				return x.GetTypeInfo().IsConstructedGenericType && x.GetGenericTypeDefinition() == typeof(IDictionary<, >);
			}

			// Token: 0x06000101 RID: 257 RVA: 0x00002F37 File Offset: 0x00001137
			internal bool <GetFormatter>b__1_5(ConstructorInfo x)
			{
				return x.GetParameters().Length == 0;
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00002F37 File Offset: 0x00001137
			internal bool <GetFormatter>b__1_0(ConstructorInfo x)
			{
				return x.GetParameters().Length == 0;
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00002F37 File Offset: 0x00001137
			internal bool <GetFormatter>b__1_1(ConstructorInfo x)
			{
				return x.GetParameters().Length == 0;
			}

			// Token: 0x0400005D RID: 93
			public static readonly HKKLOFJMAMHLJLDJMI.LJPNHNKHPJOMGIDLBD <>9 = new HKKLOFJMAMHLJLDJMI.LJPNHNKHPJOMGIDLBD();

			// Token: 0x0400005E RID: 94
			public static Func<Type, bool> <>9__1_2;

			// Token: 0x0400005F RID: 95
			public static Func<ConstructorInfo, bool> <>9__1_3;

			// Token: 0x04000060 RID: 96
			public static Func<Type, bool> <>9__1_4;

			// Token: 0x04000061 RID: 97
			public static Func<ConstructorInfo, bool> <>9__1_5;

			// Token: 0x04000062 RID: 98
			public static Func<ConstructorInfo, bool> <>9__1_0;

			// Token: 0x04000063 RID: 99
			public static Func<ConstructorInfo, bool> <>9__1_1;
		}
	}
}

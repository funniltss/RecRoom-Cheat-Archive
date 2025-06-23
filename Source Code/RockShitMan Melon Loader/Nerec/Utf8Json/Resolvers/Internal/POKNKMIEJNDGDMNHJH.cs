using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using Utf8Json.Formatters;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Resolvers.Internal
{
	// Token: 0x02000045 RID: 69
	internal static class POKNKMIEJNDGDMNHJH
	{
		// Token: 0x06000134 RID: 308 RVA: 0x0000A118 File Offset: 0x00008318
		public static object BuildFormatterToAssembly<PJPIEEAFJALPEBKOLH>(DILDNPCNJDCNMBMPHO assembly, LMCMANMFGJGJFPNBEN selfResolver, Func<string, string> nameMutator, bool excludeNull)
		{
			TypeInfo typeInfo = typeof(PJPIEEAFJALPEBKOLH).GetTypeInfo();
			if (typeInfo.IsNullable())
			{
				typeInfo = typeInfo.GenericTypeArguments[0].GetTypeInfo();
				object formatterDynamic = selfResolver.GetFormatterDynamic(typeInfo.AsType());
				if (formatterDynamic == null)
				{
					return null;
				}
				return (FLGKBGGCEAHKIBEKBN<PJPIEEAFJALPEBKOLH>)Activator.CreateInstance(typeof(EKNOLMEMLPPBCANDBP<>).MakeGenericType(new Type[]
				{
					typeInfo.AsType()
				}), new object[]
				{
					formatterDynamic
				});
			}
			else
			{
				if (typeof(Exception).GetTypeInfo().IsAssignableFrom(typeInfo))
				{
					return POKNKMIEJNDGDMNHJH.BuildAnonymousFormatter(typeof(PJPIEEAFJALPEBKOLH), nameMutator, excludeNull, false, true);
				}
				Type type;
				if (typeInfo.IsAnonymous() || POKNKMIEJNDGDMNHJH.TryGetInterfaceEnumerableElementType(typeof(PJPIEEAFJALPEBKOLH), out type))
				{
					return POKNKMIEJNDGDMNHJH.BuildAnonymousFormatter(typeof(PJPIEEAFJALPEBKOLH), nameMutator, excludeNull, false, false);
				}
				TypeInfo typeInfo2 = POKNKMIEJNDGDMNHJH.BuildType(assembly, typeof(PJPIEEAFJALPEBKOLH), nameMutator, excludeNull);
				if (typeInfo2 == null)
				{
					return null;
				}
				return (FLGKBGGCEAHKIBEKBN<PJPIEEAFJALPEBKOLH>)Activator.CreateInstance(typeInfo2.AsType());
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000A218 File Offset: 0x00008418
		public static object BuildFormatterToDynamicMethod<BNKBPFHDBJMMLBAIFM>(LMCMANMFGJGJFPNBEN selfResolver, Func<string, string> nameMutator, bool excludeNull, bool allowPrivate)
		{
			TypeInfo typeInfo = typeof(BNKBPFHDBJMMLBAIFM).GetTypeInfo();
			if (typeInfo.IsNullable())
			{
				typeInfo = typeInfo.GenericTypeArguments[0].GetTypeInfo();
				object formatterDynamic = selfResolver.GetFormatterDynamic(typeInfo.AsType());
				if (formatterDynamic == null)
				{
					return null;
				}
				return (FLGKBGGCEAHKIBEKBN<BNKBPFHDBJMMLBAIFM>)Activator.CreateInstance(typeof(EKNOLMEMLPPBCANDBP<>).MakeGenericType(new Type[]
				{
					typeInfo.AsType()
				}), new object[]
				{
					formatterDynamic
				});
			}
			else
			{
				if (typeof(Exception).GetTypeInfo().IsAssignableFrom(typeInfo))
				{
					return POKNKMIEJNDGDMNHJH.BuildAnonymousFormatter(typeof(BNKBPFHDBJMMLBAIFM), nameMutator, excludeNull, false, true);
				}
				return POKNKMIEJNDGDMNHJH.BuildAnonymousFormatter(typeof(BNKBPFHDBJMMLBAIFM), nameMutator, excludeNull, allowPrivate, false);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000A2D0 File Offset: 0x000084D0
		private static TypeInfo BuildType(DILDNPCNJDCNMBMPHO assembly, Type type, Func<string, string> nameMutator, bool excludeNull)
		{
			POKNKMIEJNDGDMNHJH.CBDKNPKHDDOFGHHCKH cbdknpkhddofghhckh = new POKNKMIEJNDGDMNHJH.CBDKNPKHDDOFGHHCKH();
			if (POKNKMIEJNDGDMNHJH.ignoreTypes.Contains(type))
			{
				return null;
			}
			OENLDEHMHHEPGDFHKG oenldehmhhepgdfhkg = new OENLDEHMHHEPGDFHKG(type, nameMutator, false);
			bool hasShouldSerialize = oenldehmhhepgdfhkg.OAFLAMGNCFIPDCHAPF.Any((GMPKOFIBGBNJPLELDP x) => x.NJEMFCEBFFHHOGPKMH != null);
			Type type2 = typeof(FLGKBGGCEAHKIBEKBN<>).MakeGenericType(new Type[]
			{
				type
			});
			TypeBuilder typeBuilder = assembly.DefineType("Utf8Json.Formatters." + POKNKMIEJNDGDMNHJH.SubtractFullNameRegex.Replace(type.FullName, "").Replace(".", "_") + "Formatter" + Interlocked.Increment(ref POKNKMIEJNDGDMNHJH.nameSequence).ToString(), TypeAttributes.Public | TypeAttributes.Sealed, null, new Type[]
			{
				type2
			});
			ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, Type.EmptyTypes);
			cbdknpkhddofghhckh.stringByteKeysField = typeBuilder.DefineField("stringByteKeys", typeof(byte[][]), FieldAttributes.Private | FieldAttributes.InitOnly);
			ILGenerator ilgenerator = constructorBuilder.GetILGenerator();
			cbdknpkhddofghhckh.customFormatterLookup = POKNKMIEJNDGDMNHJH.BuildConstructor(typeBuilder, oenldehmhhepgdfhkg, constructorBuilder, cbdknpkhddofghhckh.stringByteKeysField, ilgenerator, excludeNull, hasShouldSerialize);
			MethodBuilder methodBuilder = typeBuilder.DefineMethod("Serialize", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Final | MethodAttributes.Virtual, null, new Type[]
			{
				typeof(BJLLMLPIIIPIEPLCJH).MakeByRefType(),
				type,
				typeof(LMCMANMFGJGJFPNBEN)
			});
			ILGenerator il2 = methodBuilder.GetILGenerator();
			POKNKMIEJNDGDMNHJH.BuildSerialize(type, oenldehmhhepgdfhkg, il2, delegate
			{
				il2.EmitLoadThis();
				il2.EmitLdfld(cbdknpkhddofghhckh.stringByteKeysField);
			}, delegate(int index, GMPKOFIBGBNJPLELDP member)
			{
				FieldInfo fieldInfo;
				if (!cbdknpkhddofghhckh.customFormatterLookup.TryGetValue(member, out fieldInfo))
				{
					return false;
				}
				il2.EmitLoadThis();
				il2.EmitLdfld(fieldInfo);
				return true;
			}, excludeNull, hasShouldSerialize, 1);
			MethodBuilder methodBuilder2 = typeBuilder.DefineMethod("Deserialize", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Final | MethodAttributes.Virtual, type, new Type[]
			{
				typeof(BPIPCPJELFMIKDNCFG).MakeByRefType(),
				typeof(LMCMANMFGJGJFPNBEN)
			});
			ILGenerator il = methodBuilder2.GetILGenerator();
			POKNKMIEJNDGDMNHJH.BuildDeserialize(type, oenldehmhhepgdfhkg, il, delegate(int index, GMPKOFIBGBNJPLELDP member)
			{
				FieldInfo fieldInfo;
				if (!cbdknpkhddofghhckh.customFormatterLookup.TryGetValue(member, out fieldInfo))
				{
					return false;
				}
				il.EmitLoadThis();
				il.EmitLdfld(fieldInfo);
				return true;
			}, false, 1);
			return typeBuilder.CreateTypeInfo();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000A4E8 File Offset: 0x000086E8
		public static object BuildAnonymousFormatter(Type type, Func<string, string> nameMutator, bool excludeNull, bool allowPrivate, bool isException)
		{
			POKNKMIEJNDGDMNHJH.GLJGICMAKKLLEDALFM gljgicmakklledalfm = new POKNKMIEJNDGDMNHJH.GLJGICMAKKLLEDALFM();
			gljgicmakklledalfm.nameMutator = nameMutator;
			if (POKNKMIEJNDGDMNHJH.ignoreTypes.Contains(type))
			{
				return false;
			}
			OENLDEHMHHEPGDFHKG oenldehmhhepgdfhkg;
			if (isException)
			{
				HashSet<string> ignoreSet = new HashSet<string>(from x in new string[]
				{
					"HelpLink",
					"TargetSite",
					"HResult",
					"Data",
					"ClassName",
					"InnerException"
				}
				select gljgicmakklledalfm.nameMutator(x));
				oenldehmhhepgdfhkg = new OENLDEHMHHEPGDFHKG(type, gljgicmakklledalfm.nameMutator, false);
				oenldehmhhepgdfhkg.NOECADOFLINBMAHPKL = null;
				oenldehmhhepgdfhkg.LAIICILJOEOLHINKFE = new GMPKOFIBGBNJPLELDP[0];
				oenldehmhhepgdfhkg.OAFLAMGNCFIPDCHAPF = new EECKCCFDGNGAJENEAB[]
				{
					new EECKCCFDGNGAJENEAB(gljgicmakklledalfm.nameMutator("ClassName"), type.FullName)
				}.Concat(from x in oenldehmhhepgdfhkg.OAFLAMGNCFIPDCHAPF
				where !ignoreSet.Contains(x.LNKALLJDEAKLDIPONI)
				select x).Concat(new BGIPGFFBOJDBGFMMAD[]
				{
					new BGIPGFFBOJDBGFMMAD(gljgicmakklledalfm.nameMutator("InnerException"))
				}).ToArray<GMPKOFIBGBNJPLELDP>();
			}
			else
			{
				oenldehmhhepgdfhkg = new OENLDEHMHHEPGDFHKG(type, gljgicmakklledalfm.nameMutator, allowPrivate);
			}
			bool flag = oenldehmhhepgdfhkg.OAFLAMGNCFIPDCHAPF.Any((GMPKOFIBGBNJPLELDP x) => x.NJEMFCEBFFHHOGPKMH != null);
			List<byte[]> list = new List<byte[]>();
			int num = 0;
			foreach (GMPKOFIBGBNJPLELDP gmpkofibgbnjpleldp in from x in oenldehmhhepgdfhkg.OAFLAMGNCFIPDCHAPF
			where x.EAKBJPKGFOKCEHFJJD
			select x)
			{
				if (excludeNull || flag)
				{
					list.Add(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyName(gmpkofibgbnjpleldp.LNKALLJDEAKLDIPONI));
				}
				else if (num == 0)
				{
					list.Add(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyNameWithBeginObject(gmpkofibgbnjpleldp.LNKALLJDEAKLDIPONI));
				}
				else
				{
					list.Add(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyNameWithPrefixValueSeparator(gmpkofibgbnjpleldp.LNKALLJDEAKLDIPONI));
				}
				num++;
			}
			gljgicmakklledalfm.serializeCustomFormatters = new List<object>();
			gljgicmakklledalfm.deserializeCustomFormatters = new List<object>();
			foreach (GMPKOFIBGBNJPLELDP gmpkofibgbnjpleldp2 in from x in oenldehmhhepgdfhkg.OAFLAMGNCFIPDCHAPF
			where x.EAKBJPKGFOKCEHFJJD
			select x)
			{
				BHBMDGIJKJJJKFJCIF customAttribute = gmpkofibgbnjpleldp2.GetCustomAttribute<BHBMDGIJKJJJKFJCIF>(true);
				if (customAttribute != null)
				{
					object item = Activator.CreateInstance(customAttribute.APIMLHBDDPMHACKCOL, customAttribute.BMPCIPDFFCMMAJMCLM);
					gljgicmakklledalfm.serializeCustomFormatters.Add(item);
				}
				else
				{
					gljgicmakklledalfm.serializeCustomFormatters.Add(null);
				}
			}
			GMPKOFIBGBNJPLELDP[] members = oenldehmhhepgdfhkg.OAFLAMGNCFIPDCHAPF;
			for (int i = 0; i < members.Length; i++)
			{
				BHBMDGIJKJJJKFJCIF customAttribute2 = members[i].GetCustomAttribute<BHBMDGIJKJJJKFJCIF>(true);
				if (customAttribute2 != null)
				{
					object item2 = Activator.CreateInstance(customAttribute2.APIMLHBDDPMHACKCOL, customAttribute2.BMPCIPDFFCMMAJMCLM);
					gljgicmakklledalfm.deserializeCustomFormatters.Add(item2);
				}
				else
				{
					gljgicmakklledalfm.deserializeCustomFormatters.Add(null);
				}
			}
			DynamicMethod dynamicMethod = new DynamicMethod("Serialize", null, new Type[]
			{
				typeof(byte[][]),
				typeof(object[]),
				typeof(BJLLMLPIIIPIEPLCJH).MakeByRefType(),
				type,
				typeof(LMCMANMFGJGJFPNBEN)
			}, type.Module, true);
			ILGenerator il2 = dynamicMethod.GetILGenerator();
			POKNKMIEJNDGDMNHJH.BuildSerialize(type, oenldehmhhepgdfhkg, il2, delegate
			{
				il2.EmitLdarg(0);
			}, delegate(int index, GMPKOFIBGBNJPLELDP member)
			{
				if (gljgicmakklledalfm.serializeCustomFormatters.Count == 0)
				{
					return false;
				}
				if (gljgicmakklledalfm.serializeCustomFormatters[index] == null)
				{
					return false;
				}
				il2.EmitLdarg(1);
				il2.EmitLdc_I4(index);
				il2.Emit(OpCodes.Ldelem_Ref);
				il2.Emit(OpCodes.Castclass, gljgicmakklledalfm.serializeCustomFormatters[index].GetType());
				return true;
			}, excludeNull, flag, 2);
			DynamicMethod dynamicMethod2 = new DynamicMethod("Deserialize", type, new Type[]
			{
				typeof(object[]),
				typeof(BPIPCPJELFMIKDNCFG).MakeByRefType(),
				typeof(LMCMANMFGJGJFPNBEN)
			}, type.Module, true);
			ILGenerator il = dynamicMethod2.GetILGenerator();
			POKNKMIEJNDGDMNHJH.BuildDeserialize(type, oenldehmhhepgdfhkg, il, delegate(int index, GMPKOFIBGBNJPLELDP member)
			{
				if (gljgicmakklledalfm.deserializeCustomFormatters.Count == 0)
				{
					return false;
				}
				if (gljgicmakklledalfm.deserializeCustomFormatters[index] == null)
				{
					return false;
				}
				il.EmitLdarg(0);
				il.EmitLdc_I4(index);
				il.Emit(OpCodes.Ldelem_Ref);
				il.Emit(OpCodes.Castclass, gljgicmakklledalfm.deserializeCustomFormatters[index].GetType());
				return true;
			}, true, 1);
			object obj = dynamicMethod.CreateDelegate(typeof(NOICGFGCECKIDDMBKC<>).MakeGenericType(new Type[]
			{
				type
			}));
			object obj2 = dynamicMethod2.CreateDelegate(typeof(POONOLDLJBGBIPLHLJ<>).MakeGenericType(new Type[]
			{
				type
			}));
			return Activator.CreateInstance(typeof(LCIPHDFPOIFHHMBMED<>).MakeGenericType(new Type[]
			{
				type
			}), new object[]
			{
				list.ToArray(),
				gljgicmakklledalfm.serializeCustomFormatters.ToArray(),
				gljgicmakklledalfm.deserializeCustomFormatters.ToArray(),
				obj,
				obj2
			});
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		private static Dictionary<GMPKOFIBGBNJPLELDP, FieldInfo> BuildConstructor(TypeBuilder builder, OENLDEHMHHEPGDFHKG info, ConstructorInfo method, FieldBuilder stringByteKeysField, ILGenerator il, bool excludeNull, bool hasShouldSerialize)
		{
			il.EmitLdarg(0);
			il.Emit(OpCodes.Call, POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.ObjectCtor);
			int value = info.OAFLAMGNCFIPDCHAPF.Count((GMPKOFIBGBNJPLELDP x) => x.EAKBJPKGFOKCEHFJJD);
			il.EmitLdarg(0);
			il.EmitLdc_I4(value);
			il.Emit(OpCodes.Newarr, typeof(byte[]));
			int num = 0;
			foreach (GMPKOFIBGBNJPLELDP gmpkofibgbnjpleldp in from x in info.OAFLAMGNCFIPDCHAPF
			where x.EAKBJPKGFOKCEHFJJD
			select x)
			{
				il.Emit(OpCodes.Dup);
				il.EmitLdc_I4(num);
				il.Emit(OpCodes.Ldstr, gmpkofibgbnjpleldp.LNKALLJDEAKLDIPONI);
				if (excludeNull || hasShouldSerialize)
				{
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.GetEncodedPropertyName);
				}
				else if (num == 0)
				{
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.GetEncodedPropertyNameWithBeginObject);
				}
				else
				{
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.GetEncodedPropertyNameWithPrefixValueSeparator);
				}
				il.Emit(OpCodes.Stelem_Ref);
				num++;
			}
			il.Emit(OpCodes.Stfld, stringByteKeysField);
			Dictionary<GMPKOFIBGBNJPLELDP, FieldInfo> result = POKNKMIEJNDGDMNHJH.BuildCustomFormatterField(builder, info, il);
			il.Emit(OpCodes.Ret);
			return result;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000AB18 File Offset: 0x00008D18
		private static Dictionary<GMPKOFIBGBNJPLELDP, FieldInfo> BuildCustomFormatterField(TypeBuilder builder, OENLDEHMHHEPGDFHKG info, ILGenerator il)
		{
			Dictionary<GMPKOFIBGBNJPLELDP, FieldInfo> dictionary = new Dictionary<GMPKOFIBGBNJPLELDP, FieldInfo>();
			foreach (GMPKOFIBGBNJPLELDP gmpkofibgbnjpleldp in from x in info.OAFLAMGNCFIPDCHAPF
			where x.EAKBJPKGFOKCEHFJJD || x.NCJDJAJEIKHAIBPJBG
			select x)
			{
				BHBMDGIJKJJJKFJCIF customAttribute = gmpkofibgbnjpleldp.GetCustomAttribute<BHBMDGIJKJJJKFJCIF>(true);
				if (customAttribute != null)
				{
					FieldBuilder fieldBuilder = builder.DefineField(gmpkofibgbnjpleldp.LNKALLJDEAKLDIPONI + "_formatter", customAttribute.APIMLHBDDPMHACKCOL, FieldAttributes.Private | FieldAttributes.InitOnly);
					int value = 52;
					LocalBuilder local = il.DeclareLocal(typeof(BHBMDGIJKJJJKFJCIF));
					il.Emit(OpCodes.Ldtoken, info.JJKOCCJAHBLABJNMMG);
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetTypeFromHandle);
					il.Emit(OpCodes.Ldstr, gmpkofibgbnjpleldp.CFFGNPGGDKDKBBKIMG);
					il.EmitLdc_I4(value);
					if (gmpkofibgbnjpleldp.MFNJGOAAOFABIGHKDL)
					{
						il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.TypeGetProperty);
					}
					else
					{
						il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.TypeGetField);
					}
					il.EmitTrue();
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetCustomAttributeJsonFormatterAttribute);
					il.EmitStloc(local);
					il.EmitLoadThis();
					il.EmitLdloc(local);
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HKEMLLMGACFEPJPDJI.FormatterType);
					il.EmitLdloc(local);
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HKEMLLMGACFEPJPDJI.Arguments);
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.ActivatorCreateInstance);
					il.Emit(OpCodes.Castclass, customAttribute.APIMLHBDDPMHACKCOL);
					il.Emit(OpCodes.Stfld, fieldBuilder);
					dictionary.Add(gmpkofibgbnjpleldp, fieldBuilder);
				}
			}
			return dictionary;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000ACAC File Offset: 0x00008EAC
		private static void BuildSerialize(Type type, OENLDEHMHHEPGDFHKG info, ILGenerator il, Action emitStringByteKeys, Func<int, GMPKOFIBGBNJPLELDP, bool> tryEmitLoadCustomFormatter, bool excludeNull, bool hasShouldSerialize, int firstArgIndex)
		{
			GGLNGMDCNHOEAJHKOG gglngmdcnhoeajhkog = new GGLNGMDCNHOEAJHKOG(il, firstArgIndex, false);
			GGLNGMDCNHOEAJHKOG argValue = new GGLNGMDCNHOEAJHKOG(il, firstArgIndex + 1, type);
			GGLNGMDCNHOEAJHKOG argResolver = new GGLNGMDCNHOEAJHKOG(il, firstArgIndex + 2, false);
			TypeInfo typeInfo = type.GetTypeInfo();
			BGIPGFFBOJDBGFMMAD bgipgffbojdbgfmmad = info.OAFLAMGNCFIPDCHAPF.OfType<BGIPGFFBOJDBGFMMAD>().FirstOrDefault<BGIPGFFBOJDBGFMMAD>();
			if (bgipgffbojdbgfmmad != null)
			{
				bgipgffbojdbgfmmad.argWriter = gglngmdcnhoeajhkog;
				bgipgffbojdbgfmmad.argValue = argValue;
				bgipgffbojdbgfmmad.argResolver = argResolver;
			}
			Type type2;
			if (info.EGBBNEFIEAGFKPDKFC && info.NOECADOFLINBMAHPKL == null && POKNKMIEJNDGDMNHJH.TryGetInterfaceEnumerableElementType(type, out type2))
			{
				Type type3 = typeof(IEnumerable<>).MakeGenericType(new Type[]
				{
					type2
				});
				argResolver.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetFormatterWithVerify.MakeGenericMethod(new Type[]
				{
					type3
				}));
				gglngmdcnhoeajhkog.EmitLoad();
				argValue.EmitLoad();
				argResolver.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.Serialize(type3));
				il.Emit(OpCodes.Ret);
				return;
			}
			if (info.EGBBNEFIEAGFKPDKFC)
			{
				Label label = il.DefineLabel();
				argValue.EmitLoad();
				il.Emit(OpCodes.Brtrue_S, label);
				gglngmdcnhoeajhkog.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteNull);
				il.Emit(OpCodes.Ret);
				il.MarkLabel(label);
			}
			if (type == typeof(Exception))
			{
				Label label2 = il.DefineLabel();
				LocalBuilder local = il.DeclareLocal(typeof(Type));
				argValue.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetTypeMethod);
				il.EmitStloc(local);
				il.EmitLdloc(local);
				il.Emit(OpCodes.Ldtoken, typeof(Exception));
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetTypeFromHandle);
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.TypeEquals);
				il.Emit(OpCodes.Brtrue, label2);
				il.EmitLdloc(local);
				gglngmdcnhoeajhkog.EmitLoad();
				argValue.EmitLoad();
				argResolver.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.NongenericSerialize);
				il.Emit(OpCodes.Ret);
				il.MarkLabel(label2);
			}
			LocalBuilder local2 = null;
			Label label3 = il.DefineLabel();
			Label[] array = null;
			if (excludeNull || hasShouldSerialize)
			{
				local2 = il.DeclareLocal(typeof(bool));
				gglngmdcnhoeajhkog.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteBeginObject);
				array = (from x in info.OAFLAMGNCFIPDCHAPF
				where x.EAKBJPKGFOKCEHFJJD
				select x into _
				select il.DefineLabel()).ToArray<Label>();
			}
			int num = 0;
			foreach (GMPKOFIBGBNJPLELDP gmpkofibgbnjpleldp in from x in info.OAFLAMGNCFIPDCHAPF
			where x.EAKBJPKGFOKCEHFJJD
			select x)
			{
				if (excludeNull || hasShouldSerialize)
				{
					il.MarkLabel(array[num]);
					if (excludeNull)
					{
						if (gmpkofibgbnjpleldp.ADADCDGIIONHFKEJOC.GetTypeInfo().IsNullable())
						{
							LocalBuilder local3 = il.DeclareLocal(gmpkofibgbnjpleldp.ADADCDGIIONHFKEJOC);
							argValue.EmitLoad();
							gmpkofibgbnjpleldp.EmitLoadValue(il);
							il.EmitStloc(local3);
							il.EmitLdloca(local3);
							il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetNullableHasValue(gmpkofibgbnjpleldp.ADADCDGIIONHFKEJOC.GetGenericArguments()[0]));
							il.Emit(OpCodes.Brfalse_S, (num < array.Length - 1) ? array[num + 1] : label3);
						}
						else if (!gmpkofibgbnjpleldp.ADADCDGIIONHFKEJOC.IsValueType && !(gmpkofibgbnjpleldp is EECKCCFDGNGAJENEAB))
						{
							argValue.EmitLoad();
							gmpkofibgbnjpleldp.EmitLoadValue(il);
							il.Emit(OpCodes.Brfalse_S, (num < array.Length - 1) ? array[num + 1] : label3);
						}
					}
					if (hasShouldSerialize && gmpkofibgbnjpleldp.NJEMFCEBFFHHOGPKMH != null)
					{
						argValue.EmitLoad();
						il.EmitCall(gmpkofibgbnjpleldp.NJEMFCEBFFHHOGPKMH);
						il.Emit(OpCodes.Brfalse_S, (num < array.Length - 1) ? array[num + 1] : label3);
					}
					Label label4 = il.DefineLabel();
					Label label5 = il.DefineLabel();
					il.EmitLdloc(local2);
					il.Emit(OpCodes.Brtrue_S, label5);
					il.EmitTrue();
					il.EmitStloc(local2);
					il.Emit(OpCodes.Br, label4);
					il.MarkLabel(label5);
					gglngmdcnhoeajhkog.EmitLoad();
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteValueSeparator);
					il.MarkLabel(label4);
				}
				gglngmdcnhoeajhkog.EmitLoad();
				emitStringByteKeys();
				il.EmitLdc_I4(num);
				il.Emit(OpCodes.Ldelem_Ref);
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteRaw);
				POKNKMIEJNDGDMNHJH.EmitSerializeValue(typeInfo, gmpkofibgbnjpleldp, il, num, tryEmitLoadCustomFormatter, gglngmdcnhoeajhkog, argValue, argResolver);
				num++;
			}
			il.MarkLabel(label3);
			if (!excludeNull && num == 0)
			{
				gglngmdcnhoeajhkog.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteBeginObject);
			}
			gglngmdcnhoeajhkog.EmitLoad();
			il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteEndObject);
			il.Emit(OpCodes.Ret);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000B2E8 File Offset: 0x000094E8
		private static void EmitSerializeValue(TypeInfo type, GMPKOFIBGBNJPLELDP member, ILGenerator il, int index, Func<int, GMPKOFIBGBNJPLELDP, bool> tryEmitLoadCustomFormatter, GGLNGMDCNHOEAJHKOG writer, GGLNGMDCNHOEAJHKOG argValue, GGLNGMDCNHOEAJHKOG argResolver)
		{
			Type type2 = member.ADADCDGIIONHFKEJOC;
			if (member is BGIPGFFBOJDBGFMMAD)
			{
				(member as BGIPGFFBOJDBGFMMAD).EmitSerializeDirectly(il);
				return;
			}
			if (tryEmitLoadCustomFormatter(index, member))
			{
				writer.EmitLoad();
				argValue.EmitLoad();
				member.EmitLoadValue(il);
				argResolver.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.Serialize(type2));
				return;
			}
			if (POKNKMIEJNDGDMNHJH.jsonPrimitiveTypes.Contains(type2))
			{
				writer.EmitLoad();
				argValue.EmitLoad();
				member.EmitLoadValue(il);
				il.EmitCall((from x in typeof(BJLLMLPIIIPIEPLCJH).GetTypeInfo().GetDeclaredMethods("Write" + type2.Name)
				orderby x.GetParameters().Length descending
				select x).First<MethodInfo>());
				return;
			}
			argResolver.EmitLoad();
			il.Emit(OpCodes.Call, POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetFormatterWithVerify.MakeGenericMethod(new Type[]
			{
				type2
			}));
			writer.EmitLoad();
			argValue.EmitLoad();
			member.EmitLoadValue(il);
			argResolver.EmitLoad();
			il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.Serialize(type2));
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000B40C File Offset: 0x0000960C
		private unsafe static void BuildDeserialize(Type type, OENLDEHMHHEPGDFHKG info, ILGenerator il, Func<int, GMPKOFIBGBNJPLELDP, bool> tryEmitLoadCustomFormatter, bool useGetUninitializedObject, int firstArgIndex)
		{
			POKNKMIEJNDGDMNHJH.JDLEJNGOFKOFABDNAK jdlejngofkofabdnak = new POKNKMIEJNDGDMNHJH.JDLEJNGOFKOFABDNAK();
			jdlejngofkofabdnak.il = il;
			jdlejngofkofabdnak.tryEmitLoadCustomFormatter = tryEmitLoadCustomFormatter;
			if (info.EGBBNEFIEAGFKPDKFC && info.NOECADOFLINBMAHPKL == null && (!useGetUninitializedObject || !info.KNJAAALOFFPDMBEHPI))
			{
				jdlejngofkofabdnak.il.Emit(OpCodes.Ldstr, "generated serializer for " + type.Name + " does not support deserialize.");
				jdlejngofkofabdnak.il.Emit(OpCodes.Newobj, POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.InvalidOperationExceptionConstructor);
				jdlejngofkofabdnak.il.Emit(OpCodes.Throw);
				return;
			}
			jdlejngofkofabdnak.argReader = new GGLNGMDCNHOEAJHKOG(jdlejngofkofabdnak.il, firstArgIndex, false);
			jdlejngofkofabdnak.argResolver = new GGLNGMDCNHOEAJHKOG(jdlejngofkofabdnak.il, firstArgIndex + 1, false);
			Label label = jdlejngofkofabdnak.il.DefineLabel();
			jdlejngofkofabdnak.argReader.EmitLoad();
			jdlejngofkofabdnak.il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadIsNull);
			jdlejngofkofabdnak.il.Emit(OpCodes.Brfalse_S, label);
			if (info.EGBBNEFIEAGFKPDKFC)
			{
				jdlejngofkofabdnak.il.Emit(OpCodes.Ldnull);
				jdlejngofkofabdnak.il.Emit(OpCodes.Ret);
			}
			else
			{
				jdlejngofkofabdnak.il.Emit(OpCodes.Ldstr, "json value is null, struct is not supported");
				jdlejngofkofabdnak.il.Emit(OpCodes.Newobj, POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.InvalidOperationExceptionConstructor);
				jdlejngofkofabdnak.il.Emit(OpCodes.Throw);
			}
			jdlejngofkofabdnak.il.MarkLabel(label);
			jdlejngofkofabdnak.argReader.EmitLoad();
			jdlejngofkofabdnak.il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadIsBeginObjectWithVerify);
			jdlejngofkofabdnak.isSideEffectFreeType = true;
			if (info.NOECADOFLINBMAHPKL != null)
			{
				jdlejngofkofabdnak.isSideEffectFreeType = POKNKMIEJNDGDMNHJH.IsSideEffectFreeConstructorType(info.NOECADOFLINBMAHPKL);
				if (info.OAFLAMGNCFIPDCHAPF.Any((GMPKOFIBGBNJPLELDP x) => !x.EAKBJPKGFOKCEHFJJD && x.NCJDJAJEIKHAIBPJBG))
				{
					jdlejngofkofabdnak.isSideEffectFreeType = false;
				}
			}
			jdlejngofkofabdnak.infoList = (from item in info.OAFLAMGNCFIPDCHAPF
			select new POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK
			{
				MemberInfo = item,
				LocalField = jdlejngofkofabdnak.il.DeclareLocal(item.ADADCDGIIONHFKEJOC),
				IsDeserializedField = (jdlejngofkofabdnak.isSideEffectFreeType ? null : jdlejngofkofabdnak.il.DeclareLocal(typeof(bool)))
			}).ToArray<POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK>();
			LocalBuilder local = jdlejngofkofabdnak.il.DeclareLocal(typeof(int));
			CBCBOOCAFACEIEKOLL cbcboocafaceiekoll = new CBCBOOCAFACEIEKOLL();
			for (int i = 0; i < info.OAFLAMGNCFIPDCHAPF.Length; i++)
			{
				cbcboocafaceiekoll.Add(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyNameWithoutQuotation(info.OAFLAMGNCFIPDCHAPF[i].LNKALLJDEAKLDIPONI), i);
			}
			LocalBuilder local2 = jdlejngofkofabdnak.il.DeclareLocal(typeof(byte[]));
			LocalBuilder local3 = jdlejngofkofabdnak.il.DeclareLocal(typeof(byte).MakeByRefType(), true);
			LocalBuilder local4 = jdlejngofkofabdnak.il.DeclareLocal(typeof(ArraySegment<byte>));
			LocalBuilder key = jdlejngofkofabdnak.il.DeclareLocal(typeof(ulong));
			LocalBuilder localBuilder = jdlejngofkofabdnak.il.DeclareLocal(typeof(byte*));
			LocalBuilder localBuilder2 = jdlejngofkofabdnak.il.DeclareLocal(typeof(int));
			jdlejngofkofabdnak.argReader.EmitLoad();
			jdlejngofkofabdnak.il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.GetBufferUnsafe);
			jdlejngofkofabdnak.il.EmitStloc(local2);
			jdlejngofkofabdnak.il.EmitLdloc(local2);
			jdlejngofkofabdnak.il.EmitLdc_I4(0);
			jdlejngofkofabdnak.il.Emit(OpCodes.Ldelema, typeof(byte));
			jdlejngofkofabdnak.il.EmitStloc(local3);
			Label continueWhile = jdlejngofkofabdnak.il.DefineLabel();
			Label label2 = jdlejngofkofabdnak.il.DefineLabel();
			Label readNext = jdlejngofkofabdnak.il.DefineLabel();
			jdlejngofkofabdnak.il.MarkLabel(continueWhile);
			jdlejngofkofabdnak.argReader.EmitLoad();
			jdlejngofkofabdnak.il.EmitLdloca(local);
			jdlejngofkofabdnak.il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadIsEndObjectWithSkipValueSeparator);
			jdlejngofkofabdnak.il.Emit(OpCodes.Brtrue, label2);
			jdlejngofkofabdnak.argReader.EmitLoad();
			jdlejngofkofabdnak.il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadPropertyNameSegmentUnsafe);
			jdlejngofkofabdnak.il.EmitStloc(local4);
			jdlejngofkofabdnak.il.EmitLdloc(local3);
			jdlejngofkofabdnak.il.Emit(OpCodes.Conv_I);
			jdlejngofkofabdnak.il.EmitLdloca(local4);
			jdlejngofkofabdnak.il.EmitCall(typeof(ArraySegment<byte>).GetRuntimeProperty("Offset").GetGetMethod());
			jdlejngofkofabdnak.il.Emit(OpCodes.Add);
			jdlejngofkofabdnak.il.EmitStloc(localBuilder);
			jdlejngofkofabdnak.il.EmitLdloca(local4);
			jdlejngofkofabdnak.il.EmitCall(typeof(ArraySegment<byte>).GetRuntimeProperty("Count").GetGetMethod());
			jdlejngofkofabdnak.il.EmitStloc(localBuilder2);
			jdlejngofkofabdnak.il.EmitLdloc(localBuilder2);
			jdlejngofkofabdnak.il.Emit(OpCodes.Brfalse, readNext);
			cbcboocafaceiekoll.EmitMatch(jdlejngofkofabdnak.il, localBuilder, localBuilder2, key, delegate(KeyValuePair<string, int> x)
			{
				int value = x.Value;
				if (jdlejngofkofabdnak.infoList[value].MemberInfo != null)
				{
					POKNKMIEJNDGDMNHJH.EmitDeserializeValue(jdlejngofkofabdnak.il, jdlejngofkofabdnak.infoList[value], value, jdlejngofkofabdnak.tryEmitLoadCustomFormatter, jdlejngofkofabdnak.argReader, jdlejngofkofabdnak.argResolver);
					if (!jdlejngofkofabdnak.isSideEffectFreeType)
					{
						jdlejngofkofabdnak.il.EmitTrue();
						jdlejngofkofabdnak.il.EmitStloc(jdlejngofkofabdnak.infoList[value].IsDeserializedField);
					}
					jdlejngofkofabdnak.il.Emit(OpCodes.Br, continueWhile);
					return;
				}
				jdlejngofkofabdnak.il.Emit(OpCodes.Br, readNext);
			}, delegate
			{
				jdlejngofkofabdnak.il.Emit(OpCodes.Br, readNext);
			});
			jdlejngofkofabdnak.il.MarkLabel(readNext);
			jdlejngofkofabdnak.argReader.EmitLoad();
			jdlejngofkofabdnak.il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadNextBlock);
			jdlejngofkofabdnak.il.Emit(OpCodes.Br, continueWhile);
			jdlejngofkofabdnak.il.MarkLabel(label2);
			jdlejngofkofabdnak.il.Emit(OpCodes.Ldc_I4_0);
			jdlejngofkofabdnak.il.Emit(OpCodes.Conv_U);
			jdlejngofkofabdnak.il.EmitStloc(local3);
			LocalBuilder localBuilder3 = POKNKMIEJNDGDMNHJH.EmitNewObject(jdlejngofkofabdnak.il, type, info, jdlejngofkofabdnak.infoList, jdlejngofkofabdnak.isSideEffectFreeType);
			if (localBuilder3 != null)
			{
				jdlejngofkofabdnak.il.Emit(OpCodes.Ldloc, localBuilder3);
			}
			jdlejngofkofabdnak.il.Emit(OpCodes.Ret);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000BABC File Offset: 0x00009CBC
		private static void EmitDeserializeValue(ILGenerator il, POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK info, int index, Func<int, GMPKOFIBGBNJPLELDP, bool> tryEmitLoadCustomFormatter, GGLNGMDCNHOEAJHKOG reader, GGLNGMDCNHOEAJHKOG argResolver)
		{
			GMPKOFIBGBNJPLELDP memberInfo = info.MemberInfo;
			Type type = memberInfo.ADADCDGIIONHFKEJOC;
			if (tryEmitLoadCustomFormatter(index, memberInfo))
			{
				reader.EmitLoad();
				argResolver.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.Deserialize(type));
			}
			else if (POKNKMIEJNDGDMNHJH.jsonPrimitiveTypes.Contains(type))
			{
				reader.EmitLoad();
				il.EmitCall((from x in typeof(BPIPCPJELFMIKDNCFG).GetTypeInfo().GetDeclaredMethods("Read" + type.Name)
				orderby x.GetParameters().Length descending
				select x).First<MethodInfo>());
			}
			else
			{
				argResolver.EmitLoad();
				il.Emit(OpCodes.Call, POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetFormatterWithVerify.MakeGenericMethod(new Type[]
				{
					type
				}));
				reader.EmitLoad();
				argResolver.EmitLoad();
				il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.Deserialize(type));
			}
			il.EmitStloc(info.LocalField);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		private static LocalBuilder EmitNewObject(ILGenerator il, Type type, OENLDEHMHHEPGDFHKG info, POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK[] members, bool isSideEffectFreeType)
		{
			if (info.EGBBNEFIEAGFKPDKFC)
			{
				LocalBuilder localBuilder = null;
				if (!isSideEffectFreeType)
				{
					localBuilder = il.DeclareLocal(type);
				}
				if (info.NOECADOFLINBMAHPKL != null)
				{
					GMPKOFIBGBNJPLELDP[] constructorParameters = info.LAIICILJOEOLHINKFE;
					for (int i = 0; i < constructorParameters.Length; i++)
					{
						GMPKOFIBGBNJPLELDP item = constructorParameters[i];
						POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK necpehkcdinkmdhcbk = members.First((POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK x) => x.MemberInfo == item);
						il.EmitLdloc(necpehkcdinkmdhcbk.LocalField);
					}
					il.Emit(OpCodes.Newobj, info.NOECADOFLINBMAHPKL);
				}
				else
				{
					il.Emit(OpCodes.Ldtoken, type);
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetTypeFromHandle);
					il.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetUninitializedObject);
				}
				if (!isSideEffectFreeType)
				{
					il.EmitStloc(localBuilder);
				}
				foreach (POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK necpehkcdinkmdhcbk2 in from x in members
				where x.MemberInfo != null && x.MemberInfo.NCJDJAJEIKHAIBPJBG
				select x)
				{
					if (isSideEffectFreeType)
					{
						il.Emit(OpCodes.Dup);
						il.EmitLdloc(necpehkcdinkmdhcbk2.LocalField);
						necpehkcdinkmdhcbk2.MemberInfo.EmitStoreValue(il);
					}
					else
					{
						Label label = il.DefineLabel();
						il.EmitLdloc(necpehkcdinkmdhcbk2.IsDeserializedField);
						il.Emit(OpCodes.Brfalse, label);
						il.EmitLdloc(localBuilder);
						il.EmitLdloc(necpehkcdinkmdhcbk2.LocalField);
						necpehkcdinkmdhcbk2.MemberInfo.EmitStoreValue(il);
						il.MarkLabel(label);
					}
				}
				return localBuilder;
			}
			LocalBuilder localBuilder2 = il.DeclareLocal(type);
			if (info.NOECADOFLINBMAHPKL == null)
			{
				il.Emit(OpCodes.Ldloca, localBuilder2);
				il.Emit(OpCodes.Initobj, type);
			}
			else
			{
				GMPKOFIBGBNJPLELDP[] constructorParameters = info.LAIICILJOEOLHINKFE;
				for (int i = 0; i < constructorParameters.Length; i++)
				{
					GMPKOFIBGBNJPLELDP item = constructorParameters[i];
					POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK necpehkcdinkmdhcbk3 = members.First((POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK x) => x.MemberInfo == item);
					il.EmitLdloc(necpehkcdinkmdhcbk3.LocalField);
				}
				il.Emit(OpCodes.Newobj, info.NOECADOFLINBMAHPKL);
				il.Emit(OpCodes.Stloc, localBuilder2);
			}
			foreach (POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK necpehkcdinkmdhcbk4 in from x in members
			where x.MemberInfo != null && x.MemberInfo.NCJDJAJEIKHAIBPJBG
			select x)
			{
				if (isSideEffectFreeType)
				{
					il.EmitLdloca(localBuilder2);
					il.EmitLdloc(necpehkcdinkmdhcbk4.LocalField);
					necpehkcdinkmdhcbk4.MemberInfo.EmitStoreValue(il);
				}
				else
				{
					Label label2 = il.DefineLabel();
					il.EmitLdloc(necpehkcdinkmdhcbk4.IsDeserializedField);
					il.Emit(OpCodes.Brfalse, label2);
					il.EmitLdloca(localBuilder2);
					il.EmitLdloc(necpehkcdinkmdhcbk4.LocalField);
					necpehkcdinkmdhcbk4.MemberInfo.EmitStoreValue(il);
					il.MarkLabel(label2);
				}
			}
			return localBuilder2;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		private static bool IsSideEffectFreeConstructorType(ConstructorInfo ctorInfo)
		{
			MethodBody methodBody = ctorInfo.GetMethodBody();
			if (methodBody == null)
			{
				return false;
			}
			byte[] ilasByteArray = methodBody.GetILAsByteArray();
			if (ilasByteArray == null)
			{
				return false;
			}
			List<OpCode> list = new List<OpCode>();
			using (NBNDJGENFIKGKIHENM nbndjgenfikgkihenm = new NBNDJGENFIKGKIHENM(ilasByteArray))
			{
				while (!nbndjgenfikgkihenm.BNNOHNHANGEKHHKJCL)
				{
					OpCode opCode = nbndjgenfikgkihenm.ReadOpCode();
					if (opCode != OpCodes.Nop && opCode != OpCodes.Ldloc_0 && opCode != OpCodes.Ldloc_S && opCode != OpCodes.Stloc_0 && opCode != OpCodes.Stloc_S && opCode != OpCodes.Blt && opCode != OpCodes.Blt_S && opCode != OpCodes.Bgt && opCode != OpCodes.Bgt_S)
					{
						list.Add(opCode);
						if (list.Count == 4)
						{
							break;
						}
					}
				}
			}
			if (list.Count != 3 || !(list[0] == OpCodes.Ldarg_0) || !(list[1] == OpCodes.Call) || !(list[2] == OpCodes.Ret))
			{
				return false;
			}
			if (ctorInfo.DeclaringType.BaseType == typeof(object))
			{
				return true;
			}
			ConstructorInfo constructor = ctorInfo.DeclaringType.BaseType.GetConstructor(Type.EmptyTypes);
			return !(constructor == null) && POKNKMIEJNDGDMNHJH.IsSideEffectFreeConstructorType(constructor);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000C044 File Offset: 0x0000A244
		private static bool TryGetInterfaceEnumerableElementType(Type type, out Type elementType)
		{
			foreach (Type type2 in type.GetInterfaces())
			{
				if (type2.IsGenericType && type2.GetGenericTypeDefinition() == typeof(IEnumerable<>))
				{
					Type[] genericArguments = type2.GetGenericArguments();
					elementType = genericArguments[0];
					return true;
				}
			}
			elementType = null;
			return false;
		}

		// Token: 0x040000A0 RID: 160
		private static readonly Regex SubtractFullNameRegex = new Regex(", Version=\\d+.\\d+.\\d+.\\d+, Culture=\\w+, PublicKeyToken=\\w+");

		// Token: 0x040000A1 RID: 161
		private static int nameSequence = 0;

		// Token: 0x040000A2 RID: 162
		private static HashSet<Type> ignoreTypes = new HashSet<Type>
		{
			typeof(object),
			typeof(short),
			typeof(int),
			typeof(long),
			typeof(ushort),
			typeof(uint),
			typeof(ulong),
			typeof(float),
			typeof(double),
			typeof(bool),
			typeof(byte),
			typeof(sbyte),
			typeof(decimal),
			typeof(char),
			typeof(string),
			typeof(Guid),
			typeof(TimeSpan),
			typeof(DateTime),
			typeof(DateTimeOffset)
		};

		// Token: 0x040000A3 RID: 163
		private static HashSet<Type> jsonPrimitiveTypes = new HashSet<Type>
		{
			typeof(short),
			typeof(int),
			typeof(long),
			typeof(ushort),
			typeof(uint),
			typeof(ulong),
			typeof(float),
			typeof(double),
			typeof(bool),
			typeof(byte),
			typeof(sbyte),
			typeof(string)
		};

		// Token: 0x02000046 RID: 70
		private struct NECPEHKCDINKMDHCBK
		{
			// Token: 0x040000A4 RID: 164
			public GMPKOFIBGBNJPLELDP MemberInfo;

			// Token: 0x040000A5 RID: 165
			public LocalBuilder LocalField;

			// Token: 0x040000A6 RID: 166
			public LocalBuilder IsDeserializedField;
		}

		// Token: 0x02000047 RID: 71
		internal static class JPLGOJLHLKKLGGMCIM
		{
			// Token: 0x06000142 RID: 322 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
			public static MethodInfo Serialize(Type type)
			{
				return typeof(FLGKBGGCEAHKIBEKBN<>).MakeGenericType(new Type[]
				{
					type
				}).GetRuntimeMethod("Serialize", new Type[]
				{
					typeof(BJLLMLPIIIPIEPLCJH).MakeByRefType(),
					type,
					typeof(LMCMANMFGJGJFPNBEN)
				});
			}

			// Token: 0x06000143 RID: 323 RVA: 0x0000C340 File Offset: 0x0000A540
			public static MethodInfo Deserialize(Type type)
			{
				return typeof(FLGKBGGCEAHKIBEKBN<>).MakeGenericType(new Type[]
				{
					type
				}).GetRuntimeMethod("Deserialize", new Type[]
				{
					typeof(BPIPCPJELFMIKDNCFG).MakeByRefType(),
					typeof(LMCMANMFGJGJFPNBEN)
				});
			}

			// Token: 0x06000144 RID: 324 RVA: 0x0000335F File Offset: 0x0000155F
			public static MethodInfo GetNullableHasValue(Type type)
			{
				return typeof(Nullable<>).MakeGenericType(new Type[]
				{
					type
				}).GetRuntimeProperty("HasValue").GetGetMethod();
			}

			// Token: 0x06000145 RID: 325 RVA: 0x0000C398 File Offset: 0x0000A598
			// Note: this type is marked as 'beforefieldinit'.
			static JPLGOJLHLKKLGGMCIM()
			{
				ParameterExpression parameterExpression;
				POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GetTypeMethod = HAGIHFGIGMOBLEDDGC.GetMethodInfo<object, Type>(Expression.Lambda<Func<object, Type>>(Expression.Call(parameterExpression, methodof(object.GetType()), Array.Empty<Expression>()), new ParameterExpression[]
				{
					parameterExpression
				}));
				POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.TypeEquals = HAGIHFGIGMOBLEDDGC.GetMethodInfo<Type, bool>((Type t) => t.Equals(null));
				POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.NongenericSerialize = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BJLLMLPIIIPIEPLCJH>((BJLLMLPIIIPIEPLCJH writer) => CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(null, writer, null, null));
			}

			// Token: 0x040000A7 RID: 167
			public static readonly ConstructorInfo ObjectCtor = typeof(object).GetTypeInfo().DeclaredConstructors.First((ConstructorInfo x) => x.GetParameters().Length == 0);

			// Token: 0x040000A8 RID: 168
			public static readonly MethodInfo GetFormatterWithVerify = typeof(PMCLMDICJEBPLHOBNK).GetRuntimeMethod("GetFormatterWithVerify", new Type[]
			{
				typeof(LMCMANMFGJGJFPNBEN)
			});

			// Token: 0x040000A9 RID: 169
			public static readonly ConstructorInfo InvalidOperationExceptionConstructor = typeof(InvalidOperationException).GetTypeInfo().DeclaredConstructors.First(delegate(ConstructorInfo x)
			{
				ParameterInfo[] parameters = x.GetParameters();
				return parameters.Length == 1 && parameters[0].ParameterType == typeof(string);
			});

			// Token: 0x040000AA RID: 170
			public static readonly MethodInfo GetTypeFromHandle = HAGIHFGIGMOBLEDDGC.GetMethodInfo<Type>(Expression.Lambda<Func<Type>>(Expression.Call(null, methodof(Type.GetTypeFromHandle(RuntimeTypeHandle)), new Expression[]
			{
				Expression.Constant(default(RuntimeTypeHandle), typeof(RuntimeTypeHandle))
			}), Array.Empty<ParameterExpression>()));

			// Token: 0x040000AB RID: 171
			public static readonly MethodInfo TypeGetProperty = HAGIHFGIGMOBLEDDGC.GetMethodInfo<Type, PropertyInfo>((Type t) => t.GetProperty(null, BindingFlags.Default));

			// Token: 0x040000AC RID: 172
			public static readonly MethodInfo TypeGetField = HAGIHFGIGMOBLEDDGC.GetMethodInfo<Type, FieldInfo>((Type t) => t.GetField(null, BindingFlags.Default));

			// Token: 0x040000AD RID: 173
			public static readonly MethodInfo GetCustomAttributeJsonFormatterAttribute = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BHBMDGIJKJJJKFJCIF>(Expression.Lambda<Func<BHBMDGIJKJJJKFJCIF>>(Expression.Call(null, methodof(MemberInfo.GetCustomAttribute(bool)), new Expression[]
			{
				Expression.Constant(null, typeof(MemberInfo)),
				Expression.Constant(false, typeof(bool))
			}), Array.Empty<ParameterExpression>()));

			// Token: 0x040000AE RID: 174
			public static readonly MethodInfo ActivatorCreateInstance = HAGIHFGIGMOBLEDDGC.GetMethodInfo<object>(Expression.Lambda<Func<object>>(Expression.Call(null, methodof(Activator.CreateInstance(Type, object[])), new Expression[]
			{
				Expression.Constant(null, typeof(Type)),
				Expression.Constant(null, typeof(object[]))
			}), Array.Empty<ParameterExpression>()));

			// Token: 0x040000AF RID: 175
			public static readonly MethodInfo GetUninitializedObject = HAGIHFGIGMOBLEDDGC.GetMethodInfo<object>(Expression.Lambda<Func<object>>(Expression.Call(null, methodof(FormatterServices.GetUninitializedObject(Type)), new Expression[]
			{
				Expression.Constant(null, typeof(Type))
			}), Array.Empty<ParameterExpression>()));

			// Token: 0x040000B0 RID: 176
			public static readonly MethodInfo GetTypeMethod;

			// Token: 0x040000B1 RID: 177
			public static readonly MethodInfo TypeEquals;

			// Token: 0x040000B2 RID: 178
			public static readonly MethodInfo NongenericSerialize;

			// Token: 0x02000048 RID: 72
			internal static class HEACPIGGFHLKLBDJJK
			{
				// Token: 0x06000146 RID: 326 RVA: 0x0000C780 File Offset: 0x0000A980
				static HEACPIGGFHLKLBDJJK()
				{
					ParameterExpression parameterExpression;
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteNull = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BJLLMLPIIIPIEPLCJH>(Expression.Lambda<Action<BJLLMLPIIIPIEPLCJH>>(Expression.Call(parameterExpression, methodof(BJLLMLPIIIPIEPLCJH.WriteNull()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression
					}));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteRaw = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BJLLMLPIIIPIEPLCJH>((BJLLMLPIIIPIEPLCJH writer) => writer.WriteRaw(null));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteBeginObject = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BJLLMLPIIIPIEPLCJH>(Expression.Lambda<Action<BJLLMLPIIIPIEPLCJH>>(Expression.Call(parameterExpression, methodof(BJLLMLPIIIPIEPLCJH.WriteBeginObject()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression
					}));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteEndObject = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BJLLMLPIIIPIEPLCJH>(Expression.Lambda<Action<BJLLMLPIIIPIEPLCJH>>(Expression.Call(parameterExpression, methodof(BJLLMLPIIIPIEPLCJH.WriteEndObject()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression
					}));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.WriteValueSeparator = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BJLLMLPIIIPIEPLCJH>(Expression.Lambda<Action<BJLLMLPIIIPIEPLCJH>>(Expression.Call(parameterExpression, methodof(BJLLMLPIIIPIEPLCJH.WriteValueSeparator()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression
					}));
				}

				// Token: 0x040000B3 RID: 179
				public static readonly MethodInfo GetEncodedPropertyNameWithBeginObject = HAGIHFGIGMOBLEDDGC.GetMethodInfo<byte[]>(Expression.Lambda<Func<byte[]>>(Expression.Call(null, methodof(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyNameWithBeginObject(string)), new Expression[]
				{
					Expression.Constant(null, typeof(string))
				}), Array.Empty<ParameterExpression>()));

				// Token: 0x040000B4 RID: 180
				public static readonly MethodInfo GetEncodedPropertyNameWithPrefixValueSeparator = HAGIHFGIGMOBLEDDGC.GetMethodInfo<byte[]>(Expression.Lambda<Func<byte[]>>(Expression.Call(null, methodof(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyNameWithPrefixValueSeparator(string)), new Expression[]
				{
					Expression.Constant(null, typeof(string))
				}), Array.Empty<ParameterExpression>()));

				// Token: 0x040000B5 RID: 181
				public static readonly MethodInfo GetEncodedPropertyNameWithoutQuotation = HAGIHFGIGMOBLEDDGC.GetMethodInfo<byte[]>(Expression.Lambda<Func<byte[]>>(Expression.Call(null, methodof(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyNameWithoutQuotation(string)), new Expression[]
				{
					Expression.Constant(null, typeof(string))
				}), Array.Empty<ParameterExpression>()));

				// Token: 0x040000B6 RID: 182
				public static readonly MethodInfo GetEncodedPropertyName = HAGIHFGIGMOBLEDDGC.GetMethodInfo<byte[]>(Expression.Lambda<Func<byte[]>>(Expression.Call(null, methodof(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyName(string)), new Expression[]
				{
					Expression.Constant(null, typeof(string))
				}), Array.Empty<ParameterExpression>()));

				// Token: 0x040000B7 RID: 183
				public static readonly MethodInfo WriteNull;

				// Token: 0x040000B8 RID: 184
				public static readonly MethodInfo WriteRaw;

				// Token: 0x040000B9 RID: 185
				public static readonly MethodInfo WriteBeginObject;

				// Token: 0x040000BA RID: 186
				public static readonly MethodInfo WriteEndObject;

				// Token: 0x040000BB RID: 187
				public static readonly MethodInfo WriteValueSeparator;

				// Token: 0x02000049 RID: 73
				[CompilerGenerated]
				[Serializable]
				private sealed class OEPFDLMJIHPKKDCNHO
				{
					// Token: 0x040000BC RID: 188
					public static readonly POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.OEPFDLMJIHPKKDCNHO <>9 = new POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HEACPIGGFHLKLBDJJK.OEPFDLMJIHPKKDCNHO();
				}
			}

			// Token: 0x0200004A RID: 74
			internal static class COFCNKEGDNDCGELGDI
			{
				// Token: 0x06000149 RID: 329 RVA: 0x0000CA14 File Offset: 0x0000AC14
				static COFCNKEGDNDCGELGDI()
				{
					ParameterExpression parameterExpression;
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadIsNull = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BPIPCPJELFMIKDNCFG, bool>(Expression.Lambda<Func<BPIPCPJELFMIKDNCFG, bool>>(Expression.Call(parameterExpression, methodof(BPIPCPJELFMIKDNCFG.ReadIsNull()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression
					}));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadIsBeginObjectWithVerify = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BPIPCPJELFMIKDNCFG>(Expression.Lambda<Action<BPIPCPJELFMIKDNCFG>>(Expression.Call(parameterExpression, methodof(BPIPCPJELFMIKDNCFG.ReadIsBeginObjectWithVerify()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression
					}));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadIsEndObjectWithSkipValueSeparator = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BPIPCPJELFMIKDNCFG, int, bool>((BPIPCPJELFMIKDNCFG reader, int count) => reader.ReadIsEndObjectWithSkipValueSeparator(count));
					ParameterExpression parameterExpression2;
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadPropertyNameSegmentUnsafe = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BPIPCPJELFMIKDNCFG, ArraySegment<byte>>(Expression.Lambda<Func<BPIPCPJELFMIKDNCFG, ArraySegment<byte>>>(Expression.Call(parameterExpression2, methodof(BPIPCPJELFMIKDNCFG.ReadPropertyNameSegmentRaw()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression2
					}));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.ReadNextBlock = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BPIPCPJELFMIKDNCFG>(Expression.Lambda<Action<BPIPCPJELFMIKDNCFG>>(Expression.Call(parameterExpression2, methodof(BPIPCPJELFMIKDNCFG.ReadNextBlock()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression2
					}));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.GetBufferUnsafe = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BPIPCPJELFMIKDNCFG, byte[]>(Expression.Lambda<Func<BPIPCPJELFMIKDNCFG, byte[]>>(Expression.Call(parameterExpression2, methodof(BPIPCPJELFMIKDNCFG.GetBufferUnsafe()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression2
					}));
					POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.GetCurrentOffsetUnsafe = HAGIHFGIGMOBLEDDGC.GetMethodInfo<BPIPCPJELFMIKDNCFG, int>(Expression.Lambda<Func<BPIPCPJELFMIKDNCFG, int>>(Expression.Call(parameterExpression2, methodof(BPIPCPJELFMIKDNCFG.GetCurrentOffsetUnsafe()), Array.Empty<Expression>()), new ParameterExpression[]
					{
						parameterExpression2
					}));
				}

				// Token: 0x040000BD RID: 189
				public static readonly MethodInfo ReadIsNull;

				// Token: 0x040000BE RID: 190
				public static readonly MethodInfo ReadIsBeginObjectWithVerify;

				// Token: 0x040000BF RID: 191
				public static readonly MethodInfo ReadIsEndObjectWithSkipValueSeparator;

				// Token: 0x040000C0 RID: 192
				public static readonly MethodInfo ReadPropertyNameSegmentUnsafe;

				// Token: 0x040000C1 RID: 193
				public static readonly MethodInfo ReadNextBlock;

				// Token: 0x040000C2 RID: 194
				public static readonly MethodInfo GetBufferUnsafe;

				// Token: 0x040000C3 RID: 195
				public static readonly MethodInfo GetCurrentOffsetUnsafe;

				// Token: 0x0200004B RID: 75
				[CompilerGenerated]
				[Serializable]
				private sealed class LBBBGFEKNHJNFKGEON
				{
					// Token: 0x040000C4 RID: 196
					public static readonly POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.LBBBGFEKNHJNFKGEON <>9 = new POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.COFCNKEGDNDCGELGDI.LBBBGFEKNHJNFKGEON();
				}
			}

			// Token: 0x0200004C RID: 76
			internal static class HKEMLLMGACFEPJPDJI
			{
				// Token: 0x040000C5 RID: 197
				internal static readonly MethodInfo FormatterType = HAGIHFGIGMOBLEDDGC.GetPropertyInfo<BHBMDGIJKJJJKFJCIF, Type>((BHBMDGIJKJJJKFJCIF attr) => attr.FormatterType).GetGetMethod();

				// Token: 0x040000C6 RID: 198
				internal static readonly MethodInfo Arguments = HAGIHFGIGMOBLEDDGC.GetPropertyInfo<BHBMDGIJKJJJKFJCIF, object[]>((BHBMDGIJKJJJKFJCIF attr) => attr.Arguments).GetGetMethod();

				// Token: 0x0200004D RID: 77
				[CompilerGenerated]
				[Serializable]
				private sealed class PNCFBODJKKLAHPIHGF
				{
					// Token: 0x040000C7 RID: 199
					public static readonly POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HKEMLLMGACFEPJPDJI.PNCFBODJKKLAHPIHGF <>9 = new POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.HKEMLLMGACFEPJPDJI.PNCFBODJKKLAHPIHGF();
				}
			}

			// Token: 0x0200004E RID: 78
			[CompilerGenerated]
			[Serializable]
			private sealed class GMHCKHMIPOFOIBANDF
			{
				// Token: 0x06000151 RID: 337 RVA: 0x00002F37 File Offset: 0x00001137
				internal bool <.cctor>b__18_0(ConstructorInfo x)
				{
					return x.GetParameters().Length == 0;
				}

				// Token: 0x06000152 RID: 338 RVA: 0x0000CCD8 File Offset: 0x0000AED8
				internal bool <.cctor>b__18_1(ConstructorInfo x)
				{
					ParameterInfo[] parameters = x.GetParameters();
					return parameters.Length == 1 && parameters[0].ParameterType == typeof(string);
				}

				// Token: 0x040000C8 RID: 200
				public static readonly POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GMHCKHMIPOFOIBANDF <>9 = new POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.GMHCKHMIPOFOIBANDF();
			}
		}

		// Token: 0x0200004F RID: 79
		internal class JCKMHPOKHEGMBLKNFC : Exception
		{
			// Token: 0x06000153 RID: 339 RVA: 0x000023F0 File Offset: 0x000005F0
			public JCKMHPOKHEGMBLKNFC(string message) : base(message)
			{
			}
		}

		// Token: 0x02000050 RID: 80
		[CompilerGenerated]
		[Serializable]
		private sealed class ELMEPENNPINPIOPJBA
		{
			// Token: 0x06000156 RID: 342 RVA: 0x000033C5 File Offset: 0x000015C5
			internal bool <BuildType>b__6_0(GMPKOFIBGBNJPLELDP x)
			{
				return x.NJEMFCEBFFHHOGPKMH != null;
			}

			// Token: 0x06000157 RID: 343 RVA: 0x000033C5 File Offset: 0x000015C5
			internal bool <BuildAnonymousFormatter>b__7_0(GMPKOFIBGBNJPLELDP x)
			{
				return x.NJEMFCEBFFHHOGPKMH != null;
			}

			// Token: 0x06000158 RID: 344 RVA: 0x000033D3 File Offset: 0x000015D3
			internal bool <BuildAnonymousFormatter>b__7_3(GMPKOFIBGBNJPLELDP x)
			{
				return x.EAKBJPKGFOKCEHFJJD;
			}

			// Token: 0x06000159 RID: 345 RVA: 0x000033D3 File Offset: 0x000015D3
			internal bool <BuildAnonymousFormatter>b__7_4(GMPKOFIBGBNJPLELDP x)
			{
				return x.EAKBJPKGFOKCEHFJJD;
			}

			// Token: 0x0600015A RID: 346 RVA: 0x000033D3 File Offset: 0x000015D3
			internal bool <BuildConstructor>b__8_0(GMPKOFIBGBNJPLELDP x)
			{
				return x.EAKBJPKGFOKCEHFJJD;
			}

			// Token: 0x0600015B RID: 347 RVA: 0x000033D3 File Offset: 0x000015D3
			internal bool <BuildConstructor>b__8_1(GMPKOFIBGBNJPLELDP x)
			{
				return x.EAKBJPKGFOKCEHFJJD;
			}

			// Token: 0x0600015C RID: 348 RVA: 0x000033DB File Offset: 0x000015DB
			internal bool <BuildCustomFormatterField>b__9_0(GMPKOFIBGBNJPLELDP x)
			{
				return x.EAKBJPKGFOKCEHFJJD || x.NCJDJAJEIKHAIBPJBG;
			}

			// Token: 0x0600015D RID: 349 RVA: 0x000033D3 File Offset: 0x000015D3
			internal bool <BuildSerialize>b__10_0(GMPKOFIBGBNJPLELDP x)
			{
				return x.EAKBJPKGFOKCEHFJJD;
			}

			// Token: 0x0600015E RID: 350 RVA: 0x000033D3 File Offset: 0x000015D3
			internal bool <BuildSerialize>b__10_2(GMPKOFIBGBNJPLELDP x)
			{
				return x.EAKBJPKGFOKCEHFJJD;
			}

			// Token: 0x0600015F RID: 351 RVA: 0x000033ED File Offset: 0x000015ED
			internal int <EmitSerializeValue>b__11_0(MethodInfo x)
			{
				return x.GetParameters().Length;
			}

			// Token: 0x06000160 RID: 352 RVA: 0x000033F7 File Offset: 0x000015F7
			internal bool <BuildDeserialize>b__12_1(GMPKOFIBGBNJPLELDP x)
			{
				return !x.EAKBJPKGFOKCEHFJJD && x.NCJDJAJEIKHAIBPJBG;
			}

			// Token: 0x06000161 RID: 353 RVA: 0x000033ED File Offset: 0x000015ED
			internal int <EmitDeserializeValue>b__13_0(MethodInfo x)
			{
				return x.GetParameters().Length;
			}

			// Token: 0x06000162 RID: 354 RVA: 0x00003409 File Offset: 0x00001609
			internal bool <EmitNewObject>b__14_1(POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK x)
			{
				return x.MemberInfo != null && x.MemberInfo.NCJDJAJEIKHAIBPJBG;
			}

			// Token: 0x06000163 RID: 355 RVA: 0x00003409 File Offset: 0x00001609
			internal bool <EmitNewObject>b__14_3(POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK x)
			{
				return x.MemberInfo != null && x.MemberInfo.NCJDJAJEIKHAIBPJBG;
			}

			// Token: 0x040000C9 RID: 201
			public static readonly POKNKMIEJNDGDMNHJH.ELMEPENNPINPIOPJBA <>9 = new POKNKMIEJNDGDMNHJH.ELMEPENNPINPIOPJBA();

			// Token: 0x040000CA RID: 202
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__6_0;

			// Token: 0x040000CB RID: 203
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__7_0;

			// Token: 0x040000CC RID: 204
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__7_3;

			// Token: 0x040000CD RID: 205
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__7_4;

			// Token: 0x040000CE RID: 206
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__8_0;

			// Token: 0x040000CF RID: 207
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__8_1;

			// Token: 0x040000D0 RID: 208
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__9_0;

			// Token: 0x040000D1 RID: 209
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__10_0;

			// Token: 0x040000D2 RID: 210
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__10_2;

			// Token: 0x040000D3 RID: 211
			public static Func<MethodInfo, int> <>9__11_0;

			// Token: 0x040000D4 RID: 212
			public static Func<GMPKOFIBGBNJPLELDP, bool> <>9__12_1;

			// Token: 0x040000D5 RID: 213
			public static Func<MethodInfo, int> <>9__13_0;

			// Token: 0x040000D6 RID: 214
			public static Func<POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK, bool> <>9__14_1;

			// Token: 0x040000D7 RID: 215
			public static Func<POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK, bool> <>9__14_3;
		}

		// Token: 0x02000051 RID: 81
		[CompilerGenerated]
		private sealed class KBCBNKDGDCKKKEDPNK
		{
			// Token: 0x06000165 RID: 357 RVA: 0x00003420 File Offset: 0x00001620
			internal Label <BuildSerialize>b__1(GMPKOFIBGBNJPLELDP _)
			{
				return this.il.DefineLabel();
			}

			// Token: 0x040000D8 RID: 216
			public ILGenerator il;
		}

		// Token: 0x02000052 RID: 82
		[CompilerGenerated]
		private sealed class JDLEJNGOFKOFABDNAK
		{
			// Token: 0x06000167 RID: 359 RVA: 0x0000CD0C File Offset: 0x0000AF0C
			internal POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK <BuildDeserialize>b__0(GMPKOFIBGBNJPLELDP item)
			{
				return new POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK
				{
					MemberInfo = item,
					LocalField = this.il.DeclareLocal(item.ADADCDGIIONHFKEJOC),
					IsDeserializedField = (this.isSideEffectFreeType ? null : this.il.DeclareLocal(typeof(bool)))
				};
			}

			// Token: 0x040000D9 RID: 217
			public ILGenerator il;

			// Token: 0x040000DA RID: 218
			public bool isSideEffectFreeType;

			// Token: 0x040000DB RID: 219
			public POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK[] infoList;

			// Token: 0x040000DC RID: 220
			public Func<int, GMPKOFIBGBNJPLELDP, bool> tryEmitLoadCustomFormatter;

			// Token: 0x040000DD RID: 221
			public GGLNGMDCNHOEAJHKOG argReader;

			// Token: 0x040000DE RID: 222
			public GGLNGMDCNHOEAJHKOG argResolver;
		}

		// Token: 0x02000053 RID: 83
		[CompilerGenerated]
		private sealed class HINGBOANJDOEGNNDCC
		{
			// Token: 0x06000169 RID: 361 RVA: 0x0000CD6C File Offset: 0x0000AF6C
			internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
			{
				int value = x.Value;
				if (this.CS$<>8__locals1.infoList[value].MemberInfo != null)
				{
					POKNKMIEJNDGDMNHJH.EmitDeserializeValue(this.CS$<>8__locals1.il, this.CS$<>8__locals1.infoList[value], value, this.CS$<>8__locals1.tryEmitLoadCustomFormatter, this.CS$<>8__locals1.argReader, this.CS$<>8__locals1.argResolver);
					if (!this.CS$<>8__locals1.isSideEffectFreeType)
					{
						this.CS$<>8__locals1.il.EmitTrue();
						this.CS$<>8__locals1.il.EmitStloc(this.CS$<>8__locals1.infoList[value].IsDeserializedField);
					}
					this.CS$<>8__locals1.il.Emit(OpCodes.Br, this.continueWhile);
					return;
				}
				this.CS$<>8__locals1.il.Emit(OpCodes.Br, this.readNext);
			}

			// Token: 0x0600016A RID: 362 RVA: 0x0000342D File Offset: 0x0000162D
			internal void <BuildDeserialize>b__3()
			{
				this.CS$<>8__locals1.il.Emit(OpCodes.Br, this.readNext);
			}

			// Token: 0x040000DF RID: 223
			public Label continueWhile;

			// Token: 0x040000E0 RID: 224
			public Label readNext;

			// Token: 0x040000E1 RID: 225
			public POKNKMIEJNDGDMNHJH.JDLEJNGOFKOFABDNAK CS$<>8__locals1;
		}

		// Token: 0x02000054 RID: 84
		[CompilerGenerated]
		private sealed class LLHNEIDKMOFADDBENE
		{
			// Token: 0x0600016C RID: 364 RVA: 0x0000344A File Offset: 0x0000164A
			internal bool <EmitNewObject>b__0(POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK x)
			{
				return x.MemberInfo == this.item;
			}

			// Token: 0x040000E2 RID: 226
			public GMPKOFIBGBNJPLELDP item;
		}

		// Token: 0x02000055 RID: 85
		[CompilerGenerated]
		private sealed class HJBLLKIMOMCGHICGJA
		{
			// Token: 0x0600016E RID: 366 RVA: 0x0000345A File Offset: 0x0000165A
			internal bool <EmitNewObject>b__2(POKNKMIEJNDGDMNHJH.NECPEHKCDINKMDHCBK x)
			{
				return x.MemberInfo == this.item;
			}

			// Token: 0x040000E3 RID: 227
			public GMPKOFIBGBNJPLELDP item;
		}

		// Token: 0x02000056 RID: 86
		[CompilerGenerated]
		private sealed class CBDKNPKHDDOFGHHCKH
		{
			// Token: 0x040000E4 RID: 228
			public FieldBuilder stringByteKeysField;

			// Token: 0x040000E5 RID: 229
			public Dictionary<GMPKOFIBGBNJPLELDP, FieldInfo> customFormatterLookup;
		}

		// Token: 0x02000057 RID: 87
		[CompilerGenerated]
		private sealed class PIPKDMJEGDOCOHNIHK
		{
			// Token: 0x06000171 RID: 369 RVA: 0x0000346A File Offset: 0x0000166A
			internal void <BuildType>b__1()
			{
				this.il.EmitLoadThis();
				this.il.EmitLdfld(this.CS$<>8__locals1.stringByteKeysField);
			}

			// Token: 0x06000172 RID: 370 RVA: 0x0000CE5C File Offset: 0x0000B05C
			internal bool <BuildType>b__2(int index, GMPKOFIBGBNJPLELDP member)
			{
				FieldInfo fieldInfo;
				if (!this.CS$<>8__locals1.customFormatterLookup.TryGetValue(member, out fieldInfo))
				{
					return false;
				}
				this.il.EmitLoadThis();
				this.il.EmitLdfld(fieldInfo);
				return true;
			}

			// Token: 0x040000E6 RID: 230
			public ILGenerator il;

			// Token: 0x040000E7 RID: 231
			public POKNKMIEJNDGDMNHJH.CBDKNPKHDDOFGHHCKH CS$<>8__locals1;
		}

		// Token: 0x02000058 RID: 88
		[CompilerGenerated]
		private sealed class EGBJJIBJHGDPNENPJH
		{
			// Token: 0x06000174 RID: 372 RVA: 0x0000CE98 File Offset: 0x0000B098
			internal bool <BuildType>b__3(int index, GMPKOFIBGBNJPLELDP member)
			{
				FieldInfo fieldInfo;
				if (!this.CS$<>8__locals2.customFormatterLookup.TryGetValue(member, out fieldInfo))
				{
					return false;
				}
				this.il.EmitLoadThis();
				this.il.EmitLdfld(fieldInfo);
				return true;
			}

			// Token: 0x040000E8 RID: 232
			public ILGenerator il;

			// Token: 0x040000E9 RID: 233
			public POKNKMIEJNDGDMNHJH.CBDKNPKHDDOFGHHCKH CS$<>8__locals2;
		}

		// Token: 0x02000059 RID: 89
		[CompilerGenerated]
		private sealed class GLJGICMAKKLLEDALFM
		{
			// Token: 0x06000176 RID: 374 RVA: 0x0000348D File Offset: 0x0000168D
			internal string <BuildAnonymousFormatter>b__1(string x)
			{
				return this.nameMutator(x);
			}

			// Token: 0x040000EA RID: 234
			public Func<string, string> nameMutator;

			// Token: 0x040000EB RID: 235
			public List<object> serializeCustomFormatters;

			// Token: 0x040000EC RID: 236
			public List<object> deserializeCustomFormatters;
		}

		// Token: 0x0200005A RID: 90
		[CompilerGenerated]
		private sealed class OBMAAJEDOAFABAEHPA
		{
			// Token: 0x06000178 RID: 376 RVA: 0x0000349B File Offset: 0x0000169B
			internal bool <BuildAnonymousFormatter>b__2(GMPKOFIBGBNJPLELDP x)
			{
				return !this.ignoreSet.Contains(x.LNKALLJDEAKLDIPONI);
			}

			// Token: 0x040000ED RID: 237
			public HashSet<string> ignoreSet;
		}

		// Token: 0x0200005B RID: 91
		[CompilerGenerated]
		private sealed class NOKPDNNCJINMGMMEAG
		{
			// Token: 0x0600017A RID: 378 RVA: 0x000034B1 File Offset: 0x000016B1
			internal void <BuildAnonymousFormatter>b__5()
			{
				this.il.EmitLdarg(0);
			}

			// Token: 0x0600017B RID: 379 RVA: 0x0000CED4 File Offset: 0x0000B0D4
			internal bool <BuildAnonymousFormatter>b__6(int index, GMPKOFIBGBNJPLELDP member)
			{
				if (this.CS$<>8__locals1.serializeCustomFormatters.Count == 0)
				{
					return false;
				}
				if (this.CS$<>8__locals1.serializeCustomFormatters[index] == null)
				{
					return false;
				}
				this.il.EmitLdarg(1);
				this.il.EmitLdc_I4(index);
				this.il.Emit(OpCodes.Ldelem_Ref);
				this.il.Emit(OpCodes.Castclass, this.CS$<>8__locals1.serializeCustomFormatters[index].GetType());
				return true;
			}

			// Token: 0x040000EE RID: 238
			public ILGenerator il;

			// Token: 0x040000EF RID: 239
			public POKNKMIEJNDGDMNHJH.GLJGICMAKKLLEDALFM CS$<>8__locals1;
		}

		// Token: 0x0200005C RID: 92
		[CompilerGenerated]
		private sealed class CHNOEODNGFJPKLDLID
		{
			// Token: 0x0600017D RID: 381 RVA: 0x0000CF5C File Offset: 0x0000B15C
			internal bool <BuildAnonymousFormatter>b__7(int index, GMPKOFIBGBNJPLELDP member)
			{
				if (this.CS$<>8__locals2.deserializeCustomFormatters.Count == 0)
				{
					return false;
				}
				if (this.CS$<>8__locals2.deserializeCustomFormatters[index] == null)
				{
					return false;
				}
				this.il.EmitLdarg(0);
				this.il.EmitLdc_I4(index);
				this.il.Emit(OpCodes.Ldelem_Ref);
				this.il.Emit(OpCodes.Castclass, this.CS$<>8__locals2.deserializeCustomFormatters[index].GetType());
				return true;
			}

			// Token: 0x040000F0 RID: 240
			public ILGenerator il;

			// Token: 0x040000F1 RID: 241
			public POKNKMIEJNDGDMNHJH.GLJGICMAKKLLEDALFM CS$<>8__locals2;
		}
	}
}

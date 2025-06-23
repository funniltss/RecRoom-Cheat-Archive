using System;
using System.Reflection;
using System.Reflection.Emit;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Resolvers
{
	// Token: 0x02000025 RID: 37
	public abstract class DOANHKOAOIHLFEJPCI : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00009670 File Offset: 0x00007870
		public static LMCMANMFGJGJFPNBEN Create(DDGADMMMOKKMDLNAEK[] formatters, LMCMANMFGJGJFPNBEN[] resolvers)
		{
			string str = Guid.NewGuid().ToString().Replace("-", "");
			TypeBuilder typeBuilder = DOANHKOAOIHLFEJPCI.assembly.DefineType("DynamicCompositeResolver_" + str, TypeAttributes.Public | TypeAttributes.Sealed, typeof(DOANHKOAOIHLFEJPCI));
			TypeBuilder typeBuilder2 = DOANHKOAOIHLFEJPCI.assembly.DefineType("DynamicCompositeResolverCache_" + str, TypeAttributes.Public | TypeAttributes.Sealed, null);
			GenericTypeParameterBuilder genericTypeParameterBuilder = typeBuilder2.DefineGenericParameters(new string[]
			{
				"T"
			})[0];
			FieldBuilder fieldInfo = typeBuilder.DefineField("instance", typeBuilder, FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.Static);
			FieldBuilder field = typeBuilder2.DefineField("formatter", typeof(FLGKBGGCEAHKIBEKBN<>).MakeGenericType(new Type[]
			{
				genericTypeParameterBuilder
			}), FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.Static);
			ILGenerator ilgenerator = typeBuilder2.DefineConstructor(MethodAttributes.Static, CallingConventions.Standard, Type.EmptyTypes).GetILGenerator();
			ilgenerator.EmitLdsfld(fieldInfo);
			ilgenerator.EmitCall(typeof(DOANHKOAOIHLFEJPCI).GetMethod("GetFormatterLoop").MakeGenericMethod(new Type[]
			{
				genericTypeParameterBuilder
			}));
			ilgenerator.Emit(OpCodes.Stsfld, field);
			ilgenerator.Emit(OpCodes.Ret);
			Type type = typeBuilder2.CreateTypeInfo().AsType();
			ILGenerator ilgenerator2 = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, new Type[]
			{
				typeof(DDGADMMMOKKMDLNAEK[]),
				typeof(LMCMANMFGJGJFPNBEN[])
			}).GetILGenerator();
			ilgenerator2.EmitLdarg(0);
			ilgenerator2.EmitLdarg(1);
			ilgenerator2.EmitLdarg(2);
			ilgenerator2.Emit(OpCodes.Call, typeof(DOANHKOAOIHLFEJPCI).GetConstructors()[0]);
			ilgenerator2.Emit(OpCodes.Ret);
			MethodBuilder methodBuilder = typeBuilder.DefineMethod("GetFormatter", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual);
			GenericTypeParameterBuilder genericTypeParameterBuilder2 = methodBuilder.DefineGenericParameters(new string[]
			{
				"T"
			})[0];
			methodBuilder.SetReturnType(typeof(FLGKBGGCEAHKIBEKBN<>).MakeGenericType(new Type[]
			{
				genericTypeParameterBuilder2
			}));
			ILGenerator ilgenerator3 = methodBuilder.GetILGenerator();
			FieldInfo field2 = TypeBuilder.GetField(type.MakeGenericType(new Type[]
			{
				genericTypeParameterBuilder2
			}), type.GetField("formatter", BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField));
			ilgenerator3.EmitLdsfld(field2);
			ilgenerator3.Emit(OpCodes.Ret);
			object obj = Activator.CreateInstance(typeBuilder.CreateTypeInfo().AsType(), new object[]
			{
				formatters,
				resolvers
			});
			obj.GetType().GetField("instance", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SetValue(null, obj);
			return (LMCMANMFGJGJFPNBEN)obj;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002E9C File Offset: 0x0000109C
		public DOANHKOAOIHLFEJPCI(DDGADMMMOKKMDLNAEK[] formatters, LMCMANMFGJGJFPNBEN[] resolvers)
		{
			this.formatters = formatters;
			this.resolvers = resolvers;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000098DC File Offset: 0x00007ADC
		public FLGKBGGCEAHKIBEKBN<JNIAIIIEKEBENBEIEK> GetFormatterLoop<JNIAIIIEKEBENBEIEK>()
		{
			foreach (DDGADMMMOKKMDLNAEK ddgadmmmokkmdlnaek in this.formatters)
			{
				foreach (Type type in ddgadmmmokkmdlnaek.GetType().GetTypeInfo().ImplementedInterfaces)
				{
					TypeInfo typeInfo = type.GetTypeInfo();
					if (typeInfo.IsGenericType && typeInfo.GenericTypeArguments[0] == typeof(JNIAIIIEKEBENBEIEK))
					{
						return (FLGKBGGCEAHKIBEKBN<JNIAIIIEKEBENBEIEK>)ddgadmmmokkmdlnaek;
					}
				}
			}
			LMCMANMFGJGJFPNBEN[] array2 = this.resolvers;
			for (int i = 0; i < array2.Length; i++)
			{
				FLGKBGGCEAHKIBEKBN<JNIAIIIEKEBENBEIEK> formatter = array2[i].GetFormatter<JNIAIIIEKEBENBEIEK>();
				if (formatter != null)
				{
					return formatter;
				}
			}
			return null;
		}

		// Token: 0x060000F1 RID: 241
		public abstract FLGKBGGCEAHKIBEKBN<T> GetFormatter<T>();

		// Token: 0x0400003C RID: 60
		private const string ModuleName = "Utf8Json.Resolvers.DynamicCompositeResolver";

		// Token: 0x0400003D RID: 61
		private static readonly DILDNPCNJDCNMBMPHO assembly = new DILDNPCNJDCNMBMPHO("Utf8Json.Resolvers.DynamicCompositeResolver");

		// Token: 0x0400003E RID: 62
		public readonly DDGADMMMOKKMDLNAEK[] formatters;

		// Token: 0x0400003F RID: 63
		public readonly LMCMANMFGJGJFPNBEN[] resolvers;
	}
}

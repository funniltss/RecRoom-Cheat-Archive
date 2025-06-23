using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;
using Utf8Json.Resolvers.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000F8 RID: 248
	public sealed class OPFOEFBJDEGNOONJBD : FLGKBGGCEAHKIBEKBN<object>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x0000517F File Offset: 0x0000337F
		public OPFOEFBJDEGNOONJBD(params LMCMANMFGJGJFPNBEN[] innerResolvers)
		{
			this.innerResolvers = innerResolvers;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00015F7C File Offset: 0x0001417C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			Type type = value.GetType();
			if (type == typeof(object))
			{
				writer.WriteBeginObject();
				writer.WriteEndObject();
				return;
			}
			KeyValuePair<object, OPFOEFBJDEGNOONJBD.GDIDGIMFIMPLPEILFH> value2;
			if (!this.serializers.TryGetValue(type, out value2))
			{
				AGIKLMFPEFJELOKJEB<KeyValuePair<object, OPFOEFBJDEGNOONJBD.GDIDGIMFIMPLPEILFH>> obj = this.serializers;
				lock (obj)
				{
					if (!this.serializers.TryGetValue(type, out value2))
					{
						object obj2 = null;
						LMCMANMFGJGJFPNBEN[] array = this.innerResolvers;
						for (int i = 0; i < array.Length; i++)
						{
							obj2 = array[i].GetFormatterDynamic(type);
							if (obj2 != null)
							{
								break;
							}
						}
						if (obj2 == null)
						{
							throw new NODLCKMOHBBPIMOOAB(type.FullName + " is not registered in this resolver. resolvers:" + string.Join(", ", (from x in this.innerResolvers
							select x.GetType().Name).ToArray<string>()));
						}
						Type type2 = type;
						DynamicMethod dynamicMethod = new DynamicMethod("Serialize", null, new Type[]
						{
							typeof(object),
							typeof(BJLLMLPIIIPIEPLCJH).MakeByRefType(),
							typeof(object),
							typeof(LMCMANMFGJGJFPNBEN)
						}, type.Module, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.EmitLdarg(0);
						ilgenerator.Emit(OpCodes.Castclass, typeof(FLGKBGGCEAHKIBEKBN<>).MakeGenericType(new Type[]
						{
							type2
						}));
						ilgenerator.EmitLdarg(1);
						ilgenerator.EmitLdarg(2);
						ilgenerator.EmitUnboxOrCast(type2);
						ilgenerator.EmitLdarg(3);
						ilgenerator.EmitCall(POKNKMIEJNDGDMNHJH.JPLGOJLHLKKLGGMCIM.Serialize(type2));
						ilgenerator.Emit(OpCodes.Ret);
						value2 = new KeyValuePair<object, OPFOEFBJDEGNOONJBD.GDIDGIMFIMPLPEILFH>(obj2, (OPFOEFBJDEGNOONJBD.GDIDGIMFIMPLPEILFH)dynamicMethod.CreateDelegate(typeof(OPFOEFBJDEGNOONJBD.GDIDGIMFIMPLPEILFH)));
						this.serializers.TryAdd(type2, value2);
					}
				}
			}
			value2.Value(value2.Key, ref writer, value, formatterResolver);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000519F File Offset: 0x0000339F
		public object Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			return HHFDIECAIMKGBGGJLB.Default.Deserialize(ref reader, formatterResolver);
		}

		// Token: 0x04000248 RID: 584
		private readonly AGIKLMFPEFJELOKJEB<KeyValuePair<object, OPFOEFBJDEGNOONJBD.GDIDGIMFIMPLPEILFH>> serializers = new AGIKLMFPEFJELOKJEB<KeyValuePair<object, OPFOEFBJDEGNOONJBD.GDIDGIMFIMPLPEILFH>>(4, 0.75f);

		// Token: 0x04000249 RID: 585
		private readonly LMCMANMFGJGJFPNBEN[] innerResolvers;

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x06000427 RID: 1063
		private delegate void GDIDGIMFIMPLPEILFH(object dynamicFormatter, ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN formatterResolver);

		// Token: 0x020000FA RID: 250
		[CompilerGenerated]
		[Serializable]
		private sealed class NHLNCPMOKFKPIIBFBN
		{
			// Token: 0x0600042C RID: 1068 RVA: 0x000051B9 File Offset: 0x000033B9
			internal string <Serialize>b__4_0(LMCMANMFGJGJFPNBEN x)
			{
				return x.GetType().Name;
			}

			// Token: 0x0400024A RID: 586
			public static readonly OPFOEFBJDEGNOONJBD.NHLNCPMOKFKPIIBFBN <>9 = new OPFOEFBJDEGNOONJBD.NHLNCPMOKFKPIIBFBN();

			// Token: 0x0400024B RID: 587
			public static Func<LMCMANMFGJGJFPNBEN, string> <>9__4_0;
		}
	}
}

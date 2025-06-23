using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Utf8Json.Internal
{
	// Token: 0x020000A7 RID: 167
	internal static class OBFBKBEIGKPFIDHCOK
	{
		// Token: 0x06000265 RID: 613 RVA: 0x0000413E File Offset: 0x0000233E
		public static bool IsNullable(this TypeInfo type)
		{
			return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000415F File Offset: 0x0000235F
		public static bool IsPublic(this TypeInfo type)
		{
			return type.IsPublic;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000FF10 File Offset: 0x0000E110
		public static bool IsAnonymous(this TypeInfo type)
		{
			return type.GetCustomAttribute<CompilerGeneratedAttribute>() != null && type.Name.Contains("AnonymousType") && (type.Name.StartsWith("<>") || type.Name.StartsWith("VB$")) && (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00004167 File Offset: 0x00002367
		public static IEnumerable<PropertyInfo> GetAllProperties(this Type type)
		{
			return OBFBKBEIGKPFIDHCOK.GetAllPropertiesCore(type, new HashSet<string>());
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00004174 File Offset: 0x00002374
		private static IEnumerable<PropertyInfo> GetAllPropertiesCore(Type type, HashSet<string> nameCheck)
		{
			foreach (PropertyInfo propertyInfo in type.GetRuntimeProperties())
			{
				if (nameCheck.Add(propertyInfo.Name))
				{
					yield return propertyInfo;
				}
			}
			IEnumerator<PropertyInfo> enumerator = null;
			if (type.BaseType != null)
			{
				foreach (PropertyInfo propertyInfo2 in OBFBKBEIGKPFIDHCOK.GetAllPropertiesCore(type.BaseType, nameCheck))
				{
					yield return propertyInfo2;
				}
				enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000418B File Offset: 0x0000238B
		public static IEnumerable<FieldInfo> GetAllFields(this Type type)
		{
			return OBFBKBEIGKPFIDHCOK.GetAllFieldsCore(type, new HashSet<string>());
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00004198 File Offset: 0x00002398
		private static IEnumerable<FieldInfo> GetAllFieldsCore(Type type, HashSet<string> nameCheck)
		{
			foreach (FieldInfo fieldInfo in type.GetRuntimeFields())
			{
				if (nameCheck.Add(fieldInfo.Name))
				{
					yield return fieldInfo;
				}
			}
			IEnumerator<FieldInfo> enumerator = null;
			if (type.BaseType != null)
			{
				foreach (FieldInfo fieldInfo2 in OBFBKBEIGKPFIDHCOK.GetAllFieldsCore(type.BaseType, nameCheck))
				{
					yield return fieldInfo2;
				}
				enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}

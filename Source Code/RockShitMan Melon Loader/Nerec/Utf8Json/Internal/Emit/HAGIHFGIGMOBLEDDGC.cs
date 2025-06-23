using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Utf8Json.Internal.Emit
{
	// Token: 0x020000B0 RID: 176
	internal static class HAGIHFGIGMOBLEDDGC
	{
		// Token: 0x06000297 RID: 663 RVA: 0x00004299 File Offset: 0x00002499
		private static MethodInfo GetMethodInfoCore(LambdaExpression expression)
		{
			if (expression == null)
			{
				throw new ArgumentNullException("expression");
			}
			return (expression.Body as MethodCallExpression).Method;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000042B9 File Offset: 0x000024B9
		public static MethodInfo GetMethodInfo<IFOCDBHBOOGIHOBJED>(Expression<Func<IFOCDBHBOOGIHOBJED>> expression)
		{
			return HAGIHFGIGMOBLEDDGC.GetMethodInfoCore(expression);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000042B9 File Offset: 0x000024B9
		public static MethodInfo GetMethodInfo(Expression<Action> expression)
		{
			return HAGIHFGIGMOBLEDDGC.GetMethodInfoCore(expression);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000042B9 File Offset: 0x000024B9
		public static MethodInfo GetMethodInfo<OBJNCJOJIGACLBLDCE, HEHDHCCPDDHJLFCHLG>(Expression<Func<OBJNCJOJIGACLBLDCE, HEHDHCCPDDHJLFCHLG>> expression)
		{
			return HAGIHFGIGMOBLEDDGC.GetMethodInfoCore(expression);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000042B9 File Offset: 0x000024B9
		public static MethodInfo GetMethodInfo<PJIMKHCDEGOHJNHJJH>(Expression<Action<PJIMKHCDEGOHJNHJJH>> expression)
		{
			return HAGIHFGIGMOBLEDDGC.GetMethodInfoCore(expression);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000042B9 File Offset: 0x000024B9
		public static MethodInfo GetMethodInfo<OCNFBDDKLFNBCOJEAF, ALKELGFJKPKAOCHGCL>(Expression<Action<OCNFBDDKLFNBCOJEAF, ALKELGFJKPKAOCHGCL>> expression)
		{
			return HAGIHFGIGMOBLEDDGC.GetMethodInfoCore(expression);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000042B9 File Offset: 0x000024B9
		public static MethodInfo GetMethodInfo<NPIAJFBFGDHNHPAHLD, OIAGOOCCPMDDDHANMP, HLBGBOOGJLJNIPHOGO>(Expression<Func<NPIAJFBFGDHNHPAHLD, OIAGOOCCPMDDDHANMP, HLBGBOOGJLJNIPHOGO>> expression)
		{
			return HAGIHFGIGMOBLEDDGC.GetMethodInfoCore(expression);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000042C1 File Offset: 0x000024C1
		private static MemberInfo GetMemberInfoCore<CANPOOIAFKFLJLMCDK>(Expression<CANPOOIAFKFLJLMCDK> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return (source.Body as MemberExpression).Member;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000042E1 File Offset: 0x000024E1
		public static PropertyInfo GetPropertyInfo<JCDAEJJMGGFKAMLFJB, ALMHKDDKDAGIJALBKD>(Expression<Func<JCDAEJJMGGFKAMLFJB, ALMHKDDKDAGIJALBKD>> expression)
		{
			return HAGIHFGIGMOBLEDDGC.GetMemberInfoCore<Func<JCDAEJJMGGFKAMLFJB, ALMHKDDKDAGIJALBKD>>(expression) as PropertyInfo;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000042EE File Offset: 0x000024EE
		public static FieldInfo GetFieldInfo<PCEPAOAEMHKGHDEAJG, HBMJEEIFKFEBIEKFOB>(Expression<Func<PCEPAOAEMHKGHDEAJG, HBMJEEIFKFEBIEKFOB>> expression)
		{
			return HAGIHFGIGMOBLEDDGC.GetMemberInfoCore<Func<PCEPAOAEMHKGHDEAJG, HBMJEEIFKFEBIEKFOB>>(expression) as FieldInfo;
		}
	}
}

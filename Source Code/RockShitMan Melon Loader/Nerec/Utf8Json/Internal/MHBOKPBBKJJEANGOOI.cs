using System;
using System.Text;

namespace Utf8Json.Internal
{
	// Token: 0x020000AB RID: 171
	internal static class MHBOKPBBKJJEANGOOI
	{
		// Token: 0x06000281 RID: 641 RVA: 0x00004248 File Offset: 0x00002448
		public static string Original(string s)
		{
			return s;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00010380 File Offset: 0x0000E580
		public static string ToCamelCase(string s)
		{
			if (string.IsNullOrEmpty(s) || char.IsLower(s, 0))
			{
				return s;
			}
			char[] array = s.ToCharArray();
			array[0] = char.ToLowerInvariant(array[0]);
			return new string(array);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000103B8 File Offset: 0x0000E5B8
		public static string ToSnakeCase(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				if (char.IsUpper(c))
				{
					if (i == 0)
					{
						stringBuilder.Append(char.ToLowerInvariant(c));
					}
					else if (char.IsUpper(s[i - 1]))
					{
						stringBuilder.Append(char.ToLowerInvariant(c));
					}
					else
					{
						stringBuilder.Append("_");
						stringBuilder.Append(char.ToLowerInvariant(c));
					}
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}
	}
}

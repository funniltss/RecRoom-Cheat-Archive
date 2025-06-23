using System;
using System.Text.RegularExpressions;

namespace Utf8Json.Formatters
{
	// Token: 0x02000136 RID: 310
	public sealed class MPBKCHPCHMHCLDLIHE : FLGKBGGCEAHKIBEKBN<Type>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00005C5B File Offset: 0x00003E5B
		public MPBKCHPCHMHCLDLIHE() : this(true, true, true)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00005C66 File Offset: 0x00003E66
		public MPBKCHPCHMHCLDLIHE(bool serializeAssemblyQualifiedName, bool deserializeSubtractAssemblyQualifiedName, bool throwOnError)
		{
			this.serializeAssemblyQualifiedName = serializeAssemblyQualifiedName;
			this.deserializeSubtractAssemblyQualifiedName = deserializeSubtractAssemblyQualifiedName;
			this.throwOnError = throwOnError;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00005C83 File Offset: 0x00003E83
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, Type value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			if (this.serializeAssemblyQualifiedName)
			{
				writer.WriteString(value.AssemblyQualifiedName);
				return;
			}
			writer.WriteString(value.FullName);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00018574 File Offset: 0x00016774
		public Type Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			string text = reader.ReadString();
			if (this.deserializeSubtractAssemblyQualifiedName)
			{
				text = MPBKCHPCHMHCLDLIHE.SubtractFullNameRegex.Replace(text, "");
			}
			return Type.GetType(text, this.throwOnError);
		}

		// Token: 0x04000299 RID: 665
		public static readonly MPBKCHPCHMHCLDLIHE Default = new MPBKCHPCHMHCLDLIHE();

		// Token: 0x0400029A RID: 666
		private static readonly Regex SubtractFullNameRegex = new Regex(", Version=\\d+.\\d+.\\d+.\\d+, Culture=\\w+, PublicKeyToken=\\w+");

		// Token: 0x0400029B RID: 667
		private bool serializeAssemblyQualifiedName;

		// Token: 0x0400029C RID: 668
		private bool deserializeSubtractAssemblyQualifiedName;

		// Token: 0x0400029D RID: 669
		private bool throwOnError;
	}
}

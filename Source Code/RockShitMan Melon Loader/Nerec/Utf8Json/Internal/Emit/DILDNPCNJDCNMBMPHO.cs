using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Utf8Json.Internal.Emit
{
	// Token: 0x020000AF RID: 175
	internal class DILDNPCNJDCNMBMPHO
	{
		// Token: 0x06000293 RID: 659 RVA: 0x0001082C File Offset: 0x0000EA2C
		public TypeBuilder DefineType(string name, TypeAttributes attr)
		{
			object obj = this.gate;
			TypeBuilder result;
			lock (obj)
			{
				result = this.moduleBuilder.DefineType(name, attr);
			}
			return result;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00010878 File Offset: 0x0000EA78
		public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent)
		{
			object obj = this.gate;
			TypeBuilder result;
			lock (obj)
			{
				result = this.moduleBuilder.DefineType(name, attr, parent);
			}
			return result;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000108C4 File Offset: 0x0000EAC4
		public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, Type[] interfaces)
		{
			object obj = this.gate;
			TypeBuilder result;
			lock (obj)
			{
				result = this.moduleBuilder.DefineType(name, attr, parent, interfaces);
			}
			return result;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000425D File Offset: 0x0000245D
		public DILDNPCNJDCNMBMPHO(string moduleName)
		{
			this.assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(moduleName), AssemblyBuilderAccess.Run);
			this.moduleBuilder = this.assemblyBuilder.DefineDynamicModule(moduleName);
		}

		// Token: 0x040001A2 RID: 418
		private readonly AssemblyBuilder assemblyBuilder;

		// Token: 0x040001A3 RID: 419
		private readonly ModuleBuilder moduleBuilder;

		// Token: 0x040001A4 RID: 420
		private readonly object gate = new object();
	}
}

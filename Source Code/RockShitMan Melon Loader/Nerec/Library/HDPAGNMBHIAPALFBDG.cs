using System;
using System.Reflection;
using MelonLoader;

namespace Nerec.Library
{
	// Token: 0x02000140 RID: 320
	public static class HDPAGNMBHIAPALFBDG
	{
		// Token: 0x0600056B RID: 1387 RVA: 0x00018B2C File Offset: 0x00016D2C
		public static void RegisterMonoBehavioursToIl2cppDomain()
		{
			foreach (Type type in Assembly.GetAssembly(typeof(HDPAGNMBHIAPALFBDG)).GetTypes())
			{
				if (type.GetCustomAttribute<ODCFJDIDECFCPJJAAL>() != null)
				{
					InteropSupport.RegisterTypeInIl2CppDomain(type);
				}
			}
		}
	}
}

using System;
using MelonLoader;
using UnityEngine;

namespace Nerec.Library
{
	// Token: 0x0200013B RID: 315
	public static class BHCDOPIGBJGDONCCFH
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x00005D0E File Offset: 0x00003F0E
		public static void Initialize()
		{
			Application.logMessageReceived += new Action<string, string, LogType>(BHCDOPIGBJGDONCCFH.Internal_HandleLog);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00018834 File Offset: 0x00016A34
		private static void Internal_HandleLog(string logString, string stackTrace, LogType type)
		{
			if (!BHCDOPIGBJGDONCCFH.LoggingEnabled)
			{
				return;
			}
			switch (type)
			{
			case 0:
				MelonLogger.Error(logString);
				return;
			case 1:
				MelonLogger.Error("[ASSERTION] " + logString);
				return;
			case 2:
				MelonLogger.Warning(logString);
				return;
			case 3:
				MelonLogger.Msg(logString);
				return;
			case 4:
				MelonLogger.Error("[EXCEPTION] " + logString);
				return;
			default:
				return;
			}
		}

		// Token: 0x040002AE RID: 686
		public static bool LoggingEnabled = true;
	}
}

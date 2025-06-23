using System;
using System.Collections.Generic;
using Il2Cpp;

namespace Nerec.Library.ServerOverride
{
	// Token: 0x02000163 RID: 355
	public static class IPPGJCBBICAGMIPDAP
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000636E File Offset: 0x0000456E
		public static Dictionary<CLKLKFHFEFG, string> HFIGDGAAOLFOABOPBO
		{
			get
			{
				return IPPGJCBBICAGMIPDAP._serviceUrls;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00006375 File Offset: 0x00004575
		public static List<ALHKNNPLCHJIHPKEJA> JNOHMDBOHIFEJAOKFN
		{
			get
			{
				return IPPGJCBBICAGMIPDAP._responseOverrides;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0000637C File Offset: 0x0000457C
		public static List<string> LNDJNPLEJMKPBLJBJN { get; } = new List<string>
		{
			"/api/PlayerReporting/v1/hile"
		};

		// Token: 0x0400037D RID: 893
		private static List<ALHKNNPLCHJIHPKEJA> _responseOverrides = new List<ALHKNNPLCHJIHPKEJA>
		{
			new ALHKNNPLCHJIHPKEJA
			{
				service = 16,
				url = "/voice/config",
				statusCode = 200,
				objectData = new NGBFHGHBKJEJMDJLKI
				{
					AHBEAICOBCFJPMOEHD = "84d367ec-91ab-449a-b4b0-ffea8395060c",
					LMNAIEMFKENOIOPKDB = "82c2ea94-9b51-45e1-b3c1-c16e8c504e1b",
					ONEPIPHGCOPDJGIFCN = null,
					KJKJGIPHAIALDKIBEJ = null
				}
			},
			new ALHKNNPLCHJIHPKEJA
			{
				service = 1,
				url = "/api/config/v1/azurespeech",
				statusCode = 200,
				objectData = new HCHDIFPAJJEJBMOJCK
				{
					HMDFGEIJPBJEILLFKK = false,
					HPEJMHAEPLEIDPGMAH = "16e5572c365f4bcb97ca304fdd9eedca",
					PHGLHCEFFBNOPEILFC = "none"
				}
			},
			new ALHKNNPLCHJIHPKEJA
			{
				service = 17,
				url = "/data/event",
				statusCode = 200,
				data = "OK"
			},
			new ALHKNNPLCHJIHPKEJA
			{
				service = 1,
				url = "/api/PlayerReporting/v1/hile",
				statusCode = 403,
				errorMessage = "Forbidden",
				data = ""
			}
		};

		// Token: 0x0400037F RID: 895
		private static Dictionary<CLKLKFHFEFG, string> _serviceUrls = new Dictionary<CLKLKFHFEFG, string>
		{
			{
				10,
				"https://accounts.rec.net"
			},
			{
				1,
				"https://api.rec.net"
			},
			{
				0,
				"https://auth.rec.net"
			},
			{
				18,
				"https://bugreporting.rec.net"
			},
			{
				6,
				"https://cdn.rec.net"
			},
			{
				8,
				"https://chat.rec.net"
			},
			{
				13,
				"https://clubs.rec.net"
			},
			{
				2,
				"https://commerce.rec.net"
			},
			{
				17,
				"https://datacollection.rec.net"
			},
			{
				19,
				"https://discovery.rec.net"
			},
			{
				26,
				"https://econ.rec.net"
			},
			{
				22,
				"https://gamelogs.rec.net"
			},
			{
				5,
				"https://img.rec.net"
			},
			{
				9,
				"https://leaderboard.rec.net"
			},
			{
				11,
				"https://link.rec.net"
			},
			{
				3,
				"https://match.rec.net"
			},
			{
				16,
				"https://moderation.rec.net"
			},
			{
				4,
				"https://notify.rec.net"
			},
			{
				15,
				"https://platformnotifications.rec.net"
			},
			{
				20,
				"https://playersettings.rec.net"
			},
			{
				12,
				"https://roomcomments.rec.net"
			},
			{
				14,
				"https://rooms.rec.net"
			},
			{
				7,
				"https://storage.rec.net"
			},
			{
				23,
				"https://strings.rec.net"
			},
			{
				24,
				"https://strings-cdn.rec.net"
			},
			{
				21,
				"https://studio.rec.net"
			},
			{
				25,
				"https://rec.net"
			}
		};
	}
}

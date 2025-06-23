using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Il2CppPhoton.Pun;
using Il2CppRecRoom.Core.Creation;
using Nerec.Library.Includes;
using Nerec.Library.UnityGUI.Drawers;
using UnityEngine;

namespace Nerec.Library.UnityGUI.Custom
{
	// Token: 0x02000160 RID: 352
	public static class OIFDMGCKGNDLJCPEDO
	{
		// Token: 0x060005EA RID: 1514 RVA: 0x00019FB4 File Offset: 0x000181B4
		private static void Initialize(uint tabId)
		{
			IPDMLDCHOFKILLMKLE.Run(LLHALDELIJLHMBBGID.Update, new Action(OIFDMGCKGNDLJCPEDO.Update));
			OIFDMGCKGNDLJCPEDO._prefabList = new OFMPAOLHNHKHKFPADJ(tabId);
			OIFDMGCKGNDLJCPEDO._prefabScaleDrawer = new OCJEPDIFBENACKEIIK();
			List<string> list = new List<string>();
			foreach (GameObject gameObject in Resources.LoadAll<GameObject>(""))
			{
				string name = gameObject.name;
				if (gameObject.GetComponent<MonoBehaviourPun>() != null)
				{
					list.Add(name);
				}
			}
			list.Sort();
			OIFDMGCKGNDLJCPEDO._prefabList.SetStrings(list);
			OIFDMGCKGNDLJCPEDO._initialized = true;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0001A05C File Offset: 0x0001825C
		public static void Draw(int windowId)
		{
			if (!OIFDMGCKGNDLJCPEDO._initialized)
			{
				OIFDMGCKGNDLJCPEDO.Initialize(KDMLJLIJNANBIKHKCO.WorldModsMenuTabId);
				return;
			}
			GUI.skin.label.richText = true;
			GUILayout.Label("<b>Authority</b>", null);
			if (GUILayout.Button("Give me authority", null))
			{
				OIFDMGCKGNDLJCPEDO.StealAuthority();
			}
			GUILayout.Space(20f);
			GUILayout.Label("<b>Maker Pen</b>", null);
			if (GUILayout.Button("Delete everything", null))
			{
				OIFDMGCKGNDLJCPEDO.DeleteEverything();
			}
			GUILayout.Space(20f);
			GUILayout.Label("<b>Prefabs</b>", null);
			OIFDMGCKGNDLJCPEDO._prefabList.Draw();
			OIFDMGCKGNDLJCPEDO._prefabScaleDrawer.Draw();
			if (GUILayout.Button("Spawn Prefab", null))
			{
				JKGLHAAMDAFFCEKMOC.Instantiate(OIFDMGCKGNDLJCPEDO._prefabList.MPFFHOJOKEHBAMPOJB, JELGILABEGAPMCJHFF.LocalPlayer().get_Head().get_Transform().get_Position(), Quaternion.identity, OIFDMGCKGNDLJCPEDO._prefabScaleDrawer.EBPONMOBJHOOPHGKGF, 1, null, false);
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00003EE1 File Offset: 0x000020E1
		private static void Update()
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001A13C File Offset: 0x0001833C
		public static void StealAuthority()
		{
			foreach (CreationObject creationObject in Object.FindObjectsOfType<CreationObject>())
			{
				creationObject.pvCache.TransferOwnership(JKGLHAAMDAFFCEKMOC.get_LocalPlayer().ToIl2cpp());
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001A194 File Offset: 0x00018394
		public static void DeleteEverything()
		{
			foreach (CreationObject creationObject in Object.FindObjectsOfType<CreationObject>())
			{
				creationObject.pvCache.RPC("RpcReset", 0, null);
				creationObject.pvCache.RPC("RpcMasterDespawn", 0, null);
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001A1FC File Offset: 0x000183FC
		private static string GetGameObjectPath(GameObject gameObject)
		{
			Transform transform = gameObject.transform;
			string text = "";
			while (transform != null)
			{
				text = transform.name + "/" + text;
				transform = transform.parent;
			}
			return text.Remove(text.Length - 1);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00006330 File Offset: 0x00004530
		private static List<CreationObject> GetAllCreationObjects()
		{
			return Object.FindObjectsOfType<CreationObject>().ToList<CreationObject>();
		}

		// Token: 0x04000373 RID: 883
		private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		// Token: 0x04000374 RID: 884
		private static OFMPAOLHNHKHKFPADJ _prefabList;

		// Token: 0x04000375 RID: 885
		private static OCJEPDIFBENACKEIIK _prefabScaleDrawer;

		// Token: 0x04000376 RID: 886
		private static bool _initialized;
	}
}

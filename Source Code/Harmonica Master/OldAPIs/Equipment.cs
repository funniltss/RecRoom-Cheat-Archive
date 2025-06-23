// Decompiled with JetBrains decompiler
// Type: OldAPIs.Equipment
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace OldAPIs
{
  internal class Equipment
  {
    public static List<Equipment> LocalEquipment;

    public string PrefabName { get; set; }

    public string ModificationGuid { get; set; }

    public int UnlockedLevel { get; set; }

    public bool Favorited { get; set; }

    public static string GetUnlocked()
    {
      WebClient webClient = new WebClient();
      Equipment.LocalEquipment = JsonConvert.DeserializeObject<List<Equipment>>(new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/vaultServerDependencies/main/Equipment.json"));
      return JsonConvert.SerializeObject((object) Equipment.LocalEquipment);
    }
  }
}

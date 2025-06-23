// Decompiled with JetBrains decompiler
// Type: OldAPIs.AvatarItem
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Configs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace OldAPIs
{
  public class AvatarItem
  {
    public static List<AvatarItem> avataritems;

    public string AvatarItemDesc { get; set; }

    public int UnlockedLevel { get; set; }

    public static string SerializeItems()
    {
      WebClient webClient = new WebClient();
      AvatarItem.avataritems = JsonConvert.DeserializeObject<List<AvatarItem>>(new WebClient().DownloadString("https://raw.githubusercontent.com/MinorCrimes/Harmonica/Core/items.json"));
      return JsonConvert.SerializeObject((object) AvatarItem.avataritems);
    }

    public static List<AvatarItem> LoadAvatarItems() => JsonConvert.DeserializeObject<List<AvatarItem>>(System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\Resources\\LocalAvatar"));

    public static void AddAvatarItem(string outfitDesc, int level)
    {
      AvatarItem avatarItem = new AvatarItem()
      {
        AvatarItemDesc = outfitDesc,
        UnlockedLevel = level
      };
      Config.localItems.Add(avatarItem);
      AvatarItem.SaveAvatarItems();
    }

    public static void SaveAvatarItems()
    {
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) System.IO.File.Create(Config.LocalItemDirectory)))
      {
        foreach (AvatarItem localItem in Config.localItems)
        {
          binaryWriter.Write(localItem.AvatarItemDesc);
          binaryWriter.Write(localItem.UnlockedLevel);
        }
      }
    }
  }
}

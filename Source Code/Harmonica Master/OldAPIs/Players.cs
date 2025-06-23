// Decompiled with JetBrains decompiler
// Type: OldAPIs.Players
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Configs;
using Newtonsoft.Json;
using System.IO;

namespace OldAPIs
{
  internal class Players
  {
    public static string GetOrCreate(UserConfig player) => JsonConvert.SerializeObject((object) new Profile()
    {
      Id = player.UserID,
      Username = Players.playerName(),
      DisplayName = Players.playerName(),
      XP = 48,
      Level = player.Level,
      Reputation = 0,
      Verified = true,
      Developer = false,
      HasEmail = true,
      CanReceiveInvites = false,
      ProfileImageName = "1a427b60c9d7446da6331ce66077239c.jpg",
      HasBirthday = true
    });

    public static string GetOrCreateArray(UserConfig player) => JsonConvert.SerializeObject((object) new Profile[1]
    {
      new Profile()
      {
        Id = player.UserID,
        Username = Players.playerName(),
        DisplayName = Players.playerName(),
        XP = 48,
        Level = player.Level,
        Reputation = 0,
        Verified = true,
        Developer = false,
        HasEmail = true,
        CanReceiveInvites = false,
        ProfileImageName = "1a427b60c9d7446da6331ce66077239c.jpg",
        JuniorProfile = false,
        ForceJuniorImages = false,
        HasBirthday = true
      }
    });

    public static string playerName() => File.ReadAllText("playerNameConfig.txt");
  }
}

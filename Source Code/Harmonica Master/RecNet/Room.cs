// Decompiled with JetBrains decompiler
// Type: RecNet.Room
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecNet
{
  internal class Room
  {
    public static string Filters() => JsonConvert.SerializeObject((object) new Room.RoomFilter()
    {
      PinnedFilters = new List<string>()
      {
        "recroomoriginal",
        "community",
        "featured",
        "carnivale",
        "quest",
        "pvp",
        "hangout",
        "game",
        "art",
        "store",
        "tutorial",
        "fandom",
        "performance",
        "action",
        "horror"
      },
      PopularFilters = new List<string>()
      {
        "pvp",
        "quest",
        "game",
        "hangout",
        "art"
      },
      TrendingFilters = new List<string>()
      {
        "carnivale",
        "horror",
        "action",
        "scary",
        "puzzle",
        "parkour",
        "fun",
        "story"
      }
    });

    public class RoomFilter
    {
      public List<string> PinnedFilters { get; set; }

      public List<string> PopularFilters { get; set; }

      public List<string> TrendingFilters { get; set; }
    }
  }
}

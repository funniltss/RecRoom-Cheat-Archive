// Decompiled with JetBrains decompiler
// Type: RecNet.PlayerProgression
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RecNet
{
  internal class PlayerProgression
  {
    public static string GetProgressionBulk() => JsonConvert.SerializeObject((object) new List<PlayerProgression.Details>()
    {
      new PlayerProgression.Details()
      {
        PlayerId = 1,
        Level = 99,
        XP = 0
      }
    });

    public class Details
    {
      public int PlayerId { get; set; }

      public int Level { get; set; }

      public int XP { get; set; }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: OldAPIs.PlayerEvents
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using System.Collections.Generic;

namespace OldAPIs
{
  internal class PlayerEvents
  {
    public List<playerEvent> Created { get; set; }

    public List<OtherPlayerEvent> Responses { get; set; }

    public static string Get() => JsonConvert.SerializeObject((object) new PlayerEvents()
    {
      Created = new List<playerEvent>(),
      Responses = new List<OtherPlayerEvent>()
    });
  }
}

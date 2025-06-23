// Decompiled with JetBrains decompiler
// Type: OldAPIs.Events
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OldAPIs
{
  internal class Events
  {
    public long EventId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string PosterImageName { get; set; }

    public long CreatorPlayerId { get; set; }

    public static string list() => JsonConvert.SerializeObject((object) new List<Events>());
  }
}

// Decompiled with JetBrains decompiler
// Type: OldAPIs.playerEventResponse
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System;

namespace OldAPIs
{
  internal class playerEventResponse
  {
    public long PlayerEventResponseId { get; set; }

    public long PlayerEventId { get; set; }

    public int PlayerId { get; set; }

    public DateTime CreatedAt { get; set; }

    public int Type { get; set; }
  }
}

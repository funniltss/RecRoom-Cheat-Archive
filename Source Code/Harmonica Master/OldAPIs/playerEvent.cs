// Decompiled with JetBrains decompiler
// Type: OldAPIs.playerEvent
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System;

namespace OldAPIs
{
  internal class playerEvent
  {
    public long PlayerEventId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime StartTime { get; set; }

    public int CreatorPlayerId { get; set; }

    public int AttendeeCount { get; set; }

    public long RoomId { get; set; }
  }
}

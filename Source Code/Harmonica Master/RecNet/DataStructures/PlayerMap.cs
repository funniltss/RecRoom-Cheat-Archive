// Decompiled with JetBrains decompiler
// Type: RecNet.DataStructures.PlayerMap
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System.Collections.Generic;

namespace RecNet.DataStructures
{
  public class PlayerMap
  {
    public Dictionary<ulong, MultiplayerPlayer> AllPlayers;

    public PlayerMap() => this.AllPlayers = new Dictionary<ulong, MultiplayerPlayer>();
  }
}

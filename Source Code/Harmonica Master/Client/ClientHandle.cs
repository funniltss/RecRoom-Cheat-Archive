// Decompiled with JetBrains decompiler
// Type: Client.ClientHandle
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using RecNet.DataStructures;
using System.Collections.Generic;

namespace Client
{
  public class ClientHandle
  {
    public Dictionary<ulong, MultiplayerPlayer> AllPlayers = new Dictionary<ulong, MultiplayerPlayer>();

    public void AddPlayer(MultiplayerPlayer player) => this.AllPlayers.Add((ulong) player.m_PlayerData.Account.accountId, player);

    public MultiplayerPlayer GetPlayerDetails(ulong id)
    {
      MultiplayerPlayer multiplayerPlayer;
      this.AllPlayers.TryGetValue(id, out multiplayerPlayer);
      return multiplayerPlayer;
    }
  }
}

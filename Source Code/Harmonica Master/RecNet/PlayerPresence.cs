// Decompiled with JetBrains decompiler
// Type: RecNet.PlayerPresence
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

namespace RecNet
{
  public class PlayerPresence
  {
    public int playerId { get; set; }

    public PlayerStatusVisibility statusVisibility { get; set; }

    public DeviceClass deviceClass { get; set; }

    public VRMovementMode vrMovementMode { get; set; }

    public RoomInstance roomInstance { get; set; }

    public bool isOnline { get; set; }

    public string appVersion { get; set; }
  }
}

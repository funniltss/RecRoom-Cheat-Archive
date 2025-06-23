// Decompiled with JetBrains decompiler
// Type: RecNet.RoomInstance
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

namespace RecNet
{
  public class RoomInstance
  {
    public int roomInstanceId { get; set; }

    public int roomId { get; set; }

    public int subRoomId { get; set; }

    public string location { get; set; }

    public int roomInstanceType { get; set; }

    public string dataBlob { get; set; }

    public string photonRegionId { get; set; }

    public string photonRoomId { get; set; }

    public string name { get; set; }

    public int maxCapacity { get; set; }

    public bool isFull { get; set; }

    public bool isPrivate { get; set; }

    public bool isInProgress { get; set; }
  }
}

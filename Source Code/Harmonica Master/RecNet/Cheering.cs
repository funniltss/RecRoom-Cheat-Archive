// Decompiled with JetBrains decompiler
// Type: RecNet.Cheering
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

namespace RecNet
{
  public class Cheering
  {
    public static string SetCheerBadge(Cheering.CheerBadges cheer, string isg) => GenericRecNetResponse.SetNewResponse(true, "");

    public enum CheerBadges
    {
      General = 0,
      Helpful = 10, // 0x0000000A
      Sportmanship = 20, // 0x00000014
      GreatHost = 30, // 0x0000001E
      Creative = 40, // 0x00000028
      RecRoomDeveloper = 9000, // 0x00002328
    }
  }
}

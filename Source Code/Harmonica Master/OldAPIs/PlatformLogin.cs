// Decompiled with JetBrains decompiler
// Type: OldAPIs.PlatformLogin
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Configs;
using Newtonsoft.Json;

namespace OldAPIs
{
  internal class PlatformLogin
  {
    public string Token { get; set; }

    public ulong PlayerId { get; set; }

    public string Error { get; set; }

    public static string v4(UserConfig profile) => JsonConvert.SerializeObject((object) new PlatformLogin()
    {
      Token = "j3923mHJG032jew",
      PlayerId = profile.UserID,
      Error = ""
    });

    public class v1
    {
      public static string profiles() => "";
    }
  }
}

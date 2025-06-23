// Decompiled with JetBrains decompiler
// Type: OldAPIs.Challenge
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;

namespace OldAPIs
{
  internal class Challenge
  {
    public bool Success { get; set; }

    public string Message { get; set; }

    public static string getCurrent() => JsonConvert.SerializeObject((object) new Challenge()
    {
      Success = false,
      Message = ""
    });
  }
}

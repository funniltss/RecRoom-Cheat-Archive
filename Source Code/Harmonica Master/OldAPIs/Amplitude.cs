// Decompiled with JetBrains decompiler
// Type: OldAPIs.Amplitude
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;

namespace OldAPIs
{
  internal class Amplitude
  {
    public string AmplitudeKey { get; set; }

    public static string amplitude() => JsonConvert.SerializeObject((object) new Amplitude()
    {
      AmplitudeKey = "e1693a1003671058b6abc356c8ba8d59"
    });
  }
}

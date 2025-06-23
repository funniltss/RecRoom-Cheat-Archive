// Decompiled with JetBrains decompiler
// Type: RecNet.QuickPlay
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using RecNet.Handler;

namespace RecNet
{
  internal class QuickPlay
  {
    public static string GetAndClear()
    {
      Logger.UserPrefs.AddPref("quickplay_getandclear", "1");
      return JsonConvert.SerializeObject((object) new QuickPlay.QuickPlayResponseDTO()
      {
        TargetPlayerId = new long?(),
        RoomName = (string) null,
        ActionCode = (string) null
      });
    }

    public class QuickPlayResponseDTO
    {
      public long? TargetPlayerId { get; set; }

      public string RoomName { get; set; }

      public string ActionCode { get; set; }
    }
  }
}

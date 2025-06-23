// Decompiled with JetBrains decompiler
// Type: OldAPIs.PlayerReporting
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;

namespace OldAPIs
{
  internal class PlayerReporting
  {
    public static string moderationBlockDetails() => JsonConvert.SerializeObject((object) new PlayerReporting.ModerationBlockDetails()
    {
      ReportCategory = 0,
      Duration = 0,
      GameSessionId = 0L,
      Message = ""
    });

    private class ModerationBlockDetails
    {
      public int ReportCategory { get; set; }

      public int Duration { get; set; }

      public long GameSessionId { get; set; }

      public string Message { get; set; }
    }
  }
}

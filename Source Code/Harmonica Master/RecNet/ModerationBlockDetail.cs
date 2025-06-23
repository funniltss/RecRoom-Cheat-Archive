// Decompiled with JetBrains decompiler
// Type: RecNet.ModerationBlockDetail
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

namespace RecNet
{
  public class ModerationBlockDetail
  {
    public ReportCategory ReportCategory { get; set; }

    public int Duration { get; set; }

    public long GameSessionId { get; set; }

    public string Message { get; set; }

    public bool IsHostKick { get; set; }

    public long? PlayerIdReporter { get; set; }

    public bool IsBan { get; set; }

    public int? VoteKickReason { get; set; }
  }
}

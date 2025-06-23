// Decompiled with JetBrains decompiler
// Type: OldAPIs.AutoMicMutingConfig
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

namespace OldAPIs
{
  public class AutoMicMutingConfig
  {
    public float MicSpamSamplePercentageForForceMute { get; set; }

    public float MicSpamSamplePercentageForForceMuteToEnd { get; set; }

    public float MicSpamSamplePercentageForWarning { get; set; }

    public float MicSpamSamplePercentageForWarningToEnd { get; set; }

    public float MicSpamVolumeThreshold { get; set; }

    public float MicSpamWarningStateVolumeMultiplier { get; set; }

    public float MicSpamSampleInterval { get; set; }

    public float MicSpamSampleRollingWindowLength { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: RecNet.CDN_LoadingScreenData
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System;
using System.Collections.Generic;

namespace RecNet
{
  public class CDN_LoadingScreenData
  {
    public string Name { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    public List<object> RoomNames { get; set; }

    public int Context { get; set; }

    public int InputType { get; set; }

    public int Visibility { get; set; }

    public bool AllowCycling { get; set; }

    public bool RestrictToNewUsers { get; set; }

    public string ImageName { get; set; }

    public int PlatformMask { get; set; }

    public DateTime CreatedAt { get; set; }
  }
}

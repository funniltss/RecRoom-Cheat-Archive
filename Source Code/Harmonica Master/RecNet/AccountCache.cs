// Decompiled with JetBrains decompiler
// Type: RecNet.AccountCache
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System;

namespace RecNet
{
  public class AccountCache
  {
    public int availableUsernameChanges { get; set; }

    public string email { get; set; }

    public string phone { get; set; }

    public DateTime birthday { get; set; }

    public int accountId { get; set; }

    public string username { get; set; }

    public string displayName { get; set; }

    public string profileImage { get; set; }

    public string bannerImage { get; set; }

    public bool isJunior { get; set; }

    public int platforms { get; set; }

    public DateTime createdAt { get; set; }
  }
}

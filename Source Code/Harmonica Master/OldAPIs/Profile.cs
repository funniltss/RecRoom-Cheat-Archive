// Decompiled with JetBrains decompiler
// Type: OldAPIs.Profile
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

namespace OldAPIs
{
  public class Profile
  {
    public ulong Id { get; set; }

    public string Username { get; set; }

    public string DisplayName { get; set; }

    public int XP { get; set; }

    public int Level { get; set; }

    public int Reputation { get; set; }

    public bool Verified { get; set; }

    public bool Developer { get; set; }

    public bool HasEmail { get; set; }

    public bool CanReceiveInvites { get; set; }

    public string ProfileImageName { get; set; }

    public bool JuniorProfile { get; set; }

    public bool ForceJuniorImages { get; set; }

    public bool PendingJunior { get; set; }

    public bool HasBirthday { get; set; }
  }
}

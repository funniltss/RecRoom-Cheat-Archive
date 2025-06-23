// Decompiled with JetBrains decompiler
// Type: RecNet.MultiServer.PlatformLogin
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System.Collections.Generic;

namespace RecNet.MultiServer
{
  internal class PlatformLogin
  {
    public static List<PlatformLogin.SelfAccount> GetCachedLogins() => new List<PlatformLogin.SelfAccount>()
    {
      new PlatformLogin.SelfAccount()
      {
        Id = 1L,
        Username = "Coach",
        DisplayName = "Coach",
        Bio = "",
        XP = 0,
        Level = 99,
        RegistrationStatus = 3,
        Developer = true,
        CanReceiveInvites = true,
        ProfileImageName = "DefaultProfleImage",
        JuniorProfile = false,
        ForceJuniorImages = false,
        PendingJunior = false,
        HasBirthday = false,
        PlayerReputation = new PlatformLogin.Reputation()
        {
          Noteriety = 1f,
          SelectedCheer = 40,
          CheerGeneral = 90,
          CheerHelpful = 90,
          CheerSportsman = 90,
          CheerGreatHost = 90,
          CheerCreative = 90,
          CheerCredit = 90,
          SubscribedCount = 1,
          SubscriberCount = 182332
        },
        PlatformId = new PlatformLogin.PlatformInfo()
        {
          Platform = 0,
          PlatformId = "72348961238742"
        }
      }
    };

    public class SelfAccount
    {
      public long Id { get; set; }

      public string Username { get; set; }

      public string DisplayName { get; set; }

      public string Bio { get; set; }

      public int XP { get; set; }

      public int Level { get; set; }

      public int RegistrationStatus { get; set; }

      public bool Developer { get; set; }

      public bool CanReceiveInvites { get; set; }

      public string ProfileImageName { get; set; }

      public bool JuniorProfile { get; set; }

      public bool ForceJuniorImages { get; set; }

      public bool PendingJunior { get; set; }

      public bool HasBirthday { get; set; }

      public PlatformLogin.Reputation PlayerReputation { get; set; }

      public PlatformLogin.PlatformInfo PlatformId { get; set; }
    }

    public class Reputation
    {
      public float Noteriety { get; set; }

      public int SelectedCheer { get; set; }

      public int CheerGeneral { get; set; }

      public int CheerHelpful { get; set; }

      public int CheerGreatHost { get; set; }

      public int CheerSportsman { get; set; }

      public int CheerCreative { get; set; }

      public int CheerCredit { get; set; }

      public int SubscriberCount { get; set; }

      public int SubscribedCount { get; set; }
    }

    public class PlatformInfo
    {
      public int Platform { get; set; }

      public string PlatformId { get; set; }
    }
  }
}

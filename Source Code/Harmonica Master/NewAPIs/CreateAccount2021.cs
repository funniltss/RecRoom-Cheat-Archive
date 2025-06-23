// Decompiled with JetBrains decompiler
// Type: NewAPIs.CreateAccount2021
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System;

namespace NewAPIs
{
  public class CreateAccount2021
  {
    public static CreateAccount2021.AccountCreationResponse CreateAccount()
    {
      Random random = new Random();
      return new CreateAccount2021.AccountCreationResponse()
      {
        success = true,
        value = new CreateAccount2021.Account()
        {
          accountId = (ulong) random.Next(363455, 71236784),
          username = "recnetremoteservertestaccount",
          displayName = "recnetremoteservertestaccount",
          profileImage = "DefaultProfileImage",
          isJunior = new bool?(),
          platforms = 0,
          createdAt = DateTime.UtcNow
        }
      };
    }

    public class CreateAccountDTO
    {
      public int platform { get; set; }

      public ulong platformId { get; set; }

      public string deviceId { get; set; }
    }

    public class AccountCreationResponse
    {
      public bool success { get; set; }

      public CreateAccount2021.Account value { get; set; }
    }

    public class Account
    {
      public ulong accountId { get; set; }

      public string username { get; set; }

      public string displayName { get; set; }

      public string profileImage { get; set; }

      public bool? isJunior { get; set; }

      public int platforms { get; set; }

      public DateTime createdAt { get; set; }
    }
  }
}

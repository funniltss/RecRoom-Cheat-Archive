// Decompiled with JetBrains decompiler
// Type: OldAPIs.Generic
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

namespace OldAPIs
{
  internal class Generic
  {
    public class APISuccessResposne
    {
      public bool Success { get; set; }

      public string Message { get; set; }

      public APISuccessResposne()
      {
        this.Success = true;
        this.Message = "Success!";
      }
    }
  }
}

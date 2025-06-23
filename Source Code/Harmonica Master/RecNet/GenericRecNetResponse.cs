// Decompiled with JetBrains decompiler
// Type: RecNet.GenericRecNetResponse
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;

namespace RecNet
{
  internal class GenericRecNetResponse
  {
    public static string SetNewResponse(bool success, string message) => JsonConvert.SerializeObject((object) new GenericRecNetResponse()
    {
      Success = success,
      Message = message
    });

    public bool Success { get; set; }

    public string Message { get; set; }
  }
}

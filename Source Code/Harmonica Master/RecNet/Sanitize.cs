// Decompiled with JetBrains decompiler
// Type: RecNet.Sanitize
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;

namespace RecNet
{
  public class Sanitize
  {
    public static Sanitize.SanitizeRequestDTO SanitizeChatRequest(string chatMessage)
    {
      Sanitize.SanitizePostDTO sanitizePostDto = JsonConvert.DeserializeObject<Sanitize.SanitizePostDTO>(chatMessage);
      return new Sanitize.SanitizeRequestDTO()
      {
        StringValue = sanitizePostDto.Value
      };
    }

    public static string SanitizeChatMessageRequest(string postData, string signature) => "\"" + JsonConvert.DeserializeObject<Sanitize.SanitizePostDTO>(postData).Value + "\"";

    public static Sanitize.SanitizePureDTO SanitizeRequest(string chatMessage)
    {
      JsonConvert.DeserializeObject<Sanitize.SanitizePostDTO>(chatMessage);
      return new Sanitize.SanitizePureDTO()
      {
        IsPure = true
      };
    }

    public class SanitizePostDTO
    {
      public string Value { get; set; }

      public int ReplacementChar { get; set; }
    }

    public class SanitizeRequestDTO
    {
      public string StringValue { get; set; }
    }

    public class SanitizeStringRequest
    {
      public string value;

      public SanitizeStringRequest(string text) => this.value = text;
    }

    public class SanitizePureDTO
    {
      public bool IsPure { get; set; }
    }
  }
}

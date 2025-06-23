// Decompiled with JetBrains decompiler
// Type: RecNet.Core
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Client;
using System.Collections.Generic;
using System.Net;

namespace RecNet
{
  public class Core
  {
    public static Queue<ServerRequest> ServerRequests = new Queue<ServerRequest>();

    public static byte[] GetFromImgServer(string requestUri) => new WebClient().DownloadData("https://img.rec.net" + requestUri);

    public static byte[] GetFromCDN(string requestUri) => new WebClient().DownloadData("https://cdn.rec.net" + requestUri);

    public static bool EnqueuePerson(ServerRequest request)
    {
      try
      {
        Core.ServerRequests.Enqueue(request);
        return true;
      }
      catch
      {
        return false;
      }
    }

    public static string DequeueWithResponse(ServerRequest request) => request.url.EndsWith("/api/config/v2") ? "OK" : "{\"error\":true,\"message\":\"Failed to find the requested resource\"}";
  }
}

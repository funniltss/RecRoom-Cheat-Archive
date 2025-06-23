// Decompiled with JetBrains decompiler
// Type: Servers.WebSocketServer
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using OldAPIs;
using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Servers
{
  internal class WebSocketServer
  {
    public WebSocketServer() => Console.WriteLine("[WebSocketServer] has started.");

    public class NotificationV2 : WebSocketBehavior
    {
      protected override void OnMessage(MessageEventArgs e)
      {
        Console.WriteLine("[ws] WEBSOCKET WAS REQUESTED");
        this.Send(Notification.ProcessRequest(e.Data));
      }
    }
  }
}

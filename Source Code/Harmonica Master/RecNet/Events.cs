// Decompiled with JetBrains decompiler
// Type: RecNet.Events
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RecNet
{
  internal class Events
  {
    public static Events.PlayerEventsResponse AllEvents = new Events.PlayerEventsResponse()
    {
      Created = new List<Events.PlayerEvent>(),
      Responses = new List<Events.OtherPlayerEvent>()
    };

    public static string All() => JsonConvert.SerializeObject((object) Events.AllEvents);

    public class PlayerEventsResponse
    {
      public List<Events.PlayerEvent> Created { get; set; }

      public List<Events.OtherPlayerEvent> Responses { get; set; }
    }

    public class OtherPlayerEvent
    {
      public Events.PlayerEvent PlayerEvent { get; set; }

      public Events.PlayerEventResponse PlayerEventResponse { get; set; }
    }

    public class PlayerEvent
    {
      public long PlayerEventId { get; set; }

      public string Name { get; set; }

      public string Description { get; set; }

      public DateTime StartTime { get; set; }

      public int CreatorPlayerId { get; set; }

      public int AttendeeCount { get; set; }

      public long RoomId { get; set; }
    }

    public class PlayerEventResponse
    {
      public long PlayerEventResponseId { get; set; }

      public long PlayerEventId { get; set; }

      public int PlayerId { get; set; }

      public DateTime CreatedAt { get; set; }

      public int Type { get; set; }
    }
  }
}

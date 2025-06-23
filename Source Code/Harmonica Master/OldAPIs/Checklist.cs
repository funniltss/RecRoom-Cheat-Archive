// Decompiled with JetBrains decompiler
// Type: OldAPIs.Checklist
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Newtonsoft.Json;
using System.Collections.Generic;

namespace OldAPIs
{
  public class Checklist
  {
    public static string Get() => JsonConvert.SerializeObject((object) new List<ChecklistEntry>()
    {
      new ChecklistEntry()
      {
        Order = 0,
        Objective = 3000,
        Count = 3,
        CreditAmount = 100
      },
      new ChecklistEntry()
      {
        Order = 1,
        Objective = 3001,
        Count = 3,
        CreditAmount = 100
      },
      new ChecklistEntry()
      {
        Order = 2,
        Objective = 3002,
        Count = 3,
        CreditAmount = 100
      }
    });
  }
}

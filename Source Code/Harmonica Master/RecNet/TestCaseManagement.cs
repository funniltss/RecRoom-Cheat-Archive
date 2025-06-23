// Decompiled with JetBrains decompiler
// Type: RecNet.TestCaseManagement
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System;
using System.Collections.Generic;

namespace RecNet
{
  internal class TestCaseManagement
  {
    public static List<TestCaseManagement.TestPassDTO> LocalTestPassCases = new List<TestCaseManagement.TestPassDTO>();

    public class TestPassDTO
    {
      public int Id { get; set; }

      public string Name { get; set; }

      public object Description { get; set; }

      public DateTime StartDate { get; set; }

      public DateTime EndDate { get; set; }

      public bool WasManuallyClosed { get; set; }

      public List<TestCaseManagement.TestCase> TestCases { get; set; }

      public List<string> Tags { get; set; }

      public int NumTestCases { get; set; }

      public int NumPassedTestCases { get; set; }

      public int NumFailedTestCases { get; set; }
    }

    public class TestCase
    {
      public string Id { get; set; }

      public int TestPassId { get; set; }

      public string Key { get; set; }

      public string Title { get; set; }

      public string Description { get; set; }

      public string RoomName { get; set; }

      public int Status { get; set; }

      public List<string> AssignedPlayerNames { get; set; }

      public List<string> Tags { get; set; }

      public string JiraUrl { get; set; }

      public List<string> Comments { get; set; }
    }
  }
}

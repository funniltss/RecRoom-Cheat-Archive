// Decompiled with JetBrains decompiler
// Type: RecNet.Handler.SaveData.SaveData
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using Client;
using System.IO;

namespace RecNet.Handler.SaveData
{
  public class SaveData
  {
    public static string GetSaveData(string path)
    {
      if (File.Exists(path))
        return ClientSecurity.DecodeFrom64(File.ReadAllText(path));
      if (!File.Exists(path))
      {
        int num = 0;
        File.CreateText(path);
        while (!File.Exists(path))
          ++num;
        if (File.Exists(path))
          return ClientSecurity.DecodeFrom64(File.ReadAllText(path));
      }
      return "{}";
    }

    public static void SetSaveData(string data, string path)
    {
      if (File.Exists(path))
      {
        File.WriteAllText(path, ClientSecurity.EncodeTo64(data));
      }
      else
      {
        if (File.Exists(path))
          return;
        int num = 0;
        File.CreateText(path);
        while (!File.Exists(path))
          ++num;
        if (File.Exists(path))
          File.WriteAllText(path, ClientSecurity.EncodeTo64(data));
      }
    }
  }
}

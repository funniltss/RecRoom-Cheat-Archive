// Decompiled with JetBrains decompiler
// Type: PrivateImplementationDetails
// Assembly: NgrokRightRoomServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50707685-AB19-45DC-B196-9E24C2A59B7A
// Assembly location: C:\Users\Rohan\Desktop\Updater\Harmonica.exe

using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class PrivateImplementationDetails
{
  internal static uint ComputeStringHash(string s)
  {
    uint num = 0;
    if (s != null)
    {
      num = 2166136261U;
      for (int index = 0; index < s.Length; ++index)
        num = (uint) (((int) s[index] ^ (int) num) * 16777619);
    }
    return num;
  }
}

using System;
using System.Reflection;

namespace Utf8Json.Internal
{
	// Token: 0x0200009E RID: 158
	public static class PLFJFHEOALIJKCIFIN
	{
		// Token: 0x06000229 RID: 553 RVA: 0x0000DF3C File Offset: 0x0000C13C
		public unsafe static ulong GetKey(ref byte* p, ref int rest)
		{
			ulong result;
			int num;
			if (rest >= 8)
			{
				result = (ulong)(*p);
				num = 8;
			}
			else
			{
				switch (rest)
				{
				case 1:
					result = (ulong)(*p);
					num = 1;
					break;
				case 2:
					result = (ulong)(*p);
					num = 2;
					break;
				case 3:
				{
					ulong num2 = (ulong)(*p);
					ushort num3 = *(p + 1);
					result = (num2 | (ulong)num3 << 8);
					num = 3;
					break;
				}
				case 4:
					result = (ulong)(*p);
					num = 4;
					break;
				case 5:
				{
					ulong num4 = (ulong)(*p);
					uint num5 = *(p + 1);
					result = (num4 | (ulong)num5 << 8);
					num = 5;
					break;
				}
				case 6:
				{
					ulong num6 = (ulong)(*p);
					ulong num7 = (ulong)(*(p + 2));
					result = (num6 | num7 << 16);
					num = 6;
					break;
				}
				case 7:
				{
					ulong num8 = (ulong)(*p);
					ushort num9 = *(p + 1);
					uint num10 = *(p + 3);
					result = (num8 | (ulong)num9 << 8 | (ulong)num10 << 24);
					num = 7;
					break;
				}
				default:
					throw new InvalidOperationException("Not Supported Length");
				}
			}
			p += (IntPtr)num;
			rest -= num;
			return result;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000E020 File Offset: 0x0000C220
		public static ulong GetKeySafe(byte[] bytes, ref int offset, ref int rest)
		{
			ulong result;
			int num;
			if (BitConverter.IsLittleEndian)
			{
				if (rest >= 8)
				{
					result = ((ulong)bytes[offset] | (ulong)bytes[offset + 1] << 8 | (ulong)bytes[offset + 2] << 16 | (ulong)bytes[offset + 3] << 24 | (ulong)bytes[offset + 4] << 32 | (ulong)bytes[offset + 5] << 40 | (ulong)bytes[offset + 6] << 48 | (ulong)bytes[offset + 7] << 56);
					num = 8;
				}
				else
				{
					switch (rest)
					{
					case 1:
						result = (ulong)bytes[offset];
						num = 1;
						break;
					case 2:
						result = ((ulong)bytes[offset] | (ulong)bytes[offset + 1] << 8);
						num = 2;
						break;
					case 3:
						result = ((ulong)bytes[offset] | (ulong)bytes[offset + 1] << 8 | (ulong)bytes[offset + 2] << 16);
						num = 3;
						break;
					case 4:
						result = ((ulong)bytes[offset] | (ulong)bytes[offset + 1] << 8 | (ulong)bytes[offset + 2] << 16 | (ulong)bytes[offset + 3] << 24);
						num = 4;
						break;
					case 5:
						result = ((ulong)bytes[offset] | (ulong)bytes[offset + 1] << 8 | (ulong)bytes[offset + 2] << 16 | (ulong)bytes[offset + 3] << 24 | (ulong)bytes[offset + 4] << 32);
						num = 5;
						break;
					case 6:
						result = ((ulong)bytes[offset] | (ulong)bytes[offset + 1] << 8 | (ulong)bytes[offset + 2] << 16 | (ulong)bytes[offset + 3] << 24 | (ulong)bytes[offset + 4] << 32 | (ulong)bytes[offset + 5] << 40);
						num = 6;
						break;
					case 7:
						result = ((ulong)bytes[offset] | (ulong)bytes[offset + 1] << 8 | (ulong)bytes[offset + 2] << 16 | (ulong)bytes[offset + 3] << 24 | (ulong)bytes[offset + 4] << 32 | (ulong)bytes[offset + 5] << 40 | (ulong)bytes[offset + 6] << 48);
						num = 7;
						break;
					default:
						throw new InvalidOperationException("Not Supported Length");
					}
				}
				offset += num;
				rest -= num;
				return result;
			}
			if (rest >= 8)
			{
				result = ((ulong)bytes[offset] << 56 | (ulong)bytes[offset + 1] << 48 | (ulong)bytes[offset + 2] << 40 | (ulong)bytes[offset + 3] << 32 | (ulong)bytes[offset + 4] << 24 | (ulong)bytes[offset + 5] << 16 | (ulong)bytes[offset + 6] << 8 | (ulong)bytes[offset + 7]);
				num = 8;
			}
			else
			{
				switch (rest)
				{
				case 1:
					result = (ulong)bytes[offset];
					num = 1;
					break;
				case 2:
					result = ((ulong)bytes[offset] << 8 | (ulong)bytes[offset + 1]);
					num = 2;
					break;
				case 3:
					result = ((ulong)bytes[offset] << 16 | (ulong)bytes[offset + 1] << 8 | (ulong)bytes[offset + 2]);
					num = 3;
					break;
				case 4:
					result = ((ulong)bytes[offset] << 24 | (ulong)bytes[offset + 1] << 16 | (ulong)bytes[offset + 2] << 8 | (ulong)bytes[offset + 3]);
					num = 4;
					break;
				case 5:
					result = ((ulong)bytes[offset] << 32 | (ulong)bytes[offset + 1] << 24 | (ulong)bytes[offset + 2] << 16 | (ulong)bytes[offset + 3] << 8 | (ulong)bytes[offset + 4]);
					num = 5;
					break;
				case 6:
					result = ((ulong)bytes[offset] << 40 | (ulong)bytes[offset + 1] << 32 | (ulong)bytes[offset + 2] << 24 | (ulong)bytes[offset + 3] << 16 | (ulong)bytes[offset + 4] << 8 | (ulong)bytes[offset + 5]);
					num = 6;
					break;
				case 7:
					result = ((ulong)bytes[offset] << 48 | (ulong)bytes[offset + 1] << 40 | (ulong)bytes[offset + 2] << 32 | (ulong)bytes[offset + 3] << 24 | (ulong)bytes[offset + 4] << 16 | (ulong)bytes[offset + 5] << 8 | (ulong)bytes[offset + 6]);
					num = 7;
					break;
				default:
					throw new InvalidOperationException("Not Supported Length");
				}
			}
			offset += num;
			rest -= num;
			return result;
		}

		// Token: 0x04000165 RID: 357
		public static readonly MethodInfo GetKeyMethod = typeof(PLFJFHEOALIJKCIFIN).GetRuntimeMethod("GetKey", new Type[]
		{
			typeof(byte*).MakeByRefType(),
			typeof(int).MakeByRefType()
		});
	}
}

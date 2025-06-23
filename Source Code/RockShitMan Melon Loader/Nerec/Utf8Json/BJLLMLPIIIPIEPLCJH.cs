using System;
using System.Text;
using Utf8Json.Internal;
using Utf8Json.Internal.DoubleConversion;

namespace Utf8Json
{
	// Token: 0x0200001D RID: 29
	public struct BJLLMLPIIIPIEPLCJH
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002BCD File Offset: 0x00000DCD
		public int IPKBDDBJOANCNNAFJP
		{
			get
			{
				return this.offset;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002BD5 File Offset: 0x00000DD5
		public void AdvanceOffset(int offset)
		{
			this.offset += offset;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000086C8 File Offset: 0x000068C8
		public static byte[] GetEncodedPropertyName(string propertyName)
		{
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = default(BJLLMLPIIIPIEPLCJH);
			bjllmlpiiipieplcjh.WritePropertyName(propertyName);
			return bjllmlpiiipieplcjh.ToUtf8ByteArray();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000086EC File Offset: 0x000068EC
		public static byte[] GetEncodedPropertyNameWithPrefixValueSeparator(string propertyName)
		{
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = default(BJLLMLPIIIPIEPLCJH);
			bjllmlpiiipieplcjh.WriteValueSeparator();
			bjllmlpiiipieplcjh.WritePropertyName(propertyName);
			return bjllmlpiiipieplcjh.ToUtf8ByteArray();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00008718 File Offset: 0x00006918
		public static byte[] GetEncodedPropertyNameWithBeginObject(string propertyName)
		{
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = default(BJLLMLPIIIPIEPLCJH);
			bjllmlpiiipieplcjh.WriteBeginObject();
			bjllmlpiiipieplcjh.WritePropertyName(propertyName);
			return bjllmlpiiipieplcjh.ToUtf8ByteArray();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00008744 File Offset: 0x00006944
		public static byte[] GetEncodedPropertyNameWithoutQuotation(string propertyName)
		{
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = default(BJLLMLPIIIPIEPLCJH);
			bjllmlpiiipieplcjh.WriteString(propertyName);
			ArraySegment<byte> arraySegment = bjllmlpiiipieplcjh.GetBuffer();
			byte[] array = new byte[arraySegment.Count - 2];
			Buffer.BlockCopy(arraySegment.Array, arraySegment.Offset + 1, array, 0, array.Length);
			return array;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002BE5 File Offset: 0x00000DE5
		public BJLLMLPIIIPIEPLCJH(byte[] initialBuffer)
		{
			this.buffer = initialBuffer;
			this.offset = 0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public ArraySegment<byte> GetBuffer()
		{
			if (this.buffer == null)
			{
				return new ArraySegment<byte>(BJLLMLPIIIPIEPLCJH.emptyBytes, 0, 0);
			}
			return new ArraySegment<byte>(this.buffer, 0, this.offset);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002C1E File Offset: 0x00000E1E
		public byte[] ToUtf8ByteArray()
		{
			if (this.buffer == null)
			{
				return BJLLMLPIIIPIEPLCJH.emptyBytes;
			}
			return GBLOAMEEDDEJCBBGHB.FastCloneWithResize(this.buffer, this.offset);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002C3F File Offset: 0x00000E3F
		public override string ToString()
		{
			if (this.buffer == null)
			{
				return null;
			}
			return Encoding.UTF8.GetString(this.buffer, 0, this.offset);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002C62 File Offset: 0x00000E62
		public void EnsureCapacity(int appendLength)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, appendLength);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00008794 File Offset: 0x00006994
		public void WriteRaw(byte rawValue)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = rawValue;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002C76 File Offset: 0x00000E76
		public void WriteRaw(byte[] rawValue)
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, rawValue.Length);
			Buffer.BlockCopy(rawValue, 0, this.buffer, this.offset, rawValue.Length);
			this.offset += rawValue.Length;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000087CC File Offset: 0x000069CC
		public void WriteRawUnsafe(byte rawValue)
		{
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = rawValue;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000087F4 File Offset: 0x000069F4
		public void WriteBeginArray()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = 91;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00008830 File Offset: 0x00006A30
		public void WriteEndArray()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = 93;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000886C File Offset: 0x00006A6C
		public void WriteBeginObject()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = 123;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000088A8 File Offset: 0x00006AA8
		public void WriteEndObject()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = 125;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000088E4 File Offset: 0x00006AE4
		public void WriteValueSeparator()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = 44;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00008920 File Offset: 0x00006B20
		public void WriteNameSeparator()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = 58;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002CB2 File Offset: 0x00000EB2
		public void WritePropertyName(string propertyName)
		{
			this.WriteString(propertyName);
			this.WriteNameSeparator();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000895C File Offset: 0x00006B5C
		public void WriteQuotation()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 1);
			byte[] array = this.buffer;
			int num = this.offset;
			this.offset = num + 1;
			array[num] = 34;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00008998 File Offset: 0x00006B98
		public void WriteNull()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 4);
			this.buffer[this.offset] = 110;
			this.buffer[this.offset + 1] = 117;
			this.buffer[this.offset + 2] = 108;
			this.buffer[this.offset + 3] = 108;
			this.offset += 4;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008A08 File Offset: 0x00006C08
		public void WriteBoolean(bool value)
		{
			if (value)
			{
				GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 4);
				this.buffer[this.offset] = 116;
				this.buffer[this.offset + 1] = 114;
				this.buffer[this.offset + 2] = 117;
				this.buffer[this.offset + 3] = 101;
				this.offset += 4;
				return;
			}
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 5);
			this.buffer[this.offset] = 102;
			this.buffer[this.offset + 1] = 97;
			this.buffer[this.offset + 2] = 108;
			this.buffer[this.offset + 3] = 115;
			this.buffer[this.offset + 4] = 101;
			this.offset += 5;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public void WriteTrue()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 4);
			this.buffer[this.offset] = 116;
			this.buffer[this.offset + 1] = 114;
			this.buffer[this.offset + 2] = 117;
			this.buffer[this.offset + 3] = 101;
			this.offset += 4;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00008B60 File Offset: 0x00006D60
		public void WriteFalse()
		{
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, this.offset, 5);
			this.buffer[this.offset] = 102;
			this.buffer[this.offset + 1] = 97;
			this.buffer[this.offset + 2] = 108;
			this.buffer[this.offset + 3] = 115;
			this.buffer[this.offset + 4] = 101;
			this.offset += 5;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002CC1 File Offset: 0x00000EC1
		public void WriteSingle(float value)
		{
			this.offset += PEFHEAKKGLPFCPKEGF.GetBytes(ref this.buffer, this.offset, value);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002CE2 File Offset: 0x00000EE2
		public void WriteDouble(double value)
		{
			this.offset += PEFHEAKKGLPFCPKEGF.GetBytes(ref this.buffer, this.offset, value);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002D03 File Offset: 0x00000F03
		public void WriteByte(byte value)
		{
			this.WriteUInt64((ulong)value);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002D03 File Offset: 0x00000F03
		public void WriteUInt16(ushort value)
		{
			this.WriteUInt64((ulong)value);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002D03 File Offset: 0x00000F03
		public void WriteUInt32(uint value)
		{
			this.WriteUInt64((ulong)value);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002D0D File Offset: 0x00000F0D
		public void WriteUInt64(ulong value)
		{
			this.offset += OCPOKGPLBCLIEHKKHN.WriteUInt64(ref this.buffer, this.offset, value);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002D2E File Offset: 0x00000F2E
		public void WriteSByte(sbyte value)
		{
			this.WriteInt64((long)value);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002D2E File Offset: 0x00000F2E
		public void WriteInt16(short value)
		{
			this.WriteInt64((long)value);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002D2E File Offset: 0x00000F2E
		public void WriteInt32(int value)
		{
			this.WriteInt64((long)value);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002D38 File Offset: 0x00000F38
		public void WriteInt64(long value)
		{
			this.offset += OCPOKGPLBCLIEHKKHN.WriteInt64(ref this.buffer, this.offset, value);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00008BE0 File Offset: 0x00006DE0
		public void WriteString(string value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			int num = this.offset;
			int num2 = CHFCLNEOCDIHMILKOP.UTF8.GetMaxByteCount(value.Length) + 2;
			GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, num, num2);
			int num3 = 0;
			int length = value.Length;
			byte[] array = this.buffer;
			int num4 = this.offset;
			this.offset = num4 + 1;
			array[num4] = 34;
			int i = 0;
			while (i < value.Length)
			{
				byte b;
				switch (value[i])
				{
				case '\b':
					b = 98;
					goto IL_211;
				case '\t':
					b = 116;
					goto IL_211;
				case '\n':
					b = 110;
					goto IL_211;
				case '\f':
					b = 102;
					goto IL_211;
				case '\r':
					b = 114;
					goto IL_211;
				case '"':
					b = 34;
					goto IL_211;
				case '\\':
					b = 92;
					goto IL_211;
				}
				IL_284:
				i++;
				continue;
				IL_211:
				num2 += 2;
				GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref this.buffer, num, num2);
				this.offset += CHFCLNEOCDIHMILKOP.UTF8.GetBytes(value, num3, i - num3, this.buffer, this.offset);
				num3 = i + 1;
				byte[] array2 = this.buffer;
				num4 = this.offset;
				this.offset = num4 + 1;
				array2[num4] = 92;
				byte[] array3 = this.buffer;
				num4 = this.offset;
				this.offset = num4 + 1;
				array3[num4] = b;
				goto IL_284;
			}
			if (num3 != value.Length)
			{
				this.offset += CHFCLNEOCDIHMILKOP.UTF8.GetBytes(value, num3, value.Length - num3, this.buffer, this.offset);
			}
			byte[] array4 = this.buffer;
			num4 = this.offset;
			this.offset = num4 + 1;
			array4[num4] = 34;
		}

		// Token: 0x0400002F RID: 47
		private static readonly byte[] emptyBytes = new byte[0];

		// Token: 0x04000030 RID: 48
		private byte[] buffer;

		// Token: 0x04000031 RID: 49
		private int offset;
	}
}

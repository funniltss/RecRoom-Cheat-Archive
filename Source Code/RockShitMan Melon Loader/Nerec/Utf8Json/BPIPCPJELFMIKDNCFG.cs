using System;
using System.Text;
using Utf8Json.Internal;
using Utf8Json.Internal.DoubleConversion;

namespace Utf8Json
{
	// Token: 0x02000010 RID: 16
	public struct BPIPCPJELFMIKDNCFG
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000023F9 File Offset: 0x000005F9
		public BPIPCPJELFMIKDNCFG(byte[] bytes)
		{
			this = new BPIPCPJELFMIKDNCFG(bytes, 0);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000697C File Offset: 0x00004B7C
		public BPIPCPJELFMIKDNCFG(byte[] bytes, int offset)
		{
			this.bytes = bytes;
			this.offset = offset;
			if (bytes.Length >= 3 && bytes[offset] == BPIPCPJELFMIKDNCFG.bom[0] && bytes[offset + 1] == BPIPCPJELFMIKDNCFG.bom[1] && bytes[offset + 2] == BPIPCPJELFMIKDNCFG.bom[2])
			{
				offset = (this.offset = offset + 3);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000069D4 File Offset: 0x00004BD4
		private AAOCAAJHAGCFOOIPCG CreateParsingException(string expected)
		{
			char c = (char)this.bytes[this.offset];
			string text = c.ToString();
			int num = this.offset;
			try
			{
				switch (this.GetCurrentJsonToken())
				{
				case IHACCEAELFJBICGADL.Number:
				{
					ArraySegment<byte> arraySegment = this.ReadNumberSegment();
					text = CHFCLNEOCDIHMILKOP.UTF8.GetString(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
					break;
				}
				case IHACCEAELFJBICGADL.String:
					text = "\"" + this.ReadString() + "\"";
					break;
				case IHACCEAELFJBICGADL.True:
					text = "true";
					break;
				case IHACCEAELFJBICGADL.False:
					text = "false";
					break;
				case IHACCEAELFJBICGADL.Null:
					text = "null";
					break;
				}
			}
			catch
			{
			}
			return new AAOCAAJHAGCFOOIPCG(string.Concat(new string[]
			{
				"expected:'",
				expected,
				"', actual:'",
				text,
				"', at offset:",
				num.ToString()
			}), this.bytes, num, this.offset, text);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00006AD8 File Offset: 0x00004CD8
		private AAOCAAJHAGCFOOIPCG CreateParsingExceptionMessage(string message)
		{
			char c = (char)this.bytes[this.offset];
			string actualChar = c.ToString();
			int limit = this.offset;
			return new AAOCAAJHAGCFOOIPCG(message, this.bytes, limit, limit, actualChar);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002403 File Offset: 0x00000603
		private bool MGIPIPMFJIIAPCHPMI
		{
			get
			{
				return this.offset < this.bytes.Length;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002415 File Offset: 0x00000615
		public void AdvanceOffset(int offset)
		{
			this.offset += offset;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002425 File Offset: 0x00000625
		public byte[] GetBufferUnsafe()
		{
			return this.bytes;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000242D File Offset: 0x0000062D
		public int GetCurrentOffsetUnsafe()
		{
			return this.offset;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006B14 File Offset: 0x00004D14
		public IHACCEAELFJBICGADL GetCurrentJsonToken()
		{
			this.SkipWhiteSpace();
			if (this.offset < this.bytes.Length)
			{
				switch (this.bytes[this.offset])
				{
				case 34:
					return IHACCEAELFJBICGADL.String;
				case 44:
					return IHACCEAELFJBICGADL.ValueSeparator;
				case 45:
					return IHACCEAELFJBICGADL.Number;
				case 48:
					return IHACCEAELFJBICGADL.Number;
				case 49:
					return IHACCEAELFJBICGADL.Number;
				case 50:
					return IHACCEAELFJBICGADL.Number;
				case 51:
					return IHACCEAELFJBICGADL.Number;
				case 52:
					return IHACCEAELFJBICGADL.Number;
				case 53:
					return IHACCEAELFJBICGADL.Number;
				case 54:
					return IHACCEAELFJBICGADL.Number;
				case 55:
					return IHACCEAELFJBICGADL.Number;
				case 56:
					return IHACCEAELFJBICGADL.Number;
				case 57:
					return IHACCEAELFJBICGADL.Number;
				case 58:
					return IHACCEAELFJBICGADL.NameSeparator;
				case 91:
					return IHACCEAELFJBICGADL.BeginArray;
				case 93:
					return IHACCEAELFJBICGADL.EndArray;
				case 102:
					return IHACCEAELFJBICGADL.False;
				case 110:
					return IHACCEAELFJBICGADL.Null;
				case 116:
					return IHACCEAELFJBICGADL.True;
				case 123:
					return IHACCEAELFJBICGADL.BeginObject;
				case 125:
					return IHACCEAELFJBICGADL.EndObject;
				}
				return IHACCEAELFJBICGADL.None;
			}
			return IHACCEAELFJBICGADL.None;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00006D78 File Offset: 0x00004F78
		public void SkipWhiteSpace()
		{
			int i = this.offset;
			while (i < this.bytes.Length)
			{
				switch (this.bytes[i])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 11:
				case 12:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 30:
				case 31:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 41:
				case 42:
				case 43:
				case 44:
				case 45:
				case 46:
					goto IL_EC;
				case 9:
				case 10:
				case 13:
				case 32:
					break;
				case 47:
					i = BPIPCPJELFMIKDNCFG.ReadComment(this.bytes, i);
					break;
				default:
					goto IL_EC;
				}
				i++;
				continue;
				IL_EC:
				this.offset = i;
				return;
			}
			this.offset = this.bytes.Length;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006E9C File Offset: 0x0000509C
		public bool ReadIsNull()
		{
			this.SkipWhiteSpace();
			if (!this.MGIPIPMFJIIAPCHPMI || this.bytes[this.offset] != 110)
			{
				return false;
			}
			if (this.bytes[this.offset + 1] == 117 && this.bytes[this.offset + 2] == 108 && this.bytes[this.offset + 3] == 108)
			{
				this.offset += 4;
				return true;
			}
			throw this.CreateParsingException("null");
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002435 File Offset: 0x00000635
		public bool ReadIsBeginArray()
		{
			this.SkipWhiteSpace();
			if (this.MGIPIPMFJIIAPCHPMI && this.bytes[this.offset] == 91)
			{
				this.offset++;
				return true;
			}
			return false;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002467 File Offset: 0x00000667
		public void ReadIsBeginArrayWithVerify()
		{
			if (!this.ReadIsBeginArray())
			{
				throw this.CreateParsingException("[");
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000247D File Offset: 0x0000067D
		public bool ReadIsEndArray()
		{
			this.SkipWhiteSpace();
			if (this.MGIPIPMFJIIAPCHPMI && this.bytes[this.offset] == 93)
			{
				this.offset++;
				return true;
			}
			return false;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000024AF File Offset: 0x000006AF
		public void ReadIsEndArrayWithVerify()
		{
			if (!this.ReadIsEndArray())
			{
				throw this.CreateParsingException("]");
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006F20 File Offset: 0x00005120
		public bool ReadIsEndArrayWithSkipValueSeparator(ref int count)
		{
			this.SkipWhiteSpace();
			if (this.MGIPIPMFJIIAPCHPMI && this.bytes[this.offset] == 93)
			{
				this.offset++;
				return true;
			}
			int num = count;
			count = num + 1;
			if (num != 0)
			{
				this.ReadIsValueSeparatorWithVerify();
			}
			return false;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024C5 File Offset: 0x000006C5
		public bool ReadIsInArray(ref int count)
		{
			if (count == 0)
			{
				this.ReadIsBeginArrayWithVerify();
				if (this.ReadIsEndArray())
				{
					return false;
				}
			}
			else
			{
				if (this.ReadIsEndArray())
				{
					return false;
				}
				this.ReadIsValueSeparatorWithVerify();
			}
			count++;
			return true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024F2 File Offset: 0x000006F2
		public bool ReadIsBeginObject()
		{
			this.SkipWhiteSpace();
			if (this.MGIPIPMFJIIAPCHPMI && this.bytes[this.offset] == 123)
			{
				this.offset++;
				return true;
			}
			return false;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002524 File Offset: 0x00000724
		public void ReadIsBeginObjectWithVerify()
		{
			if (!this.ReadIsBeginObject())
			{
				throw this.CreateParsingException("{");
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000253A File Offset: 0x0000073A
		public bool ReadIsEndObject()
		{
			this.SkipWhiteSpace();
			if (this.MGIPIPMFJIIAPCHPMI && this.bytes[this.offset] == 125)
			{
				this.offset++;
				return true;
			}
			return false;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000256C File Offset: 0x0000076C
		public void ReadIsEndObjectWithVerify()
		{
			if (!this.ReadIsEndObject())
			{
				throw this.CreateParsingException("}");
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006F70 File Offset: 0x00005170
		public bool ReadIsEndObjectWithSkipValueSeparator(ref int count)
		{
			this.SkipWhiteSpace();
			if (this.MGIPIPMFJIIAPCHPMI && this.bytes[this.offset] == 125)
			{
				this.offset++;
				return true;
			}
			int num = count;
			count = num + 1;
			if (num != 0)
			{
				this.ReadIsValueSeparatorWithVerify();
			}
			return false;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002582 File Offset: 0x00000782
		public bool ReadIsInObject(ref int count)
		{
			if (count == 0)
			{
				this.ReadIsBeginObjectWithVerify();
				if (this.ReadIsEndObject())
				{
					return false;
				}
			}
			else
			{
				if (this.ReadIsEndObject())
				{
					return false;
				}
				this.ReadIsValueSeparatorWithVerify();
			}
			count++;
			return true;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000025AF File Offset: 0x000007AF
		public bool ReadIsValueSeparator()
		{
			this.SkipWhiteSpace();
			if (this.MGIPIPMFJIIAPCHPMI && this.bytes[this.offset] == 44)
			{
				this.offset++;
				return true;
			}
			return false;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000025E1 File Offset: 0x000007E1
		public void ReadIsValueSeparatorWithVerify()
		{
			if (!this.ReadIsValueSeparator())
			{
				throw this.CreateParsingException(",");
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000025F7 File Offset: 0x000007F7
		public bool ReadIsNameSeparator()
		{
			this.SkipWhiteSpace();
			if (this.MGIPIPMFJIIAPCHPMI && this.bytes[this.offset] == 58)
			{
				this.offset++;
				return true;
			}
			return false;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002629 File Offset: 0x00000829
		public void ReadIsNameSeparatorWithVerify()
		{
			if (!this.ReadIsNameSeparator())
			{
				throw this.CreateParsingException(":");
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006FC0 File Offset: 0x000051C0
		private void ReadStringSegmentCore(out byte[] resultBytes, out int resultOffset, out int resultLength)
		{
			byte[] array = null;
			int num = 0;
			char[] array2 = null;
			int num2 = 0;
			if (this.bytes[this.offset] != 34)
			{
				throw this.CreateParsingException("String Begin Token");
			}
			this.offset++;
			int num3 = this.offset;
			int i = this.offset;
			while (i < this.bytes.Length)
			{
				byte b = this.bytes[i];
				if (b != 34)
				{
					if (b == 92)
					{
						char c = (char)this.bytes[i + 1];
						byte b2;
						if (c <= '\\')
						{
							if (c != '"' && c != '/' && c != '\\')
							{
								goto IL_1C6;
							}
							b2 = this.bytes[i + 1];
						}
						else if (c <= 'f')
						{
							if (c != 'b')
							{
								if (c != 'f')
								{
									goto IL_1C6;
								}
								b2 = 12;
							}
							else
							{
								b2 = 8;
							}
						}
						else if (c != 'n')
						{
							switch (c)
							{
							case 'r':
								b2 = 13;
								break;
							case 's':
								goto IL_1C6;
							case 't':
								b2 = 9;
								break;
							case 'u':
							{
								if (array2 == null)
								{
									array2 = BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.GetCodePointStringBuffer();
								}
								if (num2 == 0)
								{
									if (array == null)
									{
										array = BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.GetBuffer();
									}
									int num4 = i - num3;
									GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref array, num, num4 + 1);
									Buffer.BlockCopy(this.bytes, num3, array, num, num4);
									num += num4;
								}
								if (array2.Length == num2)
								{
									Array.Resize<char>(ref array2, array2.Length * 2);
								}
								char a = (char)this.bytes[i + 2];
								char b3 = (char)this.bytes[i + 3];
								char c2 = (char)this.bytes[i + 4];
								char d = (char)this.bytes[i + 5];
								int codePoint = BPIPCPJELFMIKDNCFG.GetCodePoint(a, b3, c2, d);
								array2[num2++] = (char)codePoint;
								i += 5;
								this.offset += 6;
								num3 = this.offset;
								goto IL_2AC;
							}
							default:
								goto IL_1C6;
							}
						}
						else
						{
							b2 = 10;
						}
						if (array == null)
						{
							array = BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.GetBuffer();
						}
						if (num2 != 0)
						{
							GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref array, num, CHFCLNEOCDIHMILKOP.UTF8.GetMaxByteCount(num2));
							num += CHFCLNEOCDIHMILKOP.UTF8.GetBytes(array2, 0, num2, array, num);
							num2 = 0;
						}
						int num5 = i - num3;
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref array, num, num5 + 1);
						Buffer.BlockCopy(this.bytes, num3, array, num, num5);
						num += num5;
						array[num++] = b2;
						i++;
						this.offset += 2;
						num3 = this.offset;
						goto IL_2AC;
						IL_1C6:
						throw this.CreateParsingExceptionMessage("Bad JSON escape.");
					}
					if (num2 != 0)
					{
						if (array == null)
						{
							array = BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.GetBuffer();
						}
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref array, num, CHFCLNEOCDIHMILKOP.UTF8.GetMaxByteCount(num2));
						num += CHFCLNEOCDIHMILKOP.UTF8.GetBytes(array2, 0, num2, array, num);
						num2 = 0;
					}
					this.offset++;
					IL_2AC:
					i++;
				}
				else
				{
					this.offset++;
					if (num == 0 && num2 == 0)
					{
						resultBytes = this.bytes;
						resultOffset = num3;
						resultLength = this.offset - 1 - num3;
						return;
					}
					if (array == null)
					{
						array = BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.GetBuffer();
					}
					if (num2 != 0)
					{
						GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref array, num, CHFCLNEOCDIHMILKOP.UTF8.GetMaxByteCount(num2));
						num += CHFCLNEOCDIHMILKOP.UTF8.GetBytes(array2, 0, num2, array, num);
					}
					int num6 = this.offset - num3 - 1;
					GBLOAMEEDDEJCBBGHB.EnsureCapacity(ref array, num, num6);
					Buffer.BlockCopy(this.bytes, num3, array, num, num6);
					num += num6;
					resultBytes = array;
					resultOffset = 0;
					resultLength = num;
					return;
				}
			}
			resultLength = 0;
			resultBytes = null;
			resultOffset = 0;
			throw this.CreateParsingException("String End Token");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000263F File Offset: 0x0000083F
		private static int GetCodePoint(char a, char b, char c, char d)
		{
			return ((BPIPCPJELFMIKDNCFG.ToNumber(a) * 16 + BPIPCPJELFMIKDNCFG.ToNumber(b)) * 16 + BPIPCPJELFMIKDNCFG.ToNumber(c)) * 16 + BPIPCPJELFMIKDNCFG.ToNumber(d);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000732C File Offset: 0x0000552C
		private static int ToNumber(char x)
		{
			if ('0' <= x && x <= '9')
			{
				return (int)(x - '0');
			}
			if ('a' <= x && x <= 'f')
			{
				return (int)(x - 'a' + '\n');
			}
			if ('A' <= x && x <= 'F')
			{
				return (int)(x - 'A' + '\n');
			}
			throw new AAOCAAJHAGCFOOIPCG("Invalid Character" + x.ToString());
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00007384 File Offset: 0x00005584
		public ArraySegment<byte> ReadStringSegmentUnsafe()
		{
			if (this.ReadIsNull())
			{
				return BPIPCPJELFMIKDNCFG.nullTokenSegment;
			}
			byte[] array;
			int num;
			int count;
			this.ReadStringSegmentCore(out array, out num, out count);
			return new ArraySegment<byte>(array, num, count);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000073B4 File Offset: 0x000055B4
		public string ReadString()
		{
			if (this.ReadIsNull())
			{
				return null;
			}
			byte[] array;
			int index;
			int count;
			this.ReadStringSegmentCore(out array, out index, out count);
			return Encoding.UTF8.GetString(array, index, count);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002665 File Offset: 0x00000865
		public string ReadPropertyName()
		{
			string result = this.ReadString();
			this.ReadIsNameSeparatorWithVerify();
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000073E4 File Offset: 0x000055E4
		public ArraySegment<byte> ReadStringSegmentRaw()
		{
			ArraySegment<byte> result = default(ArraySegment<byte>);
			if (this.ReadIsNull())
			{
				result = BPIPCPJELFMIKDNCFG.nullTokenSegment;
			}
			else
			{
				byte[] array = this.bytes;
				int num = this.offset;
				this.offset = num + 1;
				if (array[num] != 34)
				{
					throw this.CreateParsingException("\"");
				}
				int num2 = this.offset;
				for (int i = this.offset; i < this.bytes.Length; i++)
				{
					if (this.bytes[i] == 34 && this.bytes[i - 1] != 92)
					{
						this.offset = i + 1;
						result = new ArraySegment<byte>(this.bytes, num2, this.offset - num2 - 1);
						return result;
					}
				}
				throw this.CreateParsingExceptionMessage("not found end string.");
			}
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002673 File Offset: 0x00000873
		public ArraySegment<byte> ReadPropertyNameSegmentRaw()
		{
			ArraySegment<byte> result = this.ReadStringSegmentRaw();
			this.ReadIsNameSeparatorWithVerify();
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000074A0 File Offset: 0x000056A0
		public bool ReadBoolean()
		{
			this.SkipWhiteSpace();
			if (this.bytes[this.offset] == 116)
			{
				if (this.bytes[this.offset + 1] == 114 && this.bytes[this.offset + 2] == 117 && this.bytes[this.offset + 3] == 101)
				{
					this.offset += 4;
					return true;
				}
				throw this.CreateParsingException("true");
			}
			else
			{
				if (this.bytes[this.offset] != 102)
				{
					throw this.CreateParsingException("true | false");
				}
				if (this.bytes[this.offset + 1] == 97 && this.bytes[this.offset + 2] == 108 && this.bytes[this.offset + 3] == 115 && this.bytes[this.offset + 4] == 101)
				{
					this.offset += 5;
					return false;
				}
				throw this.CreateParsingException("false");
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000075A8 File Offset: 0x000057A8
		private static bool IsWordBreak(byte c)
		{
			switch (c)
			{
			case 32:
			case 34:
			case 44:
			case 58:
			case 91:
			case 93:
			case 123:
			case 125:
				return true;
			}
			return false;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000077B8 File Offset: 0x000059B8
		public void ReadNext()
		{
			IHACCEAELFJBICGADL currentJsonToken = this.GetCurrentJsonToken();
			this.ReadNextCore(currentJsonToken);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000077D4 File Offset: 0x000059D4
		private void ReadNextCore(IHACCEAELFJBICGADL token)
		{
			switch (token)
			{
			case IHACCEAELFJBICGADL.None:
				break;
			case IHACCEAELFJBICGADL.BeginObject:
			case IHACCEAELFJBICGADL.EndObject:
			case IHACCEAELFJBICGADL.BeginArray:
			case IHACCEAELFJBICGADL.EndArray:
			case IHACCEAELFJBICGADL.ValueSeparator:
			case IHACCEAELFJBICGADL.NameSeparator:
				this.offset++;
				return;
			case IHACCEAELFJBICGADL.Number:
				for (int i = this.offset; i < this.bytes.Length; i++)
				{
					if (BPIPCPJELFMIKDNCFG.IsWordBreak(this.bytes[i]))
					{
						this.offset = i;
						return;
					}
				}
				this.offset = this.bytes.Length;
				break;
			case IHACCEAELFJBICGADL.String:
				this.offset++;
				for (int j = this.offset; j < this.bytes.Length; j++)
				{
					if (this.bytes[j] == 34 && this.bytes[j - 1] != 92)
					{
						this.offset = j + 1;
						return;
					}
				}
				throw this.CreateParsingExceptionMessage("not found end string.");
			case IHACCEAELFJBICGADL.True:
			case IHACCEAELFJBICGADL.Null:
				this.offset += 4;
				return;
			case IHACCEAELFJBICGADL.False:
				this.offset += 5;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000078D8 File Offset: 0x00005AD8
		public void ReadNextBlock()
		{
			int num = 0;
			for (;;)
			{
				IHACCEAELFJBICGADL currentJsonToken = this.GetCurrentJsonToken();
				switch (currentJsonToken)
				{
				case IHACCEAELFJBICGADL.None:
					return;
				case IHACCEAELFJBICGADL.BeginObject:
				case IHACCEAELFJBICGADL.BeginArray:
					this.offset++;
					num++;
					continue;
				case IHACCEAELFJBICGADL.EndObject:
				case IHACCEAELFJBICGADL.EndArray:
					this.offset++;
					num--;
					if (num != 0)
					{
						continue;
					}
					return;
				case IHACCEAELFJBICGADL.Number:
				case IHACCEAELFJBICGADL.String:
				case IHACCEAELFJBICGADL.True:
				case IHACCEAELFJBICGADL.False:
				case IHACCEAELFJBICGADL.Null:
				case IHACCEAELFJBICGADL.ValueSeparator:
				case IHACCEAELFJBICGADL.NameSeparator:
					do
					{
						this.ReadNextCore(currentJsonToken);
						currentJsonToken = this.GetCurrentJsonToken();
					}
					while (num != 0 && currentJsonToken >= IHACCEAELFJBICGADL.Number);
					if (num == 0)
					{
						return;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000796C File Offset: 0x00005B6C
		public ArraySegment<byte> ReadNextBlockSegment()
		{
			int num = this.offset;
			this.ReadNextBlock();
			return new ArraySegment<byte>(this.bytes, num, this.offset - num);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002681 File Offset: 0x00000881
		public sbyte ReadSByte()
		{
			return checked((sbyte)this.ReadInt64());
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000268A File Offset: 0x0000088A
		public short ReadInt16()
		{
			return checked((short)this.ReadInt64());
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002693 File Offset: 0x00000893
		public int ReadInt32()
		{
			return checked((int)this.ReadInt64());
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000799C File Offset: 0x00005B9C
		public long ReadInt64()
		{
			this.SkipWhiteSpace();
			int num;
			long result = OCPOKGPLBCLIEHKKHN.ReadInt64(this.bytes, this.offset, out num);
			if (num == 0)
			{
				throw this.CreateParsingException("Number Token");
			}
			this.offset += num;
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000269C File Offset: 0x0000089C
		public byte ReadByte()
		{
			return checked((byte)this.ReadUInt64());
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000026A5 File Offset: 0x000008A5
		public ushort ReadUInt16()
		{
			return checked((ushort)this.ReadUInt64());
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000026AE File Offset: 0x000008AE
		public uint ReadUInt32()
		{
			return checked((uint)this.ReadUInt64());
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000079E0 File Offset: 0x00005BE0
		public ulong ReadUInt64()
		{
			this.SkipWhiteSpace();
			int num;
			ulong result = OCPOKGPLBCLIEHKKHN.ReadUInt64(this.bytes, this.offset, out num);
			if (num == 0)
			{
				throw this.CreateParsingException("Number Token");
			}
			this.offset += num;
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007A24 File Offset: 0x00005C24
		public float ReadSingle()
		{
			this.SkipWhiteSpace();
			int num;
			float result = JHMMNENMMBEGNACKKH.ToSingle(this.bytes, this.offset, out num);
			if (num == 0)
			{
				throw this.CreateParsingException("Number Token");
			}
			this.offset += num;
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007A68 File Offset: 0x00005C68
		public double ReadDouble()
		{
			this.SkipWhiteSpace();
			int num;
			double result = JHMMNENMMBEGNACKKH.ToDouble(this.bytes, this.offset, out num);
			if (num == 0)
			{
				throw this.CreateParsingException("Number Token");
			}
			this.offset += num;
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007AAC File Offset: 0x00005CAC
		public ArraySegment<byte> ReadNumberSegment()
		{
			this.SkipWhiteSpace();
			int num = this.offset;
			for (int i = this.offset; i < this.bytes.Length; i++)
			{
				if (!OCPOKGPLBCLIEHKKHN.IsNumberRepresentation(this.bytes[i]))
				{
					this.offset = i;
					IL_4B:
					return new ArraySegment<byte>(this.bytes, num, this.offset - num);
				}
			}
			this.offset = this.bytes.Length;
			goto IL_4B;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007B18 File Offset: 0x00005D18
		private static int ReadComment(byte[] bytes, int offset)
		{
			if (bytes[offset + 1] == 47)
			{
				offset += 2;
				for (int i = offset; i < bytes.Length; i++)
				{
					if (bytes[i] == 13 || bytes[i] == 10)
					{
						return i;
					}
				}
				throw new AAOCAAJHAGCFOOIPCG("Can not find end token of single line comment(\r or \n).");
			}
			if (bytes[offset + 1] == 42)
			{
				offset += 2;
				for (int j = offset; j < bytes.Length; j++)
				{
					if (bytes[j] == 42 && bytes[j + 1] == 47)
					{
						return j + 1;
					}
				}
				throw new AAOCAAJHAGCFOOIPCG("Can not find end token of multi line comment(*/).");
			}
			return offset;
		}

		// Token: 0x04000005 RID: 5
		private static readonly ArraySegment<byte> nullTokenSegment = new ArraySegment<byte>(new byte[]
		{
			110,
			117,
			108,
			108
		}, 0, 4);

		// Token: 0x04000006 RID: 6
		private static readonly byte[] bom = Encoding.UTF8.GetPreamble();

		// Token: 0x04000007 RID: 7
		private readonly byte[] bytes;

		// Token: 0x04000008 RID: 8
		private int offset;

		// Token: 0x02000011 RID: 17
		internal static class NOFAKLNPPNGFAICFLG
		{
			// Token: 0x06000052 RID: 82 RVA: 0x000026E5 File Offset: 0x000008E5
			public static byte[] GetBuffer()
			{
				if (BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.buffer == null)
				{
					BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.buffer = new byte[65535];
				}
				return BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.buffer;
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002702 File Offset: 0x00000902
			public static char[] GetCodePointStringBuffer()
			{
				if (BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.codePointStringBuffer == null)
				{
					BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.codePointStringBuffer = new char[65535];
				}
				return BPIPCPJELFMIKDNCFG.NOFAKLNPPNGFAICFLG.codePointStringBuffer;
			}

			// Token: 0x04000009 RID: 9
			[ThreadStatic]
			private static byte[] buffer;

			// Token: 0x0400000A RID: 10
			[ThreadStatic]
			private static char[] codePointStringBuffer;
		}
	}
}

using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace Utf8Json.Internal
{
	// Token: 0x020000A4 RID: 164
	internal class NBNDJGENFIKGKIHENM : BinaryReader
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00004003 File Offset: 0x00002203
		public int BEMHKEKJACIMKLPMKF
		{
			get
			{
				return (int)this.BaseStream.Position;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00004011 File Offset: 0x00002211
		public bool BNNOHNHANGEKHHKJCL
		{
			get
			{
				return (int)this.BaseStream.Position >= this.endPosition;
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000E958 File Offset: 0x0000CB58
		static NBNDJGENFIKGKIHENM()
		{
			FieldInfo[] fields = typeof(OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			{
				OpCode opCode = (OpCode)fields[i].GetValue(null);
				ushort num = (ushort)opCode.Value;
				if (num < 256)
				{
					NBNDJGENFIKGKIHENM.oneByteOpCodes[(int)num] = opCode;
				}
				else if ((num & 65280) == 65024)
				{
					NBNDJGENFIKGKIHENM.twoByteOpCodes[(int)(num & 255)] = opCode;
				}
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000402A File Offset: 0x0000222A
		public NBNDJGENFIKGKIHENM(byte[] ilByteArray) : base(new MemoryStream(ilByteArray))
		{
			this.endPosition = ilByteArray.Length;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
		public OpCode ReadOpCode()
		{
			byte b = this.ReadByte();
			if (b != 254)
			{
				return NBNDJGENFIKGKIHENM.oneByteOpCodes[(int)b];
			}
			b = this.ReadByte();
			return NBNDJGENFIKGKIHENM.twoByteOpCodes[(int)b];
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00004041 File Offset: 0x00002241
		public int ReadMetadataToken()
		{
			return this.ReadInt32();
		}

		// Token: 0x04000172 RID: 370
		private static readonly OpCode[] oneByteOpCodes = new OpCode[256];

		// Token: 0x04000173 RID: 371
		private static readonly OpCode[] twoByteOpCodes = new OpCode[256];

		// Token: 0x04000174 RID: 372
		private int endPosition;
	}
}

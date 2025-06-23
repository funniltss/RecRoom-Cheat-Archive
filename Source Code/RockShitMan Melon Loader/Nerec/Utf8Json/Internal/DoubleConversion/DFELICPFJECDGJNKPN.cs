using System;
using System.Reflection;

namespace Utf8Json.Internal.DoubleConversion
{
	// Token: 0x020000C7 RID: 199
	[DefaultMember("Item")]
	internal struct DFELICPFJECDGJNKPN
	{
		// Token: 0x06000348 RID: 840 RVA: 0x00004A49 File Offset: 0x00002C49
		public DFELICPFJECDGJNKPN(byte[] bytes, int start, int length)
		{
			this.bytes = bytes;
			this.start = start;
			this._length = length;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00004A60 File Offset: 0x00002C60
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00004A71 File Offset: 0x00002C71
		public byte JKKPELLIDMMLFCFINB
		{
			get
			{
				return this.bytes[this.start + i];
			}
			set
			{
				this.bytes[this.start + i] = value;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00004A83 File Offset: 0x00002C83
		public int length()
		{
			return this._length;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00004A8B File Offset: 0x00002C8B
		public byte first()
		{
			return this.bytes[this.start];
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00004A9A File Offset: 0x00002C9A
		public byte last()
		{
			return this.bytes[this._length - 1];
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00004AAB File Offset: 0x00002CAB
		public bool is_empty()
		{
			return this._length == 0;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00004AB6 File Offset: 0x00002CB6
		public DFELICPFJECDGJNKPN SubVector(int from, int to)
		{
			return new DFELICPFJECDGJNKPN(this.bytes, this.start + from, to - from);
		}

		// Token: 0x0400020F RID: 527
		public readonly byte[] bytes;

		// Token: 0x04000210 RID: 528
		public readonly int start;

		// Token: 0x04000211 RID: 529
		public readonly int _length;
	}
}

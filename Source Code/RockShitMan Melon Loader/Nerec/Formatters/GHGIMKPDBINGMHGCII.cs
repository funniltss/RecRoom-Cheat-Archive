using System;
using System.Runtime.CompilerServices;

namespace Utf8Json.Formatters
{
	// Token: 0x020000FB RID: 251
	public static class GHGIMKPDBINGMHGCII
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x000161A8 File Offset: 0x000143A8
		public static object GetSerializeDelegate(Type type, out bool isBoxed)
		{
			Type underlyingType = Enum.GetUnderlyingType(type);
			isBoxed = true;
			OJFAAEDNBNAMBCPLED<object> result;
			if (underlyingType == typeof(byte))
			{
				result = delegate(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
				{
					writer.WriteByte((byte)value);
				};
			}
			else if (underlyingType == typeof(sbyte))
			{
				result = delegate(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
				{
					writer.WriteSByte((sbyte)value);
				};
			}
			else if (underlyingType == typeof(short))
			{
				result = delegate(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
				{
					writer.WriteInt16((short)value);
				};
			}
			else if (underlyingType == typeof(ushort))
			{
				result = delegate(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
				{
					writer.WriteUInt16((ushort)value);
				};
			}
			else if (underlyingType == typeof(int))
			{
				result = delegate(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
				{
					writer.WriteInt32((int)value);
				};
			}
			else if (underlyingType == typeof(uint))
			{
				result = delegate(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
				{
					writer.WriteUInt32((uint)value);
				};
			}
			else if (underlyingType == typeof(long))
			{
				result = delegate(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
				{
					writer.WriteInt64((long)value);
				};
			}
			else
			{
				if (!(underlyingType == typeof(ulong)))
				{
					throw new InvalidOperationException("Type is not Enum. Type:" + ((type != null) ? type.ToString() : null));
				}
				result = delegate(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
				{
					writer.WriteUInt64((ulong)value);
				};
			}
			return result;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00016390 File Offset: 0x00014590
		public static object GetDeserializeDelegate(Type type, out bool isBoxed)
		{
			Type underlyingType = Enum.GetUnderlyingType(type);
			isBoxed = true;
			PCPKEIOPEDBCBJAJCJ<object> result;
			if (underlyingType == typeof(byte))
			{
				result = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return reader.ReadByte();
				};
			}
			else if (underlyingType == typeof(sbyte))
			{
				result = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return reader.ReadSByte();
				};
			}
			else if (underlyingType == typeof(short))
			{
				result = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return reader.ReadInt16();
				};
			}
			else if (underlyingType == typeof(ushort))
			{
				result = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return reader.ReadUInt16();
				};
			}
			else if (underlyingType == typeof(int))
			{
				result = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return reader.ReadInt32();
				};
			}
			else if (underlyingType == typeof(uint))
			{
				result = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return reader.ReadUInt32();
				};
			}
			else if (underlyingType == typeof(long))
			{
				result = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return reader.ReadInt64();
				};
			}
			else
			{
				if (!(underlyingType == typeof(ulong)))
				{
					throw new InvalidOperationException("Type is not Enum. Type:" + ((type != null) ? type.ToString() : null));
				}
				result = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return reader.ReadUInt64();
				};
			}
			return result;
		}

		// Token: 0x020000FC RID: 252
		[CompilerGenerated]
		[Serializable]
		private sealed class DOCEBOAPEOJADCKPLK
		{
			// Token: 0x06000431 RID: 1073 RVA: 0x000051D2 File Offset: 0x000033D2
			internal void <GetSerializeDelegate>b__0_0(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
			{
				writer.WriteByte((byte)value);
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x000051E0 File Offset: 0x000033E0
			internal void <GetSerializeDelegate>b__0_1(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
			{
				writer.WriteSByte((sbyte)value);
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x000051EE File Offset: 0x000033EE
			internal void <GetSerializeDelegate>b__0_2(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
			{
				writer.WriteInt16((short)value);
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x000051FC File Offset: 0x000033FC
			internal void <GetSerializeDelegate>b__0_3(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
			{
				writer.WriteUInt16((ushort)value);
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x0000520A File Offset: 0x0000340A
			internal void <GetSerializeDelegate>b__0_4(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
			{
				writer.WriteInt32((int)value);
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x00005218 File Offset: 0x00003418
			internal void <GetSerializeDelegate>b__0_5(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
			{
				writer.WriteUInt32((uint)value);
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x00005226 File Offset: 0x00003426
			internal void <GetSerializeDelegate>b__0_6(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
			{
				writer.WriteInt64((long)value);
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x00005234 File Offset: 0x00003434
			internal void <GetSerializeDelegate>b__0_7(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN _)
			{
				writer.WriteUInt64((ulong)value);
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x00005242 File Offset: 0x00003442
			internal object <GetDeserializeDelegate>b__1_0(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return reader.ReadByte();
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x0000524F File Offset: 0x0000344F
			internal object <GetDeserializeDelegate>b__1_1(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return reader.ReadSByte();
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x0000525C File Offset: 0x0000345C
			internal object <GetDeserializeDelegate>b__1_2(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return reader.ReadInt16();
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00005269 File Offset: 0x00003469
			internal object <GetDeserializeDelegate>b__1_3(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return reader.ReadUInt16();
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00005276 File Offset: 0x00003476
			internal object <GetDeserializeDelegate>b__1_4(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return reader.ReadInt32();
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x00005283 File Offset: 0x00003483
			internal object <GetDeserializeDelegate>b__1_5(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return reader.ReadUInt32();
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00005290 File Offset: 0x00003490
			internal object <GetDeserializeDelegate>b__1_6(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return reader.ReadInt64();
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x0000529D File Offset: 0x0000349D
			internal object <GetDeserializeDelegate>b__1_7(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return reader.ReadUInt64();
			}

			// Token: 0x0400024C RID: 588
			public static readonly GHGIMKPDBINGMHGCII.DOCEBOAPEOJADCKPLK <>9 = new GHGIMKPDBINGMHGCII.DOCEBOAPEOJADCKPLK();

			// Token: 0x0400024D RID: 589
			public static OJFAAEDNBNAMBCPLED<object> <>9__0_0;

			// Token: 0x0400024E RID: 590
			public static OJFAAEDNBNAMBCPLED<object> <>9__0_1;

			// Token: 0x0400024F RID: 591
			public static OJFAAEDNBNAMBCPLED<object> <>9__0_2;

			// Token: 0x04000250 RID: 592
			public static OJFAAEDNBNAMBCPLED<object> <>9__0_3;

			// Token: 0x04000251 RID: 593
			public static OJFAAEDNBNAMBCPLED<object> <>9__0_4;

			// Token: 0x04000252 RID: 594
			public static OJFAAEDNBNAMBCPLED<object> <>9__0_5;

			// Token: 0x04000253 RID: 595
			public static OJFAAEDNBNAMBCPLED<object> <>9__0_6;

			// Token: 0x04000254 RID: 596
			public static OJFAAEDNBNAMBCPLED<object> <>9__0_7;

			// Token: 0x04000255 RID: 597
			public static PCPKEIOPEDBCBJAJCJ<object> <>9__1_0;

			// Token: 0x04000256 RID: 598
			public static PCPKEIOPEDBCBJAJCJ<object> <>9__1_1;

			// Token: 0x04000257 RID: 599
			public static PCPKEIOPEDBCBJAJCJ<object> <>9__1_2;

			// Token: 0x04000258 RID: 600
			public static PCPKEIOPEDBCBJAJCJ<object> <>9__1_3;

			// Token: 0x04000259 RID: 601
			public static PCPKEIOPEDBCBJAJCJ<object> <>9__1_4;

			// Token: 0x0400025A RID: 602
			public static PCPKEIOPEDBCBJAJCJ<object> <>9__1_5;

			// Token: 0x0400025B RID: 603
			public static PCPKEIOPEDBCBJAJCJ<object> <>9__1_6;

			// Token: 0x0400025C RID: 604
			public static PCPKEIOPEDBCBJAJCJ<object> <>9__1_7;
		}
	}
}

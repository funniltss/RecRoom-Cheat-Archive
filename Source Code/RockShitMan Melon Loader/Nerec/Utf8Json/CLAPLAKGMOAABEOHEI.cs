using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using Utf8Json.Internal;
using Utf8Json.Internal.Emit;
using Utf8Json.Resolvers;

namespace Utf8Json
{
	// Token: 0x02000013 RID: 19
	public static class CLAPLAKGMOAABEOHEI
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000277F File Offset: 0x0000097F
		public static LMCMANMFGJGJFPNBEN MEODJGPCLPKCIMLFKO
		{
			get
			{
				if (CLAPLAKGMOAABEOHEI.defaultResolver == null)
				{
					CLAPLAKGMOAABEOHEI.defaultResolver = PDJOLBODDKGINOODBB.Default;
				}
				return CLAPLAKGMOAABEOHEI.defaultResolver;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002797 File Offset: 0x00000997
		public static bool NEEAOLMHIGEJPMNEOG
		{
			get
			{
				return CLAPLAKGMOAABEOHEI.defaultResolver != null;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000027A1 File Offset: 0x000009A1
		public static void SetDefaultResolver(LMCMANMFGJGJFPNBEN resolver)
		{
			CLAPLAKGMOAABEOHEI.defaultResolver = resolver;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000027A9 File Offset: 0x000009A9
		public static byte[] Serialize<KPOHFMEENIIELHPFLG>(KPOHFMEENIIELHPFLG obj)
		{
			return CLAPLAKGMOAABEOHEI.Serialize<KPOHFMEENIIELHPFLG>(obj, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007BD8 File Offset: 0x00005DD8
		public static byte[] Serialize<AKJDGKELOFLDCICHMO>(AKJDGKELOFLDCICHMO value, LMCMANMFGJGJFPNBEN resolver)
		{
			if (resolver == null)
			{
				resolver = CLAPLAKGMOAABEOHEI.MEODJGPCLPKCIMLFKO;
			}
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = new BJLLMLPIIIPIEPLCJH(CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.GetBuffer());
			resolver.GetFormatterWithVerify<AKJDGKELOFLDCICHMO>().Serialize(ref bjllmlpiiipieplcjh, value, resolver);
			return bjllmlpiiipieplcjh.ToUtf8ByteArray();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000027B6 File Offset: 0x000009B6
		public static void Serialize<OBBLOPKMJEJOAEPJBP>(ref BJLLMLPIIIPIEPLCJH writer, OBBLOPKMJEJOAEPJBP value)
		{
			CLAPLAKGMOAABEOHEI.Serialize<OBBLOPKMJEJOAEPJBP>(ref writer, value, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000027C4 File Offset: 0x000009C4
		public static void Serialize<OPFJJCMLDIOADMBJMK>(ref BJLLMLPIIIPIEPLCJH writer, OPFJJCMLDIOADMBJMK value, LMCMANMFGJGJFPNBEN resolver)
		{
			if (resolver == null)
			{
				resolver = CLAPLAKGMOAABEOHEI.MEODJGPCLPKCIMLFKO;
			}
			resolver.GetFormatterWithVerify<OPFJJCMLDIOADMBJMK>().Serialize(ref writer, value, resolver);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000027DE File Offset: 0x000009DE
		public static void Serialize<AOOIDLOHIJEFIPBDFB>(Stream stream, AOOIDLOHIJEFIPBDFB value)
		{
			CLAPLAKGMOAABEOHEI.Serialize<AOOIDLOHIJEFIPBDFB>(stream, value, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007C14 File Offset: 0x00005E14
		public static void Serialize<CAEAALHFMHEPDKCFFF>(Stream stream, CAEAALHFMHEPDKCFFF value, LMCMANMFGJGJFPNBEN resolver)
		{
			if (resolver == null)
			{
				resolver = CLAPLAKGMOAABEOHEI.MEODJGPCLPKCIMLFKO;
			}
			ArraySegment<byte> arraySegment = CLAPLAKGMOAABEOHEI.SerializeUnsafe<CAEAALHFMHEPDKCFFF>(value, resolver);
			stream.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000027EC File Offset: 0x000009EC
		public static ArraySegment<byte> SerializeUnsafe<AAGKFGFCANOOPAKNAJ>(AAGKFGFCANOOPAKNAJ obj)
		{
			return CLAPLAKGMOAABEOHEI.SerializeUnsafe<AAGKFGFCANOOPAKNAJ>(obj, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007C50 File Offset: 0x00005E50
		public static ArraySegment<byte> SerializeUnsafe<GLCCLEOADEKDJPGOHM>(GLCCLEOADEKDJPGOHM value, LMCMANMFGJGJFPNBEN resolver)
		{
			if (resolver == null)
			{
				resolver = CLAPLAKGMOAABEOHEI.MEODJGPCLPKCIMLFKO;
			}
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = new BJLLMLPIIIPIEPLCJH(CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.GetBuffer());
			resolver.GetFormatterWithVerify<GLCCLEOADEKDJPGOHM>().Serialize(ref bjllmlpiiipieplcjh, value, resolver);
			return bjllmlpiiipieplcjh.GetBuffer();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000027F9 File Offset: 0x000009F9
		public static string ToJsonString<ICBDGHHPNBLFPGJIPE>(ICBDGHHPNBLFPGJIPE value)
		{
			return CLAPLAKGMOAABEOHEI.ToJsonString<ICBDGHHPNBLFPGJIPE>(value, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007C8C File Offset: 0x00005E8C
		public static string ToJsonString<NMLDOOINBMIMCBHBPG>(NMLDOOINBMIMCBHBPG value, LMCMANMFGJGJFPNBEN resolver)
		{
			if (resolver == null)
			{
				resolver = CLAPLAKGMOAABEOHEI.MEODJGPCLPKCIMLFKO;
			}
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = new BJLLMLPIIIPIEPLCJH(CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.GetBuffer());
			resolver.GetFormatterWithVerify<NMLDOOINBMIMCBHBPG>().Serialize(ref bjllmlpiiipieplcjh, value, resolver);
			return bjllmlpiiipieplcjh.ToString();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002806 File Offset: 0x00000A06
		public static LKECPJMJFJKFPOAGNM Deserialize<LKECPJMJFJKFPOAGNM>(string json)
		{
			return CLAPLAKGMOAABEOHEI.Deserialize<LKECPJMJFJKFPOAGNM>(json, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002813 File Offset: 0x00000A13
		public static GNHLEKANLDHEJCEMNA Deserialize<GNHLEKANLDHEJCEMNA>(string json, LMCMANMFGJGJFPNBEN resolver)
		{
			return CLAPLAKGMOAABEOHEI.Deserialize<GNHLEKANLDHEJCEMNA>(CHFCLNEOCDIHMILKOP.UTF8.GetBytes(json), resolver);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002826 File Offset: 0x00000A26
		public static DLGAHNCOKLDPBIMDAO Deserialize<DLGAHNCOKLDPBIMDAO>(byte[] bytes)
		{
			return CLAPLAKGMOAABEOHEI.Deserialize<DLGAHNCOKLDPBIMDAO>(bytes, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002833 File Offset: 0x00000A33
		public static OLMDHBKFFKNCFOGCLN Deserialize<OLMDHBKFFKNCFOGCLN>(byte[] bytes, LMCMANMFGJGJFPNBEN resolver)
		{
			return CLAPLAKGMOAABEOHEI.Deserialize<OLMDHBKFFKNCFOGCLN>(bytes, 0, resolver);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000283D File Offset: 0x00000A3D
		public static LANNMLGGMIHGGHFFPC Deserialize<LANNMLGGMIHGGHFFPC>(byte[] bytes, int offset)
		{
			return CLAPLAKGMOAABEOHEI.Deserialize<LANNMLGGMIHGGHFFPC>(bytes, offset, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007CCC File Offset: 0x00005ECC
		public static AJANHDDMGFJOKGBAAA Deserialize<AJANHDDMGFJOKGBAAA>(byte[] bytes, int offset, LMCMANMFGJGJFPNBEN resolver)
		{
			if (resolver == null)
			{
				resolver = CLAPLAKGMOAABEOHEI.MEODJGPCLPKCIMLFKO;
			}
			BPIPCPJELFMIKDNCFG bpipcpjelfmikdncfg = new BPIPCPJELFMIKDNCFG(bytes, offset);
			return resolver.GetFormatterWithVerify<AJANHDDMGFJOKGBAAA>().Deserialize(ref bpipcpjelfmikdncfg, resolver);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000284B File Offset: 0x00000A4B
		public static KMIPNEGDEFBBCIIKDH Deserialize<KMIPNEGDEFBBCIIKDH>(ref BPIPCPJELFMIKDNCFG reader)
		{
			return CLAPLAKGMOAABEOHEI.Deserialize<KMIPNEGDEFBBCIIKDH>(ref reader, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002858 File Offset: 0x00000A58
		public static HGBLHPEEKNPIJHCGCC Deserialize<HGBLHPEEKNPIJHCGCC>(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN resolver)
		{
			if (resolver == null)
			{
				resolver = CLAPLAKGMOAABEOHEI.MEODJGPCLPKCIMLFKO;
			}
			return resolver.GetFormatterWithVerify<HGBLHPEEKNPIJHCGCC>().Deserialize(ref reader, resolver);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002871 File Offset: 0x00000A71
		public static KCAPGLMBFNENNMCKGL Deserialize<KCAPGLMBFNENNMCKGL>(Stream stream)
		{
			return CLAPLAKGMOAABEOHEI.Deserialize<KCAPGLMBFNENNMCKGL>(stream, CLAPLAKGMOAABEOHEI.defaultResolver);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007CFC File Offset: 0x00005EFC
		public static PAOLCHJPDKLNPEAHCD Deserialize<PAOLCHJPDKLNPEAHCD>(Stream stream, LMCMANMFGJGJFPNBEN resolver)
		{
			if (resolver == null)
			{
				resolver = CLAPLAKGMOAABEOHEI.MEODJGPCLPKCIMLFKO;
			}
			byte[] array = CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.GetBuffer();
			int newSize = CLAPLAKGMOAABEOHEI.FillFromStream(stream, ref array);
			if (new BPIPCPJELFMIKDNCFG(array).GetCurrentJsonToken() == IHACCEAELFJBICGADL.Number)
			{
				array = GBLOAMEEDDEJCBBGHB.FastCloneWithResize(array, newSize);
			}
			return CLAPLAKGMOAABEOHEI.Deserialize<PAOLCHJPDKLNPEAHCD>(array, resolver);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000287E File Offset: 0x00000A7E
		public static string PrettyPrint(byte[] json)
		{
			return CLAPLAKGMOAABEOHEI.PrettyPrint(json, 0);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007D44 File Offset: 0x00005F44
		public static string PrettyPrint(byte[] json, int offset)
		{
			BPIPCPJELFMIKDNCFG bpipcpjelfmikdncfg = new BPIPCPJELFMIKDNCFG(json, offset);
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = new BJLLMLPIIIPIEPLCJH(CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.GetBuffer());
			CLAPLAKGMOAABEOHEI.WritePrittyPrint(ref bpipcpjelfmikdncfg, ref bjllmlpiiipieplcjh, 0);
			return bjllmlpiiipieplcjh.ToString();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007D80 File Offset: 0x00005F80
		public static string PrettyPrint(string json)
		{
			BPIPCPJELFMIKDNCFG bpipcpjelfmikdncfg = new BPIPCPJELFMIKDNCFG(Encoding.UTF8.GetBytes(json));
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = new BJLLMLPIIIPIEPLCJH(CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.GetBuffer());
			CLAPLAKGMOAABEOHEI.WritePrittyPrint(ref bpipcpjelfmikdncfg, ref bjllmlpiiipieplcjh, 0);
			return bjllmlpiiipieplcjh.ToString();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002887 File Offset: 0x00000A87
		public static byte[] PrettyPrintByteArray(byte[] json)
		{
			return CLAPLAKGMOAABEOHEI.PrettyPrintByteArray(json, 0);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00007DC4 File Offset: 0x00005FC4
		public static byte[] PrettyPrintByteArray(byte[] json, int offset)
		{
			BPIPCPJELFMIKDNCFG bpipcpjelfmikdncfg = new BPIPCPJELFMIKDNCFG(json, offset);
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = new BJLLMLPIIIPIEPLCJH(CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.GetBuffer());
			CLAPLAKGMOAABEOHEI.WritePrittyPrint(ref bpipcpjelfmikdncfg, ref bjllmlpiiipieplcjh, 0);
			return bjllmlpiiipieplcjh.ToUtf8ByteArray();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007DF8 File Offset: 0x00005FF8
		public static byte[] PrettyPrintByteArray(string json)
		{
			BPIPCPJELFMIKDNCFG bpipcpjelfmikdncfg = new BPIPCPJELFMIKDNCFG(Encoding.UTF8.GetBytes(json));
			BJLLMLPIIIPIEPLCJH bjllmlpiiipieplcjh = new BJLLMLPIIIPIEPLCJH(CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.GetBuffer());
			CLAPLAKGMOAABEOHEI.WritePrittyPrint(ref bpipcpjelfmikdncfg, ref bjllmlpiiipieplcjh, 0);
			return bjllmlpiiipieplcjh.ToUtf8ByteArray();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007E34 File Offset: 0x00006034
		private static void WritePrittyPrint(ref BPIPCPJELFMIKDNCFG reader, ref BJLLMLPIIIPIEPLCJH writer, int depth)
		{
			switch (reader.GetCurrentJsonToken())
			{
			case IHACCEAELFJBICGADL.BeginObject:
			{
				writer.WriteBeginObject();
				writer.WriteRaw(CLAPLAKGMOAABEOHEI.newLine);
				int num = 0;
				while (reader.ReadIsInObject(ref num))
				{
					if (num != 1)
					{
						writer.WriteRaw(44);
						writer.WriteRaw(CLAPLAKGMOAABEOHEI.newLine);
					}
					writer.WriteRaw(CLAPLAKGMOAABEOHEI.indent[depth + 1]);
					writer.WritePropertyName(reader.ReadPropertyName());
					writer.WriteRaw(32);
					CLAPLAKGMOAABEOHEI.WritePrittyPrint(ref reader, ref writer, depth + 1);
				}
				writer.WriteRaw(CLAPLAKGMOAABEOHEI.newLine);
				writer.WriteRaw(CLAPLAKGMOAABEOHEI.indent[depth]);
				writer.WriteEndObject();
				return;
			}
			case IHACCEAELFJBICGADL.EndObject:
			case IHACCEAELFJBICGADL.EndArray:
				break;
			case IHACCEAELFJBICGADL.BeginArray:
			{
				writer.WriteBeginArray();
				writer.WriteRaw(CLAPLAKGMOAABEOHEI.newLine);
				int num2 = 0;
				while (reader.ReadIsInArray(ref num2))
				{
					if (num2 != 1)
					{
						writer.WriteRaw(44);
						writer.WriteRaw(CLAPLAKGMOAABEOHEI.newLine);
					}
					writer.WriteRaw(CLAPLAKGMOAABEOHEI.indent[depth + 1]);
					CLAPLAKGMOAABEOHEI.WritePrittyPrint(ref reader, ref writer, depth + 1);
				}
				writer.WriteRaw(CLAPLAKGMOAABEOHEI.newLine);
				writer.WriteRaw(CLAPLAKGMOAABEOHEI.indent[depth]);
				writer.WriteEndArray();
				return;
			}
			case IHACCEAELFJBICGADL.Number:
			{
				double value = reader.ReadDouble();
				writer.WriteDouble(value);
				return;
			}
			case IHACCEAELFJBICGADL.String:
			{
				string value2 = reader.ReadString();
				writer.WriteString(value2);
				return;
			}
			case IHACCEAELFJBICGADL.True:
			case IHACCEAELFJBICGADL.False:
			{
				bool value3 = reader.ReadBoolean();
				writer.WriteBoolean(value3);
				return;
			}
			case IHACCEAELFJBICGADL.Null:
				reader.ReadIsNull();
				writer.WriteNull();
				break;
			default:
				return;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007FA4 File Offset: 0x000061A4
		private static int FillFromStream(Stream input, ref byte[] buffer)
		{
			int num = 0;
			int num2;
			while ((num2 = input.Read(buffer, num, buffer.Length - num)) > 0)
			{
				num += num2;
				if (num == buffer.Length)
				{
					GBLOAMEEDDEJCBBGHB.FastResize(ref buffer, num * 2);
				}
			}
			return num;
		}

		// Token: 0x0400000F RID: 15
		private static LMCMANMFGJGJFPNBEN defaultResolver;

		// Token: 0x04000010 RID: 16
		private static readonly byte[][] indent = (from x in Enumerable.Range(0, 100)
		select Encoding.UTF8.GetBytes(new string(' ', x * 2))).ToArray<byte[]>();

		// Token: 0x04000011 RID: 17
		private static readonly byte[] newLine = Encoding.UTF8.GetBytes(Environment.NewLine);

		// Token: 0x02000014 RID: 20
		private static class HNHEIEDJOGKCBDPJCL
		{
			// Token: 0x0600007C RID: 124 RVA: 0x000028CD File Offset: 0x00000ACD
			public static byte[] GetBuffer()
			{
				if (CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.buffer == null)
				{
					CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.buffer = new byte[65536];
				}
				return CLAPLAKGMOAABEOHEI.HNHEIEDJOGKCBDPJCL.buffer;
			}

			// Token: 0x04000012 RID: 18
			[ThreadStatic]
			private static byte[] buffer;
		}

		// Token: 0x02000015 RID: 21
		public static class FMGOJMGAPADFJNJHMJ
		{
			// Token: 0x0600007D RID: 125 RVA: 0x000028EA File Offset: 0x00000AEA
			static FMGOJMGAPADFJNJHMJ()
			{
				CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.CreateCompiledMethods = ((Type t) => new CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC(t));
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00002912 File Offset: 0x00000B12
			private static CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC GetOrAdd(Type type)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.serializes.GetOrAdd(type, CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.CreateCompiledMethods);
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00002924 File Offset: 0x00000B24
			public static byte[] Serialize(object value)
			{
				if (value == null)
				{
					return CLAPLAKGMOAABEOHEI.Serialize<object>(value);
				}
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(value.GetType(), value, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00002941 File Offset: 0x00000B41
			public static byte[] Serialize(Type type, object value)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(type, value, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000081 RID: 129 RVA: 0x0000294F File Offset: 0x00000B4F
			public static byte[] Serialize(object value, LMCMANMFGJGJFPNBEN resolver)
			{
				if (value == null)
				{
					return CLAPLAKGMOAABEOHEI.Serialize<object>(value, resolver);
				}
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(value.GetType(), value, resolver);
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00002969 File Offset: 0x00000B69
			public static byte[] Serialize(Type type, object value, LMCMANMFGJGJFPNBEN resolver)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).serialize1(value, resolver);
			}

			// Token: 0x06000083 RID: 131 RVA: 0x0000297D File Offset: 0x00000B7D
			public static void Serialize(Stream stream, object value)
			{
				if (value == null)
				{
					CLAPLAKGMOAABEOHEI.Serialize<object>(stream, value);
					return;
				}
				CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(value.GetType(), stream, value, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000084 RID: 132 RVA: 0x0000299C File Offset: 0x00000B9C
			public static void Serialize(Type type, Stream stream, object value)
			{
				CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(type, stream, value, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000085 RID: 133 RVA: 0x000029AB File Offset: 0x00000BAB
			public static void Serialize(Stream stream, object value, LMCMANMFGJGJFPNBEN resolver)
			{
				if (value == null)
				{
					CLAPLAKGMOAABEOHEI.Serialize<object>(stream, value, resolver);
					return;
				}
				CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(value.GetType(), stream, value, resolver);
			}

			// Token: 0x06000086 RID: 134 RVA: 0x000029C7 File Offset: 0x00000BC7
			public static void Serialize(Type type, Stream stream, object value, LMCMANMFGJGJFPNBEN resolver)
			{
				CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).serialize2(stream, value, resolver);
			}

			// Token: 0x06000087 RID: 135 RVA: 0x000029DC File Offset: 0x00000BDC
			public static void Serialize(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN resolver)
			{
				if (value == null)
				{
					writer.WriteNull();
					return;
				}
				CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(value.GetType(), ref writer, value, resolver);
			}

			// Token: 0x06000088 RID: 136 RVA: 0x000029F6 File Offset: 0x00000BF6
			public static void Serialize(Type type, ref BJLLMLPIIIPIEPLCJH writer, object value)
			{
				CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Serialize(type, ref writer, value, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000089 RID: 137 RVA: 0x00002A05 File Offset: 0x00000C05
			public static void Serialize(Type type, ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN resolver)
			{
				CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).serialize3(ref writer, value, resolver);
			}

			// Token: 0x0600008A RID: 138 RVA: 0x00002A1A File Offset: 0x00000C1A
			public static ArraySegment<byte> SerializeUnsafe(object value)
			{
				if (value == null)
				{
					return CLAPLAKGMOAABEOHEI.SerializeUnsafe<object>(value);
				}
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.SerializeUnsafe(value.GetType(), value);
			}

			// Token: 0x0600008B RID: 139 RVA: 0x00002A32 File Offset: 0x00000C32
			public static ArraySegment<byte> SerializeUnsafe(Type type, object value)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.SerializeUnsafe(type, value, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00002A40 File Offset: 0x00000C40
			public static ArraySegment<byte> SerializeUnsafe(object value, LMCMANMFGJGJFPNBEN resolver)
			{
				if (value == null)
				{
					return CLAPLAKGMOAABEOHEI.SerializeUnsafe<object>(value);
				}
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.SerializeUnsafe(value.GetType(), value, resolver);
			}

			// Token: 0x0600008D RID: 141 RVA: 0x00002A59 File Offset: 0x00000C59
			public static ArraySegment<byte> SerializeUnsafe(Type type, object value, LMCMANMFGJGJFPNBEN resolver)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).serializeUnsafe(value, resolver);
			}

			// Token: 0x0600008E RID: 142 RVA: 0x00002A6D File Offset: 0x00000C6D
			public static string ToJsonString(object value)
			{
				if (value == null)
				{
					return "null";
				}
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.ToJsonString(value.GetType(), value);
			}

			// Token: 0x0600008F RID: 143 RVA: 0x00002A84 File Offset: 0x00000C84
			public static string ToJsonString(Type type, object value)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.ToJsonString(type, value, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000090 RID: 144 RVA: 0x00002A92 File Offset: 0x00000C92
			public static string ToJsonString(object value, LMCMANMFGJGJFPNBEN resolver)
			{
				if (value == null)
				{
					return "null";
				}
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.ToJsonString(value.GetType(), value, resolver);
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002AAA File Offset: 0x00000CAA
			public static string ToJsonString(Type type, object value, LMCMANMFGJGJFPNBEN resolver)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).toJsonString(value, resolver);
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00002ABE File Offset: 0x00000CBE
			public static object Deserialize(Type type, string json)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Deserialize(type, json, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00002ACC File Offset: 0x00000CCC
			public static object Deserialize(Type type, string json, LMCMANMFGJGJFPNBEN resolver)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).deserialize1(json, resolver);
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002AE0 File Offset: 0x00000CE0
			public static object Deserialize(Type type, byte[] bytes)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Deserialize(type, bytes, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002AEE File Offset: 0x00000CEE
			public static object Deserialize(Type type, byte[] bytes, LMCMANMFGJGJFPNBEN resolver)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Deserialize(type, bytes, 0, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002AFD File Offset: 0x00000CFD
			public static object Deserialize(Type type, byte[] bytes, int offset)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Deserialize(type, bytes, offset, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00002B0C File Offset: 0x00000D0C
			public static object Deserialize(Type type, byte[] bytes, int offset, LMCMANMFGJGJFPNBEN resolver)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).deserialize2(bytes, offset, resolver);
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00002B21 File Offset: 0x00000D21
			public static object Deserialize(Type type, Stream stream)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Deserialize(type, stream, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x06000099 RID: 153 RVA: 0x00002B2F File Offset: 0x00000D2F
			public static object Deserialize(Type type, Stream stream, LMCMANMFGJGJFPNBEN resolver)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).deserialize3(stream, resolver);
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00002B43 File Offset: 0x00000D43
			public static object Deserialize(Type type, ref BPIPCPJELFMIKDNCFG reader)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.Deserialize(type, ref reader, CLAPLAKGMOAABEOHEI.defaultResolver);
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00002B51 File Offset: 0x00000D51
			public static object Deserialize(Type type, ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN resolver)
			{
				return CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.GetOrAdd(type).deserialize4(ref reader, resolver);
			}

			// Token: 0x04000013 RID: 19
			private static readonly Func<Type, CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC> CreateCompiledMethods;

			// Token: 0x04000014 RID: 20
			private static readonly AGIKLMFPEFJELOKJEB<CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC> serializes = new AGIKLMFPEFJELOKJEB<CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC>(64, 0.75f);

			// Token: 0x02000016 RID: 22
			// (Invoke) Token: 0x0600009D RID: 157
			private delegate void AMEKMPJDOLPIFFIJEM(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN resolver);

			// Token: 0x02000017 RID: 23
			// (Invoke) Token: 0x060000A1 RID: 161
			private delegate object NFFGMHGHBKPNGNEHEI(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN resolver);

			// Token: 0x02000018 RID: 24
			private class BBAJMGBEAILFIDEMLC
			{
				// Token: 0x060000A4 RID: 164 RVA: 0x00007FE0 File Offset: 0x000061E0
				public BBAJMGBEAILFIDEMLC(Type type)
				{
					DynamicMethod dynamicMethod = new DynamicMethod("serialize1", typeof(byte[]), new Type[]
					{
						typeof(object),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.EmitLdarg(0);
					ilgenerator.EmitUnboxOrCast(type);
					ilgenerator.EmitLdarg(1);
					ilgenerator.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "Serialize", new Type[]
					{
						null,
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator.Emit(OpCodes.Ret);
					this.serialize1 = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<Func<object, LMCMANMFGJGJFPNBEN, byte[]>>(dynamicMethod);
					DynamicMethod dynamicMethod2 = new DynamicMethod("serialize2", null, new Type[]
					{
						typeof(Stream),
						typeof(object),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator2 = dynamicMethod2.GetILGenerator();
					ilgenerator2.EmitLdarg(0);
					ilgenerator2.EmitLdarg(1);
					ilgenerator2.EmitUnboxOrCast(type);
					ilgenerator2.EmitLdarg(2);
					ilgenerator2.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "Serialize", new Type[]
					{
						typeof(Stream),
						null,
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator2.Emit(OpCodes.Ret);
					this.serialize2 = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<Action<Stream, object, LMCMANMFGJGJFPNBEN>>(dynamicMethod2);
					DynamicMethod dynamicMethod3 = new DynamicMethod("serialize3", null, new Type[]
					{
						typeof(BJLLMLPIIIPIEPLCJH).MakeByRefType(),
						typeof(object),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator3 = dynamicMethod3.GetILGenerator();
					ilgenerator3.EmitLdarg(0);
					ilgenerator3.EmitLdarg(1);
					ilgenerator3.EmitUnboxOrCast(type);
					ilgenerator3.EmitLdarg(2);
					ilgenerator3.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "Serialize", new Type[]
					{
						typeof(BJLLMLPIIIPIEPLCJH).MakeByRefType(),
						null,
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator3.Emit(OpCodes.Ret);
					this.serialize3 = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.AMEKMPJDOLPIFFIJEM>(dynamicMethod3);
					DynamicMethod dynamicMethod4 = new DynamicMethod("serializeUnsafe", typeof(ArraySegment<byte>), new Type[]
					{
						typeof(object),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator4 = dynamicMethod4.GetILGenerator();
					ilgenerator4.EmitLdarg(0);
					ilgenerator4.EmitUnboxOrCast(type);
					ilgenerator4.EmitLdarg(1);
					ilgenerator4.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "SerializeUnsafe", new Type[]
					{
						null,
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator4.Emit(OpCodes.Ret);
					this.serializeUnsafe = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<Func<object, LMCMANMFGJGJFPNBEN, ArraySegment<byte>>>(dynamicMethod4);
					DynamicMethod dynamicMethod5 = new DynamicMethod("toJsonString", typeof(string), new Type[]
					{
						typeof(object),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator5 = dynamicMethod5.GetILGenerator();
					ilgenerator5.EmitLdarg(0);
					ilgenerator5.EmitUnboxOrCast(type);
					ilgenerator5.EmitLdarg(1);
					ilgenerator5.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "ToJsonString", new Type[]
					{
						null,
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator5.Emit(OpCodes.Ret);
					this.toJsonString = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<Func<object, LMCMANMFGJGJFPNBEN, string>>(dynamicMethod5);
					DynamicMethod dynamicMethod6 = new DynamicMethod("Deserialize", typeof(object), new Type[]
					{
						typeof(string),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator6 = dynamicMethod6.GetILGenerator();
					ilgenerator6.EmitLdarg(0);
					ilgenerator6.EmitLdarg(1);
					ilgenerator6.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "Deserialize", new Type[]
					{
						typeof(string),
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator6.EmitBoxOrDoNothing(type);
					ilgenerator6.Emit(OpCodes.Ret);
					this.deserialize1 = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<Func<string, LMCMANMFGJGJFPNBEN, object>>(dynamicMethod6);
					DynamicMethod dynamicMethod7 = new DynamicMethod("Deserialize", typeof(object), new Type[]
					{
						typeof(byte[]),
						typeof(int),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator7 = dynamicMethod7.GetILGenerator();
					ilgenerator7.EmitLdarg(0);
					ilgenerator7.EmitLdarg(1);
					ilgenerator7.EmitLdarg(2);
					ilgenerator7.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "Deserialize", new Type[]
					{
						typeof(byte[]),
						typeof(int),
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator7.EmitBoxOrDoNothing(type);
					ilgenerator7.Emit(OpCodes.Ret);
					this.deserialize2 = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<Func<byte[], int, LMCMANMFGJGJFPNBEN, object>>(dynamicMethod7);
					DynamicMethod dynamicMethod8 = new DynamicMethod("Deserialize", typeof(object), new Type[]
					{
						typeof(Stream),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator8 = dynamicMethod8.GetILGenerator();
					ilgenerator8.EmitLdarg(0);
					ilgenerator8.EmitLdarg(1);
					ilgenerator8.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "Deserialize", new Type[]
					{
						typeof(Stream),
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator8.EmitBoxOrDoNothing(type);
					ilgenerator8.Emit(OpCodes.Ret);
					this.deserialize3 = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<Func<Stream, LMCMANMFGJGJFPNBEN, object>>(dynamicMethod8);
					DynamicMethod dynamicMethod9 = new DynamicMethod("Deserialize", typeof(object), new Type[]
					{
						typeof(BPIPCPJELFMIKDNCFG).MakeByRefType(),
						typeof(LMCMANMFGJGJFPNBEN)
					}, type.Module, true);
					ILGenerator ilgenerator9 = dynamicMethod9.GetILGenerator();
					ilgenerator9.EmitLdarg(0);
					ilgenerator9.EmitLdarg(1);
					ilgenerator9.EmitCall(CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.GetMethod(type, "Deserialize", new Type[]
					{
						typeof(BPIPCPJELFMIKDNCFG).MakeByRefType(),
						typeof(LMCMANMFGJGJFPNBEN)
					}));
					ilgenerator9.EmitBoxOrDoNothing(type);
					ilgenerator9.Emit(OpCodes.Ret);
					this.deserialize4 = CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC.CreateDelegate<CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.NFFGMHGHBKPNGNEHEI>(dynamicMethod9);
				}

				// Token: 0x060000A5 RID: 165 RVA: 0x00002B65 File Offset: 0x00000D65
				private static LDCLPCGBPCOPEGKLFA CreateDelegate<LDCLPCGBPCOPEGKLFA>(DynamicMethod dm)
				{
					return (LDCLPCGBPCOPEGKLFA)((object)dm.CreateDelegate(typeof(LDCLPCGBPCOPEGKLFA)));
				}

				// Token: 0x060000A6 RID: 166 RVA: 0x000085F8 File Offset: 0x000067F8
				private static MethodInfo GetMethod(Type type, string name, Type[] arguments)
				{
					return (from x in typeof(CLAPLAKGMOAABEOHEI).GetMethods(BindingFlags.Static | BindingFlags.Public)
					where x.Name == name
					select x).Single(delegate(MethodInfo x)
					{
						ParameterInfo[] parameters = x.GetParameters();
						if (parameters.Length != arguments.Length)
						{
							return false;
						}
						for (int i = 0; i < parameters.Length; i++)
						{
							if ((!(arguments[i] == null) || !parameters[i].ParameterType.IsGenericParameter) && parameters[i].ParameterType != arguments[i])
							{
								return false;
							}
						}
						return true;
					}).MakeGenericMethod(new Type[]
					{
						type
					});
				}

				// Token: 0x04000015 RID: 21
				public readonly Func<object, LMCMANMFGJGJFPNBEN, byte[]> serialize1;

				// Token: 0x04000016 RID: 22
				public readonly Action<Stream, object, LMCMANMFGJGJFPNBEN> serialize2;

				// Token: 0x04000017 RID: 23
				public readonly CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.AMEKMPJDOLPIFFIJEM serialize3;

				// Token: 0x04000018 RID: 24
				public readonly Func<object, LMCMANMFGJGJFPNBEN, ArraySegment<byte>> serializeUnsafe;

				// Token: 0x04000019 RID: 25
				public readonly Func<object, LMCMANMFGJGJFPNBEN, string> toJsonString;

				// Token: 0x0400001A RID: 26
				public readonly Func<string, LMCMANMFGJGJFPNBEN, object> deserialize1;

				// Token: 0x0400001B RID: 27
				public readonly Func<byte[], int, LMCMANMFGJGJFPNBEN, object> deserialize2;

				// Token: 0x0400001C RID: 28
				public readonly Func<Stream, LMCMANMFGJGJFPNBEN, object> deserialize3;

				// Token: 0x0400001D RID: 29
				public readonly CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.NFFGMHGHBKPNGNEHEI deserialize4;

				// Token: 0x02000019 RID: 25
				[CompilerGenerated]
				private sealed class BCNMKDNHNEDGINLDBE
				{
					// Token: 0x060000A8 RID: 168 RVA: 0x00002B84 File Offset: 0x00000D84
					internal bool <GetMethod>b__0(MethodInfo x)
					{
						return x.Name == this.name;
					}

					// Token: 0x060000A9 RID: 169 RVA: 0x0000865C File Offset: 0x0000685C
					internal bool <GetMethod>b__1(MethodInfo x)
					{
						ParameterInfo[] parameters = x.GetParameters();
						if (parameters.Length != this.arguments.Length)
						{
							return false;
						}
						for (int i = 0; i < parameters.Length; i++)
						{
							if ((!(this.arguments[i] == null) || !parameters[i].ParameterType.IsGenericParameter) && parameters[i].ParameterType != this.arguments[i])
							{
								return false;
							}
						}
						return true;
					}

					// Token: 0x0400001E RID: 30
					public string name;

					// Token: 0x0400001F RID: 31
					public Type[] arguments;
				}
			}

			// Token: 0x0200001A RID: 26
			[CompilerGenerated]
			[Serializable]
			private sealed class LLKNMHIBABONEAGJCC
			{
				// Token: 0x060000AC RID: 172 RVA: 0x00002BA3 File Offset: 0x00000DA3
				internal CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC <.cctor>b__4_0(Type t)
				{
					return new CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.BBAJMGBEAILFIDEMLC(t);
				}

				// Token: 0x04000020 RID: 32
				public static readonly CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.LLKNMHIBABONEAGJCC <>9 = new CLAPLAKGMOAABEOHEI.FMGOJMGAPADFJNJHMJ.LLKNMHIBABONEAGJCC();
			}
		}

		// Token: 0x0200001B RID: 27
		[CompilerGenerated]
		[Serializable]
		private sealed class FPDCPEMKDGHPEHHNHP
		{
			// Token: 0x060000AF RID: 175 RVA: 0x00002BB7 File Offset: 0x00000DB7
			internal byte[] <.cctor>b__38_0(int x)
			{
				return Encoding.UTF8.GetBytes(new string(' ', x * 2));
			}

			// Token: 0x04000021 RID: 33
			public static readonly CLAPLAKGMOAABEOHEI.FPDCPEMKDGHPEHHNHP <>9 = new CLAPLAKGMOAABEOHEI.FPDCPEMKDGHPEHHNHP();
		}
	}
}

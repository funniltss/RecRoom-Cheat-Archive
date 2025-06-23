using System;
using System.Collections;
using System.Collections.Generic;

namespace Utf8Json.Formatters
{
	// Token: 0x02000127 RID: 295
	public sealed class HHFDIECAIMKGBGGJLB : FLGKBGGCEAHKIBEKBN<object>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x00017C88 File Offset: 0x00015E88
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, object value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			Type type = value.GetType();
			int num;
			if (HHFDIECAIMKGBGGJLB.typeToJumpCode.TryGetValue(type, out num))
			{
				switch (num)
				{
				case 0:
					writer.WriteBoolean((bool)value);
					return;
				case 1:
					BIBEOBCPDOHAHEBHGB.Default.Serialize(ref writer, (char)value, formatterResolver);
					return;
				case 2:
					writer.WriteSByte((sbyte)value);
					return;
				case 3:
					writer.WriteByte((byte)value);
					return;
				case 4:
					writer.WriteInt16((short)value);
					return;
				case 5:
					writer.WriteUInt16((ushort)value);
					return;
				case 6:
					writer.WriteInt32((int)value);
					return;
				case 7:
					writer.WriteUInt32((uint)value);
					return;
				case 8:
					writer.WriteInt64((long)value);
					return;
				case 9:
					writer.WriteUInt64((ulong)value);
					return;
				case 10:
					writer.WriteSingle((float)value);
					return;
				case 11:
					writer.WriteDouble((double)value);
					return;
				case 12:
					DNGDPDMFCFACOGHDCG.Default.Serialize(ref writer, (DateTime)value, formatterResolver);
					return;
				case 13:
					writer.WriteString((string)value);
					return;
				case 14:
					JPJCGHBIBCANKABLPB.Default.Serialize(ref writer, (byte[])value, formatterResolver);
					return;
				}
			}
			if (type.IsEnum)
			{
				writer.WriteString(type.ToString());
				return;
			}
			IDictionary dictionary = value as IDictionary;
			if (dictionary != null)
			{
				int num2 = 0;
				writer.WriteBeginObject();
				foreach (object obj in dictionary)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					if (num2++ != 0)
					{
						writer.WriteValueSeparator();
					}
					writer.WritePropertyName((string)dictionaryEntry.Key);
					this.Serialize(ref writer, dictionaryEntry.Value, formatterResolver);
				}
				writer.WriteEndObject();
				return;
			}
			ICollection collection = value as ICollection;
			if (collection != null)
			{
				int num3 = 0;
				writer.WriteBeginArray();
				foreach (object value2 in collection)
				{
					if (num3++ != 0)
					{
						writer.WriteValueSeparator();
					}
					this.Serialize(ref writer, value2, formatterResolver);
				}
				writer.WriteEndArray();
				return;
			}
			throw new InvalidOperationException("Not supported primitive object resolver. type:" + type.Name);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00017F04 File Offset: 0x00016104
		public object Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			IHACCEAELFJBICGADL currentJsonToken = reader.GetCurrentJsonToken();
			switch (currentJsonToken)
			{
			case IHACCEAELFJBICGADL.BeginObject:
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				reader.ReadIsBeginObjectWithVerify();
				int num = 0;
				while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref num))
				{
					string key = reader.ReadPropertyName();
					object value = this.Deserialize(ref reader, formatterResolver);
					dictionary.Add(key, value);
				}
				return dictionary;
			}
			case IHACCEAELFJBICGADL.EndObject:
			case IHACCEAELFJBICGADL.EndArray:
			case IHACCEAELFJBICGADL.ValueSeparator:
			case IHACCEAELFJBICGADL.NameSeparator:
				throw new InvalidOperationException("Invalid Json Token:" + currentJsonToken.ToString());
			case IHACCEAELFJBICGADL.BeginArray:
			{
				List<object> list = new List<object>(4);
				reader.ReadIsBeginArrayWithVerify();
				int num2 = 0;
				while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num2))
				{
					list.Add(this.Deserialize(ref reader, formatterResolver));
				}
				return list;
			}
			case IHACCEAELFJBICGADL.Number:
				return reader.ReadDouble();
			case IHACCEAELFJBICGADL.String:
				return reader.ReadString();
			case IHACCEAELFJBICGADL.True:
				return reader.ReadBoolean();
			case IHACCEAELFJBICGADL.False:
				return reader.ReadBoolean();
			case IHACCEAELFJBICGADL.Null:
				reader.ReadIsNull();
				return null;
			}
			return null;
		}

		// Token: 0x04000289 RID: 649
		public static readonly FLGKBGGCEAHKIBEKBN<object> Default = new HHFDIECAIMKGBGGJLB();

		// Token: 0x0400028A RID: 650
		private static readonly Dictionary<Type, int> typeToJumpCode = new Dictionary<Type, int>
		{
			{
				typeof(bool),
				0
			},
			{
				typeof(char),
				1
			},
			{
				typeof(sbyte),
				2
			},
			{
				typeof(byte),
				3
			},
			{
				typeof(short),
				4
			},
			{
				typeof(ushort),
				5
			},
			{
				typeof(int),
				6
			},
			{
				typeof(uint),
				7
			},
			{
				typeof(long),
				8
			},
			{
				typeof(ulong),
				9
			},
			{
				typeof(float),
				10
			},
			{
				typeof(double),
				11
			},
			{
				typeof(DateTime),
				12
			},
			{
				typeof(string),
				13
			},
			{
				typeof(byte[]),
				14
			}
		};
	}
}

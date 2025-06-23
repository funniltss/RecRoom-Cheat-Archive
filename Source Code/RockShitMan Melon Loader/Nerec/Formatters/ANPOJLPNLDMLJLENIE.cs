using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000FD RID: 253
	public class ANPOJLPNLDMLJLENIE<T> : FLGKBGGCEAHKIBEKBN<T>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<T>
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x00016578 File Offset: 0x00014778
		static ANPOJLPNLDMLJLENIE()
		{
			List<string> list = new List<string>();
			List<object> list2 = new List<object>();
			Type type = typeof(T);
			IEnumerable<FieldInfo> fields = type.GetFields();
			Func<FieldInfo, bool> <>9__0;
			Func<FieldInfo, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((FieldInfo fi) => fi.FieldType == type));
			}
			foreach (FieldInfo fieldInfo in fields.Where(predicate))
			{
				object value2 = fieldInfo.GetValue(null);
				string name = Enum.GetName(type, value2);
				GLJJNJDFMBPNMFKPAP gljjnjdfmbpnmfkpap = fieldInfo.GetCustomAttributes(typeof(GLJJNJDFMBPNMFKPAP), true).OfType<GLJJNJDFMBPNMFKPAP>().FirstOrDefault<GLJJNJDFMBPNMFKPAP>();
				HELAFKCALOKDAFDDFJ helafkcalokdafddfj = fieldInfo.GetCustomAttributes(typeof(HELAFKCALOKDAFDDFJ), true).OfType<HELAFKCALOKDAFDDFJ>().FirstOrDefault<HELAFKCALOKDAFDDFJ>();
				list2.Add(value2);
				list.Add((helafkcalokdafddfj != null && helafkcalokdafddfj.Value != null) ? helafkcalokdafddfj.Value : ((gljjnjdfmbpnmfkpap != null && gljjnjdfmbpnmfkpap.Name != null) ? gljjnjdfmbpnmfkpap.Name : name));
			}
			ANPOJLPNLDMLJLENIE<T>.nameValueMapping = new KCGGNJEJCCLLDKMMNN<T>(list.Count);
			ANPOJLPNLDMLJLENIE<T>.valueNameMapping = new Dictionary<T, string>(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				ANPOJLPNLDMLJLENIE<T>.nameValueMapping.Add(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyNameWithoutQuotation(list[i]), (T)((object)list2[i]));
				ANPOJLPNLDMLJLENIE<T>.valueNameMapping[(T)((object)list2[i])] = list[i];
			}
			bool flag;
			object serializeDelegate = GHGIMKPDBINGMHGCII.GetSerializeDelegate(typeof(T), out flag);
			if (flag)
			{
				OJFAAEDNBNAMBCPLED<object> boxSerialize = (OJFAAEDNBNAMBCPLED<object>)serializeDelegate;
				ANPOJLPNLDMLJLENIE<T>.defaultSerializeByUnderlyingValue = delegate(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN _)
				{
					boxSerialize(ref writer, value, _);
				};
			}
			else
			{
				ANPOJLPNLDMLJLENIE<T>.defaultSerializeByUnderlyingValue = (OJFAAEDNBNAMBCPLED<T>)serializeDelegate;
			}
			bool flag2;
			object deserializeDelegate = GHGIMKPDBINGMHGCII.GetDeserializeDelegate(typeof(T), out flag2);
			if (flag2)
			{
				PCPKEIOPEDBCBJAJCJ<object> boxDeserialize = (PCPKEIOPEDBCBJAJCJ<object>)deserializeDelegate;
				ANPOJLPNLDMLJLENIE<T>.defaultDeserializeByUnderlyingValue = delegate(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
				{
					return (T)((object)boxDeserialize(ref reader, _));
				};
				return;
			}
			ANPOJLPNLDMLJLENIE<T>.defaultDeserializeByUnderlyingValue = (PCPKEIOPEDBCBJAJCJ<T>)deserializeDelegate;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000052AA File Offset: 0x000034AA
		public ANPOJLPNLDMLJLENIE(bool serializeByName)
		{
			this.serializeByName = serializeByName;
			this.serializeByUnderlyingValue = ANPOJLPNLDMLJLENIE<T>.defaultSerializeByUnderlyingValue;
			this.deserializeByUnderlyingValue = ANPOJLPNLDMLJLENIE<T>.defaultDeserializeByUnderlyingValue;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000052CF File Offset: 0x000034CF
		public ANPOJLPNLDMLJLENIE(OJFAAEDNBNAMBCPLED<T> valueSerializeAction, PCPKEIOPEDBCBJAJCJ<T> valueDeserializeAction)
		{
			this.serializeByName = false;
			this.serializeByUnderlyingValue = valueSerializeAction;
			this.deserializeByUnderlyingValue = valueDeserializeAction;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000167A4 File Offset: 0x000149A4
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (this.serializeByName)
			{
				string value2;
				if (!ANPOJLPNLDMLJLENIE<T>.valueNameMapping.TryGetValue(value, out value2))
				{
					value2 = value.ToString();
				}
				writer.WriteString(value2);
				return;
			}
			this.serializeByUnderlyingValue(ref writer, value, formatterResolver);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000167EC File Offset: 0x000149EC
		public T Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			IHACCEAELFJBICGADL currentJsonToken = reader.GetCurrentJsonToken();
			if (currentJsonToken == IHACCEAELFJBICGADL.String)
			{
				ArraySegment<byte> key = reader.ReadStringSegmentUnsafe();
				T result;
				if (!ANPOJLPNLDMLJLENIE<T>.nameValueMapping.TryGetValue(key, out result))
				{
					string @string = CHFCLNEOCDIHMILKOP.UTF8.GetString(key.Array, key.Offset, key.Count);
					result = (T)((object)Enum.Parse(typeof(T), @string));
				}
				return result;
			}
			if (currentJsonToken == IHACCEAELFJBICGADL.Number)
			{
				return this.deserializeByUnderlyingValue(ref reader, formatterResolver);
			}
			throw new InvalidOperationException("Can't parse JSON to Enum format.");
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000052EC File Offset: 0x000034EC
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (this.serializeByName)
			{
				this.Serialize(ref writer, value, formatterResolver);
				return;
			}
			writer.WriteQuotation();
			this.Serialize(ref writer, value, formatterResolver);
			writer.WriteQuotation();
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00016870 File Offset: 0x00014A70
		public T DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (this.serializeByName)
			{
				return this.Deserialize(ref reader, formatterResolver);
			}
			if (reader.GetCurrentJsonToken() != IHACCEAELFJBICGADL.String)
			{
				throw new InvalidOperationException("Can't parse JSON to Enum format.");
			}
			reader.AdvanceOffset(1);
			T result = this.Deserialize(ref reader, formatterResolver);
			reader.SkipWhiteSpace();
			reader.AdvanceOffset(1);
			return result;
		}

		// Token: 0x0400025D RID: 605
		private static readonly KCGGNJEJCCLLDKMMNN<T> nameValueMapping;

		// Token: 0x0400025E RID: 606
		private static readonly Dictionary<T, string> valueNameMapping;

		// Token: 0x0400025F RID: 607
		private static readonly OJFAAEDNBNAMBCPLED<T> defaultSerializeByUnderlyingValue;

		// Token: 0x04000260 RID: 608
		private static readonly PCPKEIOPEDBCBJAJCJ<T> defaultDeserializeByUnderlyingValue;

		// Token: 0x04000261 RID: 609
		private readonly bool serializeByName;

		// Token: 0x04000262 RID: 610
		private readonly OJFAAEDNBNAMBCPLED<T> serializeByUnderlyingValue;

		// Token: 0x04000263 RID: 611
		private readonly PCPKEIOPEDBCBJAJCJ<T> deserializeByUnderlyingValue;

		// Token: 0x020000FE RID: 254
		[CompilerGenerated]
		private sealed class OOCMCEHHANFGPPBGCH
		{
			// Token: 0x06000449 RID: 1097 RVA: 0x00005315 File Offset: 0x00003515
			internal bool <.cctor>b__0(FieldInfo fi)
			{
				return fi.FieldType == this.type;
			}

			// Token: 0x04000264 RID: 612
			public Type type;

			// Token: 0x04000265 RID: 613
			public Func<FieldInfo, bool> <>9__0;
		}

		// Token: 0x020000FF RID: 255
		[CompilerGenerated]
		private sealed class KIPGAAHEONIHAOMKCJ
		{
			// Token: 0x0600044B RID: 1099 RVA: 0x00005328 File Offset: 0x00003528
			internal void <.cctor>b__1(ref BJLLMLPIIIPIEPLCJH writer, T value, LMCMANMFGJGJFPNBEN _)
			{
				this.boxSerialize(ref writer, value, _);
			}

			// Token: 0x04000266 RID: 614
			public OJFAAEDNBNAMBCPLED<object> boxSerialize;
		}

		// Token: 0x02000100 RID: 256
		[CompilerGenerated]
		private sealed class AFPDMOENEHGLMAMPOK
		{
			// Token: 0x0600044D RID: 1101 RVA: 0x0000533D File Offset: 0x0000353D
			internal T <.cctor>b__2(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN _)
			{
				return (T)((object)this.boxDeserialize(ref reader, _));
			}

			// Token: 0x04000267 RID: 615
			public PCPKEIOPEDBCBJAJCJ<object> boxDeserialize;
		}
	}
}

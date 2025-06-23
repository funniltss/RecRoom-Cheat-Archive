using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000125 RID: 293
	public sealed class FNMGOGBIFAIAMEHOAE : FLGKBGGCEAHKIBEKBN<bool?>, DDGADMMMOKKMDLNAEK, OJKBDJBONOCKIDIKGG<bool?>
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x000059A2 File Offset: 0x00003BA2
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, bool? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBoolean(value.Value);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00017B74 File Offset: 0x00015D74
		public bool? Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			return new bool?(reader.ReadBoolean());
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000059C1 File Offset: 0x00003BC1
		public void SerializeToPropertyName(ref BJLLMLPIIIPIEPLCJH writer, bool? value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteQuotation();
			writer.WriteBoolean(value.Value);
			writer.WriteQuotation();
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00017BA0 File Offset: 0x00015DA0
		public bool? DeserializeFromPropertyName(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentRaw();
			int num;
			return new bool?(OCPOKGPLBCLIEHKKHN.ReadBoolean(arraySegment.Array, arraySegment.Offset, out num));
		}

		// Token: 0x04000287 RID: 647
		public static readonly FNMGOGBIFAIAMEHOAE Default = new FNMGOGBIFAIAMEHOAE();
	}
}

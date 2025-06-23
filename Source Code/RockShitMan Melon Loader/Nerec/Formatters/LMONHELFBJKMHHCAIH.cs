using System;
using System.Globalization;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000130 RID: 304
	public sealed class LMONHELFBJKMHHCAIH : FLGKBGGCEAHKIBEKBN<decimal>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x00005B34 File Offset: 0x00003D34
		public LMONHELFBJKMHHCAIH() : this(false)
		{
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00005B3D File Offset: 0x00003D3D
		public LMONHELFBJKMHHCAIH(bool serializeAsString)
		{
			this.serializeAsString = serializeAsString;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00005B4C File Offset: 0x00003D4C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, decimal value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (this.serializeAsString)
			{
				writer.WriteString(value.ToString(CultureInfo.InvariantCulture));
				return;
			}
			writer.WriteRaw(CHFCLNEOCDIHMILKOP.UTF8.GetBytes(value.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001836C File Offset: 0x0001656C
		public decimal Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			IHACCEAELFJBICGADL currentJsonToken = reader.GetCurrentJsonToken();
			if (currentJsonToken == IHACCEAELFJBICGADL.Number)
			{
				ArraySegment<byte> arraySegment = reader.ReadNumberSegment();
				return decimal.Parse(CHFCLNEOCDIHMILKOP.UTF8.GetString(arraySegment.Array, arraySegment.Offset, arraySegment.Count), NumberStyles.Float, CultureInfo.InvariantCulture);
			}
			if (currentJsonToken == IHACCEAELFJBICGADL.String)
			{
				return decimal.Parse(reader.ReadString(), NumberStyles.Float, CultureInfo.InvariantCulture);
			}
			throw new InvalidOperationException("Invalid Json Token for DecimalFormatter:" + currentJsonToken.ToString());
		}

		// Token: 0x04000293 RID: 659
		public static readonly FLGKBGGCEAHKIBEKBN<decimal> Default = new LMONHELFBJKMHHCAIH();

		// Token: 0x04000294 RID: 660
		private readonly bool serializeAsString;
	}
}

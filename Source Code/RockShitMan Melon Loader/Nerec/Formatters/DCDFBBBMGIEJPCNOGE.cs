using System;
using System.Collections;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x02000135 RID: 309
	public sealed class DCDFBBBMGIEJPCNOGE : FLGKBGGCEAHKIBEKBN<BitArray>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x000184DC File Offset: 0x000166DC
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, BitArray value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			writer.WriteBeginArray();
			for (int i = 0; i < value.Length; i++)
			{
				if (i != 0)
				{
					writer.WriteValueSeparator();
				}
				writer.WriteBoolean(value[i]);
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00018528 File Offset: 0x00016728
		public BitArray Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (reader.ReadIsNull())
			{
				return null;
			}
			reader.ReadIsBeginArrayWithVerify();
			int num = 0;
			MGIMFHAGEKMNFOIMFL<bool> mgimfhagekmnfoimfl = new MGIMFHAGEKMNFOIMFL<bool>(4);
			while (!reader.ReadIsEndArrayWithSkipValueSeparator(ref num))
			{
				mgimfhagekmnfoimfl.Add(reader.ReadBoolean());
			}
			return new BitArray(mgimfhagekmnfoimfl.ToArray());
		}

		// Token: 0x04000298 RID: 664
		public static readonly FLGKBGGCEAHKIBEKBN<BitArray> Default = new DCDFBBBMGIEJPCNOGE();
	}
}

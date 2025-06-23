using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Utf8Json.Formatters;

namespace Utf8Json.Resolvers
{
	// Token: 0x02000020 RID: 32
	public sealed class FAHOODOKOCCDBINONC : LMCMANMFGJGJFPNBEN
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00002B7C File Offset: 0x00000D7C
		private FAHOODOKOCCDBINONC()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002D79 File Offset: 0x00000F79
		public FLGKBGGCEAHKIBEKBN<CFBEOAFOPKHHGBMGEJ> GetFormatter<CFBEOAFOPKHHGBMGEJ>()
		{
			return FAHOODOKOCCDBINONC<CFBEOAFOPKHHGBMGEJ>.IPAFOKNPPKJMAMGNFB.formatter;
		}

		// Token: 0x04000034 RID: 52
		public static readonly LMCMANMFGJGJFPNBEN Instance = new FAHOODOKOCCDBINONC();

		// Token: 0x02000021 RID: 33
		private static class IPAFOKNPPKJMAMGNFB<T>
		{
			// Token: 0x04000035 RID: 53
			public static readonly FLGKBGGCEAHKIBEKBN<T> formatter = (FLGKBGGCEAHKIBEKBN<T>)FAHOODOKOCCDBINONC.PPEOHFBFNDFGGIJIDJ.GetFormatter(typeof(T));
		}

		// Token: 0x02000022 RID: 34
		internal static class PPEOHFBFNDFGGIJIDJ
		{
			// Token: 0x060000DE RID: 222 RVA: 0x00008F9C File Offset: 0x0000719C
			internal static object GetFormatter(Type t)
			{
				object result;
				if (FAHOODOKOCCDBINONC.PPEOHFBFNDFGGIJIDJ.formatterMap.TryGetValue(t, out result))
				{
					return result;
				}
				return null;
			}

			// Token: 0x04000036 RID: 54
			private static readonly Dictionary<Type, object> formatterMap = new Dictionary<Type, object>
			{
				{
					typeof(short),
					KKDAPNKHIEMFDCHNBD.Default
				},
				{
					typeof(int),
					GFPBBBJIKGGFLKFGLE.Default
				},
				{
					typeof(long),
					ENLBGJCICGKBEFNFAE.Default
				},
				{
					typeof(ushort),
					OFNBJFKMKNMHCCFANJ.Default
				},
				{
					typeof(uint),
					GIMAMOBODNKDLPJLFH.Default
				},
				{
					typeof(ulong),
					IGJMDLPPCAJGPGBAJK.Default
				},
				{
					typeof(float),
					LNGJKFEBMOLLNKPPKM.Default
				},
				{
					typeof(double),
					ODJHBFIBKEOLPMNFBH.Default
				},
				{
					typeof(bool),
					PKJMJJMLCBICLOGOJI.Default
				},
				{
					typeof(byte),
					NOMPCMENHDFMIICJOH.Default
				},
				{
					typeof(sbyte),
					IMJGNHMCICEJCFGNDI.Default
				},
				{
					typeof(short?),
					AGMPEMMGBOILFKDBML.Default
				},
				{
					typeof(int?),
					OOMBJDOIMBJBCFDFJJ.Default
				},
				{
					typeof(long?),
					PHCKMDECDGFINLNIOH.Default
				},
				{
					typeof(ushort?),
					LBIMCNIBNIJKDCNNFB.Default
				},
				{
					typeof(uint?),
					HKEBKNGGDLPBAKMEEJ.Default
				},
				{
					typeof(ulong?),
					JDKMENEBBPMBIKPJNH.Default
				},
				{
					typeof(float?),
					DFELCGIFFJGKPOLHBG.Default
				},
				{
					typeof(double?),
					BJLEKHIFAMADDBHNGK.Default
				},
				{
					typeof(bool?),
					FNMGOGBIFAIAMEHOAE.Default
				},
				{
					typeof(byte?),
					FGMHNGPMJJLBEKJEHO.Default
				},
				{
					typeof(sbyte?),
					PKIBHDJFLJLFNAKCNE.Default
				},
				{
					typeof(DateTime),
					DNGDPDMFCFACOGHDCG.Default
				},
				{
					typeof(TimeSpan),
					NJEBFEBMCIOELKAAJH.Default
				},
				{
					typeof(DateTimeOffset),
					MJEPABFNFHKPLFNMOB.Default
				},
				{
					typeof(DateTime?),
					new EKNOLMEMLPPBCANDBP<DateTime>(DNGDPDMFCFACOGHDCG.Default)
				},
				{
					typeof(TimeSpan?),
					new EKNOLMEMLPPBCANDBP<TimeSpan>(NJEBFEBMCIOELKAAJH.Default)
				},
				{
					typeof(DateTimeOffset?),
					new EKNOLMEMLPPBCANDBP<DateTimeOffset>(MJEPABFNFHKPLFNMOB.Default)
				},
				{
					typeof(string),
					JKKPKILCICOPILBOOM.Default
				},
				{
					typeof(char),
					BIBEOBCPDOHAHEBHGB.Default
				},
				{
					typeof(char?),
					OKFEHAMDJMGDLEJKEN.Default
				},
				{
					typeof(decimal),
					LMONHELFBJKMHHCAIH.Default
				},
				{
					typeof(decimal?),
					new EKNOLMEMLPPBCANDBP<decimal>(LMONHELFBJKMHHCAIH.Default)
				},
				{
					typeof(Guid),
					LCAAILBDJOKGFOKBAP.Default
				},
				{
					typeof(Guid?),
					new EKNOLMEMLPPBCANDBP<Guid>(LCAAILBDJOKGFOKBAP.Default)
				},
				{
					typeof(Uri),
					OBEALNGEAEJFLDBBEN.Default
				},
				{
					typeof(Version),
					PFKAAEIEJKDOFKHAOA.Default
				},
				{
					typeof(StringBuilder),
					PBIAGDAMFKDEDPEIPO.Default
				},
				{
					typeof(BitArray),
					DCDFBBBMGIEJPCNOGE.Default
				},
				{
					typeof(Type),
					MPBKCHPCHMHCLDLIHE.Default
				},
				{
					typeof(byte[]),
					JPJCGHBIBCANKABLPB.Default
				},
				{
					typeof(short[]),
					DPJPIDAFGGIHMNLHAE.Default
				},
				{
					typeof(int[]),
					KLLCCAJMPEMBKHPFNC.Default
				},
				{
					typeof(long[]),
					PIDMAPOAJKKLKAOACJ.Default
				},
				{
					typeof(ushort[]),
					FOOGMNEHKGLMPODDBE.Default
				},
				{
					typeof(uint[]),
					EBEKNAMEADGFCKOCHA.Default
				},
				{
					typeof(ulong[]),
					FPOKECPOKBPDPMADDG.Default
				},
				{
					typeof(float[]),
					PCKGPJFBBEPGMDADGH.Default
				},
				{
					typeof(double[]),
					IFALDHKCBPMBIPPKII.Default
				},
				{
					typeof(bool[]),
					DIPILMBALLFAEKKJBA.Default
				},
				{
					typeof(sbyte[]),
					GMMAAGDBDNGLLGBIMI.Default
				},
				{
					typeof(char[]),
					EGNHBAONECIEHONHOI.Default
				},
				{
					typeof(string[]),
					FNFLLANKOLKONBIAJO.Default
				},
				{
					typeof(List<short>),
					new BMKCBCOMGEOPJCGDLE<short>()
				},
				{
					typeof(List<int>),
					new BMKCBCOMGEOPJCGDLE<int>()
				},
				{
					typeof(List<long>),
					new BMKCBCOMGEOPJCGDLE<long>()
				},
				{
					typeof(List<ushort>),
					new BMKCBCOMGEOPJCGDLE<ushort>()
				},
				{
					typeof(List<uint>),
					new BMKCBCOMGEOPJCGDLE<uint>()
				},
				{
					typeof(List<ulong>),
					new BMKCBCOMGEOPJCGDLE<ulong>()
				},
				{
					typeof(List<float>),
					new BMKCBCOMGEOPJCGDLE<float>()
				},
				{
					typeof(List<double>),
					new BMKCBCOMGEOPJCGDLE<double>()
				},
				{
					typeof(List<bool>),
					new BMKCBCOMGEOPJCGDLE<bool>()
				},
				{
					typeof(List<byte>),
					new BMKCBCOMGEOPJCGDLE<byte>()
				},
				{
					typeof(List<sbyte>),
					new BMKCBCOMGEOPJCGDLE<sbyte>()
				},
				{
					typeof(List<DateTime>),
					new BMKCBCOMGEOPJCGDLE<DateTime>()
				},
				{
					typeof(List<char>),
					new BMKCBCOMGEOPJCGDLE<char>()
				},
				{
					typeof(List<string>),
					new BMKCBCOMGEOPJCGDLE<string>()
				},
				{
					typeof(ArraySegment<byte>),
					PGJDHEOBFNCMFIANLM.Default
				},
				{
					typeof(ArraySegment<byte>?),
					new EKNOLMEMLPPBCANDBP<ArraySegment<byte>>(PGJDHEOBFNCMFIANLM.Default)
				}
			};
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using Utf8Json.Internal.Emit;

namespace Utf8Json.Internal
{
	// Token: 0x02000098 RID: 152
	public class CBCBOOCAFACEIEKOLL : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00003D5B File Offset: 0x00001F5B
		public CBCBOOCAFACEIEKOLL()
		{
			this.root = new CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB(0UL);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00003D70 File Offset: 0x00001F70
		public void Add(string str, int value)
		{
			this.Add(BJLLMLPIIIPIEPLCJH.GetEncodedPropertyNameWithoutQuotation(str), value);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000D568 File Offset: 0x0000B768
		public void Add(byte[] bytes, int value)
		{
			int num = 0;
			CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB kcdlpllikhcplddhdb = this.root;
			int num2 = bytes.Length;
			while (num2 != 0)
			{
				ulong keySafe = PLFJFHEOALIJKCIFIN.GetKeySafe(bytes, ref num, ref num2);
				if (num2 == 0)
				{
					kcdlpllikhcplddhdb = kcdlpllikhcplddhdb.Add(keySafe, value, Encoding.UTF8.GetString(bytes));
				}
				else
				{
					kcdlpllikhcplddhdb = kcdlpllikhcplddhdb.Add(keySafe);
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		public bool TryGetValueSafe(ArraySegment<byte> key, out int value)
		{
			CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB kcdlpllikhcplddhdb = this.root;
			byte[] array = key.Array;
			int offset = key.Offset;
			int count = key.Count;
			while (count != 0 && kcdlpllikhcplddhdb != null)
			{
				kcdlpllikhcplddhdb = kcdlpllikhcplddhdb.SearchNextSafe(array, ref offset, ref count);
			}
			if (kcdlpllikhcplddhdb == null)
			{
				value = -1;
				return false;
			}
			value = kcdlpllikhcplddhdb.Value;
			return true;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000D608 File Offset: 0x0000B808
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			CBCBOOCAFACEIEKOLL.ToStringCore(this.root.YieldChildren(), stringBuilder, 0);
			return stringBuilder.ToString();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000D634 File Offset: 0x0000B834
		private static void ToStringCore(IEnumerable<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB> nexts, StringBuilder sb, int depth)
		{
			foreach (CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB kcdlpllikhcplddhdb in nexts)
			{
				if (depth != 0)
				{
					sb.Append(' ', depth * 2);
				}
				sb.Append("[" + kcdlpllikhcplddhdb.Key.ToString() + "]");
				if (kcdlpllikhcplddhdb.Value != -1)
				{
					sb.Append("(" + kcdlpllikhcplddhdb.originalKey + ")");
					sb.Append(" = ");
					sb.Append(kcdlpllikhcplddhdb.Value);
				}
				sb.AppendLine();
				CBCBOOCAFACEIEKOLL.ToStringCore(kcdlpllikhcplddhdb.YieldChildren(), sb, depth + 1);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003D7F File Offset: 0x00001F7F
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00003D87 File Offset: 0x00001F87
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return CBCBOOCAFACEIEKOLL.YieldCore(this.root.YieldChildren()).GetEnumerator();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00003D9E File Offset: 0x00001F9E
		private static IEnumerable<KeyValuePair<string, int>> YieldCore(IEnumerable<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB> nexts)
		{
			foreach (CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB item in nexts)
			{
				if (item.Value != -1)
				{
					yield return new KeyValuePair<string, int>(item.originalKey, item.Value);
				}
				foreach (KeyValuePair<string, int> keyValuePair in CBCBOOCAFACEIEKOLL.YieldCore(item.YieldChildren()))
				{
					yield return keyValuePair;
				}
				IEnumerator<KeyValuePair<string, int>> enumerator2 = null;
				item = null;
			}
			IEnumerator<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00003DAE File Offset: 0x00001FAE
		public void EmitMatch(ILGenerator il, LocalBuilder p, LocalBuilder rest, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound)
		{
			this.root.EmitSearchNext(il, p, rest, key, onFound, onNotFound);
		}

		// Token: 0x0400014B RID: 331
		private readonly CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB root;

		// Token: 0x02000099 RID: 153
		private class KCDLPLLIKHCPLDDHDB : IComparable<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB>
		{
			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000204 RID: 516 RVA: 0x00003DC4 File Offset: 0x00001FC4
			public bool MMEAHLACNLCNLLNFPP
			{
				get
				{
					return this.count != 0;
				}
			}

			// Token: 0x06000205 RID: 517 RVA: 0x00003DCF File Offset: 0x00001FCF
			public KCDLPLLIKHCPLDDHDB(ulong key)
			{
				this.Key = key;
				this.Value = -1;
				this.nexts = CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.emptyNodes;
				this.nextKeys = CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.emptyKeys;
				this.count = 0;
				this.originalKey = null;
			}

			// Token: 0x06000206 RID: 518 RVA: 0x0000D700 File Offset: 0x0000B900
			public CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB Add(ulong key)
			{
				int num = Array.BinarySearch<ulong>(this.nextKeys, 0, this.count, key);
				if (num < 0)
				{
					if (this.nexts.Length == this.count)
					{
						Array.Resize<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB>(ref this.nexts, (this.count == 0) ? 4 : (this.count * 2));
						Array.Resize<ulong>(ref this.nextKeys, (this.count == 0) ? 4 : (this.count * 2));
					}
					this.count++;
					CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB kcdlpllikhcplddhdb = new CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB(key);
					this.nexts[this.count - 1] = kcdlpllikhcplddhdb;
					this.nextKeys[this.count - 1] = key;
					Array.Sort<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB>(this.nexts, 0, this.count);
					Array.Sort<ulong>(this.nextKeys, 0, this.count);
					return kcdlpllikhcplddhdb;
				}
				return this.nexts[num];
			}

			// Token: 0x06000207 RID: 519 RVA: 0x00003E09 File Offset: 0x00002009
			public CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB Add(ulong key, int value, string originalKey)
			{
				CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB kcdlpllikhcplddhdb = this.Add(key);
				kcdlpllikhcplddhdb.Value = value;
				kcdlpllikhcplddhdb.originalKey = originalKey;
				return kcdlpllikhcplddhdb;
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
			public unsafe CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB SearchNext(ref byte* p, ref int rest)
			{
				ulong key = PLFJFHEOALIJKCIFIN.GetKey(ref p, ref rest);
				if (this.count < 4)
				{
					for (int i = 0; i < this.count; i++)
					{
						if (this.nextKeys[i] == key)
						{
							return this.nexts[i];
						}
					}
				}
				else
				{
					int num = CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.BinarySearch(this.nextKeys, 0, this.count, key);
					if (num >= 0)
					{
						return this.nexts[num];
					}
				}
				return null;
			}

			// Token: 0x06000209 RID: 521 RVA: 0x0000D840 File Offset: 0x0000BA40
			public CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB SearchNextSafe(byte[] p, ref int offset, ref int rest)
			{
				ulong keySafe = PLFJFHEOALIJKCIFIN.GetKeySafe(p, ref offset, ref rest);
				if (this.count < 4)
				{
					for (int i = 0; i < this.count; i++)
					{
						if (this.nextKeys[i] == keySafe)
						{
							return this.nexts[i];
						}
					}
				}
				else
				{
					int num = CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.BinarySearch(this.nextKeys, 0, this.count, keySafe);
					if (num >= 0)
					{
						return this.nexts[num];
					}
				}
				return null;
			}

			// Token: 0x0600020A RID: 522 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
			internal static int BinarySearch(ulong[] array, int index, int length, ulong value)
			{
				int i = index;
				int num = index + length - 1;
				while (i <= num)
				{
					int num2 = i + (num - i >> 1);
					ulong num3 = array[num2];
					int num4;
					if (num3 < value)
					{
						num4 = -1;
					}
					else if (num3 > value)
					{
						num4 = 1;
					}
					else
					{
						num4 = 0;
					}
					if (num4 == 0)
					{
						return num2;
					}
					if (num4 < 0)
					{
						i = num2 + 1;
					}
					else
					{
						num = num2 - 1;
					}
				}
				return ~i;
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00003E20 File Offset: 0x00002020
			public int CompareTo(CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB other)
			{
				return this.Key.CompareTo(other.Key);
			}

			// Token: 0x0600020C RID: 524 RVA: 0x00003E33 File Offset: 0x00002033
			public IEnumerable<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB> YieldChildren()
			{
				int num;
				for (int i = 0; i < this.count; i = num + 1)
				{
					yield return this.nexts[i];
					num = i;
				}
				yield break;
			}

			// Token: 0x0600020D RID: 525 RVA: 0x00003E43 File Offset: 0x00002043
			public void EmitSearchNext(ILGenerator il, LocalBuilder p, LocalBuilder rest, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound)
			{
				il.EmitLdloca(p);
				il.EmitLdloca(rest);
				il.EmitCall(PLFJFHEOALIJKCIFIN.GetKeyMethod);
				il.EmitStloc(key);
				CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.EmitSearchNextCore(il, p, rest, key, onFound, onNotFound, this.nexts, this.count);
			}

			// Token: 0x0600020E RID: 526 RVA: 0x0000D8FC File Offset: 0x0000BAFC
			private static void EmitSearchNextCore(ILGenerator il, LocalBuilder p, LocalBuilder rest, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound, CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB[] nexts, int count)
			{
				if (count < 4)
				{
					CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB[] array = (from x in nexts.Take(count)
					where x.Value != -1
					select x).ToArray<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB>();
					CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB[] array2 = (from x in nexts.Take(count)
					where x.MMEAHLACNLCNLLNFPP
					select x).ToArray<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB>();
					Label label = il.DefineLabel();
					Label label2 = il.DefineLabel();
					il.EmitLdloc(rest);
					if (array2.Length != 0 && array.Length == 0)
					{
						il.Emit(OpCodes.Brfalse, label2);
					}
					else
					{
						il.Emit(OpCodes.Brtrue, label);
					}
					Label[] array3 = (from _ in Enumerable.Range(0, Math.Max(array.Length - 1, 0))
					select il.DefineLabel()).ToArray<Label>();
					for (int i = 0; i < array.Length; i++)
					{
						Label label3 = il.DefineLabel();
						if (i != 0)
						{
							il.MarkLabel(array3[i - 1]);
						}
						il.EmitLdloc(key);
						il.EmitULong(array[i].Key);
						il.Emit(OpCodes.Bne_Un, label3);
						onFound(new KeyValuePair<string, int>(array[i].originalKey, array[i].Value));
						il.MarkLabel(label3);
						if (i != array.Length - 1)
						{
							il.Emit(OpCodes.Br, array3[i]);
						}
						else
						{
							onNotFound();
						}
					}
					il.MarkLabel(label);
					Label[] array4 = (from _ in Enumerable.Range(0, Math.Max(array2.Length - 1, 0))
					select il.DefineLabel()).ToArray<Label>();
					for (int j = 0; j < array2.Length; j++)
					{
						Label label4 = il.DefineLabel();
						if (j != 0)
						{
							il.MarkLabel(array4[j - 1]);
						}
						il.EmitLdloc(key);
						il.EmitULong(array2[j].Key);
						il.Emit(OpCodes.Bne_Un, label4);
						array2[j].EmitSearchNext(il, p, rest, key, onFound, onNotFound);
						il.MarkLabel(label4);
						if (j != array2.Length - 1)
						{
							il.Emit(OpCodes.Br, array4[j]);
						}
						else
						{
							onNotFound();
						}
					}
					il.MarkLabel(label2);
					onNotFound();
					return;
				}
				int num = count / 2;
				ulong key2 = nexts[num].Key;
				CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB[] array5 = nexts.Take(count).Take(num).ToArray<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB>();
				CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB[] array6 = nexts.Take(count).Skip(num).ToArray<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB>();
				Label label5 = il.DefineLabel();
				il.EmitLdloc(key);
				il.EmitULong(key2);
				il.Emit(OpCodes.Bge, label5);
				CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.EmitSearchNextCore(il, p, rest, key, onFound, onNotFound, array5, array5.Length);
				il.MarkLabel(label5);
				CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.EmitSearchNextCore(il, p, rest, key, onFound, onNotFound, array6, array6.Length);
			}

			// Token: 0x0400014C RID: 332
			private static readonly CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB[] emptyNodes = new CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB[0];

			// Token: 0x0400014D RID: 333
			private static readonly ulong[] emptyKeys = new ulong[0];

			// Token: 0x0400014E RID: 334
			public ulong Key;

			// Token: 0x0400014F RID: 335
			public int Value;

			// Token: 0x04000150 RID: 336
			public string originalKey;

			// Token: 0x04000151 RID: 337
			private CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB[] nexts;

			// Token: 0x04000152 RID: 338
			private ulong[] nextKeys;

			// Token: 0x04000153 RID: 339
			private int count;

			// Token: 0x0200009A RID: 154
			[CompilerGenerated]
			[Serializable]
			private sealed class HFOKLFJDIPMGPIFMCM
			{
				// Token: 0x06000212 RID: 530 RVA: 0x00003EA4 File Offset: 0x000020A4
				internal bool <EmitSearchNextCore>b__19_0(CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB x)
				{
					return x.Value != -1;
				}

				// Token: 0x06000213 RID: 531 RVA: 0x00003EB2 File Offset: 0x000020B2
				internal bool <EmitSearchNextCore>b__19_1(CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB x)
				{
					return x.MMEAHLACNLCNLLNFPP;
				}

				// Token: 0x04000154 RID: 340
				public static readonly CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.HFOKLFJDIPMGPIFMCM <>9 = new CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB.HFOKLFJDIPMGPIFMCM();

				// Token: 0x04000155 RID: 341
				public static Func<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB, bool> <>9__19_0;

				// Token: 0x04000156 RID: 342
				public static Func<CBCBOOCAFACEIEKOLL.KCDLPLLIKHCPLDDHDB, bool> <>9__19_1;
			}

			// Token: 0x0200009B RID: 155
			[CompilerGenerated]
			private sealed class GLBFKEGMKFMKDGCJIF
			{
				// Token: 0x06000215 RID: 533 RVA: 0x00003EBA File Offset: 0x000020BA
				internal Label <EmitSearchNextCore>b__3(int _)
				{
					return this.il.DefineLabel();
				}

				// Token: 0x06000216 RID: 534 RVA: 0x00003EBA File Offset: 0x000020BA
				internal Label <EmitSearchNextCore>b__2(int _)
				{
					return this.il.DefineLabel();
				}

				// Token: 0x04000157 RID: 343
				public ILGenerator il;
			}
		}
	}
}

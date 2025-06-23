using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Utf8Json.Internal
{
	// Token: 0x020000A1 RID: 161
	internal class KCGGNJEJCCLLDKMMNN<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00003F6A File Offset: 0x0000216A
		public KCGGNJEJCCLLDKMMNN(int capacity) : this(capacity, 0.42f)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000E5BC File Offset: 0x0000C7BC
		public KCGGNJEJCCLLDKMMNN(int capacity, float loadFactor)
		{
			int num = KCGGNJEJCCLLDKMMNN<T>.CalculateCapacity(capacity, loadFactor);
			this.buckets = new KCGGNJEJCCLLDKMMNN<T>.Entry[num][];
			this.indexFor = (ulong)((long)this.buckets.Length - 1L);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00003F78 File Offset: 0x00002178
		public void Add(string key, T value)
		{
			if (!this.TryAddInternal(Encoding.UTF8.GetBytes(key), value))
			{
				throw new ArgumentException("Key was already exists. Key:" + key);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00003F9F File Offset: 0x0000219F
		public void Add(byte[] key, T value)
		{
			if (!this.TryAddInternal(key, value))
			{
				throw new ArgumentException("Key was already exists. Key:" + ((key != null) ? key.ToString() : null));
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		private bool TryAddInternal(byte[] key, T value)
		{
			ulong num = KCGGNJEJCCLLDKMMNN<T>.ByteArrayGetHashCode(key, 0, key.Length);
			KCGGNJEJCCLLDKMMNN<T>.Entry entry = new KCGGNJEJCCLLDKMMNN<T>.Entry
			{
				Key = key,
				Value = value
			};
			checked
			{
				KCGGNJEJCCLLDKMMNN<T>.Entry[] array = this.buckets[(int)((IntPtr)(num & this.indexFor))];
				if (array == null)
				{
					this.buckets[(int)((IntPtr)(num & this.indexFor))] = new KCGGNJEJCCLLDKMMNN<T>.Entry[]
					{
						entry
					};
				}
				else
				{
					unchecked
					{
						for (int i = 0; i < array.Length; i++)
						{
							byte[] key2 = array[i].Key;
							if (LANLHIKNEAFDIDOKHM.Equals(key, 0, key.Length, key2))
							{
								return false;
							}
						}
						KCGGNJEJCCLLDKMMNN<T>.Entry[] array2 = new KCGGNJEJCCLLDKMMNN<T>.Entry[array.Length + 1];
						Array.Copy(array, array2, array.Length);
						array = array2;
						array[array.Length - 1] = entry;
					}
					this.buckets[(int)((IntPtr)(num & this.indexFor))] = array;
				}
				return true;
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		public bool TryGetValue(ArraySegment<byte> key, out T value)
		{
			KCGGNJEJCCLLDKMMNN<T>.Entry[][] array = this.buckets;
			ulong num = KCGGNJEJCCLLDKMMNN<T>.ByteArrayGetHashCode(key.Array, key.Offset, key.Count);
			KCGGNJEJCCLLDKMMNN<T>.Entry[] array2 = array[(int)(checked((IntPtr)(num & this.indexFor)))];
			if (array2 != null)
			{
				KCGGNJEJCCLLDKMMNN<T>.Entry entry = array2[0];
				if (LANLHIKNEAFDIDOKHM.Equals(key.Array, key.Offset, key.Count, entry.Key))
				{
					value = entry.Value;
					return true;
				}
				for (int i = 1; i < array2.Length; i++)
				{
					KCGGNJEJCCLLDKMMNN<T>.Entry entry2 = array2[i];
					if (LANLHIKNEAFDIDOKHM.Equals(key.Array, key.Offset, key.Count, entry2.Key))
					{
						value = entry2.Value;
						return true;
					}
				}
			}
			value = default(T);
			return false;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000E790 File Offset: 0x0000C990
		private static ulong ByteArrayGetHashCode(byte[] x, int offset, int count)
		{
			uint num = 0U;
			if (x != null)
			{
				int num2 = offset + count;
				num = 2166136261U;
				for (int i = offset; i < num2; i++)
				{
					num = ((uint)x[i] ^ num) * 16777619U;
				}
			}
			return (ulong)num;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		private static int CalculateCapacity(int collectionSize, float loadFactor)
		{
			int num = (int)((float)collectionSize / loadFactor);
			int i;
			for (i = 1; i < num; i <<= 1)
			{
			}
			if (i < 8)
			{
				return 8;
			}
			return i;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00003FC8 File Offset: 0x000021C8
		public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
		{
			KCGGNJEJCCLLDKMMNN<T>.Entry[][] array = this.buckets;
			foreach (KCGGNJEJCCLLDKMMNN<T>.Entry[] array3 in array)
			{
				if (array3 != null)
				{
					foreach (KCGGNJEJCCLLDKMMNN<T>.Entry entry in array3)
					{
						yield return new KeyValuePair<string, T>(Encoding.UTF8.GetString(entry.Key), entry.Value);
					}
					KCGGNJEJCCLLDKMMNN<T>.Entry[] array4 = null;
				}
			}
			KCGGNJEJCCLLDKMMNN<T>.Entry[][] array2 = null;
			yield break;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003FD7 File Offset: 0x000021D7
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000167 RID: 359
		private readonly KCGGNJEJCCLLDKMMNN<T>.Entry[][] buckets;

		// Token: 0x04000168 RID: 360
		private readonly ulong indexFor;

		// Token: 0x020000A2 RID: 162
		private struct Entry
		{
			// Token: 0x0600023B RID: 571 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
			public override string ToString()
			{
				string[] array = new string[5];
				array[0] = "(";
				array[1] = Encoding.UTF8.GetString(this.Key);
				array[2] = ", ";
				int num = 3;
				T value = this.Value;
				array[num] = ((value != null) ? value.ToString() : null);
				array[4] = ")";
				return string.Concat(array);
			}

			// Token: 0x04000169 RID: 361
			public byte[] Key;

			// Token: 0x0400016A RID: 362
			public T Value;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Utf8Json.Internal
{
	// Token: 0x020000AC RID: 172
	internal class AGIKLMFPEFJELOKJEB<TValue>
	{
		// Token: 0x06000284 RID: 644 RVA: 0x00010450 File Offset: 0x0000E650
		public AGIKLMFPEFJELOKJEB(int capacity = 4, float loadFactor = 0.75f)
		{
			int num = AGIKLMFPEFJELOKJEB<TValue>.CalculateCapacity(capacity, loadFactor);
			this.buckets = new AGIKLMFPEFJELOKJEB<TValue>.Entry[num];
			this.loadFactor = loadFactor;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001048C File Offset: 0x0000E68C
		public bool TryAdd(Type key, TValue value)
		{
			return this.TryAdd(key, (Type _) => value);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000104BC File Offset: 0x0000E6BC
		public bool TryAdd(Type key, Func<Type, TValue> valueFactory)
		{
			TValue tvalue;
			return this.TryAddInternal(key, valueFactory, out tvalue);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000104D4 File Offset: 0x0000E6D4
		private bool TryAddInternal(Type key, Func<Type, TValue> valueFactory, out TValue resultingValue)
		{
			object obj = this.writerLock;
			bool result;
			lock (obj)
			{
				int num = AGIKLMFPEFJELOKJEB<TValue>.CalculateCapacity(this.size + 1, this.loadFactor);
				if (this.buckets.Length < num)
				{
					AGIKLMFPEFJELOKJEB<TValue>.Entry[] value = new AGIKLMFPEFJELOKJEB<TValue>.Entry[num];
					for (int i = 0; i < this.buckets.Length; i++)
					{
						for (AGIKLMFPEFJELOKJEB<TValue>.Entry entry = this.buckets[i]; entry != null; entry = entry.Next)
						{
							AGIKLMFPEFJELOKJEB<TValue>.Entry newEntryOrNull = new AGIKLMFPEFJELOKJEB<TValue>.Entry
							{
								Key = entry.Key,
								Value = entry.Value,
								Hash = entry.Hash
							};
							this.AddToBuckets(value, key, newEntryOrNull, null, out resultingValue);
						}
					}
					bool flag2 = this.AddToBuckets(value, key, null, valueFactory, out resultingValue);
					AGIKLMFPEFJELOKJEB<TValue>.VolatileWrite(ref this.buckets, value);
					if (flag2)
					{
						this.size++;
					}
					result = flag2;
				}
				else
				{
					bool flag3 = this.AddToBuckets(this.buckets, key, null, valueFactory, out resultingValue);
					if (flag3)
					{
						this.size++;
					}
					result = flag3;
				}
			}
			return result;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private bool AddToBuckets(AGIKLMFPEFJELOKJEB<TValue>.Entry[] buckets, Type newKey, AGIKLMFPEFJELOKJEB<TValue>.Entry newEntryOrNull, Func<Type, TValue> valueFactory, out TValue resultingValue)
		{
			int num = (newEntryOrNull != null) ? newEntryOrNull.Hash : newKey.GetHashCode();
			if (buckets[num & buckets.Length - 1] != null)
			{
				AGIKLMFPEFJELOKJEB<TValue>.Entry entry = buckets[num & buckets.Length - 1];
				while (!(entry.Key == newKey))
				{
					if (entry.Next == null)
					{
						if (newEntryOrNull != null)
						{
							resultingValue = newEntryOrNull.Value;
							AGIKLMFPEFJELOKJEB<TValue>.VolatileWrite(ref entry.Next, newEntryOrNull);
							return true;
						}
						resultingValue = valueFactory(newKey);
						AGIKLMFPEFJELOKJEB<TValue>.VolatileWrite(ref entry.Next, new AGIKLMFPEFJELOKJEB<TValue>.Entry
						{
							Key = newKey,
							Value = resultingValue,
							Hash = num
						});
						return true;
					}
					else
					{
						entry = entry.Next;
					}
				}
				resultingValue = entry.Value;
				return false;
			}
			if (newEntryOrNull != null)
			{
				resultingValue = newEntryOrNull.Value;
				AGIKLMFPEFJELOKJEB<TValue>.VolatileWrite(ref buckets[num & buckets.Length - 1], newEntryOrNull);
			}
			else
			{
				resultingValue = valueFactory(newKey);
				AGIKLMFPEFJELOKJEB<TValue>.VolatileWrite(ref buckets[num & buckets.Length - 1], new AGIKLMFPEFJELOKJEB<TValue>.Entry
				{
					Key = newKey,
					Value = resultingValue,
					Hash = num
				});
			}
			return true;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00010724 File Offset: 0x0000E924
		public bool TryGetValue(Type key, out TValue value)
		{
			AGIKLMFPEFJELOKJEB<TValue>.Entry[] array = this.buckets;
			int hashCode = key.GetHashCode();
			AGIKLMFPEFJELOKJEB<TValue>.Entry entry = array[hashCode & array.Length - 1];
			if (entry != null)
			{
				if (entry.Key == key)
				{
					value = entry.Value;
					return true;
				}
				for (AGIKLMFPEFJELOKJEB<TValue>.Entry next = entry.Next; next != null; next = next.Next)
				{
					if (next.Key == key)
					{
						value = next.Value;
						return true;
					}
				}
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000107A0 File Offset: 0x0000E9A0
		public TValue GetOrAdd(Type key, Func<Type, TValue> valueFactory)
		{
			TValue result;
			if (this.TryGetValue(key, out result))
			{
				return result;
			}
			this.TryAddInternal(key, valueFactory, out result);
			return result;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
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

		// Token: 0x0600028C RID: 652 RVA: 0x0000424B File Offset: 0x0000244B
		private static void VolatileWrite(ref AGIKLMFPEFJELOKJEB<TValue>.Entry location, AGIKLMFPEFJELOKJEB<TValue>.Entry value)
		{
			Thread.MemoryBarrier();
			location = value;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000424B File Offset: 0x0000244B
		private static void VolatileWrite(ref AGIKLMFPEFJELOKJEB<TValue>.Entry[] location, AGIKLMFPEFJELOKJEB<TValue>.Entry[] value)
		{
			Thread.MemoryBarrier();
			location = value;
		}

		// Token: 0x04000199 RID: 409
		private AGIKLMFPEFJELOKJEB<TValue>.Entry[] buckets;

		// Token: 0x0400019A RID: 410
		private int size;

		// Token: 0x0400019B RID: 411
		private readonly object writerLock = new object();

		// Token: 0x0400019C RID: 412
		private readonly float loadFactor;

		// Token: 0x020000AD RID: 173
		private class Entry
		{
			// Token: 0x0600028E RID: 654 RVA: 0x000107C8 File Offset: 0x0000E9C8
			public override string ToString()
			{
				Type key = this.Key;
				return ((key != null) ? key.ToString() : null) + "(" + this.Count().ToString() + ")";
			}

			// Token: 0x0600028F RID: 655 RVA: 0x00010804 File Offset: 0x0000EA04
			private int Count()
			{
				int num = 1;
				AGIKLMFPEFJELOKJEB<TValue>.Entry entry = this;
				while (entry.Next != null)
				{
					num++;
					entry = entry.Next;
				}
				return num;
			}

			// Token: 0x0400019D RID: 413
			public Type Key;

			// Token: 0x0400019E RID: 414
			public TValue Value;

			// Token: 0x0400019F RID: 415
			public int Hash;

			// Token: 0x040001A0 RID: 416
			public AGIKLMFPEFJELOKJEB<TValue>.Entry Next;
		}

		// Token: 0x020000AE RID: 174
		[CompilerGenerated]
		private sealed class NELHOEOBCGBGPDIMPI
		{
			// Token: 0x06000292 RID: 658 RVA: 0x00004255 File Offset: 0x00002455
			internal TValue <TryAdd>b__0(Type _)
			{
				return this.value;
			}

			// Token: 0x040001A1 RID: 417
			public TValue value;
		}
	}
}

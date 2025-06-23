using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000ED RID: 237
	public sealed class NJEBFEBMCIOELKAAJH : FLGKBGGCEAHKIBEKBN<TimeSpan>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x0001567C File Offset: 0x0001387C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, TimeSpan value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			if (value == TimeSpan.MinValue)
			{
				writer.WriteRaw(NJEBFEBMCIOELKAAJH.minValue);
				return;
			}
			bool flag = value < TimeSpan.Zero;
			if (flag)
			{
				value = value.Negate();
			}
			int days = value.Days;
			int hours = value.Hours;
			int minutes = value.Minutes;
			int seconds = value.Seconds;
			long num = value.Ticks % 10000000L;
			writer.EnsureCapacity(19 + ((num == 0L) ? 0 : 8) + 6);
			writer.WriteRawUnsafe(34);
			if (flag)
			{
				writer.WriteRawUnsafe(45);
			}
			if (days != 0)
			{
				writer.WriteInt32(days);
				writer.WriteRawUnsafe(46);
			}
			if (hours < 10)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(hours);
			writer.WriteRawUnsafe(58);
			if (minutes < 10)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(minutes);
			writer.WriteRawUnsafe(58);
			if (seconds < 10)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(seconds);
			if (num != 0L)
			{
				writer.WriteRawUnsafe(46);
				writer.WriteInt64(num);
			}
			writer.WriteRawUnsafe(34);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00015788 File Offset: 0x00013988
		public TimeSpan Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentUnsafe();
			byte[] array = arraySegment.Array;
			int num = arraySegment.Offset;
			int count = arraySegment.Count;
			int num2 = arraySegment.Offset + arraySegment.Count;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			for (int i = num; i < arraySegment.Count; i++)
			{
				if (array[i] == 46)
				{
					if (flag3)
					{
						break;
					}
					flag2 = true;
				}
				else if (array[i] == 58)
				{
					if (flag2)
					{
						flag = true;
					}
					flag3 = true;
				}
			}
			bool flag4 = false;
			if (array[num] == 45)
			{
				flag4 = true;
				num++;
			}
			int days = 0;
			if (flag)
			{
				byte[] array2 = LCKBMKDJCBFPPGKFIB.Default.Rent();
				try
				{
					while (array[num] != 46)
					{
						array2[days++] = array[num];
						num++;
					}
					days = new BPIPCPJELFMIKDNCFG(array2).ReadInt32();
					num++;
				}
				finally
				{
					LCKBMKDJCBFPPGKFIB.Default.Return(array2);
				}
			}
			int hours = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
			if (array[num++] == 58)
			{
				int minutes = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
				if (array[num++] == 58)
				{
					int seconds = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
					int num3 = 0;
					if (num < num2 && array[num] == 46)
					{
						num++;
						if (num < num2 && OCPOKGPLBCLIEHKKHN.IsNumber(array[num]))
						{
							num3 += (int)(array[num] - 48) * 1000000;
							num++;
							if (num < num2 && OCPOKGPLBCLIEHKKHN.IsNumber(array[num]))
							{
								num3 += (int)(array[num] - 48) * 100000;
								num++;
								if (num < num2 && OCPOKGPLBCLIEHKKHN.IsNumber(array[num]))
								{
									num3 += (int)(array[num] - 48) * 10000;
									num++;
									if (num < num2 && OCPOKGPLBCLIEHKKHN.IsNumber(array[num]))
									{
										num3 += (int)(array[num] - 48) * 1000;
										num++;
										if (num < num2 && OCPOKGPLBCLIEHKKHN.IsNumber(array[num]))
										{
											num3 += (int)((array[num] - 48) * 100);
											num++;
											if (num < num2 && OCPOKGPLBCLIEHKKHN.IsNumber(array[num]))
											{
												num3 += (int)((array[num] - 48) * 10);
												num++;
												if (num < num2 && OCPOKGPLBCLIEHKKHN.IsNumber(array[num]))
												{
													num3 += (int)(array[num] - 48);
													num++;
													while (num < num2 && OCPOKGPLBCLIEHKKHN.IsNumber(array[num]))
													{
														num++;
													}
												}
											}
										}
									}
								}
							}
						}
					}
					TimeSpan timeSpan = new TimeSpan(days, hours, minutes, seconds);
					TimeSpan ts = TimeSpan.FromTicks((long)num3);
					if (!flag4)
					{
						return timeSpan.Add(ts);
					}
					return timeSpan.Negate().Subtract(ts);
				}
			}
			throw new InvalidOperationException("invalid datetime format. value:" + CHFCLNEOCDIHMILKOP.UTF8.GetString(arraySegment.Array, arraySegment.Offset, arraySegment.Count));
		}

		// Token: 0x04000245 RID: 581
		public static readonly FLGKBGGCEAHKIBEKBN<TimeSpan> Default = new NJEBFEBMCIOELKAAJH();

		// Token: 0x04000246 RID: 582
		private static byte[] minValue = CHFCLNEOCDIHMILKOP.UTF8.GetBytes("\"" + TimeSpan.MinValue.ToString() + "\"");
	}
}

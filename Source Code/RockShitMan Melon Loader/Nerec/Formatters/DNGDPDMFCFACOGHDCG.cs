using System;
using Utf8Json.Internal;

namespace Utf8Json.Formatters
{
	// Token: 0x020000E6 RID: 230
	public sealed class DNGDPDMFCFACOGHDCG : FLGKBGGCEAHKIBEKBN<DateTime>, DDGADMMMOKKMDLNAEK
	{
		// Token: 0x060003DF RID: 991 RVA: 0x0001459C File Offset: 0x0001279C
		public void Serialize(ref BJLLMLPIIIPIEPLCJH writer, DateTime value, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			int year = value.Year;
			int month = value.Month;
			int day = value.Day;
			int hour = value.Hour;
			int minute = value.Minute;
			int second = value.Second;
			long num = value.Ticks % 10000000L;
			switch (value.Kind)
			{
			case DateTimeKind.Utc:
				writer.EnsureCapacity(21 + ((num == 0L) ? 0 : 8) + 1);
				goto IL_9B;
			case DateTimeKind.Local:
				writer.EnsureCapacity(21 + ((num == 0L) ? 0 : 8) + 6);
				goto IL_9B;
			}
			writer.EnsureCapacity(21 + ((num == 0L) ? 0 : 8));
			IL_9B:
			writer.WriteRawUnsafe(34);
			if (year < 10)
			{
				writer.WriteRawUnsafe(48);
				writer.WriteRawUnsafe(48);
				writer.WriteRawUnsafe(48);
			}
			else if (year < 100)
			{
				writer.WriteRawUnsafe(48);
				writer.WriteRawUnsafe(48);
			}
			else if (year < 1000)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(year);
			writer.WriteRawUnsafe(45);
			if (month < 10)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(month);
			writer.WriteRawUnsafe(45);
			if (day < 10)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(day);
			writer.WriteRawUnsafe(84);
			if (hour < 10)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(hour);
			writer.WriteRawUnsafe(58);
			if (minute < 10)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(minute);
			writer.WriteRawUnsafe(58);
			if (second < 10)
			{
				writer.WriteRawUnsafe(48);
			}
			writer.WriteInt32(second);
			if (num != 0L)
			{
				writer.WriteRawUnsafe(46);
				if (num < 10L)
				{
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
				}
				else if (num < 100L)
				{
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
				}
				else if (num < 1000L)
				{
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
				}
				else if (num < 10000L)
				{
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
				}
				else if (num < 100000L)
				{
					writer.WriteRawUnsafe(48);
					writer.WriteRawUnsafe(48);
				}
				else if (num < 1000000L)
				{
					writer.WriteRawUnsafe(48);
				}
				writer.WriteInt64(num);
			}
			switch (value.Kind)
			{
			case DateTimeKind.Utc:
				writer.WriteRawUnsafe(90);
				break;
			case DateTimeKind.Local:
			{
				TimeSpan t = TimeZoneInfo.Local.GetUtcOffset(value);
				bool flag = t < TimeSpan.Zero;
				if (flag)
				{
					t = t.Negate();
				}
				int hours = t.Hours;
				int minutes = t.Minutes;
				writer.WriteRawUnsafe(flag ? 45 : 43);
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
				break;
			}
			}
			writer.WriteRawUnsafe(34);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000148DC File Offset: 0x00012ADC
		public DateTime Deserialize(ref BPIPCPJELFMIKDNCFG reader, LMCMANMFGJGJFPNBEN formatterResolver)
		{
			ArraySegment<byte> arraySegment = reader.ReadStringSegmentUnsafe();
			byte[] array = arraySegment.Array;
			int num = arraySegment.Offset;
			int count = arraySegment.Count;
			int num2 = arraySegment.Offset + arraySegment.Count;
			if (count == 4)
			{
				return new DateTime((int)(array[num++] - 48) * 1000 + (int)((array[num++] - 48) * 100) + (int)((array[num++] - 48) * 10) + (int)(array[num++] - 48), 1, 1);
			}
			if (count == 7)
			{
				int year = (int)(array[num++] - 48) * 1000 + (int)((array[num++] - 48) * 100) + (int)((array[num++] - 48) * 10) + (int)(array[num++] - 48);
				if (array[num++] == 45)
				{
					int month = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
					return new DateTime(year, month, 1);
				}
			}
			else if (count == 10)
			{
				int year2 = (int)(array[num++] - 48) * 1000 + (int)((array[num++] - 48) * 100) + (int)((array[num++] - 48) * 10) + (int)(array[num++] - 48);
				if (array[num++] == 45)
				{
					int month2 = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
					if (array[num++] == 45)
					{
						int day = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
						return new DateTime(year2, month2, day);
					}
				}
			}
			else if (count >= 19)
			{
				int year3 = (int)(array[num++] - 48) * 1000 + (int)((array[num++] - 48) * 100) + (int)((array[num++] - 48) * 10) + (int)(array[num++] - 48);
				if (array[num++] == 45)
				{
					int month3 = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
					if (array[num++] == 45)
					{
						int day2 = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
						if (array[num++] == 84)
						{
							int hour = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
							if (array[num++] == 58)
							{
								int minute = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
								if (array[num++] == 58)
								{
									int second = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
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
									DateTimeKind kind = DateTimeKind.Unspecified;
									if (num < num2 && array[num] == 90)
									{
										kind = DateTimeKind.Utc;
									}
									else if ((num < num2 && array[num] == 45) || array[num] == 43)
									{
										if (num + 5 < num2)
										{
											bool flag = array[num++] == 45;
											int hours = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
											num++;
											int minutes = (int)((array[num++] - 48) * 10 + (array[num++] - 48));
											TimeSpan value = new TimeSpan(hours, minutes, 0);
											if (flag)
											{
												value = value.Negate();
											}
											return new DateTime(year3, month3, day2, hour, minute, second, DateTimeKind.Utc).AddTicks((long)num3).Subtract(value).ToLocalTime();
										}
										goto IL_4A6;
									}
									return new DateTime(year3, month3, day2, hour, minute, second, kind).AddTicks((long)num3);
								}
							}
						}
					}
				}
			}
			IL_4A6:
			throw new InvalidOperationException("invalid datetime format. value:" + CHFCLNEOCDIHMILKOP.UTF8.GetString(arraySegment.Array, arraySegment.Offset, arraySegment.Count));
		}

		// Token: 0x0400023F RID: 575
		public static readonly FLGKBGGCEAHKIBEKBN<DateTime> Default = new DNGDPDMFCFACOGHDCG();
	}
}

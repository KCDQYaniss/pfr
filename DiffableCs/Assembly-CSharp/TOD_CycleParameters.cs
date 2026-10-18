//Type is in global namespace

public class TOD_CycleParameters
{
	[Range(0, 24)]
	[Tooltip("Current hour of the day.")]
	public float Hour; //Field offset: 0x10
	[Range(0, 31)]
	[Tooltip("Current day of the month.")]
	public int Day; //Field offset: 0x14
	[Range(0, 11)]
	[Tooltip("Current month of the year.")]
	public int Month; //Field offset: 0x18
	[TOD_Range(1, 9999)]
	[Tooltip("Current year.")]
	public int Year; //Field offset: 0x1C

	public DateTime DateTime
	{
		 get { } //Length: 327
		 set { } //Length: 448
	}

	public long Ticks
	{
		 get { } //Length: 149
		 set { } //Length: 58
	}

	public TOD_CycleParameters() { }

	public TOD_CycleParameters(TOD_CycleParameters from) { }

	public DateTime get_DateTime() { }

	public long get_Ticks() { }

	public void set_DateTime(DateTime value) { }

	public void set_Ticks(long value) { }

}


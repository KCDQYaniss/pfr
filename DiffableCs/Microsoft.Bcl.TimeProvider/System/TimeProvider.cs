namespace System;

[Nullable(0)]
[NullableContext(1)]
public abstract class TimeProvider
{
	private sealed class SystemTimeProvider : TimeProvider
	{

		internal SystemTimeProvider() { }

	}

	[CompilerGenerated]
	private static readonly TimeProvider <System>k__BackingField; //Field offset: 0x0
	private static readonly long s_minDateTicks; //Field offset: 0x8
	private static readonly long s_maxDateTicks; //Field offset: 0x10

	public override TimeZoneInfo LocalTimeZone
	{
		 get { } //Length: 69
	}

	private static TimeProvider() { }

	protected TimeProvider() { }

	public override TimeZoneInfo get_LocalTimeZone() { }

	public override DateTimeOffset GetUtcNow() { }

}


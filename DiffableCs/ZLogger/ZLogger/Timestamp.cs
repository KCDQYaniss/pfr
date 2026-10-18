namespace ZLogger;

[IsReadOnly]
[Nullable(0)]
[NullableContext(2)]
public struct Timestamp
{
	private static readonly long MinTicks; //Field offset: 0x0
	private static readonly long MaxTicks; //Field offset: 0x8
	private readonly DateTimeOffset utcNow; //Field offset: 0x0
	private readonly TimeProvider timeProvider; //Field offset: 0x10

	public DateTimeOffset Local
	{
		 get { } //Length: 254
	}

	public DateTimeOffset Utc
	{
		 get { } //Length: 10
	}

	private static Timestamp() { }

	public Timestamp(TimeProvider timeProvider) { }

	private static void AppendWithFillZero1(ref Utf8StringWriter writer, int value) { }

	private static void AppendWithFillZero2(ref Utf8StringWriter writer, int value) { }

	private static void AppendWithFillZero3(ref Utf8StringWriter writer, int value) { }

	private static void FormatDate(ref Utf8StringWriter writer, DateTime date) { }

	private static void FormatDateAndTime(ref Utf8StringWriter writer, DateTime dateTime) { }

	private static void FormatDateAndTimeAndMilliseconds(ref Utf8StringWriter writer, DateTime dateTime) { }

	private static void FormatTime(ref Utf8StringWriter writer, DateTime time) { }

	private static void FormatTimeMilliseconds(ref Utf8StringWriter writer, DateTime dateTime) { }

	public DateTimeOffset get_Local() { }

	public DateTimeOffset get_Utc() { }

	[NullableContext(1)]
	private static DateTimeOffset ToLocalTime(DateTimeOffset dateTimeOffset, TimeProvider timeProvider) { }

	[NullableContext(1)]
	public virtual string ToString() { }

	internal bool TryFormat(ref Utf8StringWriter writer, string format) { }

}


namespace ZLogger;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False)]
[Nullable(0)]
[NullableContext(1)]
public sealed class ZLoggerMessageAttribute : Attribute
{
	[CompilerGenerated]
	private int <EventId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private string <EventName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private LogLevel <Level>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <SkipEnabledCheck>k__BackingField; //Field offset: 0x30

	public int EventId
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(2)]
	public string EventName
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 82
	}

	public LogLevel Level
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool SkipEnabledCheck
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ZLoggerMessageAttribute() { }

	public ZLoggerMessageAttribute(LogLevel level, string message) { }

	public ZLoggerMessageAttribute(int eventId, LogLevel level, string message) { }

	public ZLoggerMessageAttribute(LogLevel level) { }

	public ZLoggerMessageAttribute(string message) { }

	[CompilerGenerated]
	public int get_EventId() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public string get_EventName() { }

	[CompilerGenerated]
	public LogLevel get_Level() { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public bool get_SkipEnabledCheck() { }

	[CompilerGenerated]
	public void set_EventId(int value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_EventName(string value) { }

	[CompilerGenerated]
	public void set_Level(LogLevel value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

	[CompilerGenerated]
	public void set_SkipEnabledCheck(bool value) { }

}


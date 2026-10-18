namespace System.Diagnostics;

[IsReadOnly]
[Nullable(0)]
[NullableContext(2)]
public struct ActivityContext : IEquatable
{
	[CompilerGenerated]
	private readonly ActivityTraceId <TraceId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ActivitySpanId <SpanId>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly ActivityTraceFlags <TraceFlags>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <TraceState>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <IsRemote>k__BackingField; //Field offset: 0x20

	public bool IsRemote
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ActivitySpanId SpanId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ActivityTraceFlags TraceFlags
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public ActivityTraceId TraceId
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public string TraceState
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool Equals(ActivityContext value) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public bool get_IsRemote() { }

	[CompilerGenerated]
	public ActivitySpanId get_SpanId() { }

	[CompilerGenerated]
	public ActivityTraceFlags get_TraceFlags() { }

	[CompilerGenerated]
	public ActivityTraceId get_TraceId() { }

	[CompilerGenerated]
	public string get_TraceState() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ActivityContext left, ActivityContext right) { }

}


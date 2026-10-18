namespace Microsoft.Extensions.Logging;

[DebuggerDisplay("{DebuggerToString(),nq}")]
[Nullable(0)]
[NullableContext(1)]
public class LoggerFilterOptions
{
	[CompilerGenerated]
	private bool <CaptureScopes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private LogLevel <MinLevel>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly List <RulesInternal>k__BackingField; //Field offset: 0x18

	public bool CaptureScopes
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LogLevel MinLevel
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal List RulesInternal
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public LoggerFilterOptions() { }

	[CompilerGenerated]
	public bool get_CaptureScopes() { }

	[CompilerGenerated]
	public LogLevel get_MinLevel() { }

	[CompilerGenerated]
	internal List get_RulesInternal() { }

	[CompilerGenerated]
	public void set_MinLevel(LogLevel value) { }

}


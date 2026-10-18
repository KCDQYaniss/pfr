namespace ZLogger;

[IsReadOnly]
[Nullable(0)]
[NullableContext(2)]
public struct LogInfo
{
	public readonly LogCategory Category; //Field offset: 0x0
	public readonly Timestamp Timestamp; //Field offset: 0x20
	public readonly LogLevel LogLevel; //Field offset: 0x38
	public readonly EventId EventId; //Field offset: 0x40
	public readonly Exception Exception; //Field offset: 0x50
	public readonly LogScopeState ScopeState; //Field offset: 0x58
	public readonly ThreadInfo ThreadInfo; //Field offset: 0x60
	public readonly object Context; //Field offset: 0x78
	public readonly string MemberName; //Field offset: 0x80
	public readonly string FilePath; //Field offset: 0x88
	public readonly int LineNumber; //Field offset: 0x90

	public LogInfo(LogCategory category, Timestamp timestamp, LogLevel logLevel, EventId eventId, Exception exception, LogScopeState scopeState, ThreadInfo threadInfo, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

}


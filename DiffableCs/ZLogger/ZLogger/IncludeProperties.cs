namespace ZLogger;

[Flags]
public enum IncludeProperties
{
	None = 0,
	Timestamp = 1,
	LogLevel = 2,
	CategoryName = 4,
	EventIdValue = 8,
	EventIdName = 16,
	Message = 32,
	Exception = 64,
	ScopeKeyValues = 128,
	ParameterKeyValues = 256,
	MemberName = 512,
	FilePath = 1024,
	LineNumber = 2048,
	Default = 487,
	All = 4095,
}


namespace Microsoft.Extensions.Logging;

[Flags]
public enum ActivityTrackingOptions
{
	None = 0,
	SpanId = 1,
	TraceId = 2,
	ParentId = 4,
	TraceState = 8,
	TraceFlags = 16,
	Tags = 32,
	Baggage = 64,
}


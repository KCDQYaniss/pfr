namespace ZLogger;

public sealed class ZLoggerLogger : ILogger
{
	private class NullDisposable : IDisposable
	{
		[Nullable(1)]
		public static readonly IDisposable Instance; //Field offset: 0x0

		private static NullDisposable() { }

		public NullDisposable() { }

		public override void Dispose() { }

	}

	private readonly LogCategory category; //Field offset: 0x10
	[Nullable(1)]
	private readonly IAsyncLogProcessor logProcessor; //Field offset: 0x30
	[Nullable(2)]
	private readonly TimeProvider timeProvider; //Field offset: 0x38
	[Nullable(2)]
	private readonly IExternalScopeProvider scopeProvider; //Field offset: 0x40
	private readonly bool formatImmediately; //Field offset: 0x48
	private readonly bool captureThreadInfo; //Field offset: 0x49

	[NullableContext(1)]
	public ZLoggerLogger(string categoryName, IAsyncLogProcessor logProcessor, ZLoggerOptions options, IExternalScopeProvider scopeProvider) { }

	[NullableContext(1)]
	public override IDisposable BeginScope(TState state) { }

	public override bool IsEnabled(LogLevel logLevel) { }

	[NullableContext(2)]
	public override void Log(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func formatter) { }

}


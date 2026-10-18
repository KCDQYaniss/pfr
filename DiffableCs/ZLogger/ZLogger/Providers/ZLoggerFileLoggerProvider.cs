namespace ZLogger.Providers;

[ProviderAlias("ZLoggerFile")]
public class ZLoggerFileLoggerProvider : ILoggerProvider, IDisposable, ISupportExternalScope, IAsyncDisposable
{
	[CompilerGenerated]
	private struct <DisposeAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ZLoggerFileLoggerProvider <>4__this; //Field offset: 0x28
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(1)]
	private readonly ZLoggerFileOptions options; //Field offset: 0x10
	[Nullable(1)]
	private readonly AsyncStreamLineMessageWriter streamWriter; //Field offset: 0x18
	[Nullable(2)]
	private IExternalScopeProvider scopeProvider; //Field offset: 0x20

	[NullableContext(1)]
	public ZLoggerFileLoggerProvider(string filePath, ZLoggerFileOptions options) { }

	[NullableContext(1)]
	public override ILogger CreateLogger(string categoryName) { }

	public override void Dispose() { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__6))]
	public override ValueTask DisposeAsync() { }

	[NullableContext(1)]
	public override void SetScopeProvider(IExternalScopeProvider scopeProvider) { }

}


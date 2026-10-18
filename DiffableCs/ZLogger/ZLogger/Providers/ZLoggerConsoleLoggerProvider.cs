namespace ZLogger.Providers;

[Nullable(0)]
[NullableContext(1)]
[ProviderAlias("ZLoggerConsole")]
public sealed class ZLoggerConsoleLoggerProvider : ILoggerProvider, IDisposable, ISupportExternalScope, IAsyncDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public LogLevel logToStandardErrorThreshold; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <.ctor>b__0(LogLevel level) { }

	}

	[CompilerGenerated]
	private struct <DisposeAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public ZLoggerConsoleLoggerProvider <>4__this; //Field offset: 0x28
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(0)]
	private sealed class DualAsyncLogProcessor : IAsyncLogProcessor, IAsyncDisposable
	{
		[CompilerGenerated]
		private struct <DisposeAsync>d__5 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
			[Nullable(0)]
			public DualAsyncLogProcessor <>4__this; //Field offset: 0x28
			private ValueTask <t2>5__2; //Field offset: 0x30
			private ValueTaskAwaiter <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private AsyncStreamLineMessageWriter <processor1>P; //Field offset: 0x10
		[CompilerGenerated]
		private AsyncStreamLineMessageWriter <processor2>P; //Field offset: 0x18
		[CompilerGenerated]
		private Func <levelFilter>P; //Field offset: 0x20

		public DualAsyncLogProcessor(AsyncStreamLineMessageWriter processor1, AsyncStreamLineMessageWriter processor2, Func levelFilter) { }

		[AsyncStateMachine(typeof(<DisposeAsync>d__5))]
		public override ValueTask DisposeAsync() { }

		public override void Post(IZLoggerEntry log) { }

	}

	private readonly ZLoggerConsoleOptions options; //Field offset: 0x10
	private readonly IAsyncLogProcessor processor; //Field offset: 0x18
	[Nullable(2)]
	private IExternalScopeProvider scopeProvider; //Field offset: 0x20

	public ZLoggerConsoleLoggerProvider(ZLoggerConsoleOptions options) { }

	public override ILogger CreateLogger(string categoryName) { }

	public override void Dispose() { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__6))]
	public override ValueTask DisposeAsync() { }

	public override void SetScopeProvider(IExternalScopeProvider scopeProvider) { }

}


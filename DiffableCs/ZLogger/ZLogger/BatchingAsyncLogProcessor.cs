namespace ZLogger;

[Nullable(0)]
[NullableContext(1)]
public abstract class BatchingAsyncLogProcessor : IAsyncLogProcessor, IAsyncDisposable
{
	[CompilerGenerated]
	private struct <DisposeAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public BatchingAsyncLogProcessor <>4__this; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteLoop>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public BatchingAsyncLogProcessor <>4__this; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private ChannelReader <reader>5__2; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private List <list>5__3; //Field offset: 0x30
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Channel channel; //Field offset: 0x10
	private readonly Task writeLoop; //Field offset: 0x18
	private readonly ZLoggerOptions options; //Field offset: 0x20
	private readonly int batchSize; //Field offset: 0x28

	public BatchingAsyncLogProcessor(int batchSize, ZLoggerOptions options) { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__9))]
	public override ValueTask DisposeAsync() { }

	protected abstract ValueTask DisposeAsyncCore() { }

	public override void Post(IZLoggerEntry log) { }

	protected abstract ValueTask ProcessAsync(IReadOnlyList list) { }

	[AsyncStateMachine(typeof(<WriteLoop>d__8))]
	private Task WriteLoop() { }

}


namespace ZLogger;

[Nullable(0)]
[NullableContext(1)]
public sealed class AsyncStreamLineMessageWriter : IAsyncLogProcessor, IAsyncDisposable
{
	[CompilerGenerated]
	private struct <DisposeAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public AsyncStreamLineMessageWriter <>4__this; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteLoop>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public AsyncStreamLineMessageWriter <>4__this; //Field offset: 0x20
		[Nullable(0)]
		private StreamBufferWriter <writer>5__2; //Field offset: 0x28
		[Nullable(0)]
		private IZLoggerFormatter <formatter>5__3; //Field offset: 0x30
		private bool <withLineBreak>5__4; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private ChannelReader <reader>5__5; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly byte[] newLine; //Field offset: 0x10
	private readonly bool crlf; //Field offset: 0x18
	private readonly byte newLine1; //Field offset: 0x19
	private readonly byte newLine2; //Field offset: 0x1A
	private readonly Stream stream; //Field offset: 0x20
	private readonly Channel channel; //Field offset: 0x28
	private readonly Task writeLoop; //Field offset: 0x30
	private readonly ZLoggerOptions options; //Field offset: 0x38

	public AsyncStreamLineMessageWriter(Stream stream, ZLoggerOptions options) { }

	private void AppendLine(StreamBufferWriter writer) { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__13))]
	public override ValueTask DisposeAsync() { }

	public override void Post(IZLoggerEntry log) { }

	private void PostSlow(IZLoggerEntry log) { }

	[AsyncStateMachine(typeof(<WriteLoop>d__12))]
	private Task WriteLoop() { }

}


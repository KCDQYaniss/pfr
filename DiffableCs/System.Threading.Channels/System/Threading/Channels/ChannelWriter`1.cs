namespace System.Threading.Channels;

[Nullable(0)]
[NullableContext(2)]
public abstract class ChannelWriter`1
{
	[CompilerGenerated]
	private struct <WriteAsyncCore>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ChannelWriter <>4__this; //Field offset: 0x0
		public T innerItem; //Field offset: 0x0
		public CancellationToken ct; //Field offset: 0x0
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	protected ChannelWriter`1() { }

	public void Complete(Exception error = null) { }

	public override bool TryComplete(Exception error = null) { }

	[NullableContext(1)]
	public abstract bool TryWrite(T item) { }

	[NullableContext(0)]
	public abstract ValueTask WaitToWriteAsync(CancellationToken cancellationToken = null) { }

	[NullableContext(1)]
	public override ValueTask WriteAsync(T item, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<WriteAsyncCore>d__4))]
	private ValueTask WriteAsyncCore(T innerItem, CancellationToken ct) { }

}


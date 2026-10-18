namespace System.IO;

public abstract class TextReader : MarshalByRefObject, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <ReadAsyncInternal>b__17_0(object state) { }

	}

	[CompilerGenerated]
	private struct <ReadToEndAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TextReader <>4__this; //Field offset: 0x20
		private StringBuilder <sb>5__2; //Field offset: 0x28
		private char[] <chars>5__3; //Field offset: 0x30
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class NullTextReader : TextReader
	{

		public NullTextReader() { }

		public virtual int Read(char[] buffer, int index, int count) { }

		public virtual string ReadLine() { }

	}

	public sealed class SyncTextReader : TextReader
	{
		internal readonly TextReader _in; //Field offset: 0x18

		internal SyncTextReader(TextReader t) { }

		public virtual void Close() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual int Peek() { }

		public virtual int Read() { }

		public virtual int Read(char[] buffer, int index, int count) { }

		public virtual Task ReadAsync(char[] buffer, int index, int count) { }

		public virtual string ReadLine() { }

		public virtual string ReadToEnd() { }

		public virtual Task ReadToEndAsync() { }

	}

	public static readonly TextReader Null; //Field offset: 0x0

	private static TextReader() { }

	protected TextReader() { }

	public override void Close() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read(char[] buffer, int index, int count) { }

	public override int Read(Span buffer) { }

	public override Task ReadAsync(char[] buffer, int index, int count) { }

	internal override ValueTask ReadAsyncInternal(Memory buffer, CancellationToken cancellationToken) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

	[AsyncStateMachine(typeof(<ReadToEndAsync>d__14))]
	public override Task ReadToEndAsync() { }

	public static TextReader Synchronized(TextReader reader) { }

}


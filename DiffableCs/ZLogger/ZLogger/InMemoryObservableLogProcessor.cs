namespace ZLogger;

[Nullable(0)]
[NullableContext(1)]
public class InMemoryObservableLogProcessor : IAsyncLogProcessor, IAsyncDisposable, IDisposable
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Action MessageReceived; //Field offset: 0x10
	[CompilerGenerated]
	private IZLoggerFormatter <Formatter>k__BackingField; //Field offset: 0x18
	private bool isDisposed; //Field offset: 0x20

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public event Action MessageReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public internal IZLoggerFormatter Formatter
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public InMemoryObservableLogProcessor() { }

	[CompilerGenerated]
	public void add_MessageReceived(Action value) { }

	[CompilerGenerated]
	public IZLoggerFormatter get_Formatter() { }

	[CompilerGenerated]
	public void remove_MessageReceived(Action value) { }

	[CompilerGenerated]
	internal void set_Formatter(IZLoggerFormatter value) { }

	private override ValueTask System.IAsyncDisposable.DisposeAsync() { }

	private override void System.IDisposable.Dispose() { }

	private override void ZLogger.IAsyncLogProcessor.Post(IZLoggerEntry log) { }

}


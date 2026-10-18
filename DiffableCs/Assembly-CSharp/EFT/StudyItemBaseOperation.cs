namespace EFT;

public abstract class StudyItemBaseOperation : AbstractOperation
{
	[CompilerGenerated]
	private struct <ExecuteAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StudyItemBaseOperation <>4__this; //Field offset: 0x20
		public Callback callback; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private EStudyState <CurrentState>k__BackingField; //Field offset: 0x40
	private readonly CancellationTokenSource _cancellationTokenSource; //Field offset: 0x48
	private readonly TaskCompletionSource _executeCompletionSource; //Field offset: 0x50
	protected readonly CompletableItem Item; //Field offset: 0x58
	protected readonly InventoryController InventoryController; //Field offset: 0x60

	protected CancellationToken CancellationToken
	{
		 get { } //Length: 29
	}

	public EStudyState CurrentState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Task ExecuteCompletionTask
	{
		 get { } //Length: 66
	}

	protected StudyItemBaseOperation(ushort id, InventoryController controller, CompletableItem item) { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<ExecuteAsync>d__16))]
	private Task ExecuteAsync(Callback callback) { }

	protected virtual void ExecuteInternal(Callback callback) { }

	protected CancellationToken get_CancellationToken() { }

	[CompilerGenerated]
	public EStudyState get_CurrentState() { }

	public Task get_ExecuteCompletionTask() { }

	public abstract void Pause() { }

	protected abstract Task ProcessAudio() { }

	public abstract void Resume() { }

	[CompilerGenerated]
	protected void set_CurrentState(EStudyState value) { }

	public override void Terminate() { }

}


namespace EFT.InventoryLogic.Operations;

public abstract class AbstractAsyncOperation`1 : AbstractOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Callback callback; //Field offset: 0x0

		public <>c__DisplayClass11_0() { }

		internal void <ExecuteInternal>g__CheckException|0(Task finishedTask) { }

	}

	[CompilerGenerated]
	private struct <InProcess>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AbstractAsyncOperation <>4__this; //Field offset: 0x0
		public Item item; //Field offset: 0x0
		public ItemAddress to; //Field offset: 0x0
		public IInventoryOperation operation; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OutProcess>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AbstractAsyncOperation <>4__this; //Field offset: 0x0
		public Item item; //Field offset: 0x0
		public ItemAddress from; //Field offset: 0x0
		public ItemAddress to; //Field offset: 0x0
		public IInventoryOperation operation; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ExecutionException : Exception
	{
		public readonly Error Error; //Field offset: 0x0

		public ExecutionException(Error error) { }

	}

	private sealed class InProcessException : Exception
	{

		public InProcessException(string error) { }

	}

	private sealed class OutProcessException : Exception
	{

		public OutProcessException(string error) { }

	}

	private readonly TResult _simulatedResult; //Field offset: 0x0
	private OperationResult _executedResult; //Field offset: 0x0
	private readonly Option _executableResult; //Field offset: 0x0

	protected bool ExecutedSuccessfully
	{
		 get { } //Length: 71
	}

	protected AbstractAsyncOperation`1(ushort id, ItemController controller, TResult simulatedResult) { }

	public virtual IResult CanExecute() { }

	public virtual void Dispose() { }

	protected override OperationResult Execute() { }

	protected IResult ExecuteAndFinish() { }

	protected abstract Task ExecuteInternal() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	private void FinalizeOperation() { }

	protected IResult FinishExecution() { }

	protected bool get_ExecutedSuccessfully() { }

	[AsyncStateMachine(typeof(<InProcess>d__13))]
	protected Task InProcess(Item item, ItemAddress to, IInventoryOperation operation = null) { }

	[AsyncStateMachine(typeof(<OutProcess>d__12))]
	protected Task OutProcess(Item item, ItemAddress from, ItemAddress to, IInventoryOperation operation = null) { }

}


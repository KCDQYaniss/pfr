namespace EFT.Dialogs;

public sealed class ClientBackendDialogController : ClientDialogController
{
	[CompilerGenerated]
	private struct <ExecuteLineAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendDialogController <>4__this; //Field offset: 0x20
		public BaseTraderDialogLine line; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartDialogAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MongoID traderId; //Field offset: 0x20
		public ClientBackendDialogController <>4__this; //Field offset: 0x38
		public Nullable entryDialogId; //Field offset: 0x40
		public ITraderAnimationController animationController; //Field offset: 0x60
		private Nullable <targetDialogId>5__2; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly DialogPreLoader <DialogPreLoader>k__BackingField; //Field offset: 0xF0

	public DialogPreLoader DialogPreLoader
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ClientBackendDialogController(Profile profile, QuestController questController, InventoryController inventoryController, IEftSession session) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(MongoID traderId, Nullable entryDialogId, ITraderAnimationController animationController) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__1(BaseTraderDialogLine line) { }

	[AsyncStateMachine(typeof(<ExecuteLineAsync>d__7))]
	private Task ExecuteLineAsync(BaseTraderDialogLine line) { }

	[CompilerGenerated]
	public DialogPreLoader get_DialogPreLoader() { }

	protected virtual void OnExecuteLineHandler(BaseTraderDialogLine line) { }

	public virtual void StartDialog(MongoID traderId, Nullable entryDialogId = null, ITraderAnimationController animationController = null) { }

	[AsyncStateMachine(typeof(<StartDialogAsync>d__6))]
	private Task StartDialogAsync(MongoID traderId, Nullable entryDialogId, ITraderAnimationController animationController) { }

}


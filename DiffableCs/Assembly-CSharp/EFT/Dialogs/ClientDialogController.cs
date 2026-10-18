namespace EFT.Dialogs;

public class ClientDialogController : BaseTraderDialogController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_0; //Field offset: 0x8
		public static Func <>9__21_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <ExecuteLine>b__19_0(DialogAction action) { }

		internal bool <TryHandleHandoverSelection>b__21_1(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public DialogHandoverItemAction handoverAction; //Field offset: 0x10
		public TaskCompletionSource taskSource; //Field offset: 0x18
		public DialogWindowContext context; //Field offset: 0x20

		public <>c__DisplayClass21_0() { }

		internal bool <TryHandleHandoverSelection>b__0(KeyValuePair x) { }

		internal void <TryHandleHandoverSelection>g__DeclineHandler|2() { }

	}

	[CompilerGenerated]
	private struct <AwaitAnimation>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task animationTask; //Field offset: 0x20
		public ClientDialogController <>4__this; //Field offset: 0x28
		private CancellationTokenRegistration <registration>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private ValueTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteLine>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientDialogController <>4__this; //Field offset: 0x20
		public BaseTraderDialogLine line; //Field offset: 0x28
		private CombinedAnimationData <animationInfo>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48
		private YieldAwaiter <>u__4; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteLineInternal>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientDialogController <>4__this; //Field offset: 0x20
		public ProgressDialogData dialogData; //Field offset: 0x28
		public BaseTraderDialogLine line; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryHandleHandoverSelection>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseTraderDialogLine line; //Field offset: 0x20
		public ClientDialogController <>4__this; //Field offset: 0x28
		private Quest <quest>5__2; //Field offset: 0x30
		private ConditionItem <condition>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryWaitForConfirmation>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseTraderDialogLine line; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private ITraderAnimationController _animationController; //Field offset: 0xC0
	private TaskCompletionSource _animationTaskSource; //Field offset: 0xC8
	private IEnumerable _actionsToNotify; //Field offset: 0xD0
	private bool _hidePlayerChoices; //Field offset: 0xD8
	[CompilerGenerated]
	private Action OnSetHidePlayerChoices; //Field offset: 0xE0
	[CompilerGenerated]
	private Action OnLineExecuted; //Field offset: 0xE8

	public event Action OnLineExecuted
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnSetHidePlayerChoices
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private bool HidePlayerChoices
	{
		 get { } //Length: 8
		private set { } //Length: 34
	}

	public ClientDialogController(Profile profile, QuestController questController, InventoryController inventoryController, Dictionary globalSaveStates = null) { }

	[CompilerGenerated]
	public void add_OnLineExecuted(Action value) { }

	[CompilerGenerated]
	public void add_OnSetHidePlayerChoices(Action value) { }

	[AsyncStateMachine(typeof(<AwaitAnimation>d__22))]
	private Task AwaitAnimation(Task animationTask) { }

	protected virtual void ClearTempData() { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<ExecuteLine>d__19))]
	private Task ExecuteLine(BaseTraderDialogLine line) { }

	public bool ExecuteLineByIndex(int index) { }

	[AsyncStateMachine(typeof(<ExecuteLineInternal>d__20))]
	private Task ExecuteLineInternal(BaseTraderDialogLine line, ProgressDialogData dialogData) { }

	public bool get_HidePlayerChoices() { }

	private void InvokeActionEvents() { }

	protected virtual void OnExecuteLineHandler(BaseTraderDialogLine line) { }

	[CompilerGenerated]
	public void remove_OnLineExecuted(Action value) { }

	[CompilerGenerated]
	public void remove_OnSetHidePlayerChoices(Action value) { }

	private void set_HidePlayerChoices(bool value) { }

	public override void StartDialog(MongoID traderId, Nullable entryDialogId = null, ITraderAnimationController animationController = null) { }

	public void StopDialog() { }

	[AsyncStateMachine(typeof(<TryHandleHandoverSelection>d__21))]
	private Task TryHandleHandoverSelection(BaseTraderDialogLine line) { }

	public bool TrySkipAnimation() { }

	[AsyncStateMachine(typeof(<TryWaitForConfirmation>d__18))]
	private Task TryWaitForConfirmation(BaseTraderDialogLine line) { }

}


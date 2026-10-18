namespace EFT.UI;

public abstract class EftScreenState : UIElement
{
	[CompilerGenerated]
	private struct <ChangeState>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftScreenState <>4__this; //Field offset: 0x20
		public bool enabled; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HideState>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftScreenState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowState>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftScreenState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	protected CanvasGroup _stateCanvasGroup; //Field offset: 0x70
	private bool _stateReady; //Field offset: 0x78
	protected readonly CompositeDisposable _compositeDisposable; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnStateReady; //Field offset: 0x88

	public event Action OnStateReady
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override string NextButtonDisabledTooltip
	{
		 get { } //Length: 59
	}

	protected override float PreviewAnimationDuration
	{
		 get { } //Length: 9
	}

	public override bool ShowNextButtonWhenNotReady
	{
		 get { } //Length: 3
	}

	protected CanvasGroup StateCanvasGroup
	{
		 get { } //Length: 5
	}

	public override bool StateReady
	{
		 get { } //Length: 5
		 set { } //Length: 36
	}

	protected override float TransitionDuration
	{
		 get { } //Length: 9
	}

	protected EftScreenState() { }

	[CompilerGenerated]
	public void add_OnStateReady(Action value) { }

	protected override void Awake() { }

	[AsyncStateMachine(typeof(<ChangeState>d__23))]
	protected override Task ChangeState(bool enabled) { }

	public virtual void Close() { }

	public override string get_NextButtonDisabledTooltip() { }

	protected override float get_PreviewAnimationDuration() { }

	public override bool get_ShowNextButtonWhenNotReady() { }

	protected CanvasGroup get_StateCanvasGroup() { }

	public override bool get_StateReady() { }

	protected override float get_TransitionDuration() { }

	[AsyncStateMachine(typeof(<HideState>d__22))]
	public override Task HideState() { }

	protected void NotifyStateChanged() { }

	[CompilerGenerated]
	public void remove_OnStateReady(Action value) { }

	protected override void set_StateReady(bool value) { }

	[AsyncStateMachine(typeof(<ShowState>d__21))]
	public override Task ShowState() { }

	protected void SubscribeVisibleEvent(UnityEvent unityEvent, UnityAction handler) { }

	protected void SubscribeVisibleEvent(IBindableEvent bindableEvent, Action handler) { }

}


namespace EFT.UI;

[UsedImplicitly]
public sealed class EventDialogWindow : TraderDialogWindow
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public TaskCompletionSource tcs; //Field offset: 0x10
		public bool completed; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <StartTypeWriterInternal>b__1() { }

		internal void <StartTypeWriterInternal>g__OnComplete|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public TaskCompletionSource tcs; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal void <HideOptionsAnimated>b__0() { }

		internal void <HideOptionsAnimated>b__1() { }

		internal void <HideOptionsAnimated>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public TaskCompletionSource tcs; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal void <ShowOptionsAnimated>b__0() { }

		internal void <ShowOptionsAnimated>b__1() { }

		internal void <ShowOptionsAnimated>b__2() { }

	}

	[CompilerGenerated]
	private struct <HideOptionsAnimated>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EventDialogWindow <>4__this; //Field offset: 0x20
		private CancellationTokenRegistration <cancellationRegistration>5__2; //Field offset: 0x28
		private object <>7__wrap2; //Field offset: 0x40
		private int <>7__wrap3; //Field offset: 0x48
		private bool <>7__wrap4; //Field offset: 0x4C
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private ValueTaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnStartTypeWriter>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EventDialogWindow <>4__this; //Field offset: 0x28
		public string text; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RedrawAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseTraderDialog dialog; //Field offset: 0x20
		public EventDialogWindow <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowOptionsAnimated>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EventDialogWindow <>4__this; //Field offset: 0x20
		private CancellationTokenRegistration <cancellationRegistration>5__2; //Field offset: 0x28
		private object <>7__wrap2; //Field offset: 0x40
		private int <>7__wrap3; //Field offset: 0x48
		private bool <>7__wrap4; //Field offset: 0x4C
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private ValueTaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartTypeWriterInternal>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EventDialogWindow <>4__this; //Field offset: 0x20
		public string text; //Field offset: 0x28
		private <>c__DisplayClass20_0 <>8__1; //Field offset: 0x30
		private CancellationTokenRegistration <cancellationRegistration>5__2; //Field offset: 0x38
		private object <>7__wrap2; //Field offset: 0x50
		private int <>7__wrap3; //Field offset: 0x58
		private bool <>7__wrap4; //Field offset: 0x5C
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private ValueTaskAwaiter <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private float _optionsFadeTime; //Field offset: 0x118
	[SerializeField]
	private TypeWriterComponent _typeWriterComponent; //Field offset: 0x120
	[SerializeField]
	private TextMeshProUGUI _locationNameText; //Field offset: 0x128
	private MediaAnimationController _mediaAnimationController; //Field offset: 0x130
	private Tweener _currentFadeTweener; //Field offset: 0x138
	private MappedStatVariable _locationNameData; //Field offset: 0x140
	private bool _isAnimationInProgress; //Field offset: 0x148
	[CompilerGenerated]
	private bool <IsTypingText>k__BackingField; //Field offset: 0x149

	public private bool IsTypingText
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public EventDialogWindow() { }

	protected virtual void AssemblePlayerRows(BaseTraderDialog dialog) { }

	public virtual void Close() { }

	[CompilerGenerated]
	public bool get_IsTypingText() { }

	[AsyncStateMachine(typeof(<HideOptionsAnimated>d__21))]
	private Task HideOptionsAnimated() { }

	private void KillCurrentTweener() { }

	[AsyncStateMachine(typeof(<OnStartTypeWriter>d__19))]
	public void OnStartTypeWriter(string text) { }

	protected virtual void Redraw(BaseTraderDialog dialog) { }

	[AsyncStateMachine(typeof(<RedrawAsync>d__17))]
	private Task RedrawAsync(BaseTraderDialog dialog) { }

	[CompilerGenerated]
	private void set_IsTypingText(bool value) { }

	protected virtual void SetHidePlayerChoices(bool isHidden) { }

	public void SetHistoryButtonVisible(bool isVisible) { }

	public void Show(ClientDialogController dialogController, MongoID mainSpeakerId, Dictionary profileTraderInfos, MediaAnimationController mediaController) { }

	[AsyncStateMachine(typeof(<ShowOptionsAnimated>d__22))]
	private Task ShowOptionsAnimated() { }

	public void SkipTypeWriter() { }

	[AsyncStateMachine(typeof(<StartTypeWriterInternal>d__20))]
	private Task StartTypeWriterInternal(string text) { }

	private void UpdateLocationName() { }

	private void UpdateSpeakerHeader(BaseTraderDialog dialog) { }

}


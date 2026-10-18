namespace EFT.UI.Screens;

public abstract class StatedEftScreen`2 : EftScreen
{
	[CompilerGenerated]
	private struct <NextButtonPressedHandlerAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public StatedEftScreen <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowAnotherState>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public StatedEftScreen <>4__this; //Field offset: 0x0
		public int stateIndex; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowFirstState>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public StatedEftScreen <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	protected DefaultUIButton _nextButton; //Field offset: 0x0
	[SerializeField]
	protected DefaultUIButton _backButton; //Field offset: 0x0
	[SerializeField]
	protected CanvasGroup _canvasGroup; //Field offset: 0x0
	protected List _registeredStates; //Field offset: 0x0
	protected int _currentSelectedStateIndex; //Field offset: 0x0
	private bool _interactive; //Field offset: 0x0
	private bool _canGoBack; //Field offset: 0x0

	protected override bool CanGoBack
	{
		 get { } //Length: 3
	}

	protected StatedEftScreen`2() { }

	[CompilerGenerated]
	private void <ShowPreviousScreen>b__17_0() { }

	private void BackButtonPressedHandler() { }

	protected override bool CanGoBackOnState(int stateIndex) { }

	public virtual void Close() { }

	protected override bool ForceDisablePreviousButton(int stateIndex) { }

	protected override bool get_CanGoBack() { }

	private void NextButtonPressedHandler() { }

	[AsyncStateMachine(typeof(<NextButtonPressedHandlerAsync>d__19))]
	protected override Task NextButtonPressedHandlerAsync() { }

	protected override Task PrepareRegisteredStatesAsync() { }

	protected void SetInteractable(bool interactable) { }

	[AsyncStateMachine(typeof(<ShowAnotherState>d__12))]
	protected override Task ShowAnotherState(int stateIndex) { }

	[AsyncStateMachine(typeof(<ShowFirstState>d__10))]
	protected override Task ShowFirstState() { }

	protected override void ShowNextScreen() { }

	private void ShowPreviousScreen() { }

	private void StateReadyHandler(bool ready) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}


namespace EFT.UI.Seasons;

[ExecuteInEditMode]
public sealed class BattlePassRewardReceivedPanel : UIInputNode, ITweenController
{
	[CompilerGenerated]
	private struct <CloseFade>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassRewardReceivedPanel <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EFT-UI-Seasons-BattlePassRewardReceivedPanel-ITweenController-Run>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassRewardReceivedPanel <>4__this; //Field offset: 0x20
		public Tween tween; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FadeIn>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassRewardReceivedPanel <>4__this; //Field offset: 0x20
		public ITweenController tweenController; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private Task <backgroundTask>5__3; //Field offset: 0x38
		private Task <textTask>5__4; //Field offset: 0x40
		private Task <highlightTask>5__5; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FadeOut>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassRewardReceivedPanel <>4__this; //Field offset: 0x20
		public ITweenController tweenController; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private Task <buttonTask>5__3; //Field offset: 0x38
		private Task <backgroundTask>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowFade>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassRewardReceivedPanel <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal interface ITweenController
	{

		public Task Run(Tween tween) { }

	}

	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	[SerializeField]
	private Image _image; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _nameField; //Field offset: 0x90
	[SerializeField]
	private DefaultUIButton _continueButton; //Field offset: 0x98
	[SerializeField]
	private EUISoundType _showSound; //Field offset: 0xA0
	[SerializeField]
	private CanvasGroup _textGroup; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _imageGroup; //Field offset: 0xB0
	[SerializeField]
	private CanvasGroup _highlightGroup; //Field offset: 0xB8
	[SerializeField]
	private CanvasGroup _buttonGroup; //Field offset: 0xC0
	[SerializeField]
	private RectMask2D _mask; //Field offset: 0xC8
	private bool _animationComplete; //Field offset: 0xD0
	private readonly List _tweens; //Field offset: 0xD8

	public BattlePassRewardReceivedPanel() { }

	[CompilerGenerated]
	private void <Show>b__13_0() { }

	[CompilerGenerated]
	private void <Show>b__13_1() { }

	[AsyncStateMachine(typeof(<CloseFade>d__15))]
	private Task CloseFade() { }

	[AsyncStateMachine(typeof(<EFT-UI-Seasons-BattlePassRewardReceivedPanel-ITweenController-Run>d__18))]
	private override Task EFT.UI.Seasons.BattlePassRewardReceivedPanel.ITweenController.Run(Tween tween) { }

	[AsyncStateMachine(typeof(<FadeIn>d__16))]
	public Task FadeIn(ITweenController tweenController) { }

	[AsyncStateMachine(typeof(<FadeOut>d__17))]
	public Task FadeOut(ITweenController tweenController) { }

	private void OnDestroy() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(BattlePassReward reward, Rect imageSize, IImageLoader imageLoader) { }

	[AsyncStateMachine(typeof(<ShowFade>d__14))]
	private Task ShowFade() { }

	private void StopTweens() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}


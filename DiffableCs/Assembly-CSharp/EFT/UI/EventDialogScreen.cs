namespace EFT.UI;

public sealed class EventDialogScreen : BaseDialogScreen
{
	internal sealed class EventDialogScreenController : EftDialogScreenController
	{
		[CompilerGenerated]
		private struct <CloseAction>d__8 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public EventDialogScreenController <>4__this; //Field offset: 0x28
			public bool moveForward; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public readonly Profile Profile; //Field offset: 0x60
		public readonly MongoID DialogId; //Field offset: 0x68
		public readonly IEftSession Session; //Field offset: 0x80

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public EventDialogScreenController(Profile profile, IEftSession session, BaseTraderDialogController dialogController, MongoID dialogId) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0(bool moveForward) { }

		[AsyncStateMachine(typeof(<CloseAction>d__8))]
		protected virtual void CloseAction(bool moveForward) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

	}

	[SerializeField]
	private EventDialogWindow _dialogWindow; //Field offset: 0xB8
	[SerializeField]
	private DialogImagePanel _dialogImage; //Field offset: 0xC0
	[SerializeField]
	private TextGameStatsPanel _statsPanel; //Field offset: 0xC8
	[SerializeField]
	private Button _mapButton; //Field offset: 0xD0
	[SerializeField]
	private Button _quitButton; //Field offset: 0xD8
	[SerializeField]
	private TextGameMapPanel _mapPanel; //Field offset: 0xE0
	[SerializeField]
	private AudioClipConfigDictionary _audioClipData; //Field offset: 0xE8
	private Profile _profile; //Field offset: 0xF0
	private IEftSession _session; //Field offset: 0xF8
	private MongoID _initialDialogId; //Field offset: 0x100
	private MediaAnimationController _animationController; //Field offset: 0x118
	private IDialogSoundscapeManager _audioController; //Field offset: 0x120

	protected virtual bool CanHandleInput
	{
		 get { } //Length: 121
	}

	public EventDialogScreen() { }

	[CompilerGenerated]
	private void <InitDialog>b__17_0() { }

	[CompilerGenerated]
	private void <InitDialog>b__17_1() { }

	[CompilerGenerated]
	private void <InitDialog>b__17_2() { }

	[CompilerGenerated]
	private void <InitDialog>b__17_3() { }

	private void ActionFinishedHandler(DialogAction action) { }

	public virtual void Close() { }

	private void DialogChangedHandler(BaseTraderDialog dialog) { }

	protected virtual bool get_CanHandleInput() { }

	private void HandleQuitAction() { }

	private void InitAudio() { }

	private void InitDialog() { }

	public virtual void Show(EventDialogScreenController controller) { }

	private void ToggleMap() { }

}


namespace EFT.Dialogs;

public abstract class DialogMediaPresenter : UIElement, ITraderAnimationController
{
	[CompilerGenerated]
	private struct <AwaitSubtitles>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogMediaPresenter <>4__this; //Field offset: 0x20
		public List subtitleData; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected bool _questAccepted; //Field offset: 0x70
	protected bool _alwaysDisplay; //Field offset: 0x71
	protected LipSyncDictionary _lipSyncDictionary; //Field offset: 0x78
	private CinemachineVirtualCamera _dialogueCamera; //Field offset: 0x80
	private ItemUiContext _itemUiContext; //Field offset: 0x88
	[CompilerGenerated]
	private readonly NPCObject <Animator>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private ClientDialogController <ClientDialogController>k__BackingField; //Field offset: 0x98

	public override NPCObject Animator
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override ClientDialogController ClientDialogController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected DialogMediaPresenter() { }

	[CompilerGenerated]
	private void <Show>b__5_0() { }

	private void ActionFinishedHandler(DialogAction action) { }

	[AsyncStateMachine(typeof(<AwaitSubtitles>d__11))]
	protected Task AwaitSubtitles(List subtitleData) { }

	public abstract Task ExecuteDialogOption(CombinedAnimationData animationData) { }

	[CompilerGenerated]
	public override NPCObject get_Animator() { }

	[CompilerGenerated]
	public override ClientDialogController get_ClientDialogController() { }

	protected override void HandleAcceptQuestAction() { }

	protected override void HandleQuitAction() { }

	public override void Hide() { }

	public void Init(bool alwaysDisplay) { }

	[CompilerGenerated]
	private void set_ClientDialogController(ClientDialogController value) { }

	public override void Show(ClientDialogController dialogController, CinemachineVirtualCamera dialogueCamera, LipSyncDictionary lipSyncDictionary) { }

	public abstract void ShowPreview() { }

	public override void SkipAnimation() { }

}


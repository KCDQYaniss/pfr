namespace EFT.Dialogs;

public sealed class DialogLaptopPresenter : DialogMediaPresenter
{
	[CompilerGenerated]
	private struct <ExecuteDialogOption>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CombinedAnimationData animationData; //Field offset: 0x20
		public DialogLaptopPresenter <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private DialogueVideoAnimationPlayer _videoAnimationPlayer; //Field offset: 0xA0
	[SerializeField]
	private GameObject _videoImageReplacer; //Field offset: 0xA8
	[SerializeField]
	private DynamicIterativeTextOutput _dynamicIterativeTextOutput; //Field offset: 0xB0
	[SerializeField]
	private AmbientAudioFilterBase _audioFilter; //Field offset: 0xB8

	public DialogLaptopPresenter() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<ExecuteDialogOption>d__6))]
	public virtual Task ExecuteDialogOption(CombinedAnimationData animationData) { }

	protected virtual void HandleQuitAction() { }

	public virtual void Show(ClientDialogController dialogController, CinemachineVirtualCamera dialogueCamera, LipSyncDictionary lipSyncDictionary) { }

	public virtual void ShowPreview() { }

}


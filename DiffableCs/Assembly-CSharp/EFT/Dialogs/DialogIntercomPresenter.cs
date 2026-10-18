namespace EFT.Dialogs;

public sealed class DialogIntercomPresenter : DialogMediaPresenter
{
	[CompilerGenerated]
	private struct <ExecuteDialogOption>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CombinedAnimationData animationData; //Field offset: 0x20
		public DialogIntercomPresenter <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0xA0
	[SerializeField]
	private AmbientAudioFilterBase _audioFilter; //Field offset: 0xA8

	public DialogIntercomPresenter() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<ExecuteDialogOption>d__4))]
	public virtual Task ExecuteDialogOption(CombinedAnimationData animationData) { }

	protected virtual void HandleQuitAction() { }

	public virtual void Show(ClientDialogController dialogController, CinemachineVirtualCamera dialogueCamera, LipSyncDictionary lipSyncDictionary) { }

	public virtual void ShowPreview() { }

}


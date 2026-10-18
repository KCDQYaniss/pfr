namespace EFT.Dialogs;

public sealed class MediaAnimationController : ITraderAnimationController, IDisposable
{
	[CompilerGenerated]
	private struct <ExecuteDialogOption>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CombinedAnimationData animationData; //Field offset: 0x20
		public MediaAnimationController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action OnSpriteChanged; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnMusicChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnSoundChanged; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnSkipTypeWriter; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnStartTypeWriter; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnCompleteTypeWriter; //Field offset: 0x38
	[CompilerGenerated]
	private readonly ClientDialogController <ClientDialogController>k__BackingField; //Field offset: 0x40
	private TaskCompletionSource _typeWriterCompletionSource; //Field offset: 0x48
	private readonly IImageLoader _imageLoader; //Field offset: 0x50
	private readonly Dictionary _initializedDialogs; //Field offset: 0x58
	private bool _disposed; //Field offset: 0x60
	private readonly ClientDialogController _clientDialogController; //Field offset: 0x68

	public event Action OnCompleteTypeWriter
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnMusicChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSkipTypeWriter
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnSoundChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSpriteChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnStartTypeWriter
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override NPCObject Animator
	{
		 get { } //Length: 3
	}

	public override ClientDialogController ClientDialogController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MediaAnimationController(ClientDialogController clientDialogController, IImageLoader imageLoader) { }

	[CompilerGenerated]
	public void add_OnCompleteTypeWriter(Action value) { }

	[CompilerGenerated]
	public void add_OnMusicChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSkipTypeWriter(Action value) { }

	[CompilerGenerated]
	public void add_OnSoundChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSpriteChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnStartTypeWriter(Action value) { }

	public void CompleteTypeWriter() { }

	public override void Dispose() { }

	[AsyncStateMachine(typeof(<ExecuteDialogOption>d__30))]
	public override Task ExecuteDialogOption(CombinedAnimationData animationData) { }

	public override NPCObject get_Animator() { }

	[CompilerGenerated]
	public override ClientDialogController get_ClientDialogController() { }

	private void OnDialogChanged(BaseTraderDialog newDialog) { }

	[CompilerGenerated]
	public void remove_OnCompleteTypeWriter(Action value) { }

	[CompilerGenerated]
	public void remove_OnMusicChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSkipTypeWriter(Action value) { }

	[CompilerGenerated]
	public void remove_OnSoundChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpriteChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnStartTypeWriter(Action value) { }

	public override void SkipAnimation() { }

}


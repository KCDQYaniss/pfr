namespace EFT.Dialogs;

[ExecuteAlways]
public sealed class DialogueVideoAnimationPlayer : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public CancellationTokenSource cancellationToken; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <Play>b__0() { }

	}

	[CompilerGenerated]
	private struct <Play>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogueVideoAnimationPlayer <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public float duration; //Field offset: 0x30
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0x38
		private CancellationTokenRegistration <>7__wrap1; //Field offset: 0x40
		private object <>7__wrap2; //Field offset: 0x58
		private int <>7__wrap3; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68
		private ValueTaskAwaiter <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private VideoPlayer _videoPlayer; //Field offset: 0x70
	[SerializeField]
	private RawImage _sourceImage; //Field offset: 0x78
	[SerializeField]
	private bool _loop; //Field offset: 0x80
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x88
	[SerializeField]
	private VideoClip _idleVideoClip; //Field offset: 0x90
	[SerializeField]
	private VideoClip _speechVideoClip; //Field offset: 0x98
	[SerializeField]
	private VideoClip _transitionVideoClip; //Field offset: 0xA0
	[SerializeField]
	private int _transitionDurationMilliSec; //Field offset: 0xA8
	private LipSyncDictionary _lipSyncDictionary; //Field offset: 0xB0
	private CancellationTokenSource _cancellationToken; //Field offset: 0xB8

	public DialogueVideoAnimationPlayer() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<Play>d__11))]
	public Task Play(string key, float duration) { }

	private void Play(VideoClip clip, AudioClip audioClip) { }

	private void Play() { }

	public void PlayIdle() { }

	public void Show(bool loop, LipSyncDictionary lipSyncDictionary) { }

	private void Stop() { }

	public void StopWithCancellation() { }

}


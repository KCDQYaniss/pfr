namespace EFT.Hideout;

[RequireComponent(typeof(VideoPlayer))]
public sealed class VideoAmbiance : InteractiveAmbianceObject
{
	[CompilerGenerated]
	private struct <PerformInteraction>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VideoAmbiance <>4__this; //Field offset: 0x20
		public ELightStatus status; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class CurrentVideoClip
	{
		public VideoClip VideoClip; //Field offset: 0x10
		public float CurrentTime; //Field offset: 0x18

		public CurrentVideoClip(VideoClip clip) { }

	}

	internal sealed class VideoPlaybackSettings
	{
		public List VideoClips; //Field offset: 0x10
		public bool PlayerEnabled; //Field offset: 0x18

		public VideoPlaybackSettings() { }

		public VideoClip GetRandomClip(VideoClip lastClip) { }

	}

	private VideoPlayer _videoPlayer; //Field offset: 0x88
	private Stopwatch _stopwatch; //Field offset: 0x90
	private Dictionary _currentClips; //Field offset: 0x98

	public VideoAmbiance() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ELightStatus status) { }

	private void Awake() { }

	private void NextClip(VideoPlayer source) { }

	private void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__10))]
	public virtual Task PerformInteraction(ELightStatus status) { }

	private void Play(VideoClip lastClip) { }

}


namespace Game.Tutorial;

public class StartMissionAudioController : IDisposable
{
	[CompilerGenerated]
	private struct <PreloadSounds>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StartMissionAudioController <>4__this; //Field offset: 0x20
		private IEasyAssets <easyAssets>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float LOOPED_BREATH_FADE_OUT_TIME = 1; //Field offset: 0x0
	private const float LOOPED_BREATH_VOLUME = 0.5; //Field offset: 0x0
	private LoopedSpeechPlayer _loopedBreathPlayer; //Field offset: 0x10
	private AudioLibrary _introAnimSounds; //Field offset: 0x18
	private Token _token; //Field offset: 0x20
	private Player _player; //Field offset: 0x28

	public StartMissionAudioController() { }

	public override void Dispose() { }

	public void Init(Player player) { }

	public void PlayAnimationSound(IAnimatorEventParameter param) { }

	public void PlayPlayerBreathSound() { }

	[AsyncStateMachine(typeof(<PreloadSounds>d__10))]
	public Task PreloadSounds() { }

	public void StopPlayerBreathSound() { }

	public void ToggleGunsMixerGroupVolume(bool value) { }

}


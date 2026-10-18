namespace EFT.Hideout;

[RequireComponent(typeof(AudioArray))]
public sealed class AudioAmbiance : InteractiveAmbianceObject
{
	[CompilerGenerated]
	private struct <PerformInteraction>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AudioAmbiance <>4__this; //Field offset: 0x20
		public ELightStatus status; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ContinuingPlaybackSettings : IAudioPlaybackSettings
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public ContinuingPlaybackSettings <>4__this; //Field offset: 0x10
			public AudioArray audioArray; //Field offset: 0x18
			public ELightStatus status; //Field offset: 0x20

			public <>c__DisplayClass5_0() { }

			internal void <Play>g__NextTrack|0() { }

		}

		public List TrackList; //Field offset: 0x10
		private float _currentTime; //Field offset: 0x18
		private Stopwatch _stopwatch; //Field offset: 0x20
		private AudioClip _currentClip; //Field offset: 0x28

		public ContinuingPlaybackSettings() { }

		public override void Pause(AudioArray audioArray) { }

		public override void Play(AudioArray audioArray, ELightStatus status, bool firstStart) { }

	}

	internal sealed class MuteSettings : IAudioPlaybackSettings
	{

		public MuteSettings() { }

		public override void Pause(AudioArray audioArray) { }

		public override void Play(AudioArray audioArray, ELightStatus status, bool firstStart) { }

	}

	internal sealed class PlaybackSettings : IAudioPlaybackSettings
	{
		[SerializeField]
		private AudioSequence _audioSequence; //Field offset: 0x10

		public AudioSequence AudioSequence
		{
			 get { } //Length: 5
		}

		public PlaybackSettings() { }

		public AudioSequence get_AudioSequence() { }

		public override void Pause(AudioArray audioArray) { }

		public override void Play(AudioArray audioArray, ELightStatus status, bool firstStart) { }

	}

	internal sealed class SimpleAudioSettings : IAudioPlaybackSettings
	{
		[SerializeField]
		private AudioClip _audioClip; //Field offset: 0x10
		[SerializeField]
		private bool _loop; //Field offset: 0x18

		public SimpleAudioSettings() { }

		public override void Pause(AudioArray audioArray) { }

		public override void Play(AudioArray audioArray, ELightStatus status, bool firstStart) { }

	}

	private AudioArray _audioArray; //Field offset: 0x88

	public AudioAmbiance() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ELightStatus status) { }

	private void Awake() { }

	internal void OnDestroy() { }

	protected virtual void OnEnable() { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__7))]
	public virtual Task PerformInteraction(ELightStatus status) { }

}


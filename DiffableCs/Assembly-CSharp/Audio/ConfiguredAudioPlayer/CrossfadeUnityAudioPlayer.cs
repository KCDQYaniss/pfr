namespace Audio.ConfiguredAudioPlayer;

public sealed class CrossfadeUnityAudioPlayer : IConfiguredAudioPlayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public int op; //Field offset: 0x10
		public CrossfadeUnityAudioPlayer <>4__this; //Field offset: 0x18
		public Action onStopped; //Field offset: 0x20

		public <>c__DisplayClass18_0() { }

		internal void <Stop>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public CrossfadeUnityAudioPlayer <>4__this; //Field offset: 0x10
		public Action onReleased; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Release>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public int op; //Field offset: 0x10
		public CrossfadeUnityAudioPlayer <>4__this; //Field offset: 0x18
		public AudioClipConfig oldConfig; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal void <StartTransition>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public CrossfadeUnityAudioPlayer <>4__this; //Field offset: 0x10
		public AudioClipConfig config; //Field offset: 0x18
		public AudioSource source; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

		internal void <WatchForClipEnd>b__0() { }

	}

	private readonly Transform _parent; //Field offset: 0x10
	private readonly AudioSource _sourceA; //Field offset: 0x18
	private readonly AudioSource _sourceB; //Field offset: 0x20
	private AudioSource _currentSource; //Field offset: 0x28
	private AudioSource _nextSource; //Field offset: 0x30
	private EPlayerState _state; //Field offset: 0x38
	private AudioClipConfig _prevClipConfig; //Field offset: 0x40
	private AudioClipConfig _pendingConfig; //Field offset: 0x48
	private Sequence _transitionSequence; //Field offset: 0x50
	private Tween _clipEndTween; //Field offset: 0x58
	private bool _isReleasing; //Field offset: 0x60
	private bool _isStopping; //Field offset: 0x61
	private int _operationId; //Field offset: 0x64

	public CrossfadeUnityAudioPlayer(Transform parent, AudioMixerGroup mixerGroup) { }

	private void ConfigureSource(AudioSource source, AudioClipConfig config) { }

	private AudioSource CreateAudioSource(AudioMixerGroup mixerGroup) { }

	private void EndTransition() { }

	private void OnStopComplete(Action onStopped = null) { }

	public override void Play(AudioClipConfig config, bool force = false) { }

	public override void Release(bool allowFadeout = false, Action onReleased = null) { }

	public void SetEnabled(bool enabled) { }

	public void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	private void StartTransition(AudioClipConfig newConfig) { }

	public override void Stop(bool allowFadeout = false, Action onStopped = null) { }

	private void StopSources() { }

	private void WatchForClipEnd(AudioClipConfig config, AudioSource source) { }

}


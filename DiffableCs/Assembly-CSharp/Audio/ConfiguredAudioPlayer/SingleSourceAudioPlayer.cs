namespace Audio.ConfiguredAudioPlayer;

public sealed class SingleSourceAudioPlayer : IConfiguredAudioPlayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public SingleSourceAudioPlayer <>4__this; //Field offset: 0x10
		public Action onStopped; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <Stop>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Action onReleased; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <Release>b__0() { }

	}

	private EPlayerState _state; //Field offset: 0x10
	private BetterSource _source; //Field offset: 0x18
	private AudioClipConfig _prevClipConfig; //Field offset: 0x20
	private readonly BetterAudio _betterAudio; //Field offset: 0x28

	public SingleSourceAudioPlayer(BetterAudio betterAudio, AudioSourceGroupType groupType, AudioMixerGroup mixerGroup) { }

	[CompilerGenerated]
	private void <Play>b__6_0() { }

	private void ConfigureSource(AudioClipConfig config) { }

	private void OnStopComplete(Action onStopped = null) { }

	public override void Play(AudioClipConfig config, bool force = false) { }

	public override void Release(bool allowFadeout = false, Action onReleased = null) { }

	private void ReleaseSource(BetterSource source, bool allowFadeout) { }

	public override void Stop(bool allowFadeout = false, Action onStopped = null) { }

}


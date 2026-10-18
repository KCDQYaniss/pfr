namespace Audio.ConfiguredAudioPlayer;

public sealed class CrossfadeAudioPlayer : IConfiguredAudioPlayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public CrossfadeAudioPlayer <>4__this; //Field offset: 0x10
		public Action onStopped; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <Stop>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Action onReleased; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal void <Release>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <TransitionCoroutine>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CrossfadeAudioPlayer <>4__this; //Field offset: 0x20
		public AudioClipConfig newConfig; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <TransitionCoroutine>d__15(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private EPlayerState _state; //Field offset: 0x10
	private BetterSource _sourceA; //Field offset: 0x18
	private BetterSource _sourceB; //Field offset: 0x20
	private BetterSource _currentSource; //Field offset: 0x28
	private BetterSource _nextSource; //Field offset: 0x30
	private AudioClipConfig _prevClipConfig; //Field offset: 0x38
	private readonly Queue _playQueue; //Field offset: 0x40
	private readonly MonoBehaviour _runner; //Field offset: 0x48
	private readonly BetterAudio _betterAudio; //Field offset: 0x50
	private Coroutine _transitionCoroutine; //Field offset: 0x58

	public CrossfadeAudioPlayer(BetterAudio betterAudio, AudioSourceGroupType groupType, AudioMixerGroup mixerGroup) { }

	private void ConfigureSource(BetterSource source, AudioClipConfig config) { }

	private AudioClipConfig DequeueNextConfig() { }

	private void EndTransition() { }

	private void EnqueueConfig(AudioClipConfig config) { }

	private void OnStopComplete(Action onStopped = null) { }

	public override void Play(AudioClipConfig config, bool force = false) { }

	public override void Release(bool allowFadeout = false, Action onReleased = null) { }

	private void ReleaseSource(BetterSource source, bool allowFadeout) { }

	public override void Stop(bool allowFadeout = false, Action onStopped = null) { }

	private void StopSources() { }

	[IteratorStateMachine(typeof(<TransitionCoroutine>d__15))]
	private IEnumerator TransitionCoroutine(AudioClipConfig newConfig) { }

}


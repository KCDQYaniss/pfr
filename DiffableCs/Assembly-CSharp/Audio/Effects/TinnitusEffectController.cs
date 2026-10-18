namespace Audio.Effects;

public class TinnitusEffectController : IDisposable
{
	[CompilerGenerated]
	private sealed class <TinnitusCoroutine>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TinnitusEffectController <>4__this; //Field offset: 0x20
		public AudioClip clip; //Field offset: 0x28
		private BetterSource <source>5__2; //Field offset: 0x30
		private AudioMixerDataContainer <mixerData>5__3; //Field offset: 0x38
		private AudioMixer <master>5__4; //Field offset: 0x40
		private AudioMixerGroup <outputGroup>5__5; //Field offset: 0x48
		private float <mainVolume>5__6; //Field offset: 0x50
		private float <mult>5__7; //Field offset: 0x54

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
		public <TinnitusCoroutine>d__11(int <>1__state) { }

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

	private readonly float _maxEffectDuration; //Field offset: 0x10
	private readonly float _effectBaseDurationMultiplier; //Field offset: 0x14
	private readonly BetterAudio _betterAudio; //Field offset: 0x18
	private float _tinnitusLn; //Field offset: 0x20
	private float _endTime; //Field offset: 0x24
	private Coroutine _tinnitusCoroutine; //Field offset: 0x28
	private bool _tinnitusPaused; //Field offset: 0x30
	private Action _unpauseTinnitusAction; //Field offset: 0x38

	public TinnitusEffectController(BetterAudio betterAudio, TinnitusEffectConfig effectConfig) { }

	public override void Dispose() { }

	public void StartTinnitusEffect(float time, AudioClip clip = null) { }

	[IteratorStateMachine(typeof(<TinnitusCoroutine>d__11))]
	private IEnumerator TinnitusCoroutine(AudioClip clip) { }

	public void TogglePauseTinnitusEffect(bool pause) { }

}


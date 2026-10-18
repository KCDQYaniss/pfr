namespace Audio.AmbientSubsystem;

public class AudioSourceCrossfader : IAudioCrossfader
{
	[CompilerGenerated]
	private sealed class <CrossfadeCoroutine>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioSourceCrossfader <>4__this; //Field offset: 0x20
		public bool startFromRndTime; //Field offset: 0x28
		public float duration; //Field offset: 0x2C
		public float startVolume; //Field offset: 0x30
		public float endVolume; //Field offset: 0x34
		public float speed; //Field offset: 0x38
		public Action callback; //Field offset: 0x40
		private float <timer>5__2; //Field offset: 0x48

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
		public <CrossfadeCoroutine>d__15(int <>1__state) { }

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

	private readonly AudioSource _sourceA; //Field offset: 0x10
	private readonly AudioSource _sourceB; //Field offset: 0x18
	private Coroutine _crossfadeCoroutine; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsCrossfadeStarted>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private AudioSource <CurrentSource>k__BackingField; //Field offset: 0x30

	public private override AudioSource CurrentSource
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override bool IsCrossfadeStarted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override AudioSource MixSource
	{
		 get { } //Length: 111
	}

	public AudioSourceCrossfader(AudioSource sourceA, AudioSource sourceB) { }

	[IteratorStateMachine(typeof(<CrossfadeCoroutine>d__15))]
	private IEnumerator CrossfadeCoroutine(float duration, float speed, float startVolume, float endVolume, bool startFromRndTime = true, Action callback = null) { }

	[CompilerGenerated]
	public override AudioSource get_CurrentSource() { }

	[CompilerGenerated]
	public override bool get_IsCrossfadeStarted() { }

	public override AudioSource get_MixSource() { }

	[CompilerGenerated]
	private void set_CurrentSource(AudioSource value) { }

	[CompilerGenerated]
	private void set_IsCrossfadeStarted(bool value) { }

	public override void StartCrossfade(float duration = 1, float speed = 1, float startVolume = 1, float endVolume = 0, bool startFromRndTime = true, Action callback = null) { }

	public override void Stop() { }

	private void StopCrossfadeCoroutine() { }

}


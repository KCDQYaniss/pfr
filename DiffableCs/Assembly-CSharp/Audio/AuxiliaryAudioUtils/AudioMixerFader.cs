namespace Audio.AuxiliaryAudioUtils;

public sealed class AudioMixerFader : IAudioMixerFader, IDisposable
{
	[CompilerGenerated]
	private sealed class <FadeValue>d__12 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioMixerFader <>4__this; //Field offset: 0x20
		public string mixerParameter; //Field offset: 0x28
		public float duration; //Field offset: 0x30
		public Func easingFunction; //Field offset: 0x38
		public float targetValue; //Field offset: 0x40
		private float <currentTime>5__2; //Field offset: 0x44
		private float <startVolume>5__3; //Field offset: 0x48

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
		public <FadeValue>d__12(int <>1__state) { }

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

	private readonly Dictionary _fadeCoroutines; //Field offset: 0x10
	private readonly AudioMixer _mixer; //Field offset: 0x18
	private readonly MonoBehaviour _behaviour; //Field offset: 0x20
	private short _workingCoroutines; //Field offset: 0x28

	public override bool IsFading
	{
		 get { } //Length: 9
	}

	public AudioMixerFader(MonoBehaviour behaviour, AudioMixer audioMixer) { }

	public override void Dispose() { }

	[IteratorStateMachine(typeof(<FadeValue>d__12))]
	private IEnumerator FadeValue(string mixerParameter, float targetValue, float duration, Func easingFunction) { }

	public override bool get_IsFading() { }

	private float GetCurrentValue(string mixerParameter) { }

	private void SetValue(string mixerParameter, float volume) { }

	public override void StartFade(string mixerParameter, float targetValue, AnimationCurve fadeCurve, float duration = 0) { }

	public override void StartFade(string mixerParameter, float targetValue, EAudioFadeType fadeType = 0, float duration = 0) { }

	private void StartFadeInternal(string mixerParameter, float targetValue, float duration, Func easingFunction) { }

	private void StopAllCoroutines() { }

	public override void StopFade(string mixerParameter) { }

	public override void StopFade() { }

	private void TryStopFadeCoroutine(ref Coroutine coroutine) { }

}


namespace uLipSync;

[Extension]
public static class AudioSourceExtensions
{
	[CompilerGenerated]
	private sealed class <FadeInCoroutine>d__5 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioSource audioSource; //Field offset: 0x20
		public Action callback; //Field offset: 0x28
		public float fadeTime; //Field offset: 0x30
		public float targetVolume; //Field offset: 0x34
		private float <startTime>5__2; //Field offset: 0x38

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
		public <FadeInCoroutine>d__5(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <FadeInWithDelayCoroutine>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioSource audioSource; //Field offset: 0x20
		public Action callback; //Field offset: 0x28
		public float delay; //Field offset: 0x30
		public float targetVolume; //Field offset: 0x34
		public float fadeTime; //Field offset: 0x38

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
		public <FadeInWithDelayCoroutine>d__6(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <FadeOutCoroutine>d__4 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioSource audioSource; //Field offset: 0x20
		public Action callback; //Field offset: 0x28
		public float fadeTime; //Field offset: 0x30
		private float <startVolume>5__2; //Field offset: 0x34
		private float <startTime>5__3; //Field offset: 0x38

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
		public <FadeOutCoroutine>d__4(int <>1__state) { }

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


	[IteratorStateMachine(typeof(<FadeInCoroutine>d__5))]
	private static IEnumerator FadeInCoroutine(AudioSource audioSource, float targetVolume, float fadeTime, Action callback = null) { }

	[IteratorStateMachine(typeof(<FadeInWithDelayCoroutine>d__6))]
	private static IEnumerator FadeInWithDelayCoroutine(AudioSource audioSource, float targetVolume, float fadeTime, float delay, Action callback = null) { }

	[IteratorStateMachine(typeof(<FadeOutCoroutine>d__4))]
	private static IEnumerator FadeOutCoroutine(AudioSource audioSource, float fadeTime, Action callback = null) { }

	[Extension]
	public static Coroutine PlayDelayedWithFadeIn(AudioSource audioSource, MonoBehaviour runner, float delay, float fadeTime, float targetVolume = 1, Action callback = null) { }

	[Extension]
	public static Coroutine PlayOneShotWithFadeIn(AudioSource audioSource, MonoBehaviour runner, AudioClip clip, float fadeTime, float targetVolume = 1, Action callback = null) { }

	[Extension]
	public static Coroutine PlayWithFadeIn(AudioSource audioSource, MonoBehaviour runner, float fadeTime, float targetVolume = 1, Action callback = null) { }

	[Extension]
	public static Coroutine StopWithFadeOut(AudioSource audioSource, MonoBehaviour runner, float fadeTime, Action callback = null) { }

}


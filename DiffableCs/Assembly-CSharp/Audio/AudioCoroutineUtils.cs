namespace Audio;

public static class AudioCoroutineUtils
{
	[CompilerGenerated]
	private sealed class <WaitForClip>d__0 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioClip clip; //Field offset: 0x20
		public float pitch; //Field offset: 0x28
		public float extraDelay; //Field offset: 0x2C
		public bool realtime; //Field offset: 0x30

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
		public <WaitForClip>d__0(int <>1__state) { }

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


	[IteratorStateMachine(typeof(<WaitForClip>d__0))]
	public static IEnumerator WaitForClip(AudioClip clip, float pitch = 1, float extraDelay = 0, bool realtime = true) { }

}


//Type is in global namespace

[Extension]
public static class MonoBehaviourExtensions
{
	[CompilerGenerated]
	private sealed class <TimerBehaviourCoroutine>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool ignoreTimeScale; //Field offset: 0x20
		public Nullable delay; //Field offset: 0x24
		public Action action; //Field offset: 0x30
		public bool repeatable; //Field offset: 0x38
		private float <start>5__2; //Field offset: 0x3C

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
		public <TimerBehaviourCoroutine>d__7(int <>1__state) { }

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


	[Extension]
	public static bool IsNullOrDestroyed(MonoBehaviour monoBehaviour) { }

	[Extension]
	public static IEnumerator StartBehaviourTimer(MonoBehaviour monoBehaviour, float delay, Action action) { }

	[Extension]
	public static IEnumerator StartBehaviourTimer(MonoBehaviour monoBehaviour, Nullable delay, Action action) { }

	[Extension]
	public static IEnumerator StartBehaviourTimer(MonoBehaviour monoBehaviour, float delay, bool repeatable, Action action) { }

	[Extension]
	public static IEnumerator StartBehaviourTimer(MonoBehaviour monoBehaviour, Nullable delay, bool repeatable, bool ignoreTimeScale, Action action) { }

	[Extension]
	public static void StopBehaviourTimer(MonoBehaviour monoBehaviour, ref IEnumerator timerCoroutine) { }

	[Extension]
	[IteratorStateMachine(typeof(<TimerBehaviourCoroutine>d__7))]
	public static IEnumerator TimerBehaviourCoroutine(MonoBehaviour monoBehaviour, Nullable delay, bool repeatable, bool ignoreTimeScale, Action action) { }

	[Extension]
	public static void TryStopCoroutine(MonoBehaviour monoBehaviour, ref Coroutine coroutine) { }

	[Extension]
	public static void TryStopCoroutine(MonoBehaviour monoBehaviour, ref IEnumerator coroutine) { }

}


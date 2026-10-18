namespace Vuplex.WebView.Internal;

internal class CachingGetter`1
{
	[CompilerGenerated]
	private sealed class <_invalidateCachePeriodically>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public CachingGetter <>4__this; //Field offset: 0x0

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
		public <_invalidateCachePeriodically>d__6(int <>1__state) { }

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

	private Func _getterFunction; //Field offset: 0x0
	private bool _valueNeedsToBeUpdated; //Field offset: 0x0
	private TResult _cachedValue; //Field offset: 0x0
	private WaitForSeconds _waitForSeconds; //Field offset: 0x0

	[IteratorStateMachine(typeof(<_invalidateCachePeriodically>d__6))]
	private IEnumerator _invalidateCachePeriodically() { }

	public CachingGetter`1(Func getterFunction, int cacheInvalidationPeriodSeconds, MonoBehaviour monoBehaviourForCoroutine) { }

	public TResult GetValue() { }

}


namespace Dissonance.Extensions;

[Extension]
public static class IEnumerableExtensions
{
	[CompilerGenerated]
	private sealed class <ConcatUnsafe>d__1`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable enumerable; //Field offset: 0x0
		public IEnumerable <>3__enumerable; //Field offset: 0x0
		private T tail; //Field offset: 0x0
		public T <>3__tail; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 172
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 171
		}

		[DebuggerHidden]
		public <ConcatUnsafe>d__1`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	[Extension]
	[NotNull]
	public static IEnumerable Concat(IEnumerable enumerable, T tail) { }

	[Extension]
	[IteratorStateMachine(typeof(<ConcatUnsafe>d__1`1))]
	[NotNull]
	private static IEnumerable ConcatUnsafe(IEnumerable enumerable, T tail) { }

}


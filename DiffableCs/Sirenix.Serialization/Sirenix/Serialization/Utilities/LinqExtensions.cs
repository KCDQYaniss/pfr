namespace Sirenix.Serialization.Utilities;

[Extension]
internal static class LinqExtensions
{
	[CompilerGenerated]
	private sealed class <Append>d__2`1 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerable append; //Field offset: 0x0
		public IEnumerable <>3__append; //Field offset: 0x0
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
		public <Append>d__2`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

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
	[IteratorStateMachine(typeof(<Append>d__2`1))]
	public static IEnumerable Append(IEnumerable source, IEnumerable append) { }

	[Extension]
	public static IEnumerable ForEach(IEnumerable source, Action action) { }

	[Extension]
	public static IEnumerable ForEach(IEnumerable source, Action action) { }

}


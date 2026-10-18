//Type is in global namespace

[Extension]
public static class CollectionUtils
{
	[CompilerGenerated]
	private sealed class <EmptyIfNull>d__3`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private TElement <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable collection; //Field offset: 0x0
		public IEnumerable <>3__collection; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TElement System.Collections.Generic.IEnumerator<TElement>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 43
		}

		[DebuggerHidden]
		public <EmptyIfNull>d__3`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TElement>.GetEnumerator() { }

		[DebuggerHidden]
		private override TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

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
	[MustUseReturnValue]
	public static TCollection AddElement(TCollection collection, TElement element) { }

	[Extension]
	[MustUseReturnValue]
	public static TDictionary AddElement(TDictionary collection, TKey key, TValue value) { }

	[Extension]
	[MustUseReturnValue]
	public static bool ContainsElement(TCollection collection, TElement element) { }

	[Extension]
	[IteratorStateMachine(typeof(<EmptyIfNull>d__3`1))]
	[NotNull]
	public static IEnumerable EmptyIfNull(IEnumerable collection) { }

}


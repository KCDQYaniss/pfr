namespace System.Linq.Expressions.Interpreter;

[DefaultMember("Item")]
internal class HybridReferenceDictionary`2
{
	[CompilerGenerated]
	private sealed class <GetEnumeratorWorker>d__7 : IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair <>2__current; //Field offset: 0x0
		public HybridReferenceDictionary <>4__this; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
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
		public <GetEnumeratorWorker>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private KeyValuePair[] _keysAndValues; //Field offset: 0x0
	private Dictionary _dict; //Field offset: 0x0

	public TValue Item
	{
		 get { } //Length: 302
		 set { } //Length: 1124
	}

	public HybridReferenceDictionary`2() { }

	public bool ContainsKey(TKey key) { }

	public TValue get_Item(TKey key) { }

	public IEnumerator GetEnumerator() { }

	[IteratorStateMachine(typeof(<GetEnumeratorWorker>d__7))]
	private IEnumerator GetEnumeratorWorker() { }

	public void Remove(TKey key) { }

	public void set_Item(TKey key, TValue value) { }

	public bool TryGetValue(TKey key, out TValue value) { }

}


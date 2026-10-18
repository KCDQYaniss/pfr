namespace EFT;

[DefaultMember("Item")]
public class EmptyDictionary`2 : IReadOnlyDictionary, IEnumerable, IEnumerable, IReadOnlyCollection
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__5 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair <>2__current; //Field offset: 0x0

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
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
		public <GetEnumerator>d__5(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <System-Collections-IEnumerable-GetEnumerator>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0

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
		public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state) { }

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

	public static EmptyDictionary Instance; //Field offset: 0x0
	private readonly TValue _defaultValue; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 3
	}

	public override TValue Item
	{
		 get { } //Length: 143
	}

	public override IEnumerable Keys
	{
		 get { } //Length: 24
	}

	public override IEnumerable Values
	{
		 get { } //Length: 24
	}

	private static EmptyDictionary`2() { }

	private EmptyDictionary`2() { }

	public override bool ContainsKey(TKey key) { }

	public override int get_Count() { }

	public override TValue get_Item(TKey key) { }

	public override IEnumerable get_Keys() { }

	public override IEnumerable get_Values() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__5))]
	public override IEnumerator GetEnumerator() { }

	[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__6))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

}


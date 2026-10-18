namespace Diz.Binding;

public class BindableSortedList`1 : IBindableIndexed, IUpdatableList
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public TValue newItem; //Field offset: 0x0

		public <>c__DisplayClass12_0() { }

		internal bool <UpdateItems>b__0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_1
	{
		public KeyValuePair existingItem; //Field offset: 0x0

		public <>c__DisplayClass12_1() { }

		internal bool <UpdateItems>b__1(TValue x) { }

	}

	[CompilerGenerated]
	private sealed class <get_Items>d__9 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public BindableSortedList <>4__this; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,TValue>>.Current
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
		public <get_Items>d__9(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TValue>>.GetEnumerator() { }

		[DebuggerHidden]
		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,TValue>>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private TValue <>2__current; //Field offset: 0x0
		public BindableSortedList <>4__this; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TValue System.Collections.Generic.IEnumerator<TValue>.Current
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
		public <GetEnumerator>d__15(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override TValue System.Collections.Generic.IEnumerator<TValue>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private Action ItemAdded; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemRemoved; //Field offset: 0x0
	public BindableEvent OnItemsChanged; //Field offset: 0x0
	private readonly SortedList _sortedList; //Field offset: 0x0

	public override event Action ItemAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ItemRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override IEnumerable Items
	{
		[IteratorStateMachine(typeof(<get_Items>d__9))]
		 get { } //Length: 249
	}

	public BindableSortedList`1() { }

	public void Add(TValue value) { }

	[CompilerGenerated]
	public override void add_ItemAdded(Action value) { }

	[CompilerGenerated]
	public override void add_ItemRemoved(Action value) { }

	public bool Contains(TValue item) { }

	public TValue First() { }

	[IteratorStateMachine(typeof(<get_Items>d__9))]
	public override IEnumerable get_Items() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
	public IEnumerator GetEnumerator() { }

	public TValue Last() { }

	public bool Remove(TValue value) { }

	[CompilerGenerated]
	public override void remove_ItemAdded(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemRemoved(Action value) { }

	public override void UpdateItems(ICollection newItems) { }

}


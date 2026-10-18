namespace System.Linq;

[DefaultMember("Item")]
public class Lookup`2 : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__12 : IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private IGrouping <>2__current; //Field offset: 0x0
		public Lookup <>4__this; //Field offset: 0x0
		private Grouping <g>5__2; //Field offset: 0x0

		private override IGrouping System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current
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
		public <GetEnumerator>d__12(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IGrouping System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public class Grouping : IGrouping, IEnumerable, IEnumerable, IList, ICollection
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__7 : IEnumerator, IDisposable, IEnumerator
		{
			private int <>1__state; //Field offset: 0x0
			private TElement <>2__current; //Field offset: 0x0
			public Grouping <>4__this; //Field offset: 0x0
			private int <i>5__2; //Field offset: 0x0

			private override TElement System.Collections.Generic.IEnumerator<TElement>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 4
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 41
			}

			[DebuggerHidden]
			public <GetEnumerator>d__7(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		internal TKey key; //Field offset: 0x0
		internal int hashCode; //Field offset: 0x0
		internal TElement[] elements; //Field offset: 0x0
		internal int count; //Field offset: 0x0
		internal Grouping hashNext; //Field offset: 0x0
		internal Grouping next; //Field offset: 0x0

		public override TKey Key
		{
			 get { } //Length: 164
		}

		private override int System.Collections.Generic.ICollection<TElement>.Count
		{
			private get { } //Length: 4
		}

		private override bool System.Collections.Generic.ICollection<TElement>.IsReadOnly
		{
			private get { } //Length: 3
		}

		private override TElement System.Collections.Generic.IList<TElement>.Item
		{
			private get { } //Length: 90
			private set { } //Length: 27
		}

		public Grouping() { }

		internal void Add(TElement element) { }

		public override TKey get_Key() { }

		[IteratorStateMachine(typeof(<GetEnumerator>d__7))]
		public override IEnumerator GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }

		private override void System.Collections.Generic.ICollection<TElement>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }

		private override void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }

		private override int System.Collections.Generic.ICollection<TElement>.get_Count() { }

		private override bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }

		private override TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }

		private override int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }

		private override void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }

		private override void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }

		private override void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private IEqualityComparer comparer; //Field offset: 0x0
	private Grouping[] groupings; //Field offset: 0x0
	private Grouping lastGrouping; //Field offset: 0x0
	private int count; //Field offset: 0x0

	private Lookup`2(IEqualityComparer comparer) { }

	internal static Lookup Create(IEnumerable source, Func keySelector, Func elementSelector, IEqualityComparer comparer) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__12))]
	public override IEnumerator GetEnumerator() { }

	internal Grouping GetGrouping(TKey key, bool create) { }

	internal int InternalGetHashCode(TKey key) { }

	private void Resize() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


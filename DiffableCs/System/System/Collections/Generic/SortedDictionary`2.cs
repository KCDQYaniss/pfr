namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
public class SortedDictionary`2 : IDictionary, ICollection, IEnumerable, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary, IReadOnlyCollection
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public bool found; //Field offset: 0x0
		public TValue value; //Field offset: 0x0

		public <>c__DisplayClass34_0() { }

		internal bool <ContainsValue>b__0(Node node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_1
	{
		public EqualityComparer valueComparer; //Field offset: 0x0
		public <>c__DisplayClass34_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass34_1() { }

		internal bool <ContainsValue>b__1(Node node) { }

	}

	internal struct Enumerator : IEnumerator, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private Enumerator _treeEnum; //Field offset: 0x0
		private int _getEnumeratorRetType; //Field offset: 0x0

		public override KeyValuePair Current
		{
			 get { } //Length: 192
		}

		internal bool NotStartedOrEnded
		{
			internal get { } //Length: 119
		}

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			private get { } //Length: 372
		}

		private override object System.Collections.IDictionaryEnumerator.Key
		{
			private get { } //Length: 255
		}

		private override object System.Collections.IDictionaryEnumerator.Value
		{
			private get { } //Length: 199
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 723
		}

		internal Enumerator(SortedDictionary dictionary, int getEnumeratorRetType) { }

		public override void Dispose() { }

		public override KeyValuePair get_Current() { }

		internal bool get_NotStartedOrEnded() { }

		public override bool MoveNext() { }

		internal void Reset() { }

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	internal sealed class KeyCollection : ICollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public TKey[] array; //Field offset: 0x0
			public int index; //Field offset: 0x0

			public <>c__DisplayClass5_0() { }

			internal bool <CopyTo>b__0(Node node) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public int index; //Field offset: 0x0
			public object[] objects; //Field offset: 0x0

			public <>c__DisplayClass6_0() { }

			internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

		}

		internal struct Enumerator : IEnumerator, IDisposable, IEnumerator
		{
			private Enumerator _dictEnum; //Field offset: 0x0

			public override TKey Current
			{
				 get { } //Length: 96
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 219
			}

			internal Enumerator(SortedDictionary dictionary) { }

			public override void Dispose() { }

			public override TKey get_Current() { }

			public override bool MoveNext() { }

			private override object System.Collections.IEnumerator.get_Current() { }

			private override void System.Collections.IEnumerator.Reset() { }

		}

		private SortedDictionary _dictionary; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 61
		}

		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			private get { } //Length: 3
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 78
		}

		public KeyCollection(SortedDictionary dictionary) { }

		public override void CopyTo(TKey[] array, int index) { }

		public override int get_Count() { }

		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		private override IEnumerator System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	public sealed class KeyValuePairComparer : Comparer
	{
		internal IComparer keyComparer; //Field offset: 0x0

		public KeyValuePairComparer(IComparer keyComparer) { }

		public virtual int Compare(KeyValuePair x, KeyValuePair y) { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	internal sealed class ValueCollection : ICollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public TValue[] array; //Field offset: 0x0
			public int index; //Field offset: 0x0

			public <>c__DisplayClass5_0() { }

			internal bool <CopyTo>b__0(Node node) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public int index; //Field offset: 0x0
			public object[] objects; //Field offset: 0x0

			public <>c__DisplayClass6_0() { }

			internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

		}

		internal struct Enumerator : IEnumerator, IDisposable, IEnumerator
		{
			private Enumerator _dictEnum; //Field offset: 0x0

			public override TValue Current
			{
				 get { } //Length: 95
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 170
			}

			internal Enumerator(SortedDictionary dictionary) { }

			public override void Dispose() { }

			public override TValue get_Current() { }

			public override bool MoveNext() { }

			private override object System.Collections.IEnumerator.get_Current() { }

			private override void System.Collections.IEnumerator.Reset() { }

		}

		private SortedDictionary _dictionary; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 61
		}

		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			private get { } //Length: 3
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 78
		}

		public ValueCollection(SortedDictionary dictionary) { }

		public override void CopyTo(TValue[] array, int index) { }

		public override int get_Count() { }

		public Enumerator GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		private override IEnumerator System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private KeyCollection _keys; //Field offset: 0x0
	private ValueCollection _values; //Field offset: 0x0
	private TreeSet _set; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 52
	}

	public override TValue Item
	{
		 get { } //Length: 298
		 set { } //Length: 572
	}

	public KeyCollection Keys
	{
		 get { } //Length: 262
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override ICollection System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 23
	}

	private override ICollection System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 23
	}

	private override IEnumerable System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 23
	}

	private override IEnumerable System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 23
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 78
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 315
		private set { } //Length: 658
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 23
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 23
	}

	public ValueCollection Values
	{
		 get { } //Length: 262
	}

	public SortedDictionary`2() { }

	public SortedDictionary`2(IComparer comparer) { }

	public override void Add(TKey key, TValue value) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	public bool ContainsValue(TValue value) { }

	public override void CopyTo(KeyValuePair[] array, int index) { }

	public override int get_Count() { }

	public override TValue get_Item(TKey key) { }

	public KeyCollection get_Keys() { }

	public ValueCollection get_Values() { }

	public Enumerator GetEnumerator() { }

	private static bool IsCompatibleKey(object key) { }

	public override bool Remove(TKey key) { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair keyValuePair) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair keyValuePair) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair keyValuePair) { }

	private override ICollection System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	private override ICollection System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	private override IEnumerator System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerable System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	private override IEnumerable System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.Remove(object key) { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

}


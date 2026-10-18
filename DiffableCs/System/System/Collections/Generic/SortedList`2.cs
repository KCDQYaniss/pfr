namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
public class SortedList`2 : IDictionary, ICollection, IEnumerable, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary, IReadOnlyCollection
{
	private struct Enumerator : IEnumerator, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private SortedList _sortedList; //Field offset: 0x0
		private TKey _key; //Field offset: 0x0
		private TValue _value; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private int _getEnumeratorRetType; //Field offset: 0x0

		public override KeyValuePair Current
		{
			 get { } //Length: 148
		}

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			private get { } //Length: 242
		}

		private override object System.Collections.IDictionaryEnumerator.Key
		{
			private get { } //Length: 211
		}

		private override object System.Collections.IDictionaryEnumerator.Value
		{
			private get { } //Length: 161
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 481
		}

		internal Enumerator(SortedList sortedList, int getEnumeratorRetType) { }

		public override void Dispose() { }

		public override KeyValuePair get_Current() { }

		public override bool MoveNext() { }

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	[DefaultMember("Item")]
	private sealed class KeyList : IList, ICollection, IEnumerable, IEnumerable, ICollection
	{
		private SortedList _dict; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 26
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override TKey Item
		{
			 get { } //Length: 229
			 set { } //Length: 73
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 78
		}

		internal KeyList(SortedList dictionary) { }

		public override void Add(TKey key) { }

		public override void Clear() { }

		public override bool Contains(TKey key) { }

		public override void CopyTo(TKey[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override TKey get_Item(int index) { }

		public override IEnumerator GetEnumerator() { }

		public override int IndexOf(TKey key) { }

		public override void Insert(int index, TKey value) { }

		public override bool Remove(TKey key) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, TKey value) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private sealed class SortedListKeyEnumerator : IEnumerator, IDisposable, IEnumerator
	{
		private SortedList _sortedList; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private TKey _currentKey; //Field offset: 0x0

		public override TKey Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 148
		}

		internal SortedListKeyEnumerator(SortedList sortedList) { }

		public override void Dispose() { }

		public override TKey get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private sealed class SortedListValueEnumerator : IEnumerator, IDisposable, IEnumerator
	{
		private SortedList _sortedList; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private TValue _currentValue; //Field offset: 0x0

		public override TValue Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 119
		}

		internal SortedListValueEnumerator(SortedList sortedList) { }

		public override void Dispose() { }

		public override TValue get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	[DefaultMember("Item")]
	private sealed class ValueList : IList, ICollection, IEnumerable, IEnumerable, ICollection
	{
		private SortedList _dict; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 26
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override TValue Item
		{
			 get { } //Length: 229
			 set { } //Length: 73
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 78
		}

		internal ValueList(SortedList dictionary) { }

		public override void Add(TValue key) { }

		public override void Clear() { }

		public override bool Contains(TValue value) { }

		public override void CopyTo(TValue[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override TValue get_Item(int index) { }

		public override IEnumerator GetEnumerator() { }

		public override int IndexOf(TValue value) { }

		public override void Insert(int index, TValue value) { }

		public override bool Remove(TValue value) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, TValue value) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private const int DefaultCapacity = 4; //Field offset: 0x0
	private const int MaxArrayLength = 2146435071; //Field offset: 0x0
	private TKey[] keys; //Field offset: 0x0
	private TValue[] values; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int version; //Field offset: 0x0
	private IComparer comparer; //Field offset: 0x0
	private KeyList keyList; //Field offset: 0x0
	private ValueList valueList; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public int Capacity
	{
		 set { } //Length: 452
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public override TValue Item
	{
		 get { } //Length: 261
		 set { } //Length: 174
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
		private get { } //Length: 170
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
		private get { } //Length: 364
		private set { } //Length: 726
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 23
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 23
	}

	public IList Values
	{
		 get { } //Length: 23
	}

	public SortedList`2() { }

	public SortedList`2(int capacity) { }

	public override void Add(TKey key, TValue value) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	public bool ContainsValue(TValue value) { }

	private void EnsureCapacity(int min) { }

	public override int get_Count() { }

	public override TValue get_Item(TKey key) { }

	public IList get_Values() { }

	private TValue GetByIndex(int index) { }

	public IEnumerator GetEnumerator() { }

	private TKey GetKey(int index) { }

	private KeyList GetKeyListHelper() { }

	private ValueList GetValueListHelper() { }

	public int IndexOfKey(TKey key) { }

	public int IndexOfValue(TValue value) { }

	private void Insert(int index, TKey key, TValue value) { }

	private static bool IsCompatibleKey(object key) { }

	public override bool Remove(TKey key) { }

	public void RemoveAt(int index) { }

	public void set_Capacity(int value) { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair keyValuePair) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair keyValuePair) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair[] array, int arrayIndex) { }

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


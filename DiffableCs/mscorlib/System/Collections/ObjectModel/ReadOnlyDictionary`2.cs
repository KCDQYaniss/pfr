namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DictionaryDebugView`2))]
[DefaultMember("Item")]
public class ReadOnlyDictionary`2 : IDictionary, ICollection, IEnumerable, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary, IReadOnlyCollection
{
	private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private readonly IDictionary _dictionary; //Field offset: 0x0
		private IEnumerator _enumerator; //Field offset: 0x0

		public override object Current
		{
			 get { } //Length: 172
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 846
		}

		public override object Key
		{
			 get { } //Length: 476
		}

		public override object Value
		{
			 get { } //Length: 476
		}

		public DictionaryEnumerator(IDictionary dictionary) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
	internal sealed class KeyCollection : ICollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection
	{
		private readonly ICollection _collection; //Field offset: 0x0
		private object _syncRoot; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 69
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
			private get { } //Length: 256
		}

		internal KeyCollection(ICollection collection) { }

		internal KeyCollection() { }

		public override void CopyTo(TKey[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override IEnumerator GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
	internal sealed class ValueCollection : ICollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection
	{
		private readonly ICollection _collection; //Field offset: 0x0
		private object _syncRoot; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 69
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
			private get { } //Length: 256
		}

		internal ValueCollection(ICollection collection) { }

		internal ValueCollection() { }

		public override void CopyTo(TValue[] array, int arrayIndex) { }

		public override int get_Count() { }

		public override IEnumerator GetEnumerator() { }

		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private readonly IDictionary m_dictionary; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0
	private KeyCollection _keys; //Field offset: 0x0
	private ValueCollection _values; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 73
	}

	public override TValue Item
	{
		 get { } //Length: 317
	}

	public KeyCollection Keys
	{
		 get { } //Length: 282
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item
	{
		private get { } //Length: 317
		private set { } //Length: 73
	}

	private override ICollection System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 24
	}

	private override ICollection System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 24
	}

	private override IEnumerable System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 24
	}

	private override IEnumerable System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 24
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 256
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
		private get { } //Length: 572
		private set { } //Length: 73
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 24
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 24
	}

	public ValueCollection Values
	{
		 get { } //Length: 282
	}

	public override bool ContainsKey(TKey key) { }

	public override int get_Count() { }

	public override TValue get_Item(TKey key) { }

	public KeyCollection get_Keys() { }

	public ValueCollection get_Values() { }

	public override IEnumerator GetEnumerator() { }

	private static bool IsCompatibleKey(object key) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair item) { }

	private override void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	private override TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	private override ICollection System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	private override ICollection System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	private override bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	private override void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	private override IEnumerable System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	private override IEnumerable System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override void System.Collections.IDictionary.Clear() { }

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


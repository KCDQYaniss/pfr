namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
public class ConcurrentDictionary`2 : IDictionary, ICollection, IEnumerable, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary, IReadOnlyCollection
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__35 : IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair <>2__current; //Field offset: 0x0
		public ConcurrentDictionary <>4__this; //Field offset: 0x0
		private Node[] <buckets>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0
		private Node <current>5__4; //Field offset: 0x0

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 21
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 54
		}

		[DebuggerHidden]
		public <GetEnumerator>d__35(int <>1__state) { }

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

	private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private IEnumerator _enumerator; //Field offset: 0x0

		public override object Current
		{
			 get { } //Length: 508
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 260
		}

		public override object Key
		{
			 get { } //Length: 130
		}

		public override object Value
		{
			 get { } //Length: 90
		}

		internal DictionaryEnumerator(ConcurrentDictionary dictionary) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private sealed class Node
	{
		internal readonly TKey _key; //Field offset: 0x0
		internal TValue _value; //Field offset: 0x0
		internal Node _next; //Field offset: 0x0
		internal readonly int _hashcode; //Field offset: 0x0

		internal Node(TKey key, TValue value, int hashcode, Node next) { }

	}

	private sealed class Tables
	{
		internal readonly Node[] _buckets; //Field offset: 0x0
		internal readonly object[] _locks; //Field offset: 0x0
		internal int[] _countPerLock; //Field offset: 0x0

		internal Tables(Node[] buckets, object[] locks, int[] countPerLock) { }

	}

	private static readonly bool s_isValueWriteAtomic; //Field offset: 0x0
	private Tables _tables; //Field offset: 0x0
	private IEqualityComparer _comparer; //Field offset: 0x0
	private readonly bool _growLockArray; //Field offset: 0x0
	private int _budget; //Field offset: 0x0
	private KeyValuePair[] _serializationArray; //Field offset: 0x0
	private int _serializationConcurrencyLevel; //Field offset: 0x0
	private int _serializationCapacity; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 164
	}

	private static int DefaultConcurrencyLevel
	{
		private get { } //Length: 69
	}

	public override TValue Item
	{
		 get { } //Length: 192
		 set { } //Length: 328
	}

	public override ICollection Keys
	{
		 get { } //Length: 23
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		private get { } //Length: 3
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
		private get { } //Length: 73
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
		private get { } //Length: 277
		private set { } //Length: 822
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 23
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 23
	}

	public override ICollection Values
	{
		 get { } //Length: 23
	}

	private static ConcurrentDictionary`2() { }

	public ConcurrentDictionary`2() { }

	public ConcurrentDictionary`2(IEqualityComparer comparer) { }

	public ConcurrentDictionary`2(int concurrencyLevel, int capacity, IEqualityComparer comparer) { }

	internal ConcurrentDictionary`2(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer comparer) { }

	private void AcquireAllLocks(ref int locksAcquired) { }

	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }

	public override void Clear() { }

	public override bool ContainsKey(TKey key) { }

	private void CopyToEntries(DictionaryEntry[] array, int index) { }

	private void CopyToObjects(object[] array, int index) { }

	private void CopyToPairs(KeyValuePair[] array, int index) { }

	public override int get_Count() { }

	private static int get_DefaultConcurrencyLevel() { }

	public override TValue get_Item(TKey key) { }

	public override ICollection get_Keys() { }

	public override ICollection get_Values() { }

	private static int GetBucket(int hashcode, int bucketCount) { }

	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }

	private int GetCountInternal() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__35))]
	public override IEnumerator GetEnumerator() { }

	private ReadOnlyCollection GetKeys() { }

	public TValue GetOrAdd(TKey key, Func valueFactory) { }

	public TValue GetOrAdd(TKey key, TValue value) { }

	public TValue GetOrAdd(TKey key, Func valueFactory, TArg factoryArgument) { }

	private ReadOnlyCollection GetValues() { }

	private void GrowTable(Tables tables) { }

	private void InitializeFromCollection(IEnumerable collection) { }

	private static bool IsValueWriteAtomic() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	[OnSerialized]
	private void OnSerialized(StreamingContext context) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext context) { }

	private void ReleaseLocks(int fromInclusive, int toExclusive) { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair keyValuePair) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair keyValuePair) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair[] array, int index) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair keyValuePair) { }

	private override void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	private override bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

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

	private static void ThrowKeyNotFoundException(object key) { }

	private static void ThrowKeyNullException() { }

	public KeyValuePair[] ToArray() { }

	public bool TryAdd(TKey key, TValue value) { }

	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }

	public override bool TryGetValue(TKey key, out TValue value) { }

	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }

	public bool TryRemove(TKey key, out TValue value) { }

	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }

}


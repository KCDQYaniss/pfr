namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
public class HashSet`1 : ICollection, IEnumerable, IEnumerable, ISet, IReadOnlyCollection, ISerializable, IDeserializationCallback
{
	internal struct Enumerator : IEnumerator, IDisposable, IEnumerator
	{
		private HashSet _set; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private T _current; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 190
		}

		internal Enumerator(HashSet set) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	public struct Slot
	{
		internal int hashCode; //Field offset: 0x0
		internal int next; //Field offset: 0x0
		internal T value; //Field offset: 0x0

	}

	private const int Lower31BitMask = 2147483647; //Field offset: 0x0
	private const int StackAllocThreshold = 100; //Field offset: 0x0
	private const int ShrinkThreshold = 3; //Field offset: 0x0
	private const string CapacityName = "Capacity"; //Field offset: 0x0
	private const string ElementsName = "Elements"; //Field offset: 0x0
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	private const string VersionName = "Version"; //Field offset: 0x0
	private int[] _buckets; //Field offset: 0x0
	private Slot[] _slots; //Field offset: 0x0
	private int _count; //Field offset: 0x0
	private int _lastIndex; //Field offset: 0x0
	private int _freeList; //Field offset: 0x0
	private IEqualityComparer _comparer; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private SerializationInfo _siInfo; //Field offset: 0x0

	public IEqualityComparer Comparer
	{
		 get { } //Length: 76
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	public HashSet`1() { }

	public HashSet`1(IEqualityComparer comparer) { }

	public HashSet`1(int capacity) { }

	public HashSet`1(IEnumerable collection) { }

	public HashSet`1(IEnumerable collection, IEqualityComparer comparer) { }

	protected HashSet`1(SerializationInfo info, StreamingContext context) { }

	public HashSet`1(int capacity, IEqualityComparer comparer) { }

	public override bool Add(T item) { }

	private bool AddIfNotPresent(T value) { }

	private void AddValue(int index, int hashCode, T value) { }

	private static bool AreEqualityComparersEqual(HashSet set1, HashSet set2) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	private bool ContainsAllElements(IEnumerable other) { }

	private void CopyFrom(HashSet source) { }

	public void CopyTo(T[] array, int arrayIndex, int count) { }

	public void CopyTo(T[] array) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public override void ExceptWith(IEnumerable other) { }

	public IEqualityComparer get_Comparer() { }

	public override int get_Count() { }

	public Enumerator GetEnumerator() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void IncreaseCapacity() { }

	private int Initialize(int capacity) { }

	private int InternalGetHashCode(T item) { }

	public override bool IsSupersetOf(IEnumerable other) { }

	public override void OnDeserialization(object sender) { }

	public override bool Remove(T item) { }

	public int RemoveWhere(Predicate match) { }

	private void SetCapacity(int newSize) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void TrimExcess() { }

	public override void UnionWith(IEnumerable other) { }

}


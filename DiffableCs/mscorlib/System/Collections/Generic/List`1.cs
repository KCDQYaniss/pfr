namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
public class List`1 : IList, ICollection, IEnumerable, IEnumerable, IList, ICollection, IReadOnlyList, IReadOnlyCollection
{
	internal struct Enumerator : IEnumerator, IDisposable, IEnumerator
	{
		private List _list; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private T _current; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 133
		}

		internal Enumerator(List list) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private bool MoveNextRare() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private const int DefaultCapacity = 4; //Field offset: 0x0
	private static readonly T[] s_emptyArray; //Field offset: 0x0
	private T[] _items; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 26
		 set { } //Length: 278
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public override T Item
	{
		 get { } //Length: 69
		 set { } //Length: 157
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 170
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 91
		private set { } //Length: 359
	}

	private static List`1() { }

	public List`1(IEnumerable collection) { }

	public List`1() { }

	public List`1(int capacity) { }

	public override void Add(T item) { }

	private void AddEnumerable(IEnumerable enumerable) { }

	public void AddRange(IEnumerable collection) { }

	private void AddWithResize(T item) { }

	public ReadOnlyCollection AsReadOnly() { }

	public int BinarySearch(T item, IComparer comparer) { }

	public int BinarySearch(T item) { }

	public int BinarySearch(int index, int count, T item, IComparer comparer) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public List ConvertAll(Converter converter) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public void CopyTo(T[] array) { }

	private void EnsureCapacity(int min) { }

	public bool Exists(Predicate match) { }

	public T Find(Predicate match) { }

	public List FindAll(Predicate match) { }

	public int FindIndex(int startIndex, int count, Predicate match) { }

	public int FindIndex(Predicate match) { }

	public void ForEach(Action action) { }

	public int get_Capacity() { }

	public override int get_Count() { }

	public override T get_Item(int index) { }

	public Enumerator GetEnumerator() { }

	public List GetRange(int index, int count) { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	public void InsertRange(int index, IEnumerable collection) { }

	private static bool IsCompatibleObject(object value) { }

	public override bool Remove(T item) { }

	public int RemoveAll(Predicate match) { }

	public override void RemoveAt(int index) { }

	public void RemoveRange(int index, int count) { }

	public void Reverse() { }

	public void Reverse(int index, int count) { }

	public void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	public void Sort(Comparison comparison) { }

	public void Sort() { }

	public void Sort(IComparer comparer) { }

	public void Sort(int index, int count, IComparer comparer) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object item) { }

	private override bool System.Collections.IList.Contains(object item) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object item) { }

	private override void System.Collections.IList.Insert(int index, object item) { }

	private override void System.Collections.IList.Remove(object item) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	public T[] ToArray() { }

	public void TrimExcess() { }

}


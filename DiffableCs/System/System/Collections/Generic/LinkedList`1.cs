namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
public class LinkedList`1 : ICollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection, ISerializable, IDeserializationCallback
{
	internal struct Enumerator : IEnumerator, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private LinkedList _list; //Field offset: 0x0
		private LinkedListNode _node; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private T _current; //Field offset: 0x0
		private int _index; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 212
		}

		internal Enumerator(LinkedList list) { }

		private Enumerator(SerializationInfo info, StreamingContext context) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private const string VersionName = "Version"; //Field offset: 0x0
	private const string CountName = "Count"; //Field offset: 0x0
	private const string ValuesName = "Data"; //Field offset: 0x0
	internal LinkedListNode head; //Field offset: 0x0
	internal int count; //Field offset: 0x0
	internal int version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0
	private SerializationInfo _siInfo; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 4
	}

	public LinkedListNode First
	{
		 get { } //Length: 5
	}

	public LinkedListNode Last
	{
		 get { } //Length: 19
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

	public LinkedList`1() { }

	public LinkedList`1(IEnumerable collection) { }

	protected LinkedList`1(SerializationInfo info, StreamingContext context) { }

	public LinkedListNode AddAfter(LinkedListNode node, T value) { }

	public LinkedListNode AddBefore(LinkedListNode node, T value) { }

	public LinkedListNode AddFirst(T value) { }

	public void AddLast(LinkedListNode node) { }

	public LinkedListNode AddLast(T value) { }

	public override void Clear() { }

	public override bool Contains(T value) { }

	public override void CopyTo(T[] array, int index) { }

	public LinkedListNode Find(T value) { }

	public override int get_Count() { }

	public LinkedListNode get_First() { }

	public LinkedListNode get_Last() { }

	public Enumerator GetEnumerator() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void InternalInsertNodeBefore(LinkedListNode node, LinkedListNode newNode) { }

	private void InternalInsertNodeToEmptyList(LinkedListNode newNode) { }

	internal void InternalRemoveNode(LinkedListNode node) { }

	public override void OnDeserialization(object sender) { }

	public override bool Remove(T value) { }

	public void Remove(LinkedListNode node) { }

	public void RemoveFirst() { }

	public void RemoveLast() { }

	private override void System.Collections.Generic.ICollection<T>.Add(T value) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	internal void ValidateNewNode(LinkedListNode node) { }

	internal void ValidateNode(LinkedListNode node) { }

}


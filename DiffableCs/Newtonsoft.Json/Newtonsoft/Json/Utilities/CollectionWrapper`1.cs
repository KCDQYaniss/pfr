namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class CollectionWrapper`1 : ICollection, IEnumerable, IEnumerable, IWrappedCollection, IList, ICollection
{
	[Nullable(2)]
	private readonly IList _list; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private readonly ICollection _genericCollection; //Field offset: 0x0
	[Nullable(2)]
	private object _syncRoot; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 160
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 163
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
		private get { } //Length: 163
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 170
		private set { } //Length: 567
	}

	public override object UnderlyingCollection
	{
		 get { } //Length: 14
	}

	public CollectionWrapper`1(IList list) { }

	public CollectionWrapper`1(ICollection list) { }

	public override void Add(T item) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override object get_UnderlyingCollection() { }

	public override IEnumerator GetEnumerator() { }

	private static bool IsCompatibleObject(object value) { }

	public override bool Remove(T item) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	private static void VerifyValueType(object value) { }

}


namespace Sirenix.Serialization.Utilities;

[DefaultMember("Item")]
public sealed class ImmutableList`1 : IImmutableList, IImmutableList, IList, ICollection, IEnumerable, IList, ICollection, IEnumerable
{
	[SerializeField]
	private IList innerList; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 70
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override T Item
	{
		 get { } //Length: 189
	}

	private override T System.Collections.Generic.IList<T>.Item
	{
		private get { } //Length: 189
		private set { } //Length: 73
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 3
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
		private get { } //Length: 198
		private set { } //Length: 73
	}

	public ImmutableList`1(IList innerList) { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override T get_Item(int index) { }

	public override IEnumerator GetEnumerator() { }

	public override int IndexOf(T item) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private override void System.Collections.Generic.ICollection<T>.Clear() { }

	private override bool System.Collections.Generic.ICollection<T>.Remove(T item) { }

	private override T System.Collections.Generic.IList<T>.get_Item(int index) { }

	private override void System.Collections.Generic.IList<T>.Insert(int index, T item) { }

	private override void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}


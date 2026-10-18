namespace UnityEngine.UI.Collections;

[DefaultMember("Item")]
internal class IndexedSet`1 : IList, ICollection, IEnumerable, IEnumerable
{
	private readonly List m_List; //Field offset: 0x0
	private Dictionary m_Dictionary; //Field offset: 0x0
	private int m_EnabledObjectCount; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 26
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override T Item
	{
		 get { } //Length: 129
		 set { } //Length: 268
	}

	public IndexedSet`1() { }

	public override void Add(T item) { }

	public void Add(T item, bool isActive) { }

	public bool AddUnique(T item, bool isActive = true) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	public bool DisableItem(T item) { }

	public bool EnableItem(T item) { }

	public int get_Capacity() { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override T get_Item(int index) { }

	public override IEnumerator GetEnumerator() { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	public override bool Remove(T item) { }

	public void RemoveAll(Predicate match) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, T value) { }

	public void Sort(Comparison sortLayoutFunction) { }

	private void Swap(int index1, int index2) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


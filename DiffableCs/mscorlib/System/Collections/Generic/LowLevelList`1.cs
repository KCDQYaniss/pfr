namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
internal class LowLevelList`1
{
	private const int _defaultCapacity = 4; //Field offset: 0x0
	private static readonly T[] s_emptyArray; //Field offset: 0x0
	protected T[] _items; //Field offset: 0x0
	protected int _size; //Field offset: 0x0
	protected int _version; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 26
		 set { } //Length: 314
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public override T Item
	{
		 get { } //Length: 107
		 set { } //Length: 102
	}

	private static LowLevelList`1() { }

	public LowLevelList`1() { }

	public LowLevelList`1(int capacity) { }

	public override void Add(T item) { }

	public void AddRange(IEnumerable collection) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	private void EnsureCapacity(int min) { }

	public int get_Capacity() { }

	public override int get_Count() { }

	public override T get_Item(int index) { }

	public override int IndexOf(T item) { }

	public override void Insert(int index, T item) { }

	public void InsertRange(int index, IEnumerable collection) { }

	public override bool Remove(T item) { }

	public int RemoveAll(Predicate match) { }

	public override void RemoveAt(int index) { }

	public void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	public T[] ToArray() { }

}


namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
[DefaultMember("Item")]
public abstract class KeyedCollection`2 : Collection
{
	private readonly IEqualityComparer comparer; //Field offset: 0x0
	private Dictionary dict; //Field offset: 0x0
	private int keyCount; //Field offset: 0x0
	private readonly int threshold; //Field offset: 0x0

	protected IDictionary Dictionary
	{
		 get { } //Length: 5
	}

	public TItem Item
	{
		 get { } //Length: 181
	}

	private List Items
	{
		private get { } //Length: 134
	}

	protected KeyedCollection`2() { }

	protected KeyedCollection`2(IEqualityComparer comparer) { }

	protected KeyedCollection`2(IEqualityComparer comparer, int dictionaryCreationThreshold) { }

	private void AddKey(TKey key, TItem item) { }

	protected virtual void ClearItems() { }

	public bool Contains(TKey key) { }

	private void CreateDictionary() { }

	protected IDictionary get_Dictionary() { }

	public TItem get_Item(TKey key) { }

	private List get_Items() { }

	protected abstract TKey GetKeyForItem(TItem item) { }

	protected virtual void InsertItem(int index, TItem item) { }

	protected virtual void RemoveItem(int index) { }

	private void RemoveKey(TKey key) { }

	protected virtual void SetItem(int index, TItem item) { }

	public bool TryGetValue(TKey key, out TItem item) { }

}


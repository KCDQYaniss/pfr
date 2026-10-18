namespace EFT.HandBook;

[DefaultMember("Item")]
public sealed class HandbookNodes : BindableDictionary
{
	private readonly Dictionary _cachedNodes; //Field offset: 0x50

	public ValueCollection AllNodes
	{
		 get { } //Length: 73
	}

	[CanBeNull]
	public virtual HandbookNode Item
	{
		 get { } //Length: 108
		 set { } //Length: 386
	}

	public HandbookNodes(IDictionary nodes) { }

	public HandbookNodes(HandbookNodes nodes) { }

	public virtual void Add(string key, HandbookNode value) { }

	public virtual void AddRange(IDictionary dict) { }

	public void AddVirtual(string key, HandbookNode value) { }

	private void CacheNode(HandbookNode node) { }

	public virtual void Clear() { }

	public ValueCollection get_AllNodes() { }

	public virtual HandbookNode get_Item(string index) { }

	private static int GetNodeCount(HandbookNode node) { }

	public virtual bool Remove(string existingItem) { }

	public void RemoveVirtual(string existingItem) { }

	public virtual void set_Item(string index, HandbookNode value) { }

}


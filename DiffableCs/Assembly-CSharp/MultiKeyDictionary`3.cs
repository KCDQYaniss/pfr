//Type is in global namespace

[DefaultMember("Item")]
public class MultiKeyDictionary`3
{
	private readonly Dictionary _baseDictionary; //Field offset: 0x0
	private readonly Dictionary _primaryToSubkeyMapping; //Field offset: 0x0
	private readonly Dictionary _subDictionary; //Field offset: 0x0
	private readonly ReaderWriterLockSlim readerWriterLock; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 215
	}

	public V Item
	{
		 get { } //Length: 815
	}

	public V Item
	{
		 get { } //Length: 828
	}

	public List Values
	{
		 get { } //Length: 251
	}

	public MultiKeyDictionary`3() { }

	public void Add(K primaryKey, L subKey, V val) { }

	public void Add(K primaryKey, V val) { }

	public void Associate(L subKey, K primaryKey) { }

	public void Clear() { }

	public K[] ClonePrimaryKeys() { }

	public L[] CloneSubKeys() { }

	public V[] CloneValues() { }

	public bool ContainsKey(L subKey) { }

	public bool ContainsKey(K primaryKey) { }

	public int get_Count() { }

	public V get_Item(L subKey) { }

	public V get_Item(K primaryKey) { }

	public List get_Values() { }

	public IEnumerator GetEnumerator() { }

	public void Remove(L subKey) { }

	public void Remove(K primaryKey) { }

	public bool TryGetValue(K primaryKey, out V val) { }

	public bool TryGetValue(L subKey, out V val) { }

}


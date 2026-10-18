//Type is in global namespace

public class DictionaryListHydra`2
{
	internal struct ValuesEnumerator
	{
		private List _list; //Field offset: 0x0

		public ValuesEnumerator(List list) { }

		public Enumerator GetEnumerator() { }

	}

	private Dictionary _access; //Field offset: 0x0
	private List _iteration; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 26
	}

	public DictionaryListHydra`2(int capacity = 0) { }

	public void Add(TKey key, TValue value) { }

	public TValue AddOrReplace(TKey key, TValue value) { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	private void DirectAdd(TKey key, TValue value) { }

	public int get_Count() { }

	public TValue GetByIndex(int index) { }

	public TValue GetByKey(TKey key) { }

	public ValuesEnumerator GetValuesEnumerator() { }

	public bool Remove(TKey key) { }

	public bool TryGetByKey(TKey key, out TValue value) { }

	public IEnumerable Where(Func predicate) { }

}


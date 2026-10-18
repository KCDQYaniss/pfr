namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IReadOnlyDictionary`2 : IReadOnlyCollection, IEnumerable, IEnumerable
{

	public TValue Item
	{
		 get { } //Length: 0
	}

	public IEnumerable Keys
	{
		 get { } //Length: 0
	}

	public IEnumerable Values
	{
		 get { } //Length: 0
	}

	public bool ContainsKey(TKey key) { }

	public TValue get_Item(TKey key) { }

	public IEnumerable get_Keys() { }

	public IEnumerable get_Values() { }

	public bool TryGetValue(TKey key, out TValue value) { }

}


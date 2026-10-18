namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IDictionary`2 : ICollection, IEnumerable, IEnumerable
{

	public TValue Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ICollection Keys
	{
		 get { } //Length: 0
	}

	public ICollection Values
	{
		 get { } //Length: 0
	}

	public void Add(TKey key, TValue value) { }

	public bool ContainsKey(TKey key) { }

	public TValue get_Item(TKey key) { }

	public ICollection get_Keys() { }

	public ICollection get_Values() { }

	public bool Remove(TKey key) { }

	public void set_Item(TKey key, TValue value) { }

	public bool TryGetValue(TKey key, out TValue value) { }

}


namespace Sirenix.Utilities;

[DefaultMember("Item")]
public class DoubleLookupDictionary`3 : Dictionary
{
	private readonly IEqualityComparer secondKeyComparer; //Field offset: 0x0

	public Dictionary Item
	{
		 get { } //Length: 239
	}

	public DoubleLookupDictionary`3() { }

	public DoubleLookupDictionary`3(IEqualityComparer firstKeyComparer, IEqualityComparer secondKeyComparer) { }

	public TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value) { }

	public bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey) { }

	public Dictionary get_Item(TFirstKey firstKey) { }

	public int InnerCount(TFirstKey firstKey) { }

	public bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey) { }

	public void RemoveWhere(Func predicate) { }

	public int TotalInnerCount() { }

	public bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, out TValue value) { }

}


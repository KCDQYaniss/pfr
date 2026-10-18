namespace EFT.InventoryLogic;

[DefaultMember("Item")]
public class GridItemCollection : IEnumerable, IEnumerable
{
	protected readonly Dictionary Items; //Field offset: 0x10
	protected readonly List ItemsList; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 68
	}

	public LocationInGrid Item
	{
		 get { } //Length: 88
	}

	public List ItemsKeyList
	{
		 get { } //Length: 5
	}

	public KeyCollection Keys
	{
		 get { } //Length: 73
	}

	public ValueCollection Values
	{
		 get { } //Length: 73
	}

	public GridItemCollection() { }

	public override void Add(Item item, Grid grid, LocationInGrid location) { }

	public bool ContainsKey(Item item) { }

	public int get_Count() { }

	public LocationInGrid get_Item(Item item) { }

	public List get_ItemsKeyList() { }

	public KeyCollection get_Keys() { }

	public ValueCollection get_Values() { }

	public override IEnumerator GetEnumerator() { }

	public LocationInGrid GetLocation(Item item) { }

	public override void Remove(Item item, Grid grid) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryFindItem(string itemId, out Item item) { }

	public bool TryFindItem(Func predicate, out Item result) { }

}


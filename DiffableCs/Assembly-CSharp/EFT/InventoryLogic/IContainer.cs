namespace EFT.InventoryLogic;

public interface IContainer : IItemContainer
{

	public ItemFilter[] Filters
	{
		 get { } //Length: 0
	}

	public string ID
	{
		 get { } //Length: 0
	}

	public IEnumerable Items
	{
		 get { } //Length: 0
	}

	public EParentMergeType MergeContainerWithChildren
	{
		 get { } //Length: 0
	}

	public Item ParentItem
	{
		 get { } //Length: 0
	}

	public bool CheckCompatibility(Item item) { }

	public ItemAddress CreateItemAddress(ItemAddressDescriptor descriptor) { }

	public ItemFilter[] get_Filters() { }

	public string get_ID() { }

	public IEnumerable get_Items() { }

	public EParentMergeType get_MergeContainerWithChildren() { }

	public Item get_ParentItem() { }

	public int GetHashSum() { }

	public bool TryFindLocationForItem(Item item, out ItemAddress location) { }

}


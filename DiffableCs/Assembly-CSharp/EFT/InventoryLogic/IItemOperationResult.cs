namespace EFT.InventoryLogic;

public interface IItemOperationResult : IOperationResult, IRollable
{

	public ItemAddress From
	{
		 get { } //Length: 0
	}

	public Item Item
	{
		 get { } //Length: 0
	}

	public Item ResultItem
	{
		 get { } //Length: 0
	}

	public ItemAddress get_From() { }

	public Item get_Item() { }

	public Item get_ResultItem() { }

}


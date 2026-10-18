namespace EFT.InventoryLogic.Operations;

public interface ITwoItemOperation : IOneItemOperation, IInventoryOperation
{

	[CanBeNull]
	public ItemAddress From2
	{
		 get { } //Length: 0
	}

	public Item Item2
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public ItemAddress To2
	{
		 get { } //Length: 0
	}

	public ItemAddress get_From2() { }

	public Item get_Item2() { }

	public ItemAddress get_To2() { }

}


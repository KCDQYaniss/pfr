namespace EFT.InventoryLogic.Operations;

public interface IOneItemOperation : IInventoryOperation
{

	[CanBeNull]
	public ItemAddress From1
	{
		 get { } //Length: 0
	}

	public Item Item1
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public ItemAddress To1
	{
		 get { } //Length: 0
	}

	public ItemAddress get_From1() { }

	public Item get_Item1() { }

	public ItemAddress get_To1() { }

}


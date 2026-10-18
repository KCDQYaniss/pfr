namespace EFT.InventoryLogic;

public interface IToEmptyAddressResult : IItemOperationResult, IOperationResult, IRollable
{

	public ItemAddress To
	{
		 get { } //Length: 0
	}

	public ItemAddress get_To() { }

}


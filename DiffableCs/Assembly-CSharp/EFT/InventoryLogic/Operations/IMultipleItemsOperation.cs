namespace EFT.InventoryLogic.Operations;

public interface IMultipleItemsOperation : IInventoryOperation
{

	public IEnumerable Items
	{
		 get { } //Length: 0
	}

	public IEnumerable get_Items() { }

}


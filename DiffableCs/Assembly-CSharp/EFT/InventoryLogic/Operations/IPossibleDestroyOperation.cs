namespace EFT.InventoryLogic.Operations;

public interface IPossibleDestroyOperation : IObservedOperation, IOperationInfo
{

	public Item Item
	{
		 get { } //Length: 0
	}

	public Item get_Item() { }

}


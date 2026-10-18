namespace EFT.InventoryLogic.Operations;

public interface ISubOperation
{

	public IInventoryOperation BaseInventoryOperation
	{
		 get { } //Length: 0
	}

	public IInventoryOperation get_BaseInventoryOperation() { }

}


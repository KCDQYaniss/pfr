namespace EFT.InventoryLogic.Operations;

public interface IParentOperation : IInventoryOperation
{

	public AbstractOperation InternalOperation
	{
		 get { } //Length: 0
	}

	public AbstractOperation get_InternalOperation() { }

}


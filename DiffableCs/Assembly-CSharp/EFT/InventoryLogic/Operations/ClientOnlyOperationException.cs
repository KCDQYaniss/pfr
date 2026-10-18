namespace EFT.InventoryLogic.Operations;

public sealed class ClientOnlyOperationException : RestrictedOperationException
{

	protected virtual string Description
	{
		 get { } //Length: 49
	}

	public ClientOnlyOperationException(IInventoryOperation operation) { }

	protected virtual string get_Description() { }

}


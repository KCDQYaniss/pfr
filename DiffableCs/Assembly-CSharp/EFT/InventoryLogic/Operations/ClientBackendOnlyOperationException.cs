namespace EFT.InventoryLogic.Operations;

public sealed class ClientBackendOnlyOperationException : RestrictedOperationException
{

	protected virtual string Description
	{
		 get { } //Length: 49
	}

	public ClientBackendOnlyOperationException(IInventoryOperation operation) { }

	protected virtual string get_Description() { }

}


namespace EFT.InventoryLogic.Operations;

public sealed class ClientServerOnlyOperationException : RestrictedOperationException
{

	protected virtual string Description
	{
		 get { } //Length: 49
	}

	public ClientServerOnlyOperationException(IInventoryOperation operation) { }

	protected virtual string get_Description() { }

}


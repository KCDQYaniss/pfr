namespace EFT.InventoryLogic.Operations;

public sealed class ServerOnlyOperationException : RestrictedOperationException
{

	protected virtual string Description
	{
		 get { } //Length: 49
	}

	public ServerOnlyOperationException(IInventoryOperation operation) { }

	protected virtual string get_Description() { }

}


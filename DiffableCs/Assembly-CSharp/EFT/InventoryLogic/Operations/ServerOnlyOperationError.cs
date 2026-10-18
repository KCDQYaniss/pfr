namespace EFT.InventoryLogic.Operations;

public sealed class ServerOnlyOperationError : RestrictedOperationError
{

	protected virtual string Description
	{
		 get { } //Length: 49
	}

	public ServerOnlyOperationError(InventoryOperationDescriptor descriptor) { }

	protected virtual string get_Description() { }

}


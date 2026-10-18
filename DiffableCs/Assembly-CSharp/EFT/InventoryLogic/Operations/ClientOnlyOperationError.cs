namespace EFT.InventoryLogic.Operations;

public sealed class ClientOnlyOperationError : RestrictedOperationError
{

	protected virtual string Description
	{
		 get { } //Length: 49
	}

	public ClientOnlyOperationError(InventoryOperationDescriptor descriptor) { }

	protected virtual string get_Description() { }

}


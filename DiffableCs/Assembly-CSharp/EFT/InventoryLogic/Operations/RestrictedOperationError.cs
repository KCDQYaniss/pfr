namespace EFT.InventoryLogic.Operations;

public abstract class RestrictedOperationError : Error
{
	private readonly Type _descriptorType; //Field offset: 0x10

	protected abstract string Description
	{
		 get { } //Length: 0
	}

	protected RestrictedOperationError(InventoryOperationDescriptor descriptor) { }

	protected abstract string get_Description() { }

	public virtual string ToString() { }

}


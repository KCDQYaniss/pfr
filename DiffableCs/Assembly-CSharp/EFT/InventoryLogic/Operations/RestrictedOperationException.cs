namespace EFT.InventoryLogic.Operations;

public abstract class RestrictedOperationException : NotImplementedException
{
	private readonly Type _operationType; //Field offset: 0x90

	protected abstract string Description
	{
		 get { } //Length: 0
	}

	public virtual string Message
	{
		 get { } //Length: 87
	}

	protected RestrictedOperationException(IInventoryOperation operation) { }

	protected abstract string get_Description() { }

	public virtual string get_Message() { }

}


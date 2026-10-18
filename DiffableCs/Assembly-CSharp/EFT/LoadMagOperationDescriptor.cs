namespace EFT;

public sealed class LoadMagOperationDescriptor : MagOperationDescriptor
{

	public LoadMagOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}


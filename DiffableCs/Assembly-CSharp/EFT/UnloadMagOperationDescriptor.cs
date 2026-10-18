namespace EFT;

public sealed class UnloadMagOperationDescriptor : MagOperationDescriptor
{

	public UnloadMagOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}


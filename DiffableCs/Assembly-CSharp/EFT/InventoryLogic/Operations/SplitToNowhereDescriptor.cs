namespace EFT.InventoryLogic.Operations;

public sealed class SplitToNowhereDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30
	public uint Count; //Field offset: 0x48

	public SplitToNowhereDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}


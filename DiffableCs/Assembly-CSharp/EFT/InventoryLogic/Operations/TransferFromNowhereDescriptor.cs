namespace EFT.InventoryLogic.Operations;

public sealed class TransferFromNowhereDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30
	public uint Count; //Field offset: 0x48
	public bool SpawnedInSession; //Field offset: 0x4C

	public TransferFromNowhereDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}


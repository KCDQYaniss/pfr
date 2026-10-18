namespace EFT.InventoryLogic.Operations;

public sealed class SearchContentOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ItemId; //Field offset: 0x30

	public SearchContentOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}


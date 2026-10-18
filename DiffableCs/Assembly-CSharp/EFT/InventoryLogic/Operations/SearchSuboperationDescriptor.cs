namespace EFT.InventoryLogic.Operations;

public sealed class SearchSuboperationDescriptor : InventoryOperationDescriptor
{
	public MongoID SearchedItem; //Field offset: 0x30
	[CanBeNull]
	[Nullable]
	public List Content; //Field offset: 0x48
	public bool Instant; //Field offset: 0x50

	public SearchSuboperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}


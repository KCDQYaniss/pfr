namespace EFT.InventoryLogic.Operations;

public sealed class RemoveFromWishlistOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID TemplateId; //Field offset: 0x30
	public EWishlistGroup GroupType; //Field offset: 0x48

	public RemoveFromWishlistOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


namespace EFT.InventoryLogic.Operations;

public sealed class AddToWishlistOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID TemplateId; //Field offset: 0x30
	public EWishlistGroup GroupType; //Field offset: 0x48

	public AddToWishlistOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


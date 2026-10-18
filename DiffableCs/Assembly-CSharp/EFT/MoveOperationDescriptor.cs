namespace EFT;

public sealed class MoveOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public ItemAddressDescriptor From; //Field offset: 0x38
	public ItemAddressDescriptor To; //Field offset: 0x40
	[Nullable]
	public List DestroyedItems; //Field offset: 0x48

	public MoveOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


namespace EFT;

public sealed class SwapOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public ItemAddressDescriptor To; //Field offset: 0x38
	public string Item1Id; //Field offset: 0x40
	public ItemAddressDescriptor To1; //Field offset: 0x48
	[Nullable]
	public List DestroyedItems; //Field offset: 0x50

	public SwapOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


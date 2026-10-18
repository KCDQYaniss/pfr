namespace EFT;

public sealed class ThrowOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public bool DownDirection; //Field offset: 0x38
	[Nullable]
	public List DestroyedItems; //Field offset: 0x40

	public ThrowOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


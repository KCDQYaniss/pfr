namespace EFT;

public sealed class TransferOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public string Item1Id; //Field offset: 0x38
	public int Count; //Field offset: 0x40

	public TransferOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


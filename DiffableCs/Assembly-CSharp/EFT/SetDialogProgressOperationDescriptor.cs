namespace EFT;

public sealed class SetDialogProgressOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID TraderId; //Field offset: 0x30
	public MongoID DialogId; //Field offset: 0x48
	public MongoID LineId; //Field offset: 0x60
	public InventoryOperationDescriptor SubOperation; //Field offset: 0x78

	public SetDialogProgressOperationDescriptor() { }

	public SetDialogProgressOperationDescriptor(SetDialogProgressOperation operation) { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


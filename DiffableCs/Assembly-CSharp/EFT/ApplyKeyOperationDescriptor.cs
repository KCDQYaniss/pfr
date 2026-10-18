namespace EFT;

public sealed class ApplyKeyOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public string TargetItemId; //Field offset: 0x38

	public ApplyKeyOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


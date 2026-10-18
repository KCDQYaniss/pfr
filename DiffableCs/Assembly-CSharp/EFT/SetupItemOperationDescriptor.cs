namespace EFT;

public sealed class SetupItemOperationDescriptor : InventoryOperationDescriptor
{
	public string ItemId; //Field offset: 0x30
	public string ZoneId; //Field offset: 0x38
	public ClassVector3 Position; //Field offset: 0x40
	public ClassQuaternion Rotation; //Field offset: 0x48
	public float SetupTime; //Field offset: 0x50

	public SetupItemOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}


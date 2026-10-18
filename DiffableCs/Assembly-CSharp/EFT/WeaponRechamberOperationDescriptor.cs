namespace EFT;

public sealed class WeaponRechamberOperationDescriptor : InventoryOperationDescriptor
{
	public string WeaponId; //Field offset: 0x30

	public WeaponRechamberOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}


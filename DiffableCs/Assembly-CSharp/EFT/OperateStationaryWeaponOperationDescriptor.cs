namespace EFT;

public sealed class OperateStationaryWeaponOperationDescriptor : InventoryOperationDescriptor
{
	public string WeaponId; //Field offset: 0x30

	public OperateStationaryWeaponOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}


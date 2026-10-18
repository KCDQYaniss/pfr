namespace EFT.InventoryLogic.Operations;

public sealed class StationaryWeaponOperation : AbstractOperation, IObservedOperation, IOperationInfo
{
	private readonly StationaryWeapon _stationaryWeapon; //Field offset: 0x40

	public StationaryWeaponOperation(ushort id, ItemController controller, StationaryWeapon stationaryWeapon) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}


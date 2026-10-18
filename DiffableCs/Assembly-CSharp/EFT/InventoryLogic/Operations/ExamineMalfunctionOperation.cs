namespace EFT.InventoryLogic.Operations;

public sealed class ExamineMalfunctionOperation : AbstractOperation
{
	private readonly Item _item; //Field offset: 0x40
	private readonly int _raidId; //Field offset: 0x48

	internal ExamineMalfunctionOperation(ushort id, ItemController controller, int raidId, Item item) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}


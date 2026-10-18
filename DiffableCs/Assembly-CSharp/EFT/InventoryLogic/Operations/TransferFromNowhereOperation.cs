namespace EFT.InventoryLogic.Operations;

public sealed class TransferFromNowhereOperation : AbstractOperation
{
	private readonly Item _item; //Field offset: 0x40
	private readonly uint _count; //Field offset: 0x48
	private readonly bool _spawnedInSession; //Field offset: 0x4C

	public TransferFromNowhereOperation(ushort id, Item item, uint count, bool spawnedInSession, ItemController controller) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	private void RaiseEvents(EOperationStatus status) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}


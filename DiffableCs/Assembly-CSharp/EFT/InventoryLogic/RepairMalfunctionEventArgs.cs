namespace EFT.InventoryLogic;

public sealed class RepairMalfunctionEventArgs : ItemEventArgs, IUninterruptibleEventArgs, IItemInHandsEventArgs, ISingleEventArgs
{

	public RepairMalfunctionEventArgs(Item item, CommandStatus status, IItemOwner owner) { }

	protected virtual void SetTimeoutForOutdate() { }

}


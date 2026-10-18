namespace EFT.InventoryLogic;

public sealed class InOutHandsProcessEventArgs : ItemEventArgs, IItemInHandsEventArgs, ISingleEventArgs
{

	public InOutHandsProcessEventArgs(Item item, CommandStatus status, IItemOwner owner) { }

	protected virtual void SetTimeoutForOutdate() { }

}


namespace EFT.InventoryLogic;

public sealed class RemoveFromHandsEventArgs : ItemEventArgs, IUninterruptibleEventArgs, IItemInHandsEventArgs, ISingleEventArgs
{

	public RemoveFromHandsEventArgs(Item item, CommandStatus status, IItemOwner owner) { }

	protected virtual void SetTimeoutForOutdate() { }

}


namespace EFT.InventoryLogic;

public sealed class SetInHandsEventArgs : ItemEventArgs, IUninterruptibleEventArgs, IItemInHandsEventArgs, ISingleEventArgs
{

	public SetInHandsEventArgs(Item item, CommandStatus status, IItemOwner owner) { }

	protected virtual void SetTimeoutForOutdate() { }

}


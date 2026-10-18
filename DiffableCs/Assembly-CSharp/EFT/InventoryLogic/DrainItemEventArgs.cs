namespace EFT.InventoryLogic;

public sealed class DrainItemEventArgs : ItemEventArgs, IItemInHandsEventArgs, ISingleEventArgs
{

	public DrainItemEventArgs(Item item, CommandStatus status, IItemOwner owner) { }

	protected virtual void SetTimeoutForOutdate() { }

}


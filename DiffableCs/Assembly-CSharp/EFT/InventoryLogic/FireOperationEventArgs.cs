namespace EFT.InventoryLogic;

public sealed class FireOperationEventArgs : ItemEventArgs, IUninterruptibleEventArgs, IItemInHandsEventArgs, ISingleEventArgs
{

	public FireOperationEventArgs(Item item, CommandStatus status, IItemOwner owner) { }

}


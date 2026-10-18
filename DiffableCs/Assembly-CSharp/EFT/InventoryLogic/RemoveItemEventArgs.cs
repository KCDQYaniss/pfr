namespace EFT.InventoryLogic;

public sealed class RemoveItemEventArgs : ItemEventArgs, IUninterruptibleEventArgs, IItemInHandsEventArgs, ISingleEventArgs
{

	public ItemAddress From
	{
		 get { } //Length: 5
	}

	public RemoveItemEventArgs(Item item, ItemAddress from, CommandStatus status, IItemOwner owner) { }

	public ItemAddress get_From() { }

}


namespace EFT.InventoryLogic;

public sealed class AddItemEventArgs : ItemEventArgs, IUninterruptibleEventArgs, IItemInHandsEventArgs, ISingleEventArgs
{

	public ItemAddress To
	{
		 get { } //Length: 5
	}

	public AddItemEventArgs(Item item, ItemAddress to, CommandStatus status, IItemOwner owner) { }

	public ItemAddress get_To() { }

}


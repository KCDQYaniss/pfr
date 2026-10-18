namespace EFT.InventoryLogic;

public sealed class UnpackAmmoBoxEventArgs : ItemEventArgs, IItemBlockInteractionsEventArgs
{

	public UnpackAmmoBoxEventArgs(Item item, CommandStatus status, IItemOwner owner) { }

}


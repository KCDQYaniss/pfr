namespace EFT.InventoryLogic;

public sealed class BindItemEventArgs : ItemEventArgs
{
	public readonly Item Item; //Field offset: 0x40
	public readonly EBoundItem Index; //Field offset: 0x48

	public BindItemEventArgs(Item item, EBoundItem index, CommandStatus status, IItemOwner owner) { }

}


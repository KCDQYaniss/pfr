namespace EFT.InventoryLogic;

public sealed class NoFreeSpaceError : InventoryError
{
	public readonly Item Item; //Field offset: 0x10

	public NoFreeSpaceError(Item item) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


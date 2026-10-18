namespace EFT.InventoryLogic;

public sealed class NotRaidModdableError : InventoryError
{
	public readonly Item Item; //Field offset: 0x10

	public NotRaidModdableError(Item item) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


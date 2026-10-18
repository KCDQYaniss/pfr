namespace EFT.InventoryLogic;

public sealed class NotModdableWithoutMultitoolError : InventoryError
{
	public readonly Item Item; //Field offset: 0x10

	public NotModdableWithoutMultitoolError(Item item) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


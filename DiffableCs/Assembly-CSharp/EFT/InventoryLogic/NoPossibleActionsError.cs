namespace EFT.InventoryLogic;

public sealed class NoPossibleActionsError : InventoryError
{
	public readonly Item Item; //Field offset: 0x10

	public NoPossibleActionsError(Item item) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


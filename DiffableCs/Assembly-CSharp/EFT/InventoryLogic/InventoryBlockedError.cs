namespace EFT.InventoryLogic;

public sealed class InventoryBlockedError : InventoryError
{

	public InventoryBlockedError() { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


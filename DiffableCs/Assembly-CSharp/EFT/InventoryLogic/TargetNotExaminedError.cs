namespace EFT.InventoryLogic;

public sealed class TargetNotExaminedError : InventoryError
{
	public readonly Item TargetItem; //Field offset: 0x10

	public TargetNotExaminedError(Item targetItem) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


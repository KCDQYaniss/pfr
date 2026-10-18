namespace EFT.InventoryLogic;

public sealed class CannotModifyVitalInRaidError : InventoryError
{
	public readonly Slot Slot; //Field offset: 0x10

	public CannotModifyVitalInRaidError(Slot slot) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


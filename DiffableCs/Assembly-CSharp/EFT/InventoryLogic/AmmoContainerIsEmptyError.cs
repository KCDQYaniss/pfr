namespace EFT.InventoryLogic;

public sealed class AmmoContainerIsEmptyError : InventoryError
{
	private readonly IAmmoContainer _container; //Field offset: 0x10

	public AmmoContainerIsEmptyError(IAmmoContainer container) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


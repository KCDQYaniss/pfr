namespace EFT.InventoryLogic;

public sealed class AmmoPack
{
	private readonly LoopedQueue _ammoPacks; //Field offset: 0x10

	public int AmmoCount
	{
		 get { } //Length: 225
	}

	public AmmoPack(IList foundAmmo) { }

	public int get_AmmoCount() { }

	[CanBeNull]
	public Ammo GetAmmoToReload(int index) { }

	[NotNull]
	public string[] GetReloadingAmmoIds() { }

	public OperationResult LoadAmmo(IDatabaseIdGenerator idGenerator, ItemController itemController, ItemAddress to) { }

	public void LockItems() { }

	public virtual string ToString() { }

	public void UnlockItems() { }

}


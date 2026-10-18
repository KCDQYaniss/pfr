namespace EFT.InventoryLogic;

public sealed class UnknownAddressError : InventoryError
{
	private const string UNKNOWN_LOCATION = "InventoryError/TransferToUnknownLocation"; //Field offset: 0x0
	private readonly ItemAddress _address; //Field offset: 0x10

	public UnknownAddressError(ItemAddress address) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


namespace EFT.InventoryLogic;

public sealed class ItemTransferError : InventoryError
{
	public const string TRANSFER_LOCKED_KEY = "UI/Trader/TransferLocked"; //Field offset: 0x0

	public ItemTransferError() { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


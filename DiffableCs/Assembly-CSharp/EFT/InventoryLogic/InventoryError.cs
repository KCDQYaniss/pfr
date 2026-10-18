namespace EFT.InventoryLogic;

public abstract class InventoryError : LocalizedError
{
	public const string PLAYER_IS_BUSY_ERROR = "Inventory/PlayerIsBusy"; //Field offset: 0x0

	protected InventoryError() { }

	public virtual string GetLocalizedDescription() { }

	public IResult ToResult() { }

}


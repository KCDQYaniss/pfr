namespace EFT.InventoryLogic;

public abstract class LocalizedError : Error
{

	protected LocalizedError() { }

	public abstract string GetLocalizedDescription() { }

}


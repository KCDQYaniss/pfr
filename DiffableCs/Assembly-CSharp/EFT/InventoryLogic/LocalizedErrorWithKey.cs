namespace EFT.InventoryLogic;

public sealed class LocalizedErrorWithKey : LocalizedError
{
	private readonly string _localizationKey; //Field offset: 0x10

	public LocalizedErrorWithKey(string localizationKey) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}


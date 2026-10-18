namespace EFT.InventoryLogic;

public sealed class MissingItemsError : LocalizedError
{
	private readonly Item _missingItem; //Field offset: 0x10
	private readonly IReadOnlyDictionary _missingChildren; //Field offset: 0x18
	private string _localizedDescription; //Field offset: 0x20

	public MissingItemsError(Item missingItem, IReadOnlyDictionary missingChildren) { }

	private string CreateLocalizedDescription() { }

	public virtual string GetLocalizedDescription() { }

}


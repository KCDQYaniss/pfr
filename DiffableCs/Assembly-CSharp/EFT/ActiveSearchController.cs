namespace EFT;

public sealed class ActiveSearchController : PlayerSearchController
{
	private readonly Dictionary _knownItems; //Field offset: 0x48
	private readonly HashSet _temporaryKnownItems; //Field offset: 0x50
	private readonly HashSet _discoveredItems; //Field offset: 0x58

	internal ActiveSearchController(Profile profile, PlayerInventoryController inventoryController) { }

	private bool DiscoverItem(Item item) { }

	public void ForgetItem(Item item) { }

	public virtual bool IsItemKnown(Item item, ItemAddress itemAddress = null) { }

	public void RemoveItemFromTemporaryKnown(Item item) { }

	public virtual void SetItemAsKnown(Item item, bool raiseEvents) { }

	public void SetItemAsTemporaryKnown(Item item) { }

	private void UncoverContent(Item item) { }

}


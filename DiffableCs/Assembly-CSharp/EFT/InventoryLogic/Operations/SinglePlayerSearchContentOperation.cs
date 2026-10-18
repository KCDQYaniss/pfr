namespace EFT.InventoryLogic.Operations;

public sealed class SinglePlayerSearchContentOperation : ActiveSearchContentOperation
{

	public SinglePlayerSearchContentOperation(ushort id, ItemController controller, IPlayerSearchController searchController, Profile profile, SearchableItem item) { }

	protected virtual void DiscoverItem(Item item) { }

	protected virtual void ExecuteInternal(Callback callback) { }

	private static void PlayDiscoverSound(Item item) { }

	private static void PlayInstantSearchSound() { }

}


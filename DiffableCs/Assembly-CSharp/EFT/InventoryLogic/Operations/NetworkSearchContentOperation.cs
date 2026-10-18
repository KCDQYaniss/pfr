namespace EFT.InventoryLogic.Operations;

public sealed class NetworkSearchContentOperation : SearchContentOperation, IServerDependentOperation
{
	private Callback _callback; //Field offset: 0x50

	public NetworkSearchContentOperation(ushort id, ItemController itemController, SearchableItem item) { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public static void PlayDiscoverSound(Item item) { }

	public static void PlayInstantSearchSound() { }

	public virtual void Terminate() { }

}


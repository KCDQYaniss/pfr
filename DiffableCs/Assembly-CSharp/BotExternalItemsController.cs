//Type is in global namespace

public class BotExternalItemsController : BotData
{
	private readonly HashSet _pickUpedItems; //Field offset: 0x18

	public BotExternalItemsController(BotOwner owner) { }

	public void Activate() { }

	public void Dispose() { }

	public string GetRandomItemToDrop() { }

	public bool HaveItemsToDrop() { }

	private void OnItemDrop(Item obj) { }

	private void OnItemTaken(Item obj, IPlayer itemLastOwner) { }

}


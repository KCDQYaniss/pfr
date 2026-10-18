namespace EFT;

public class RecodableItemsHandler
{
	private Player _player; //Field offset: 0x10
	private List recodableItems; //Field offset: 0x18

	public RecodableItemsHandler(Player player) { }

	public T GetRecodableComponent() { }

	public List GetRecodableComponents() { }

	private void InitializeRecodableHandlers() { }

	private void OnAddItem(AddItemEventArgs args) { }

	private void OnRemoveItem(RemoveItemEventArgs args) { }

	public bool TryToGetRecodableComponent(out T component) { }

}


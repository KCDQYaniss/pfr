namespace EFT.InventoryLogic;

public interface IRecodableItem
{

	public RecodableComponent RecodableComponent
	{
		 get { } //Length: 0
	}

	public RecodableComponent get_RecodableComponent() { }

	public void InitializeHandler(Player player) { }

	public bool IsEncoded() { }

	public bool IsInitializedHandler() { }

	public void OnAddRecodableItem(Player player) { }

	public void OnRemoveRecodableItem() { }

}


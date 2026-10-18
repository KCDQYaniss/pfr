namespace EFT.InventoryLogic;

public interface IFavoriteContextComponent
{

	public bool AddingToFavoriteAvailable
	{
		 get { } //Length: 0
	}

	public FavoriteItemsStorage FavoriteItems
	{
		 get { } //Length: 0
	}

	public bool get_AddingToFavoriteAvailable() { }

	public FavoriteItemsStorage get_FavoriteItems() { }

	public bool ShouldSetFavoriteIcon(Item item, out bool isFavorite) { }

}


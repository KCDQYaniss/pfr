namespace EFT.InventoryLogic;

public interface IItemContainer
{

	public bool TryFindItem(string itemId, out Item item) { }

}


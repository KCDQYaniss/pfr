namespace EFT.InventoryLogic;

public interface IAntiRMTItemController
{

	public void AddDiscardLimits(Item item, IEnumerable destroyedItems) { }

	public IEnumerable GetItemsOverDiscardLimit(Item item) { }

	public bool HasDiscardLimit(Item item, out int limit) { }

	public void ResetDiscardLimits() { }

	public void SubtractFromDiscardLimits(Item rootItem, IEnumerable destroyedItems) { }

}


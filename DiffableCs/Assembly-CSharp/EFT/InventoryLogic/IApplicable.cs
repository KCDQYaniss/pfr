namespace EFT.InventoryLogic;

public interface IApplicable
{

	public OperationResult Apply(ItemController itemController, Item item, int count, bool simulate) { }

}


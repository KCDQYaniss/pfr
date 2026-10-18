namespace EFT.Hideout;

public interface IRequirementPanel : IUIView, IDisposable
{

	public void Show(ItemUiContext itemUiContext, InventoryController inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment) { }

}


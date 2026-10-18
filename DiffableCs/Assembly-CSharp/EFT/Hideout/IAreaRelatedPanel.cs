namespace EFT.Hideout;

public interface IAreaRelatedPanel : IUIView, IDisposable
{

	public Task Show(RelatedData info, Stage stage, ELevelType levelType, AreaData areaData, InventoryController inventoryController, IEftSession session) { }

}


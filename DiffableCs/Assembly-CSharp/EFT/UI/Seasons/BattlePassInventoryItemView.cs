namespace EFT.UI.Seasons;

public sealed class BattlePassInventoryItemView : BattlePassBaseItemView
{

	public BattlePassInventoryItemView() { }

	protected virtual string GetCountText(int itemsCount) { }

	protected virtual bool IsActive(int itemsCount) { }

	public void Show(BattlePassDocumentScheme document, BattlePassController controller, IImageLoader imageLoader) { }

}


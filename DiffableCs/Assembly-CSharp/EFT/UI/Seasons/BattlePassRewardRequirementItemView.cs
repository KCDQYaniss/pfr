namespace EFT.UI.Seasons;

public sealed class BattlePassRewardRequirementItemView : BattlePassBaseItemView
{
	private int _maxItemsCount; //Field offset: 0xC8

	public BattlePassRewardRequirementItemView() { }

	protected virtual string GetCountText(int itemsCount) { }

	protected virtual bool IsActive(int itemsCount) { }

	public void Show(BattlePassDocumentScheme document, BattlePassController controller, IImageLoader imageLoader, int maxItemsCount) { }

}


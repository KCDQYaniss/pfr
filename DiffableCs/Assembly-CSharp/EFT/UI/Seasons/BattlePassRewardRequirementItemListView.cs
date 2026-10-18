namespace EFT.UI.Seasons;

public sealed class BattlePassRewardRequirementItemListView : UIElement
{
	[SerializeField]
	private BattlePassRewardRequirementItemView _itemViewTemplate; //Field offset: 0x70
	[SerializeField]
	private RectTransform _itemsContainer; //Field offset: 0x78
	private UiElementPool _itemViews; //Field offset: 0x80

	public BattlePassRewardRequirementItemListView() { }

	private void InitItems(BattlePassReward reward, BattlePassController controller, IImageLoader imageLoader) { }

	public void Show(BattlePassReward reward, BattlePassController controller, IImageLoader imageLoader) { }

}


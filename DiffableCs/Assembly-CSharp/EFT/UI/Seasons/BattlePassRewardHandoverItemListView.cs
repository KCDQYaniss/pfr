namespace EFT.UI.Seasons;

public sealed class BattlePassRewardHandoverItemListView : UIElement
{
	[SerializeField]
	private BattlePassRewardRequirementItemView _itemViewTemplate; //Field offset: 0x70
	[SerializeField]
	private RectTransform _itemsContainer; //Field offset: 0x78
	private UiElementPool _itemViews; //Field offset: 0x80

	public BattlePassRewardHandoverItemListView() { }

	public void Show(IReadOnlyCollection documents, BattlePassController controller, IImageLoader imageLoader) { }

}


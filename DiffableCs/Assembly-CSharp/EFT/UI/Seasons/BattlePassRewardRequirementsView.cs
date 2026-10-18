namespace EFT.UI.Seasons;

public sealed class BattlePassRewardRequirementsView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public BattlePassReward reward; //Field offset: 0x10
		public BattlePassRewardRequirementsView <>4__this; //Field offset: 0x18
		public BattlePassController controller; //Field offset: 0x20
		public IImageLoader imageLoader; //Field offset: 0x28

		public <>c__DisplayClass5_0() { }

		internal void <Show>g__UpdateClaimedState|0() { }

	}

	[SerializeField]
	private BattlePassRewardsBoughtRequirementView _rewardsBoughtRequirement; //Field offset: 0x70
	[SerializeField]
	private BattlePassItemsHandoverRequirementView _itemsHandedOverRequirement; //Field offset: 0x78
	[SerializeField]
	private BattlePassRewardRequirementItemListView _itemsList; //Field offset: 0x80
	[SerializeField]
	private List _normalStateObjects; //Field offset: 0x88
	[SerializeField]
	private List _claimedStateObjects; //Field offset: 0x90

	public BattlePassRewardRequirementsView() { }

	public void Show(BattlePassReward reward, BattlePassController controller, IImageLoader imageLoader) { }

}


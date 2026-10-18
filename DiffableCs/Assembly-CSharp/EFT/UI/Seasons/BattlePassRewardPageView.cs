namespace EFT.UI.Seasons;

public sealed class BattlePassRewardPageView : SeasonRewardPageView
{
	[SerializeField]
	private BattleBassRewardView _viewTemplate; //Field offset: 0xA0

	protected virtual BattleBassRewardView ViewTemplate
	{
		 get { } //Length: 8
	}

	public BattlePassRewardPageView() { }

	protected virtual BattleBassRewardView get_ViewTemplate() { }

	protected virtual void InitRewardView(BattlePassReward reward, BattleBassRewardView view) { }

	public void Show(IEnumerable rewards, IImageLoader imageLoader) { }

}


namespace EFT.UI.Seasons;

public sealed class SeasonRewardsGridView : SeasonRewardPageView
{
	[SerializeField]
	private SeasonalRewardTileView _viewTemplate; //Field offset: 0xA0
	private SeasonsHubScreenController _context; //Field offset: 0xA8

	protected virtual SeasonalRewardTileView ViewTemplate
	{
		 get { } //Length: 8
	}

	public SeasonRewardsGridView() { }

	protected virtual SeasonalRewardTileView get_ViewTemplate() { }

	protected virtual void InitRewardView(SeasonalReward reward, SeasonalRewardTileView view) { }

	public void Show(SeasonsHubScreenController context) { }

}


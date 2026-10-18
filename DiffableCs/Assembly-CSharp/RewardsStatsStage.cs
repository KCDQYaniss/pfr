//Type is in global namespace

public class RewardsStatsStage : FinalStatisticScreenStage
{
	[SerializeField]
	private StatisticPanel _statisticPanel; //Field offset: 0xC0
	[SerializeField]
	private GridLayoutGroup _rewardViewsContainer; //Field offset: 0xC8
	private List _rewardViews; //Field offset: 0xD0

	public RewardsStatsStage() { }

	private void ShowRewards(IEnumerable rewards, IImageLoader session) { }

	public virtual Task ShowState() { }

}


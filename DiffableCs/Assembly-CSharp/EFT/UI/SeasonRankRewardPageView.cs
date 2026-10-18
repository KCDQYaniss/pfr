namespace EFT.UI;

public sealed class SeasonRankRewardPageView : SeasonRewardPageView
{
	[SerializeField]
	private SeasonRankRewardView _viewTemplate; //Field offset: 0xA0

	protected virtual SeasonRankRewardView ViewTemplate
	{
		 get { } //Length: 8
	}

	public SeasonRankRewardPageView() { }

	protected virtual SeasonRankRewardView get_ViewTemplate() { }

	protected virtual void InitRewardView(SeasonRankReward reward, SeasonRankRewardView view) { }

	public void Show(IList rewards, IImageLoader imageLoader) { }

	private void UpdateSize(IList rewards) { }

}


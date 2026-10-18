namespace EFT.UI;

public sealed class SeasonsSeasonRewardsTab : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateInfoCaption>b__11_0(SeasonalReward reward) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public SeasonalReward reward; //Field offset: 0x10
		public SeasonsSeasonRewardsTab <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0() { }

	}

	internal sealed class SeasonsSeasonRewardsTabController : UIElementTabController
	{
		private readonly SeasonsHubScreenController _context; //Field offset: 0x18

		public SeasonsSeasonRewardsTabController(SeasonsSeasonRewardsTab content, SeasonsHubScreenController context) { }

		public virtual void Show() { }

	}

	private const string NO_REWARDS_INFO_KEY = "SeasonalRewards/Infotext/NoRewards"; //Field offset: 0x0
	private const string AVAILABLE_REWARDS_INFO_KEY = "SeasonalRewards/Infotext/Available{0}"; //Field offset: 0x0
	private const string NOT_SEASONAL_INFO_KEY = "SeasonalRewards/Infotext/NotSeasonal"; //Field offset: 0x0
	private static readonly Color ERROR_TEXT_COLOR; //Field offset: 0x0
	[SerializeField]
	private SeasonRewardsGridView _rewardViewsContainer; //Field offset: 0x70
	[SerializeField]
	private SeasonalRewardDetailsView _rewardDetails; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _infoCaptionLabel; //Field offset: 0x80
	private SeasonsHubScreenController _context; //Field offset: 0x88
	private SeasonalReward _currentReward; //Field offset: 0x90

	private static SeasonsSeasonRewardsTab() { }

	public SeasonsSeasonRewardsTab() { }

	private void RewardStatusChanged(SeasonalReward _, bool __) { }

	private void SelectReward(SeasonalReward reward) { }

	private void Show(SeasonsHubScreenController context) { }

	private void UpdateInfoCaption() { }

}


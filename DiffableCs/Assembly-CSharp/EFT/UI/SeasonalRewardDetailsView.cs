namespace EFT.UI;

public sealed class SeasonalRewardDetailsView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public SeasonalReward reward; //Field offset: 0x10
		public SeasonalRewardDetailsView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal void <Show>b__0(MongoID rewardId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public SeasonalRewardConditionView conditionView; //Field offset: 0x10
		public SeasonalRewardDetailsView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal void <ShowConditions>b__0() { }

	}

	[CompilerGenerated]
	private struct <ObtainRewardAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonalRewardDetailsView <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string UNAVAILABLE_KEY = "Seasons/Hub/SeasonalRewards/Unavailable"; //Field offset: 0x0
	private const string OBTAIN_KEY = "Seasons/Hub/SeasonalRewards/Obtain"; //Field offset: 0x0
	private const string CLAIMED_KEY = "Seasons/Hub/SeasonalRewards/Claimed"; //Field offset: 0x0
	private const string NOT_SEASONAL_KEY = "Seasons/Hub/SeasonalRewards/NotSeasonal"; //Field offset: 0x0
	private const string TRADE_OFFER_CONDITION_KEY = "Seasons/Hub/TradeOfferCondition"; //Field offset: 0x0
	private const string TRADER_LOYALTY_REQUIRED_TOOLTIP_KEY = "Seasons/Hub/TraderLoyaltyRequiredTooltip"; //Field offset: 0x0
	[Header("Labels")]
	[SerializeField]
	private NetworkImageView _image; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _rewardType; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _rewardName; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x88
	[Header("Buttons")]
	[SerializeField]
	private DefaultUiButtonNewStyle _obtainButton; //Field offset: 0x90
	[SerializeField]
	private Button _infoButton; //Field offset: 0x98
	[SerializeField]
	private Button _soundButton; //Field offset: 0xA0
	[SerializeField]
	private Button _playButton; //Field offset: 0xA8
	[SerializeField]
	private TradingOfferTooltipArea _tradingOfferTooltipArea; //Field offset: 0xB0
	[Header("Conditions")]
	[SerializeField]
	private SeasonalRewardConditionView _conditionViewTemplate; //Field offset: 0xB8
	[SerializeField]
	private Transform _conditionsContainer; //Field offset: 0xC0
	[Header("Sound")]
	[SerializeField]
	private EUISoundType _rewardSound; //Field offset: 0xC8
	private readonly Queue _conditionViewsPool; //Field offset: 0xD0
	private SeasonalReward _reward; //Field offset: 0xD8
	private SeasonsHubScreenController _context; //Field offset: 0xE0
	private SeasonalRewardControllerClient _seasonalRewardController; //Field offset: 0xE8
	private RewardDetailsActionState _rewardActions; //Field offset: 0xF0

	public SeasonalRewardDetailsView() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<ObtainRewardAsync>d__30))]
	private Task ObtainRewardAsync() { }

	private void ObtainRewardHandler() { }

	private void SetupActionButtons(PrestigeReward reward) { }

	public void Show(SeasonalReward reward, SeasonsHubScreenController context) { }

	private void ShowConditions(SeasonalReward seasonalReward) { }

	private void ShowHeader(SeasonalReward reward, PrestigeReward firstReward, IImageLoader imageLoader) { }

	private void ShowImage(SeasonalReward reward, IImageLoader imageLoader) { }

	private void UpdateObtainButton() { }

}


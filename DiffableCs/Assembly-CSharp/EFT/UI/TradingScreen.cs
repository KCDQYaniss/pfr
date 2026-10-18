namespace EFT.UI;

public sealed class TradingScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <InitMerchantsTab>b__28_0(Trader trader) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public string traderId; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <GetTraderPanelById>b__0(TraderPanel e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public TradingScreen <>4__this; //Field offset: 0x10
		public TradersScreenController merchantsScreenController; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal void <ShowScreen>b__0() { }

	}

	internal enum ETradingScreenTab
	{
		Merchants = 1,
		FleaMarket = 2,
	}

	internal sealed class RagfairScreenController : TradingScreenController
	{

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public virtual ETradingScreenTab Tab
		{
			 get { } //Length: 6
		}

		public RagfairScreenController(IEftSession session, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, RagfairSearch ragfairSearch) { }

		public virtual EEftScreenType get_ScreenType() { }

		public virtual ETradingScreenTab get_Tab() { }

		protected virtual void ShowAction(TradingScreen screen) { }

	}

	internal sealed class TradersScreenController : TradingScreenController
	{

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public virtual ETradingScreenTab Tab
		{
			 get { } //Length: 6
		}

		public TradersScreenController(IEftSession session, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController) { }

		public virtual EEftScreenType get_ScreenType() { }

		public virtual ETradingScreenTab get_Tab() { }

	}

	internal abstract class TradingScreenController : EftScreenController
	{
		public readonly IEftSession Session; //Field offset: 0x58
		public readonly IHealthController HealthController; //Field offset: 0x60
		public readonly InventoryController InventoryController; //Field offset: 0x68
		public readonly QuestController QuestController; //Field offset: 0x70
		public readonly AchievementsController AchievementsController; //Field offset: 0x78
		public readonly RagfairSearch RagfairSearch; //Field offset: 0x80
		public Action TraderSelectedEvent; //Field offset: 0x88

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public abstract ETradingScreenTab Tab
		{
			 get { } //Length: 0
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected TradingScreenController(IEftSession session, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, RagfairSearch ragfairSearch) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public abstract ETradingScreenTab get_Tab() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	[SerializeField]
	private DefaultUIButton _exitButton; //Field offset: 0xA0
	[SerializeField]
	private UIAnimatedToggleSpawner _merchantsToggle; //Field offset: 0xA8
	[SerializeField]
	private UIAnimatedToggleSpawner _ragfairToggle; //Field offset: 0xB0
	[SerializeField]
	private GameObject _ragfairLockIcon; //Field offset: 0xB8
	[SerializeField]
	private MerchantsList _merchantsList; //Field offset: 0xC0
	[SerializeField]
	private RagfairScreen _ragfairScreen; //Field offset: 0xC8
	[SerializeField]
	private HoverTooltipArea _tooltipArea; //Field offset: 0xD0
	[SerializeField]
	private GameObject _loader; //Field offset: 0xD8
	[SerializeField]
	public TraderScreensGroup TraderScreensGroup; //Field offset: 0xE0
	private IEftSession _session; //Field offset: 0xE8
	private IHealthController _healthController; //Field offset: 0xF0
	private InventoryController _inventoryController; //Field offset: 0xF8
	private QuestController _questController; //Field offset: 0x100
	private AchievementsController _achievementsController; //Field offset: 0x108
	private Profile _profile; //Field offset: 0x110
	private RagFair _ragfair; //Field offset: 0x118
	private RagfairSearch _ragfairSearch; //Field offset: 0x120
	private ToggleTab _merchantsTab; //Field offset: 0x128
	private ToggleTab _ragfairTab; //Field offset: 0x130
	private DateTime _lastUpdate; //Field offset: 0x138
	private Action _traderSelectedEvent; //Field offset: 0x140

	public TradingScreen() { }

	[CompilerGenerated]
	private void <Awake>b__26_0() { }

	[CompilerGenerated]
	private void <Awake>b__26_1(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__26_2(bool arg) { }

	[CompilerGenerated]
	private void <InitMerchantsTab>b__28_1() { }

	[CompilerGenerated]
	private void <Show>b__30_0(ERagFairStatus status) { }

	private void Awake() { }

	public virtual void Close() { }

	private ToggleTab GetTab(ETradingScreenTab tabType) { }

	[CanBeNull]
	internal TraderPanel GetTraderPanelById(string traderId) { }

	private void InitMerchantsTab() { }

	private void InitRagfairScreen() { }

	private void OnCancellableFilterAdded(CancellableFilter filter) { }

	private void OnCancellableFilterRemoved(CancellableFilter filter) { }

	private void OnTraderSelected(Trader trader) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	private void Show(IEftSession session, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, Profile profile, RagfairSearch ragfairSearch, ETradingScreenTab tab, Action traderSelectedEvent) { }

	public virtual void Show(TradingScreenController controller) { }

	private void ShowScreen(ETradingScreenTab tabType) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateRagfairAvailability() { }

}


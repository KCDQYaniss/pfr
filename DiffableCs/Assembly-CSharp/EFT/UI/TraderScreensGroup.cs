namespace EFT.UI;

[UsedImplicitly]
public sealed class TraderScreensGroup : EftScreen, IAddHandler, IItemRelatedView, IRemoveHandler, IRefreshHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__47_4; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__47_4(Trader trader) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public TraderScreensGroup <>4__this; //Field offset: 0x10
		public CaptchaHandler captchaHandler; //Field offset: 0x18
		public TaskCompletionSource tradingRequestAwaiter; //Field offset: 0x20

		public <>c__DisplayClass47_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1(TraderDealScreen dealScreen) { }

		internal void <Show>b__2(QuestsScreen questsScreen) { }

		internal void <Show>b__3(ServicesScreen servicesScreen) { }

		internal void <Show>g__TradingModeChanged|6(ETradeMode mode) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_1
	{
		public TraderDealScreen dealScreen; //Field offset: 0x10
		public <>c__DisplayClass47_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass47_1() { }

		internal void <Show>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public Trader nextTrader; //Field offset: 0x10
		public TraderScreensGroup <>4__this; //Field offset: 0x18

		public <>c__DisplayClass49_0() { }

		internal void <SpawnCards>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		private struct <<SelectTrader>g__RefreshAssortment|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass51_0 <>4__this; //Field offset: 0x20
			private IResult <result>5__2; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30
			private YieldAwaiter <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public TraderScreensGroup <>4__this; //Field offset: 0x10
		public TaskCompletionSource tradingRequestCompletionSource; //Field offset: 0x18

		public <>c__DisplayClass51_0() { }

		[AsyncStateMachine(typeof(<<SelectTrader>g__RefreshAssortment|0>d))]
		internal Task <SelectTrader>g__RefreshAssortment|0() { }

	}

	internal sealed class DialogTraderScreenController : TraderScreenController
	{

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual bool RestrictScreenTransitions
		{
			 get { } //Length: 3
		}

		public virtual bool ShowDialogStartButton
		{
			 get { } //Length: 3
		}

		public virtual bool UseUnderlay
		{
			 get { } //Length: 3
		}

		public DialogTraderScreenController(Trader trader, IEnumerable tradersList, Profile profile, InventoryController stashController, IHealthController healthController, QuestController questController, AchievementsController achievementsController, IEftSession session, ETraderMode initialMode) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual bool get_RestrictScreenTransitions() { }

		public virtual bool get_ShowDialogStartButton() { }

		public virtual bool get_UseUnderlay() { }

	}

	internal enum ETraderMode
	{
		Trade = 0,
		Tasks = 1,
		Services = 2,
	}

	internal class TraderScreenController : EftScreenController
	{
		public readonly ETraderMode InitialMode; //Field offset: 0x58
		[CompilerGenerated]
		private Trader <Trader>k__BackingField; //Field offset: 0x60
		public readonly Profile Profile; //Field offset: 0x68
		public readonly InventoryController StashController; //Field offset: 0x70
		public readonly IHealthController HealthController; //Field offset: 0x78
		public readonly QuestController QuestController; //Field offset: 0x80
		public readonly AchievementsController AchievementsController; //Field offset: 0x88
		public readonly IEftSession Session; //Field offset: 0x90
		public readonly IEnumerable TradersList; //Field offset: 0x98
		public Action StartDialogAction; //Field offset: 0xA0

		public override bool RestrictScreenTransitions
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public override bool ShowDialogStartButton
		{
			 get { } //Length: 3
		}

		public private Trader Trader
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override bool UseUnderlay
		{
			 get { } //Length: 3
		}

		public TraderScreenController(Trader trader, IEnumerable tradersList, Profile profile, InventoryController stashController, IHealthController healthController, QuestController questController, AchievementsController achievementsController, IEftSession session, ETraderMode initialMode = 0) { }

		protected virtual void CloseAction(bool moveForward) { }

		public override bool get_RestrictScreenTransitions() { }

		public virtual EEftScreenType get_ScreenType() { }

		public override bool get_ShowDialogStartButton() { }

		[CompilerGenerated]
		public Trader get_Trader() { }

		public override bool get_UseUnderlay() { }

		[CompilerGenerated]
		private void set_Trader(Trader value) { }

		protected virtual void ShowAction(TraderScreensGroup screen) { }

	}

	[SerializeField]
	private DefaultUIButton _closeButton; //Field offset: 0xA0
	[SerializeField]
	private DialogStartButton _dialogueStartButton; //Field offset: 0xA8
	[SerializeField]
	private Tab _tradingTab; //Field offset: 0xB0
	[SerializeField]
	private Tab _tasksTab; //Field offset: 0xB8
	[SerializeField]
	private Tab _servicesTab; //Field offset: 0xC0
	[SerializeField]
	private TraderDealScreen _traderDealScreen; //Field offset: 0xC8
	[SerializeField]
	private QuestsScreen _questsScreen; //Field offset: 0xD0
	[SerializeField]
	private ServicesScreen _servicesScreen; //Field offset: 0xD8
	[SerializeField]
	private Transform _traderCardsContainer; //Field offset: 0xE0
	[SerializeField]
	private TradingPlayerPanel _playerPanel; //Field offset: 0xE8
	[SerializeField]
	private TraderCard _traderCardPrefab; //Field offset: 0xF0
	[SerializeField]
	private GameObject _alpha; //Field offset: 0xF8
	[SerializeField]
	private TraderTooltip _traderTooltip; //Field offset: 0x100
	[SerializeField]
	private GameObject _underlay; //Field offset: 0x108
	private ItemUiContext _itemUiContext; //Field offset: 0x110
	private TabGroup _tabsHeader; //Field offset: 0x118
	private TraderScreenController _traderScreenController; //Field offset: 0x120
	private readonly List _spawnedCards; //Field offset: 0x128
	private ETradeMode _lastTradeMode; //Field offset: 0x130
	private Action _startDialogueAction; //Field offset: 0x138
	private ETraderMode _traderMode; //Field offset: 0x140
	[CompilerGenerated]
	private Trader <Trader>k__BackingField; //Field offset: 0x148

	private AchievementsController AchievementsController
	{
		private get { } //Length: 33
	}

	private IHealthController HealthController
	{
		private get { } //Length: 30
	}

	private InventoryController InventoryController
	{
		private get { } //Length: 30
	}

	private Profile Profile
	{
		private get { } //Length: 30
	}

	private QuestController QuestController
	{
		private get { } //Length: 33
	}

	private IEftSession Session
	{
		private get { } //Length: 33
	}

	private Trader Trader
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private ETraderMode TraderMode
	{
		private get { } //Length: 7
		private set { } //Length: 51
	}

	private IEnumerable TradersList
	{
		private get { } //Length: 33
	}

	public TraderScreensGroup() { }

	[CompilerGenerated]
	private void <Awake>b__45_0() { }

	[UsedImplicitly]
	private void Awake() { }

	public virtual void Close() { }

	private void ConfigureUIContext() { }

	private void DisposePreviousTrader() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRefreshHandler.OnRefreshItem(RefreshItemEventArgs eventArgs) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private AchievementsController get_AchievementsController() { }

	private IHealthController get_HealthController() { }

	private InventoryController get_InventoryController() { }

	private Profile get_Profile() { }

	private QuestController get_QuestController() { }

	private IEftSession get_Session() { }

	[CompilerGenerated]
	private Trader get_Trader() { }

	private ETraderMode get_TraderMode() { }

	private IEnumerable get_TradersList() { }

	private void LoyaltyChangeHandler() { }

	protected virtual void OnDestroy() { }

	private void OnSessionErrorHandler(EBackendErrorCode errorCode, string errorMessage) { }

	private void SelectTrader(Trader nextSelected, TaskCompletionSource tradingRequestCompletionSource = null) { }

	[CompilerGenerated]
	private void set_Trader(Trader value) { }

	private void set_TraderMode(ETraderMode value) { }

	private void SetMode(ETraderMode mode) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public virtual void Show(TraderScreenController controller) { }

	private void SpawnCards() { }

	private void StartDialogue() { }

	private void TraderStatsChangeHandler() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}


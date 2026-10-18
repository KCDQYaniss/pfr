namespace EFT.UI;

public sealed class ArenaEftTransferServiceView : ServiceView, ISelectionContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__23_1; //Field offset: 0x8
		public static Func <>9__97_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <get_RubLeftInStash>b__23_1(Item item) { }

		internal ArenaEftTransferItem <TransferItemsToArena>b__97_0(Item item) { }

	}

	[CompilerGenerated]
	private struct <TransferItemsToArena>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArenaEftTransferServiceView <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateNoArenaSyncTimer>d__107 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArenaEftTransferServiceView <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTimer>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArenaEftTransferServiceView <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int MEANING_DIGITS = 5; //Field offset: 0x0
	public const string TAX_TOOLTIP_HEADER_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/СommissionTooltip/Header"; //Field offset: 0x0
	public const string MONEY_TRANSFER_TOOLTIP_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/СommissionTooltip/MoneyTransfer"; //Field offset: 0x0
	public const string CHARISMA_BONUS_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/СommissionTooltip/CharismaBonus"; //Field offset: 0x0
	public const string STANDING_BONUS_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/СommissionTooltip/StandingBonus"; //Field offset: 0x0
	public const string ITEM_TRANSFER_TOOLTIP_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/СommissionTooltip/ItemTransfer"; //Field offset: 0x0
	public const string TRANSFER_UNAVAILABLE_HEADER_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/CommissionTooltip/ServiceUnavaliable"; //Field offset: 0x0
	public const string NOT_ENOUGH_MONEY_FOR_TAX_TOOLTIP_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/CommissionTooltip/NotEnoughMoneyForTax"; //Field offset: 0x0
	public const string LIMIT_EXHAUSTED_TOOLTIP_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/CommissionTooltip/LimitExhausted"; //Field offset: 0x0
	public const string ARENA_NOT_PURCHASED_LOCALIZATION_KEY = "EFT/UI/Trading/ArenaEftTransfer/CommissionTooltip/ArenaNotPurchased"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0x70
	[CompilerGenerated]
	private Action _onInteractionLock; //Field offset: 0x78
	[SerializeField]
	private GridView _stashView; //Field offset: 0x80
	[SerializeField]
	private ArenaEftItemTransferGridView _transferView; //Field offset: 0x88
	[SerializeField]
	private DefaultUIButton _dealButton; //Field offset: 0x90
	[SerializeField]
	private DefaultUIButton _cancelButton; //Field offset: 0x98
	[SerializeField]
	private TMP_Text[] _itemsSendTimerTexts; //Field offset: 0xA0
	[SerializeField]
	private TMP_Text[] _transferTaxTexts; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _dealButtonDisabledText; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _updateTimer; //Field offset: 0xB8
	[SerializeField]
	private Color _defaultTransferedColor; //Field offset: 0xC0
	[SerializeField]
	private Color _overflowTransferedColor; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _transferredToArenaMaxValue; //Field offset: 0xE0
	[SerializeField]
	private Color _commissionTooltipRublesColor; //Field offset: 0xE8
	[SerializeField]
	private GameObject _taxTooltipTriggerZone; //Field offset: 0xF8
	private ReferenceGrid _transferGrid; //Field offset: 0x100
	private ItemController _fakeController; //Field offset: 0x108
	private Trader _trader; //Field offset: 0x110
	private Profile _profile; //Field offset: 0x118
	private Stash _stash; //Field offset: 0x120
	private IEftSession _session; //Field offset: 0x128
	private bool _isArenaPurchased; //Field offset: 0x130
	private bool _isGameSynced; //Field offset: 0x131
	private bool _interactionLock; //Field offset: 0x132
	private List _taxTooltipTextData; //Field offset: 0x138
	private CompoundTooltip _taxTooltip; //Field offset: 0x140
	private int _rubblesReadyToTransfer; //Field offset: 0x148
	private bool _isLimitOverflowed; //Field offset: 0x14C
	private bool _isNeedToRestartTimer; //Field offset: 0x14D
	private DateTime _resetDateTime; //Field offset: 0x150
	private CancellationTokenSource _timerCancellation; //Field offset: 0x158
	private bool _isNoArenaSyncTimerActive; //Field offset: 0x160
	private CancellationTokenSource _noArenaSyncTimerCancellation; //Field offset: 0x168
	private DateTime _noArenaSyncResetDateTime; //Field offset: 0x170
	private int _noArenaSyncTimerTimesLaunched; //Field offset: 0x178
	private HashSet _selectedItems; //Field offset: 0x180
	private Dictionary _itemTaxDictionary; //Field offset: 0x188
	private DateTime _countdownEndTime; //Field offset: 0x190
	private bool _isCountdownStarted; //Field offset: 0x198

	private event Action _onInteractionLock
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private decimal CharismaAndTradingRepTaxComponent
	{
		private get { } //Length: 414
	}

	private int CharismaLevel
	{
		private get { } //Length: 94
	}

	private decimal CharismaTaxDecreaseCoefficient
	{
		private get { } //Length: 445
	}

	private ArenaEftTransferGlobalSettings GlobalTransferSettings
	{
		private get { } //Length: 64
	}

	private bool InteractionLock
	{
		private get { } //Length: 8
		private set { } //Length: 31
	}

	private bool IsCountdownStarted
	{
		private get { } //Length: 8
		private set { } //Length: 289
	}

	private int RubLeftInStash
	{
		private get { } //Length: 515
	}

	private decimal StandingTaxDecreaseCoefficient
	{
		private get { } //Length: 568
	}

	private int TransferCountdownTimeSeconds
	{
		private get { } //Length: 72
	}

	private MoneyTransferLimitData TransferLimitsData
	{
		private get { } //Length: 33
	}

	public ArenaEftTransferServiceView() { }

	[CompilerGenerated]
	private void <Awake>b__75_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__75_1(PointerEventData arg) { }

	[CompilerGenerated]
	private bool <CalculateRawItemsTransferTax>b__110_0(Item x) { }

	[CompilerGenerated]
	private bool <CalculateRawRubleTransferTax>b__109_0(Item x) { }

	[CompilerGenerated]
	private bool <Close>b__112_0(Task _) { }

	[CompilerGenerated]
	private bool <get_RubLeftInStash>b__23_0(Item item) { }

	[CompilerGenerated]
	private bool <LateUpdate>b__78_0(Task _) { }

	[CompilerGenerated]
	private void <Show>b__79_0() { }

	[CompilerGenerated]
	private void <Show>b__79_1() { }

	private void ActivateNoArenaSyncTimer() { }

	[CompilerGenerated]
	private void add__onInteractionLock(Action value) { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	private DateTime AddTimeToNoArenaSyncTimer() { }

	private void Awake() { }

	private int CalculateRawItemsTransferTax() { }

	private int CalculateRawRubleTransferTax() { }

	private int CalculateTotalTransferTax() { }

	private int CalculateTransferTaxForEnumerable(IEnumerable itemsCollection) { }

	private int CalculateTransferTaxForSingleItem(Item item) { }

	public virtual bool CheckAvailable(Trader trader) { }

	private void ClearAllSelectedItems() { }

	public virtual void Close() { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

	private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

	private string GenerateCommissionTooltipString() { }

	private decimal get_CharismaAndTradingRepTaxComponent() { }

	private int get_CharismaLevel() { }

	private decimal get_CharismaTaxDecreaseCoefficient() { }

	private ArenaEftTransferGlobalSettings get_GlobalTransferSettings() { }

	private bool get_InteractionLock() { }

	private bool get_IsCountdownStarted() { }

	private int get_RubLeftInStash() { }

	private decimal get_StandingTaxDecreaseCoefficient() { }

	private int get_TransferCountdownTimeSeconds() { }

	private MoneyTransferLimitData get_TransferLimitsData() { }

	private bool IsRubles(Item item) { }

	private bool IsSelected(Item item) { }

	private void LateUpdate() { }

	private void OnCancelButtonClick() { }

	private void OnDealButtonClick() { }

	private void PrepareTimer() { }

	[CompilerGenerated]
	private void remove__onInteractionLock(Action value) { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	private decimal RoundTaxMultiplier(float multiplier) { }

	private void SelectItem(Item item, ItemAddress to = null) { }

	private void SelectItemHandler(Item item, ItemAddress address) { }

	private void set_InteractionLock(bool value) { }

	private void set_IsCountdownStarted(bool value) { }

	public virtual void Show(Trader trader, Profile profile, InventoryController controller, OfflineHealthController healthController, QuestBook quests, AchievementsBook achievements, ItemUiContext context, IEftSession session) { }

	private void StopNoArenaSyncTimer() { }

	private void StopTimer() { }

	[AsyncStateMachine(typeof(<TransferItemsToArena>d__97))]
	private Task TransferItemsToArena() { }

	private void TrickLimitsUpdate() { }

	private void Update() { }

	private void UpdateDealButton() { }

	private void UpdateDealButtonPrice() { }

	[AsyncStateMachine(typeof(<UpdateNoArenaSyncTimer>d__107))]
	private Task UpdateNoArenaSyncTimer(CancellationToken token) { }

	private void UpdateResetDateTime() { }

	[AsyncStateMachine(typeof(<UpdateTimer>d__100))]
	private Task UpdateTimer(CancellationToken token) { }

	private void UpdateTimer(TimeSpan timeSpan) { }

	private void UpdateTransferLimit() { }

	private void UpdateTransferLimitLabel(int moneyToTransfer) { }

}


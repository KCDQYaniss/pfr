namespace EFT.UI.Ragfair;

public sealed class HandoverExchangeableItemsWindow : HandoverSelectItemsWindow
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__30_3; //Field offset: 0x8
		public static Func <>9__31_1; //Field offset: 0x10
		public static Func <>9__31_2; //Field offset: 0x18
		public static Func <>9__31_3; //Field offset: 0x20
		public static Func <>9__31_4; //Field offset: 0x28
		public static Func <>9__32_1; //Field offset: 0x30
		public static Func <>9__32_0; //Field offset: 0x38
		public static Func <>9__38_2; //Field offset: 0x40
		public static Func <>9__38_0; //Field offset: 0x48
		public static Func <>9__38_1; //Field offset: 0x50
		public static Func <>9__42_0; //Field offset: 0x58
		public static Func <>9__45_1; //Field offset: 0x60
		public static Func <>9__45_2; //Field offset: 0x68

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <Accept>b__32_0(Requisite requisite) { }

		internal ItemReference <Accept>b__32_1(TradingItemReference reference) { }

		internal int <AddToSelection>b__45_1(Requisite requisite) { }

		internal int <AddToSelection>b__45_2(Requisite requisite) { }

		internal int <Awake>b__30_3(KeyValuePair x) { }

		internal bool <Show>b__31_1(KeyValuePair x) { }

		internal DateTime <Show>b__31_2(KeyValuePair x) { }

		internal int <Show>b__31_3(KeyValuePair x) { }

		internal bool <Show>b__31_4(KeyValuePair x) { }

		internal bool <TrySelectItemToHandover>b__42_0(Requisite x) { }

		internal IEnumerable <UpdateSelectedViews>b__38_0(Requisite x) { }

		internal bool <UpdateSelectedViews>b__38_1(Requisite x) { }

		internal Item <UpdateSelectedViews>b__38_2(TradingItemReference itemReference) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Predicate allowedItemPredicate; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <Show>b__0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_1
	{
		public Requisite requisite; //Field offset: 0x10

		public <>c__DisplayClass31_1() { }

		internal bool <Show>b__5(Requisite r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass45_0() { }

		internal bool <AddToSelection>b__0(Requisite requisite) { }

	}

	[SerializeField]
	private HandoverRequirementBarterIcon _barterIcon; //Field offset: 0x138
	[SerializeField]
	private RectTransform _barterContainer; //Field offset: 0x140
	[SerializeField]
	private TextMeshProUGUI _expirationLabel; //Field offset: 0x148
	[SerializeField]
	private TMP_InputField _inputField; //Field offset: 0x150
	[SerializeField]
	private TextMeshProUGUI _maxCountLabel; //Field offset: 0x158
	[SerializeField]
	private Button _allItemsButton; //Field offset: 0x160
	[SerializeField]
	private GameObject _countPanel; //Field offset: 0x168
	[SerializeField]
	private GameObject _toolMarker; //Field offset: 0x170
	private SimpleTooltip _tooltip; //Field offset: 0x178
	public Dictionary Goods; //Field offset: 0x180
	private Dictionary _deal; //Field offset: 0x188
	private Dictionary _requirements; //Field offset: 0x190
	private ViewList _requirementsPanels; //Field offset: 0x198
	private Action _acceptAction; //Field offset: 0x1A0
	private readonly List _requisites; //Field offset: 0x1A8
	private readonly List _playerItems; //Field offset: 0x1B0
	private EMemberCategory _traderType; //Field offset: 0x1B8
	private EExchangeableWindowType _windowType; //Field offset: 0x1BC
	private DateTime _endTime; //Field offset: 0x1C0
	private IEnumerator _timerWorker; //Field offset: 0x1C8
	private bool _purchaseProcessing; //Field offset: 0x1D0
	private bool _acceptWasAvailable; //Field offset: 0x1D1
	private bool _keepOpenOnAccept; //Field offset: 0x1D2
	private readonly HashSet _toolTemplates; //Field offset: 0x1D8
	private readonly List _filteredPlayerItems; //Field offset: 0x1E0
	private readonly List _missingItems; //Field offset: 0x1E8

	protected virtual bool CloseOnAccept
	{
		 get { } //Length: 11
	}

	private TimeSpan TimeLeft
	{
		private get { } //Length: 146
	}

	public HandoverExchangeableItemsWindow() { }

	[CompilerGenerated]
	private void <Awake>b__30_0(string arg) { }

	[CompilerGenerated]
	private void <Awake>b__30_1() { }

	[CompilerGenerated]
	private void <Awake>b__30_2() { }

	[CompilerGenerated]
	private void <UpdateItems>b__33_0(Requisite requisite, HandoverRequirementBarterIcon panel) { }

	protected virtual void Accept() { }

	private void AddToSelection(Item item) { }

	protected virtual void AutoSelectButtonPressedHandler() { }

	protected virtual void Awake() { }

	private void ClearRequisites() { }

	protected virtual void ClearSelectedList() { }

	private void ClearView() { }

	public virtual void Close() { }

	protected virtual bool get_CloseOnAccept() { }

	private TimeSpan get_TimeLeft() { }

	protected virtual bool IsActive(Item item, out string tooltip) { }

	private bool IsActive(Item item) { }

	protected virtual bool IsSelected(Item item) { }

	private void MarkItemsAsTool() { }

	private void RemoveFromSelection(Item item) { }

	private void RequisiteChangeHandler() { }

	public void SetPurchaseProcessing(bool isProcessing) { }

	public DialogWindowContext Show(EExchangeableWindowType windowType, Dictionary goods, bool displayInputField, Profile profile, InventoryController controller, Action acceptAction, bool canShowCloseButton, Predicate allowedItemPredicate = null) { }

	private void Tick() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	protected virtual void TrySelectItemToHandover(Item item) { }

	protected virtual void UpdateItems(IEnumerable playerItems) { }

	private void UpdateQuantity() { }

	private void UpdateSelectedViews() { }

}


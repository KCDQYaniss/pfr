namespace EFT.Hideout;

public sealed class ProduceView : ProduceViewBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__34_0; //Field offset: 0x8
		public static Func <>9__35_3; //Field offset: 0x10
		public static Func <>9__40_0; //Field offset: 0x18
		public static Func <>9__43_0; //Field offset: 0x20
		public static Func <>9__43_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <GetBuyButtonTooltipText>b__43_0(ItemRequirement x) { }

		internal bool <GetBuyButtonTooltipText>b__43_1(ItemRequirement x) { }

		internal bool <SetStartButtonActive>b__40_0(ItemRequirement x) { }

		internal string <Show>b__35_3() { }

		internal void <ToggleFavorite>b__34_0(HideoutProductionRequirementView val) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public ProduceView <>4__this; //Field offset: 0x10
		public IEnumerable allItems; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

		internal void <Show>b__4(ItemRequirement requirement, HideoutProductionRequirementView view) { }

	}

	[CompilerGenerated]
	private struct <BuyMaterials>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ProduceView <>4__this; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int INTERVAL_SECONDS = 1; //Field offset: 0x0
	private static readonly string _producingKey; //Field offset: 0x0
	private const string DEFAULT_CODE = "*********"; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _viewCanvas; //Field offset: 0xC8
	[SerializeField]
	private HideoutProductionRequirementView _requiredItemTemplate; //Field offset: 0xD0
	[SerializeField]
	private Transform _requiredItemsContainer; //Field offset: 0xD8
	[SerializeField]
	private GameObject _expectedTimePanel; //Field offset: 0xE0
	[SerializeField]
	private TextMeshProUGUI _expectedTime; //Field offset: 0xE8
	[SerializeField]
	private GameObject _productionPercentagesPanel; //Field offset: 0xF0
	[SerializeField]
	private GameObject _productionBackground; //Field offset: 0xF8
	[SerializeField]
	private TextMeshProUGUI _productionPercentages; //Field offset: 0x100
	[SerializeField]
	private HideoutItemViewFactory _resultItemIconViewFactory; //Field offset: 0x108
	[SerializeField]
	private DefaultUIButton _startButton; //Field offset: 0x110
	[SerializeField]
	private DefaultUIButton _getItemsButton; //Field offset: 0x118
	[SerializeField]
	private ComplementaryButton _favoriteButton; //Field offset: 0x120
	[SerializeField]
	private ComplementaryButton _buyButton; //Field offset: 0x128
	[SerializeField]
	private TextMeshProUGUI _productionStatus; //Field offset: 0x130
	[SerializeField]
	private GameObject _loaderPanel; //Field offset: 0x138
	private ViewList _requirementsViewList; //Field offset: 0x140
	private SimpleTooltip _tooltip; //Field offset: 0x148
	private bool _anyItemsReady; //Field offset: 0x150
	private bool _isRequirementsFulfilled; //Field offset: 0x151
	private DateTime _lastTimerUpdate; //Field offset: 0x158
	[CompilerGenerated]
	private Action OnUpdateFavoriteSchemesList; //Field offset: 0x160

	public event Action OnUpdateFavoriteSchemesList
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public bool AnyItemsReady
	{
		 set { } //Length: 22
	}

	private bool IsRequirementsFulfilled
	{
		private get { } //Length: 8
		private set { } //Length: 22
	}

	protected virtual bool ShowItemsListWindow
	{
		 get { } //Length: 3
	}

	private static ProduceView() { }

	public ProduceView() { }

	[CompilerGenerated]
	private void <Awake>b__33_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__33_1(PointerEventData arg) { }

	[CompilerGenerated]
	private void <StartProducing>b__38_0() { }

	[CompilerGenerated]
	public void add_OnUpdateFavoriteSchemesList(Action value) { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<BuyMaterials>d__39))]
	private void BuyMaterials(bool isClick = false) { }

	public virtual void Close() { }

	private bool get_IsRequirementsFulfilled() { }

	protected virtual bool get_ShowItemsListWindow() { }

	private string GetBuyButtonTooltipText() { }

	[CompilerGenerated]
	public void remove_OnUpdateFavoriteSchemesList(Action value) { }

	public void set_AnyItemsReady(bool value) { }

	private void set_IsRequirementsFulfilled(bool value) { }

	private void SetStartButtonActive() { }

	public void Show(ItemUiContext itemUiContext, InventoryController inventoryController, ProductionScheme scheme, ItemsProducerBase producer, Action onStartProducing, Action getProducedItems, bool availableFavorites) { }

	private void StartProducing() { }

	private void ToggleFavorite(bool isClick = false) { }

	private void Update() { }

	private void UpdateButtonsActiveness() { }

	private void UpdateProducingInfo(ProducingItemController producingItem) { }

	public virtual void UpdateView() { }

}


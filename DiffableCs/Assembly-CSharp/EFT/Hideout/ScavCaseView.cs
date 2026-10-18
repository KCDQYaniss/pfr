namespace EFT.Hideout;

public sealed class ScavCaseView : ProduceViewBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__35_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ItemRequirement <StartProducing>b__35_0(KeyValuePair _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public ScavCaseView <>4__this; //Field offset: 0x10
		public ItemUiContext itemUiContext; //Field offset: 0x18
		public InventoryController inventoryController; //Field offset: 0x20
		public List allItems; //Field offset: 0x28

		public <>c__DisplayClass31_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1(ItemRequirement requirement, HideoutProductionRequirementView view) { }

	}

	[CompilerGenerated]
	private struct <StartProducing>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ScavCaseView <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float INTERVAL_SECONDS = 0.5; //Field offset: 0x0
	private static readonly string _collectingKey; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xC8
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
	private GameObject _resultItemImage; //Field offset: 0x108
	[SerializeField]
	private DefaultUIButton _startButton; //Field offset: 0x110
	[SerializeField]
	private DefaultUIButton _getItemsButton; //Field offset: 0x118
	[SerializeField]
	private TextMeshProUGUI _productionStatus; //Field offset: 0x120
	[SerializeField]
	private GameObject _loaderPanel; //Field offset: 0x128
	[SerializeField]
	private GameObject _timerPanel; //Field offset: 0x130
	private ViewList _requirementsViewList; //Field offset: 0x138
	private SimpleTooltip _tooltip; //Field offset: 0x140
	private MultiLineTooltip _discountTooltip; //Field offset: 0x148
	private MultiLineInfo _dataForDiscountTooltip; //Field offset: 0x150
	private bool _isRequirementsFulfilled; //Field offset: 0x158
	private bool _anyItemsReady; //Field offset: 0x159
	private DateTime _lastTimerUpdate; //Field offset: 0x160

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

	private static ScavCaseView() { }

	public ScavCaseView() { }

	[CompilerGenerated]
	private void <Awake>b__30_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__30_1(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__30_2(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__30_3(PointerEventData arg) { }

	private void Awake() { }

	private MultiLineInfo CalculateDiscountForTooltip(BaseHideoutScheme scheme) { }

	public virtual void Close() { }

	private bool get_IsRequirementsFulfilled() { }

	protected virtual bool get_ShowItemsListWindow() { }

	public void set_AnyItemsReady(bool value) { }

	private void set_IsRequirementsFulfilled(bool value) { }

	private void SetStartButtonActive() { }

	public void Show(ItemUiContext itemUiContext, InventoryController inventoryController, ScavCaseScheme scheme, ScavCaseProducer producer, Action onStartProducing, Action getProducedItems) { }

	[AsyncStateMachine(typeof(<StartProducing>d__35))]
	private Task StartProducing() { }

	private void Update() { }

	private void UpdateProducingInfo(ProducingItemController producingItem) { }

	public virtual void UpdateView() { }

	private void UpdateViewData() { }

}


namespace EFT.Hideout;

public abstract class ProduceViewBase`2 : UIElement, IProduceView
{
	[CompilerGenerated]
	private struct <CancelProducing>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ProduceViewBase <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetProducedItemsAsync>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ProduceViewBase <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RestartProducing>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ProduceViewBase <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected const string REQUIREMENTS_NOT_FULFILLED = "hideout/Requirements are not fulfilled"; //Field offset: 0x0
	protected const string OUT_OF_FUEL = "hideout/Cannot start production without the fuel in Generator"; //Field offset: 0x0
	protected const string OTHER_ITEMS_READY = "hideout/Take crafted items"; //Field offset: 0x0
	protected const string RAGFAIR_UNAVAILABLE = "ragfair/Flea market is not available now"; //Field offset: 0x0
	protected const string HAVE_ALL_ITEMS = "Hideout/Craft/HaveAllCraftItems"; //Field offset: 0x0
	protected const string CANT_BUY_FIR_ITEMS = "Hideout/Craft/CantBuyFIRItems"; //Field offset: 0x0
	[CompilerGenerated]
	private TProductionScheme <Scheme>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TItemsProducer <Producer>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ItemUiContext <ItemUiContext>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private InventoryController <InventoryController>k__BackingField; //Field offset: 0x0
	[SerializeField]
	protected DefaultUIButton _cancelButton; //Field offset: 0x0
	[SerializeField]
	private InteractableElement _electricityNeededIcon; //Field offset: 0x0
	[CompilerGenerated]
	private Action <OnStartProducing>k__BackingField; //Field offset: 0x0
	[SerializeField]
	protected DefaultUIButton _restartButton; //Field offset: 0x0
	[SerializeField]
	protected Dictionary _stateActiveObjects; //Field offset: 0x0
	[CompilerGenerated]
	private bool <GettingItems>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Action <OnGetProducedItems>k__BackingField; //Field offset: 0x0

	protected private bool GettingItems
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected private InventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private ItemUiContext ItemUiContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private Action OnGetProducedItems
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private Action OnStartProducing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private TItemsProducer Producer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private TProductionScheme Scheme
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected abstract bool ShowItemsListWindow
	{
		 get { } //Length: 0
	}

	protected ProduceViewBase`2() { }

	protected void ApplyState(EProductionState state, Dictionary _stateActiveObjects) { }

	[AsyncStateMachine(typeof(<CancelProducing>d__45))]
	protected Task CancelProducing() { }

	[CompilerGenerated]
	protected bool get_GettingItems() { }

	[CompilerGenerated]
	protected InventoryController get_InventoryController() { }

	[CompilerGenerated]
	protected ItemUiContext get_ItemUiContext() { }

	[CompilerGenerated]
	protected Action get_OnGetProducedItems() { }

	[CompilerGenerated]
	protected Action get_OnStartProducing() { }

	[CompilerGenerated]
	protected TItemsProducer get_Producer() { }

	[CompilerGenerated]
	protected TProductionScheme get_Scheme() { }

	protected abstract bool get_ShowItemsListWindow() { }

	protected void GetProducedItems() { }

	[AsyncStateMachine(typeof(<GetProducedItemsAsync>d__46))]
	private Task GetProducedItemsAsync() { }

	[AsyncStateMachine(typeof(<RestartProducing>d__44))]
	protected Task RestartProducing() { }

	[CompilerGenerated]
	private void set_GettingItems(bool value) { }

	[CompilerGenerated]
	private void set_InventoryController(InventoryController value) { }

	[CompilerGenerated]
	private void set_ItemUiContext(ItemUiContext value) { }

	[CompilerGenerated]
	private void set_OnGetProducedItems(Action value) { }

	[CompilerGenerated]
	private void set_OnStartProducing(Action value) { }

	[CompilerGenerated]
	private void set_Producer(TItemsProducer value) { }

	[CompilerGenerated]
	private void set_Scheme(TProductionScheme value) { }

	protected void Show(ItemUiContext itemUiContext, InventoryController inventoryController, TProductionScheme scheme, TItemsProducer producer, Action onStartProducing, Action getProducedItems) { }

	public override void UpdateView() { }

}


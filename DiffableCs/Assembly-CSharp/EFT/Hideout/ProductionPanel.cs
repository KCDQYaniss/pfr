namespace EFT.Hideout;

public sealed class ProductionPanel : AbstractPanel
{
	[CompilerGenerated]
	private struct <<UpdateViews>g__UpdateViewsAsync|25_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProductionPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_1; //Field offset: 0x8
		public static Func <>9__13_2; //Field offset: 0x10
		public static Func <>9__13_3; //Field offset: 0x18
		public static Func <>9__15_3; //Field offset: 0x20
		public static Func <>9__15_4; //Field offset: 0x28
		public static Func <>9__16_1; //Field offset: 0x30
		public static Func <>9__17_3; //Field offset: 0x38
		public static Func <>9__17_4; //Field offset: 0x40
		public static Func <>9__23_0; //Field offset: 0x48
		public static Func <>9__23_1; //Field offset: 0x50
		public static Func <>9__23_2; //Field offset: 0x58
		public static Func <>9__23_3; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal bool <GetSortedSchemes>b__23_0(ProductionScheme scheme) { }

		internal int <GetSortedSchemes>b__23_1(ProductionScheme scheme) { }

		internal int <GetSortedSchemes>b__23_2(ProductionScheme scheme) { }

		internal bool <GetSortedSchemes>b__23_3(ProductionScheme s) { }

		internal bool <ShowContents>b__13_1(ItemsProducerBase p) { }

		internal bool <ShowContents>b__13_2(BaseHideoutScheme s) { }

		internal bool <ShowContents>b__13_3(BaseHideoutScheme s) { }

		internal bool <ShowPermanentView>b__16_1(BaseHideoutScheme s) { }

		internal BaseHideoutScheme <ShowProduceView>b__15_3(KeyValuePair view) { }

		internal IProduceView <ShowProduceView>b__15_4(KeyValuePair view) { }

		internal BaseHideoutScheme <ShowScavCaseView>b__17_3(KeyValuePair view) { }

		internal IProduceView <ShowScavCaseView>b__17_4(KeyValuePair view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public ItemsProducerBase producer; //Field offset: 0x10
		public ProductionPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <ShowContents>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public ProduceView template; //Field offset: 0x10
		public ProductionPanel <>4__this; //Field offset: 0x18
		public ItemUiContext itemUiContext; //Field offset: 0x20
		public ItemsProducerBase itemsProducerBase; //Field offset: 0x28
		public bool availableSearch; //Field offset: 0x30

		public <>c__DisplayClass15_0() { }

		internal ProduceView <ShowProduceView>b__0(ProductionScheme arg) { }

		internal Transform <ShowProduceView>b__1(ProductionScheme arg) { }

		internal void <ShowProduceView>b__2(ProductionScheme scheme, ProduceView view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_1
	{
		public ProduceView view; //Field offset: 0x10
		public <>c__DisplayClass15_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass15_1() { }

		internal void <ShowProduceView>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public ProductionPanel <>4__this; //Field offset: 0x10
		public ItemUiContext itemUiContext; //Field offset: 0x18
		public ScavCaseProducer scavProducer; //Field offset: 0x20

		public <>c__DisplayClass17_0() { }

		internal ScavCaseView <ShowScavCaseView>b__0(ScavCaseScheme arg) { }

		internal Transform <ShowScavCaseView>b__1(ScavCaseScheme arg) { }

		internal void <ShowScavCaseView>b__2(ScavCaseScheme scheme, ScavCaseView view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		private struct <<ItemChangedHandler>g__UpdateViewsWithItemAsync|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass21_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public ProductionPanel <>4__this; //Field offset: 0x10
		public Item item; //Field offset: 0x18
		public Func <>9__2; //Field offset: 0x20

		public <>c__DisplayClass21_0() { }

		internal bool <ItemChangedHandler>b__1() { }

		internal bool <ItemChangedHandler>b__2(ItemRequirement x) { }

		[AsyncStateMachine(typeof(<<ItemChangedHandler>g__UpdateViewsWithItemAsync|0>d))]
		internal Task <ItemChangedHandler>g__UpdateViewsWithItemAsync|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public ProductionScheme scheme; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <GetSortedSchemes>b__5(ItemsProducerBase p) { }

		internal bool <GetSortedSchemes>b__6(ItemsProducerBase p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public string schemeId; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <StartProducing>b__0(BaseHideoutScheme x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public string value; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <Search>g__SearchFilter|0(ProductionScheme scheme) { }

	}

	[CompilerGenerated]
	private struct <ShowContents>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProductionPanel <>4__this; //Field offset: 0x20
		private ItemUiContext <itemUiContext>5__2; //Field offset: 0x28
		private bool <availableSearch>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private Enumerator <>7__wrap3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowProduceView>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProduceView template; //Field offset: 0x20
		public ProductionPanel <>4__this; //Field offset: 0x28
		public ItemUiContext itemUiContext; //Field offset: 0x30
		public ItemsProducerBase itemsProducerBase; //Field offset: 0x38
		public bool availableSearch; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowScavCaseView>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProductionPanel <>4__this; //Field offset: 0x20
		public ItemUiContext itemUiContext; //Field offset: 0x28
		public ScavCaseProducer scavProducer; //Field offset: 0x30
		private AsyncViewList <viewList>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private ProduceView _produceViewTemplate; //Field offset: 0xA0
	[SerializeField]
	private FarmingView _farmingViewTemplate; //Field offset: 0xA8
	[SerializeField]
	private PermanentProductionView _permanentViewTemplate; //Field offset: 0xB0
	[SerializeField]
	private ScavCaseView _scavCaseTemplate; //Field offset: 0xB8
	[SerializeField]
	private ProduceView _decryptionProductionView; //Field offset: 0xC0
	[SerializeField]
	private RectTransform _container; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI _header; //Field offset: 0xD0
	[SerializeField]
	private ValidationInputField _searchInputField; //Field offset: 0xD8
	private List _producers; //Field offset: 0xE0
	private BaseHideoutScheme[] _schemes; //Field offset: 0xE8
	private Dictionary _views; //Field offset: 0xF0
	private AsyncViewList _viewList; //Field offset: 0xF8

	public ProductionPanel() { }

	[CompilerGenerated]
	private int <GetSortedSchemes>g__GetStatusOrder|23_4(ProductionScheme scheme) { }

	[CompilerGenerated]
	private void <ShowBitcoinFarmView>b__18_0() { }

	[CompilerGenerated]
	private void <ShowPermanentView>b__16_0() { }

	[CompilerGenerated]
	private bool <UpdateViews>b__25_1() { }

	[AsyncStateMachine(typeof(<<UpdateViews>g__UpdateViewsAsync|25_0>d))]
	[CompilerGenerated]
	private Task <UpdateViews>g__UpdateViewsAsync|25_0() { }

	public virtual void Close() { }

	private void DataChangedHandler() { }

	private void EnergyGenerationChangedHandler(bool obj) { }

	private void FavoriteSchemeUpdatedHandler(ProductionScheme scheme) { }

	private void GetProducedItems(string schemeId) { }

	private IEnumerable GetSortedSchemes(bool includeContinuous) { }

	private void ItemChangedHandler(Item item) { }

	private void OnCompleteItemsCountChanged(IProductionStorage storage) { }

	private void ProducingCompleteHandler(ItemsProducerBase producer, Item[] items, ProducingItemController _) { }

	private void Search(string value) { }

	public virtual void SetInfo() { }

	public virtual Task Show(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryController inventoryController, IEftSession session) { }

	private void ShowBitcoinFarmView(ItemUiContext itemUiContext, BitcoinProducer bitcoinProducer) { }

	[AsyncStateMachine(typeof(<ShowContents>d__13))]
	public virtual Task ShowContents() { }

	private void ShowPermanentView(ItemUiContext itemUiContext, PermanentProducer permanentProducer) { }

	[AsyncStateMachine(typeof(<ShowProduceView>d__15))]
	private Task ShowProduceView(ItemUiContext itemUiContext, ProduceView template, bool availableSearch, ItemsProducerBase itemsProducerBase) { }

	[AsyncStateMachine(typeof(<ShowScavCaseView>d__17))]
	private Task ShowScavCaseView(ItemUiContext itemUiContext, ScavCaseProducer scavProducer) { }

	private void StartProducing(string schemeId) { }

	private void UpdateOrder() { }

	private void UpdateViews() { }

}


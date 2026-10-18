namespace UI.Hideout;

public abstract class BaseHideoutAreaTransferItemsScreen`2 : EftScreen
{
	internal abstract class BaseHideoutAreaTransferItemsScreenController : EftSequenceScreenController
	{
		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__13 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public BaseHideoutAreaTransferItemsScreenController <>4__this; //Field offset: 0x0
			public bool moveForward; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private AreaData <AreaData>k__BackingField; //Field offset: 0x0
		public readonly InventoryController InventoryController; //Field offset: 0x0
		public readonly IEftSession Session; //Field offset: 0x0

		public AreaData AreaData
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public override bool ShowSortingTable
		{
			 get { } //Length: 3
		}

		protected BaseHideoutAreaTransferItemsScreenController(AreaData areaData, InventoryController inventoryController, IEftSession session) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__13))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		[CompilerGenerated]
		public AreaData get_AreaData() { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		public virtual EEftScreenType get_ScreenType() { }

		public override bool get_ShowSortingTable() { }

		[CompilerGenerated]
		protected void set_AreaData(AreaData value) { }

	}

	internal sealed class TransferScreenSwitcherTabController : SimpleTabController
	{
		private readonly BaseHideoutAreaTransferItemsScreen _screen; //Field offset: 0x0
		private readonly AreaData _areaData; //Field offset: 0x0
		private readonly CompoundItem _stash; //Field offset: 0x0

		public TransferScreenSwitcherTabController(AreaData areaData, CompoundItem stash, BaseHideoutAreaTransferItemsScreen screen) { }

		public virtual void Show() { }

	}

	protected InventoryController _inventoryController; //Field offset: 0x0
	[SerializeField]
	protected DefaultUIButton _closeButton; //Field offset: 0x0
	[SerializeField]
	protected SimpleStashPanel _stashPanel; //Field offset: 0x0
	[SerializeField]
	protected CanvasGroup _handoverItemsWindowCanvasGroup; //Field offset: 0x0
	[SerializeField]
	protected CanvasGroup _inventoryCanvasGroup; //Field offset: 0x0
	[SerializeField]
	protected CanvasGroup _areaStashCanvasGroup; //Field offset: 0x0
	[SerializeField]
	protected Transform _tabsRoot; //Field offset: 0x0
	[SerializeField]
	protected Tab[] _tabs; //Field offset: 0x0
	[SerializeField]
	protected Toggle _uiHiddenToggle; //Field offset: 0x0
	protected IEftSession _backEndSession; //Field offset: 0x0
	protected ItemContext _inventoryItemContext; //Field offset: 0x0
	protected ItemUiContext _itemUiContext; //Field offset: 0x0
	protected AreaData _selectedAreaData; //Field offset: 0x0
	protected AreaData _mainAreaData; //Field offset: 0x0
	protected CompoundItem _areaStash; //Field offset: 0x0
	protected CompoundItem _playerStash; //Field offset: 0x0
	protected TabGroup _tabGroup; //Field offset: 0x0
	protected List _linkedAreaDatas; //Field offset: 0x0

	protected override bool SetAsLastSiblingTabGroup
	{
		 get { } //Length: 3
	}

	protected BaseHideoutAreaTransferItemsScreen`2() { }

	[CompilerGenerated]
	private void <Awake>b__21_0() { }

	[CompilerGenerated]
	private void <CreateTabGroupAndShow>b__25_0() { }

	protected override void Awake() { }

	private void CollectLinkedAreas() { }

	protected void CreateTabGroupAndShow(Tab selectedTab) { }

	protected override bool get_SetAsLastSiblingTabGroup() { }

	private void SetStashUiVisibility(bool hide) { }

	protected void Show(CompoundItem stashToShow, int selectedTabIndex = 0) { }

	protected override void UpdateAreaStashView(AreaData areaData, CompoundItem stash) { }

	protected override void UpdateTabGroup(int selectedTabIndex) { }

}


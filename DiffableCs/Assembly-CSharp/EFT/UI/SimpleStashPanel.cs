namespace EFT.UI;

public sealed class SimpleStashPanel : UIInputNode, ISelectionContext, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__34_0; //Field offset: 0x8
		public static Action <>9__35_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <SetupExternalObtainButton>b__34_0() { }

		internal void <SetupLinesCountButton>b__35_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public int availableLinesCount; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal void <SetupExternalObtainButton>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public int availableLinesCount; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal void <SetupLinesCountButton>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public WindowContext searchWindowContext; //Field offset: 0x10
		public SimpleStashPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass41_0() { }

		internal void <SearchHandler>b__0() { }

		internal void <SearchHandler>g__SearchCloseHandler|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public SortingTableWindowContext sortingTableContext; //Field offset: 0x10
		public SimpleStashPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass46_0() { }

		internal void <ShowSortingTable>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__CloseTooltip; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <TryClose>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SimpleStashPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EStashSearchAvailability
	{
		Unavailable = 0,
		StashOnly = 1,
		All = 2,
	}

	[SerializeField]
	private GameObject _header; //Field offset: 0x80
	[SerializeField]
	private SearchableItemView _simplePanel; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _simpleGridName; //Field offset: 0x90
	[SerializeField]
	private FilterPanel _filterPanel; //Field offset: 0x98
	[SerializeField]
	private DisplayMoneyPanel _moneyCountPanel; //Field offset: 0xA0
	[SerializeField]
	private GameObject _containerNamePanel; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _containerName; //Field offset: 0xB0
	[SerializeField]
	private List _lobbyOnlyElements; //Field offset: 0xB8
	[SerializeField]
	private GridSortPanel _gridSortPanel; //Field offset: 0xC0
	[SerializeField]
	private ToggleEFT _sortingTableTab; //Field offset: 0xC8
	[SerializeField]
	private ToggleEFT _searchTab; //Field offset: 0xD0
	[SerializeField]
	private ScrollRect _stashScroll; //Field offset: 0xD8
	[SerializeField]
	private DefaultUiButtonNewStyle _externalObtainButton; //Field offset: 0xE0
	[SerializeField]
	private ToggleButton _pinModeButton; //Field offset: 0xE8
	[SerializeField]
	private ToggleButton _lockModeButton; //Field offset: 0xF0
	[SerializeField]
	private ToggleButton _priorityButton; //Field offset: 0xF8
	[SerializeField]
	private DefaultUiButtonNewStyle _linesCountButton; //Field offset: 0x100
	private StashMoneyController _stashMoneyController; //Field offset: 0x108
	private InventoryController _inventoryController; //Field offset: 0x110
	private CompoundItem _item; //Field offset: 0x118
	private InventorySelectableItemContext _itemContext; //Field offset: 0x120
	private ItemUiContext _itemUiContext; //Field offset: 0x128
	private InventoryController _leftSideInventoryController; //Field offset: 0x130
	private bool _lobbyMode; //Field offset: 0x138
	private SortingTable _sortingTable; //Field offset: 0x140
	private EStashSearchAvailability _searchAvailability; //Field offset: 0x148
	private EItemPinLockState _pinLockSelectionMode; //Field offset: 0x14C
	private readonly CompositeDisposable _searchUnsubscriber; //Field offset: 0x150
	private readonly CompositeDisposable _sortingTableUnsubscriber; //Field offset: 0x158
	private SortingTableWindowContext _sortingTableContext; //Field offset: 0x160
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0x168

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private bool IsShopAccessBlocked
	{
		private get { } //Length: 21
	}

	public SimpleStashPanel() { }

	[CompilerGenerated]
	private void <InitSortingTable>b__43_0() { }

	[CompilerGenerated]
	private void <InitSortingTable>g__OnProfileUpdate|43_1() { }

	[CompilerGenerated]
	private void <Show>b__33_0(bool value) { }

	[CompilerGenerated]
	private void <Show>b__33_1(bool value) { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	private void ChangePriority(bool active) { }

	public virtual void Close() { }

	private void CloseSortingTable() { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

	private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

	private void ExternalObtainButtonClickHandler() { }

	private bool get_IsShopAccessBlocked() { }

	private void InitSearch(EItemsTab tab) { }

	private void InitSorting(EItemsTab tab) { }

	private void InitSortingTable(EItemsTab tab) { }

	private void PriorityGridWindowStateChanged(GridWindowContext gridWindow) { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	private void SearchHandler(bool active) { }

	private void SetLobbyOnlyElementsStatus(bool active) { }

	private void SetupExternalObtainButton() { }

	private void SetupLinesCountButton() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(CompoundItem item, InventoryController inventoryController, ItemContext itemContext, SortingTable sortingTable, EStashSearchAvailability searchAvailability, InventoryController leftSideInventoryController = null, EItemsTab tab = 0) { }

	private void ShowSortingTable() { }

	private void SortingTableCloseHandler() { }

	private void SortingTableTabSelectionChangedHandler(bool isVisible) { }

	private override void System.IDisposable.Dispose() { }

	private void TogglePinLockMode(EItemPinLockState state) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TryClose>d__57))]
	public Task TryClose() { }

}


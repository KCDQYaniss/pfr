namespace EFT.UI;

[UsedImplicitly]
public sealed class SortingTableWindow : Window
{
	[CompilerGenerated]
	private struct <<TryClose>g__TryCloseAsync|20_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SortingTableWindow <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryToRemoveAllFromSortingTable>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SortingTableWindow <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class SortingTableWindowContext : WindowContext
	{
		[CompilerGenerated]
		private struct <TryClose>d__3 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public SortingTableWindowContext <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private SortingTableWindow _sortingTable; //Field offset: 0x20

		public SortingTableWindowContext() { }

		public SortingTableWindowContext(SortingTableWindow sortingTable) { }

		public void CloseForced() { }

		[AsyncStateMachine(typeof(<TryClose>d__3))]
		public Task TryClose() { }

	}

	private const string SELL_ITEMS_CONFIRMATION_MESSAGE = "SortingTable/SellFromSortingTableConfirmation{0}"; //Field offset: 0x0
	public const string MOVE_FROM_SORTING_TABLE_ERROR = "SortingTable/TransferFromSortingTableError"; //Field offset: 0x0
	private const int DEFAULT_DIMENSION_SIZE = 7; //Field offset: 0x0
	[SerializeField]
	private GridView _grid; //Field offset: 0xB8
	[SerializeField]
	private Button _sellAllButton; //Field offset: 0xC0
	[SerializeField]
	private CanvasGroup _sellButtonCanvasGroup; //Field offset: 0xC8
	[SerializeField]
	private GameObject _blockScreen; //Field offset: 0xD0
	private SortingTable _sortingTable; //Field offset: 0xD8
	private BackEndInventoryController _inventoryController; //Field offset: 0xE0
	private ItemUiContext _uiContext; //Field offset: 0xE8
	private ItemContext _itemContext; //Field offset: 0xF0
	private bool _preparingToClose; //Field offset: 0xF8
	private Task _closingTask; //Field offset: 0x100

	protected virtual bool ShowOnTop
	{
		 get { } //Length: 3
	}

	public SortingTableWindow() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0() { }

	[CompilerGenerated]
	private void <Show>b__16_0() { }

	[AsyncStateMachine(typeof(<<TryClose>g__TryCloseAsync|20_0>d))]
	[CompilerGenerated]
	private Task <TryClose>g__TryCloseAsync|20_0() { }

	public virtual void Close() { }

	private void CloseForced() { }

	protected virtual SortingTableWindowContext CreateContext() { }

	protected virtual bool get_ShowOnTop() { }

	[UsedImplicitly]
	private void OnRectTransformDimensionsChange() { }

	public SortingTableWindowContext Show(ItemContext itemContext, SortingTable sortingTable, BackEndInventoryController inventoryController, ItemUiContext uiContext) { }

	private void ShowGrid() { }

	private Task TryClose() { }

	[AsyncStateMachine(typeof(<TryToRemoveAllFromSortingTable>d__18))]
	private Task TryToRemoveAllFromSortingTable() { }

}


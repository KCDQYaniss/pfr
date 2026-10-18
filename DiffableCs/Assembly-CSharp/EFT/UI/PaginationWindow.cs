namespace EFT.UI;

public abstract class PaginationWindow : HandoverItemsWindow
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FillGrids>b__20_0(Grid grid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public IItemOwner owner; //Field offset: 0x10
		public PaginationWindow <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <SetItemOwner>b__0() { }

	}

	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private PaginationPanel _paginationPanel; //Field offset: 0x120
	private List _pageButtons; //Field offset: 0x128
	private int _gridIndex; //Field offset: 0x130
	private int _currentPage; //Field offset: 0x134
	[CompilerGenerated]
	private bool <ItemsUpdateRequired>k__BackingField; //Field offset: 0x138
	private readonly CompositeDisposable _itemOwnerSubscriber; //Field offset: 0x140

	protected virtual bool CanStretchHorizontally
	{
		 get { } //Length: 3
	}

	protected virtual bool CanStretchVertically
	{
		 get { } //Length: 3
	}

	protected override bool ItemsUpdateRequired
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private int PagesCount
	{
		private get { } //Length: 38
	}

	protected PaginationWindow() { }

	[CompilerGenerated]
	private void <Show>b__16_0() { }

	[CompilerGenerated]
	private void <Show>b__16_1() { }

	[CompilerGenerated]
	private void <Show>b__16_2() { }

	[CompilerGenerated]
	private void <Show>b__16_3() { }

	protected abstract bool CheckForUpdateItemsRequirement(Item item, ItemAddress itemAddress) { }

	private void ClearStashGrids() { }

	private void FillGrids(IEnumerable items) { }

	protected virtual bool get_CanStretchHorizontally() { }

	protected virtual bool get_CanStretchVertically() { }

	[CompilerGenerated]
	protected override bool get_ItemsUpdateRequired() { }

	private int get_PagesCount() { }

	protected abstract IEnumerable GetItemsToHandover() { }

	private void InstantiatePageButtons() { }

	private void OnItemAddedHandler(AddItemEventArgs args) { }

	private void OnItemRefreshHandler(RefreshItemEventArgs args) { }

	private void OnItemRemovedHandler(RemoveItemEventArgs args) { }

	[CompilerGenerated]
	protected override void set_ItemsUpdateRequired(bool value) { }

	protected void SetItemOwner(IItemOwner owner) { }

	private void SetPage(int page) { }

	protected DialogWindowContext Show(string title, string message, IInventoryProfileInfo profile, ItemController itemController, ItemContext itemContext, bool canShowCancelButton) { }

	protected virtual void Update() { }

	protected virtual void UpdateItems(IEnumerable items) { }

	private void UpdatePageButtonsGroupView() { }

	private void UpdatePageNumberButtonsView() { }

	private void UpdateSkipPageButtonsView() { }

}


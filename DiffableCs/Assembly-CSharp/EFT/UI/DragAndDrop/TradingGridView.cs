namespace EFT.UI.DragAndDrop;

[UsedImplicitly]
public sealed class TradingGridView : GridView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8
		public static Func <>9__14_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <RequisiteChangedHandler>b__14_0(Requisite x) { }

		internal Item <RequisiteChangedHandler>b__14_1(TradingItemReference x) { }

	}

	[CompilerGenerated]
	private Action OnFilterChanged; //Field offset: 0x108
	private Assortment _traderAssortment; //Field offset: 0x110
	private Stash _parentStash; //Field offset: 0x118
	private IEnumerable _items; //Field offset: 0x120

	public event Action OnFilterChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public TradingGridView() { }

	[CompilerGenerated]
	public void add_OnFilterChanged(Action value) { }

	private void ApplyFilter() { }

	private void ApplyFilterAndRefresh() { }

	public virtual bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public void ClearFilterChoice() { }

	public virtual void Close() { }

	protected virtual Color GetHighlightColor(DragItemContext itemContext, OperationResult possibleOperation, ItemContext targetItemContext) { }

	private void Init(IEnumerable items, Assortment assortment) { }

	private void InvokeFilterChanged() { }

	private void LateInit() { }

	protected virtual void PrepareItems() { }

	[CompilerGenerated]
	public void remove_OnFilterChanged(Action value) { }

	private void RequisiteChangedHandler() { }

	public void Show(Grid grid, ItemContext sourceContext, Assortment assortment, InventoryController inventoryController, ItemUiContext itemUiContext) { }

	public void Show(IEnumerable items, ItemContext sourceContext, Assortment assortment, InventoryController inventoryController, ItemUiContext itemUiContext, bool raiseEvents) { }

}


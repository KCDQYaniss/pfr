namespace EFT.UI;

public sealed class RagfairNewOfferContext : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8
		public static Func <>9__21_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <get_OfferItemCount>b__17_0(Item x) { }

		internal string <get_SelectedItemsIds>b__21_0(Item item) { }

	}

	[CompilerGenerated]
	private Action OnItemSelectionChanged; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnItemChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnOfferTakesMaxCellsChanged; //Field offset: 0x20
	private readonly ItemController _itemController; //Field offset: 0x28
	private readonly Grid _grid; //Field offset: 0x30
	private readonly RagFair _ragfair; //Field offset: 0x38
	public readonly NewOfferItemContext ItemContext; //Field offset: 0x40
	private readonly HashSet _selectedItems; //Field offset: 0x48
	[CompilerGenerated]
	private Item <SelectedItem>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <AutoSelectSimilar>k__BackingField; //Field offset: 0x58
	private bool _isOfferTakesMaxCellsCount; //Field offset: 0x59

	public event Action OnItemChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnItemSelectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnOfferTakesMaxCellsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool AutoSelectSimilar
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsAllSelectedItemSame
	{
		 get { } //Length: 158
	}

	public private bool IsOfferTakesMaxCellsCount
	{
		 get { } //Length: 5
		private set { } //Length: 37
	}

	private int MaxAvailableCellsSize
	{
		private get { } //Length: 194
	}

	public int OfferItemCount
	{
		 get { } //Length: 387
	}

	public private Item SelectedItem
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IReadOnlyCollection SelectedItems
	{
		 get { } //Length: 5
	}

	public string[] SelectedItemsIds
	{
		 get { } //Length: 492
	}

	public RagfairNewOfferContext(Grid grid, ItemController itemController, RagFair ragfair) { }

	[CompilerGenerated]
	private bool <get_IsAllSelectedItemSame>b__35_0(Item item) { }

	[CompilerGenerated]
	private bool <GetFirstAvailableItemOrNull>b__37_0(Item item) { }

	[CompilerGenerated]
	public void add_OnItemChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnItemSelectionChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnOfferTakesMaxCellsChanged(Action value) { }

	private void AddToSelection(Item item) { }

	private bool CanSelectItemBySize(Item item) { }

	public void ClearSelectedList() { }

	public void DeselectItem(Item item) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public bool get_AutoSelectSimilar() { }

	public bool get_IsAllSelectedItemSame() { }

	public bool get_IsOfferTakesMaxCellsCount() { }

	private int get_MaxAvailableCellsSize() { }

	public int get_OfferItemCount() { }

	[CompilerGenerated]
	public Item get_SelectedItem() { }

	public IReadOnlyCollection get_SelectedItems() { }

	public string[] get_SelectedItemsIds() { }

	public Item GetFirstAvailableItemOrNull() { }

	private int GetMaxAvailableItemsCount(Item item) { }

	public bool HighlightedAtRagfair(Item item) { }

	public void InvokeItemChanged(Item item) { }

	public bool IsLockedByLevel(Item item, out string message) { }

	[CompilerGenerated]
	public void remove_OnItemChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemSelectionChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnOfferTakesMaxCellsChanged(Action value) { }

	public void SelectItem(Item selectedItem) { }

	[CompilerGenerated]
	public void set_AutoSelectSimilar(bool value) { }

	private void set_IsOfferTakesMaxCellsCount(bool value) { }

	[CompilerGenerated]
	private void set_SelectedItem(Item value) { }

	public bool TrySelectFirstAvailableItem() { }

	private void UpdateTakenSpace() { }

}


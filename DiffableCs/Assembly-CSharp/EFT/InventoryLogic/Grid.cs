namespace EFT.InventoryLogic;

public class Grid : IContainer, IItemContainer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__67_0; //Field offset: 0x8
		public static Func <>9__95_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CheckCompatibility>b__67_0(Grid grid) { }

		internal string <GetHashSum>b__95_0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public IntRect rect; //Field offset: 0x10

		public <>c__DisplayClass59_0() { }

		internal bool <GetItemsInRect>b__0(KeyValuePair x) { }

	}

	internal sealed class ItemFiltersWontAllowError : InventoryError
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__3_0; //Field offset: 0x8
			public static Func <>9__3_1; //Field offset: 0x10
			public static Func <>9__3_2; //Field offset: 0x18
			public static Func <>9__3_3; //Field offset: 0x20
			public static Func <>9__3_4; //Field offset: 0x28

			private static <>c() { }

			public <>c() { }

			internal IEnumerable <ToString>b__3_0(ItemFilter x) { }

			internal string <ToString>b__3_1(MongoID x) { }

			internal bool <ToString>b__3_2(ItemFilter x) { }

			internal IEnumerable <ToString>b__3_3(ItemFilter x) { }

			internal string <ToString>b__3_4(MongoID x) { }

		}

		private readonly Item _item; //Field offset: 0x10
		private readonly Grid _grid; //Field offset: 0x18

		public ItemFiltersWontAllowError(Item item, Grid grid) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class ItemNotInGridError : InventoryError
	{
		private readonly string _itemId; //Field offset: 0x10
		private readonly Item _item; //Field offset: 0x18
		private readonly Grid _grid; //Field offset: 0x20

		public ItemNotInGridError(Item item, Grid grid) { }

		public virtual string ToString() { }

	}

	internal sealed class MaxItemsCountReachedError : InventoryError
	{
		private readonly int _maxItemsCount; //Field offset: 0x10

		public MaxItemsCountReachedError(int maxItemsCount) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class ModificationUnavailable : InventoryError
	{
		public readonly IContainer Container; //Field offset: 0x10

		public ModificationUnavailable(IContainer grid) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class NoFreeSpaceError : InventoryError
	{
		private readonly Item _item; //Field offset: 0x10
		private readonly Grid _grid; //Field offset: 0x18

		public NoFreeSpaceError(Item item, Grid grid) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class PlaceTakenByAnotherItemError : InventoryError
	{
		private readonly Item _item; //Field offset: 0x10
		private readonly LocationInGrid _location; //Field offset: 0x18
		private readonly Grid _grid; //Field offset: 0x20

		public PlaceTakenByAnotherItemError(Item item, LocationInGrid location, Grid grid) { }

		public virtual string ToString() { }

	}

	private sealed class ProtectedGridItemAddress : GridItemAddress
	{

		public ProtectedGridItemAddress(Grid grid, LocationInGrid locationInGrid) { }

	}

	internal sealed class SecureContainerPerkRestrictionError : InventoryError
	{
		private const string ERROR_KEY = "Perks/SecureContainerRestriction{0}"; //Field offset: 0x0
		private readonly Item _item; //Field offset: 0x10
		private readonly Grid _grid; //Field offset: 0x18
		private readonly string _perkName; //Field offset: 0x20

		public SecureContainerPerkRestrictionError(Item item, Grid grid, string perkName) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class WontFitToGridError : InventoryError
	{
		private readonly Item _item; //Field offset: 0x10
		private readonly Grid _grid; //Field offset: 0x18
		private readonly LocationInGrid _location; //Field offset: 0x20

		public WontFitToGridError(Item item, LocationInGrid location, Grid grid) { }

		public virtual string ToString() { }

	}

	[CompilerGenerated]
	private Action OnResize; //Field offset: 0x10
	protected readonly List LayoutBuffer; //Field offset: 0x18
	protected readonly List Horizontal; //Field offset: 0x20
	protected readonly List Vertical; //Field offset: 0x28
	[CompilerGenerated]
	private readonly bool <CanStretchVertically>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly bool <CanStretchHorizontally>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private int <GridWidth>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <GridHeight>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable <MaxItemsCount>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private readonly GridItemCollection <ItemCollection>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly ItemFilter[] <Filters>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly CompoundItem <ParentItem>k__BackingField; //Field offset: 0x58
	private HashSet _overlappingItems; //Field offset: 0x60
	protected HashSet _outOfBoundsItems; //Field offset: 0x68
	[CompilerGenerated]
	private readonly string <ID>k__BackingField; //Field offset: 0x70

	public event Action OnResize
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool CanStretchHorizontally
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool CanStretchVertically
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public GridItemCollection ContainedItems
	{
		 get { } //Length: 20
	}

	private override Item EFT.InventoryLogic.IContainer.ParentItem
	{
		private get { } //Length: 5
	}

	public override ItemFilter[] Filters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int GridHeight
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private int GridWidth
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override string ID
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override GridItemCollection ItemCollection
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override IEnumerable Items
	{
		 get { } //Length: 97
	}

	public IReadOnlyList Layout
	{
		 get { } //Length: 5
	}

	public Nullable MaxItemsCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override EParentMergeType MergeContainerWithChildren
	{
		 get { } //Length: 3
	}

	public IEnumerable OutOfBoundsItems
	{
		 get { } //Length: 63
	}

	public IEnumerable OverlappingItems
	{
		 get { } //Length: 63
	}

	public CompoundItem ParentItem
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Grid(Grid grid, CompoundItem parentItem) { }

	public Grid(string id, int gridWidth, int gridHeight, bool canStretchVertically, ItemFilter[] filters, CompoundItem parentItem) { }

	public Grid(string id, int gridWidth, int gridHeight, bool canStretchVertically, bool canStretchHorizontally, ItemFilter[] filters, CompoundItem parentItem, int maxItemsCount = -1) { }

	public OperationResult Add(Item item, LocationInGrid location, bool simulate) { }

	[CompilerGenerated]
	public void add_OnResize(Action value) { }

	public OperationResult AddAnywhere(Item item, EErrorHandlingType errorHandling) { }

	protected override OperationResult AddInternal(Item item, LocationInGrid location, bool simulate, bool ignoreRestrictions) { }

	public OperationResult AddItemWithoutRestrictions(Item item, LocationInGrid location) { }

	public bool CanReplace(Item item, Item item1) { }

	public override bool CheckCompatibility(Item item) { }

	private bool CheckLayout(IntVec2 itemSize, LocationInGrid location) { }

	public void ClampSize(int preferredWidth, int preferredHeight, bool force = false) { }

	public bool Contains(Item item) { }

	public override GridItemAddress CreateItemAddress(LocationInGrid location) { }

	private override ItemAddress EFT.InventoryLogic.IContainer.CreateItemAddress(ItemAddressDescriptor descriptor) { }

	private override Item EFT.InventoryLogic.IContainer.get_ParentItem() { }

	protected void FillSpaceBuffer() { }

	[CanBeNull]
	public override LocationInGrid FindFreeSpace(Item item) { }

	[CanBeNull]
	protected LocationInGrid FindFreeSpaceInGrid(int itemWidth, int itemHeight, ItemRotation rotation) { }

	[CanBeNull]
	public GridItemAddress FindLocationForItem(Item item) { }

	[CompilerGenerated]
	public bool get_CanStretchHorizontally() { }

	[CompilerGenerated]
	public override bool get_CanStretchVertically() { }

	public GridItemCollection get_ContainedItems() { }

	[CompilerGenerated]
	public override ItemFilter[] get_Filters() { }

	[CompilerGenerated]
	public int get_GridHeight() { }

	[CompilerGenerated]
	public int get_GridWidth() { }

	[CompilerGenerated]
	public override string get_ID() { }

	[CompilerGenerated]
	public override GridItemCollection get_ItemCollection() { }

	public override IEnumerable get_Items() { }

	public IReadOnlyList get_Layout() { }

	[CompilerGenerated]
	public Nullable get_MaxItemsCount() { }

	public override EParentMergeType get_MergeContainerWithChildren() { }

	public IEnumerable get_OutOfBoundsItems() { }

	public IEnumerable get_OverlappingItems() { }

	[CompilerGenerated]
	public CompoundItem get_ParentItem() { }

	private LocationInGrid GetFreeLocation(int itemMainSize, int itemSecondSize, ItemRotation rotation, int firstDimensionSize, int secondDimensionSize, List firstDimensionSpaces, List secondDimensionSpaces, bool invertDimensions = false) { }

	public override int GetHashSum() { }

	[CanBeNull]
	public Item GetItemAt(LocationInGrid location) { }

	[CanBeNull]
	public LocationInGrid GetItemLocation(Item item) { }

	public IEnumerable GetItemsInRect(IntRect rect) { }

	private bool HasFreeSpace(Item item, LocationInGrid location) { }

	public bool HasFreeSpaceForItems(IEnumerable items) { }

	private static bool IsConflicting(IntRect first, IntRect second) { }

	private static bool IsInRect(Item item, LocationInGrid location, IntRect rect) { }

	private bool LiesWithinGrid(IntVec2 size, LocationInGrid location) { }

	protected bool LiesWithinGrid(Item item, LocationInGrid location) { }

	private void PlaceItem(Item item, LocationInGrid location) { }

	public void RaiseResizeEvent() { }

	public OperationResult Remove(Item item, bool simulate) { }

	[CompilerGenerated]
	public void remove_OnResize(Action value) { }

	public void RemoveAll() { }

	protected override OperationResult RemoveInternal(Item item, bool simulate, bool ignoreRestrictions) { }

	protected void RemoveItem(Item item, LocationInGrid location, bool updateSpaceBuffer = true) { }

	public OperationResult RemoveWithoutRestrictions(Item item) { }

	public OperationResult Resize(Item item, IntVec2 oldSize, IntVec2 newSize, bool simulate = false) { }

	public void RevalidateSpaceBuffer() { }

	[CompilerGenerated]
	protected void set_GridHeight(int value) { }

	[CompilerGenerated]
	private void set_GridWidth(int value) { }

	[CompilerGenerated]
	protected void set_MaxItemsCount(Nullable value) { }

	private void SetLayout(IntVec2 itemSize, LocationInGrid location, bool value, bool stretch) { }

	protected void SetLayout(Item item, LocationInGrid itemLocation, bool value, bool stretch) { }

	public virtual string ToString() { }

	public bool TryFindItem(Func predicate, out Item item) { }

	public override bool TryFindItem(string itemId, out Item item) { }

	public override bool TryFindLocationForItem(Item item, out ItemAddress location) { }

	private bool TryGetSecureContainerPerkRestriction(Item item, out string perkName) { }

}


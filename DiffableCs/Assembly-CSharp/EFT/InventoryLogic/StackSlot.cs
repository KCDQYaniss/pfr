namespace EFT.InventoryLogic;

public sealed class StackSlot : IContainer, IItemContainer
{
	private sealed class ProtectedStackSlotItemAddress : StackSlotItemAddress
	{

		public ProtectedStackSlotItemAddress(StackSlot stackSlot) { }

	}

	public readonly int MaxCount; //Field offset: 0x10
	private readonly List _items; //Field offset: 0x18
	private SortedList _deserializationList; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <ID>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ItemFilter[] <Filters>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly Item <ParentItem>k__BackingField; //Field offset: 0x38

	public int Count
	{
		 get { } //Length: 187
	}

	public override ItemFilter[] Filters
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override string ID
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override IEnumerable Items
	{
		 get { } //Length: 5
	}

	[CanBeNull]
	public Item Last
	{
		 get { } //Length: 145
	}

	public override EParentMergeType MergeContainerWithChildren
	{
		 get { } //Length: 3
	}

	public override Item ParentItem
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StackSlot(StackSlot stackSlot, Item parentItem) { }

	public StackSlot(string id, int maxCount, ItemFilter[] filters) { }

	public OperationResult Add(Item item, bool simulate) { }

	public void AddAtPosition(Item item, int position) { }

	public override bool CheckCompatibility(Item item) { }

	public ItemAddress CreateItemAddress() { }

	private override ItemAddress EFT.InventoryLogic.IContainer.CreateItemAddress(ItemAddressDescriptor descriptor) { }

	public Option FinalizeDeserialization() { }

	public int get_Count() { }

	[CompilerGenerated]
	public override ItemFilter[] get_Filters() { }

	[CompilerGenerated]
	public override string get_ID() { }

	public override IEnumerable get_Items() { }

	public Item get_Last() { }

	public override EParentMergeType get_MergeContainerWithChildren() { }

	[CompilerGenerated]
	public override Item get_ParentItem() { }

	public override int GetHashSum() { }

	public Item GetItemAtPosition(int index) { }

	public int GetItemPosition(Item testedItem) { }

	public Option GetMaxAddCount(Item item) { }

	public OperationResult PopTo(ItemController itemController, ItemAddress to) { }

	public OperationResult PopToNowhere(ItemController itemController) { }

	public OperationResult Remove(Item item, bool simulate) { }

	[CompilerGenerated]
	public void set_Filters(ItemFilter[] value) { }

	public virtual string ToString() { }

	public override bool TryFindItem(string itemId, out Item item) { }

	public bool TryFindItem(Func predicate, out Item result) { }

	public override bool TryFindLocationForItem(Item item, out ItemAddress location) { }

}


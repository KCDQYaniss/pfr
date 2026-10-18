namespace EFT.InventoryLogic;

public sealed class VirtualContainer : IContainer, IItemContainer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public IContainer comparedContainer; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <Equals>b__0(IContainer resultingContainer) { }

	}

	private readonly IEnumerable _resultingContainers; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <ID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly IEnumerable <Items>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ItemFilter[] <Filters>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Item <ParentItem>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly EParentMergeType <MergeContainerWithChildren>k__BackingField; //Field offset: 0x38

	public override ItemFilter[] Filters
	{
		[CompilerGenerated]
		 get { } //Length: 5
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
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override EParentMergeType MergeContainerWithChildren
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override Item ParentItem
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public VirtualContainer(Item parent, IEnumerable resultingContainers, string id = "virtual container") { }

	public override bool CheckCompatibility(Item item) { }

	public override ItemAddress CreateItemAddress(ItemAddressDescriptor descriptor) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public override ItemFilter[] get_Filters() { }

	[CompilerGenerated]
	public override string get_ID() { }

	[CompilerGenerated]
	public override IEnumerable get_Items() { }

	[CompilerGenerated]
	public override EParentMergeType get_MergeContainerWithChildren() { }

	[CompilerGenerated]
	public override Item get_ParentItem() { }

	public override int GetHashSum() { }

	[CompilerGenerated]
	public void set_Filters(ItemFilter[] value) { }

	public override bool TryFindItem(string itemId, out Item item) { }

	public override bool TryFindLocationForItem(Item item, out ItemAddress location) { }

}


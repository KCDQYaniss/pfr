namespace EFT.InventoryLogic;

public class InternalSplitResult : IItemOperationResult, IOperationResult, IRollable
{
	protected readonly Item SourceItem; //Field offset: 0x10
	protected readonly IDatabaseIdGenerator IDGenerator; //Field offset: 0x18
	protected readonly ItemController ItemController; //Field offset: 0x20
	private bool _executed; //Field offset: 0x28
	private bool _finalized; //Field offset: 0x29
	[CompilerGenerated]
	private readonly Item <ResultItem>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x38

	public int Count
	{
		 get { } //Length: 26
	}

	public override ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Item Item
	{
		 get { } //Length: 5
	}

	public override Item ResultItem
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	protected InternalSplitResult(InternalSplitResult result) { }

	public InternalSplitResult(Item sourceItem, Item cloneItem, ItemController itemController, IDatabaseIdGenerator idGenerator) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public int get_Count() { }

	[CompilerGenerated]
	public override ItemAddress get_From() { }

	public override Item get_Item() { }

	[CompilerGenerated]
	public override Item get_ResultItem() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}


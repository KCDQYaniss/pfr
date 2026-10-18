namespace EFT.InventoryLogic;

public sealed class SplitResult : InternalSplitResult, ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, IToEmptyAddressResult, IItemOperationResult
{
	private readonly AddResult _addResult; //Field offset: 0x40
	private readonly IDestroyResult _destroyResult; //Field offset: 0x48
	[CompilerGenerated]
	private readonly ItemAddress <To>k__BackingField; //Field offset: 0x50

	public override ItemAddress To
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public SplitResult(InternalSplitResult result, ItemAddress to, AddResult addResult, IDestroyResult destroyResult) { }

	public virtual bool CanExecute(ItemController controller) { }

	public virtual OperationResult Execute() { }

	public void ExecuteWithNewCount(ItemController itemController, int count) { }

	[CompilerGenerated]
	public override ItemAddress get_To() { }

	public virtual void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public virtual void RollBack() { }

}


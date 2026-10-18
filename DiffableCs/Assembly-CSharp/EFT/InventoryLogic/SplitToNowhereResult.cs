namespace EFT.InventoryLogic;

public class SplitToNowhereResult : InternalSplitResult, ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, IRemoveToNowhereResult, IItemOperationResult
{
	[CompilerGenerated]
	private readonly ItemsCount <ItemsCount>k__BackingField; //Field offset: 0x40

	public override ItemsCount ItemsCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public SplitToNowhereResult(InternalSplitResult result) { }

	public virtual OperationResult Execute() { }

	[CompilerGenerated]
	public override ItemsCount get_ItemsCount() { }

}


namespace EFT.InventoryLogic;

public interface ITransferOrMergeResult : IItemOperationResult, IOperationResult, IRollable
{

	public Item TargetItem
	{
		 get { } //Length: 0
	}

	public Item get_TargetItem() { }

}


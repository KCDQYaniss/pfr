namespace EFT.InventoryLogic;

public interface IRemoveToNowhereResult : IItemOperationResult, IOperationResult, IRollable, ISyncOperation
{

	public ItemsCount ItemsCount
	{
		 get { } //Length: 0
	}

	public ItemsCount get_ItemsCount() { }

}


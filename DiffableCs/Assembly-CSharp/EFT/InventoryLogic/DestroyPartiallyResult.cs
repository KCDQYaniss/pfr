namespace EFT.InventoryLogic;

public sealed class DestroyPartiallyResult : SplitToNowhereResult, IRemoveToNowhereResult, IItemOperationResult, IOperationResult, IRollable, ISyncOperation
{
	private readonly ItemsCount _itemsCount; //Field offset: 0x50

	private override ItemsCount EFT.InventoryLogic.IRemoveToNowhereResult.ItemsCount
	{
		private get { } //Length: 11
	}

	public DestroyPartiallyResult(SplitToNowhereResult result, int itemsToPreserve) { }

	private override ItemsCount EFT.InventoryLogic.IRemoveToNowhereResult.get_ItemsCount() { }

}

